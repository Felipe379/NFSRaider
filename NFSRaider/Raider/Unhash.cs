using Combinatorics.Collections;
using NFSRaider.Enum;
using NFSRaider.Raider.Model;
using NFSRaider.GeneratedStrings;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NFSRaider.Raider
{
    public class Unhash
    {
        private int ProcessorCount { get; set; }
        private HashSet<uint> Hashes { get; set; }
        private HashSet<string> Prefixes { get; set; }
        private HashSet<string> Suffixes { get; set; }
        private HashSet<string> WordsBetweenVariations { get; set; }
        private Endianness UnhashingEndianness { get; set; }
        private CaseOptions CaseOption { get; set; }
        private HashFactory HashFactory { get; set; }
        private Variation VariationModel { get; set; }
        private List<Variation> VariationsGroups { get; set; }

        private bool CheckForHashesInFile { get; set; }
        private bool TryToBruteForce { get; set; }

        private NFSRaiderForm Sender { get; set; }

        public Unhash(
            NFSRaiderForm sender, HashFactory hashFactory, bool checkForHashesInFile, bool tryToBruteForce, string txtPrefixes, string txtSuffixes, string txtVariations, 
            string txtWordsBetweenVariations, string txtMinVariations, string txtMaxVariations, string processorCount, GenerateOption generateOption, Endianness unhashingEndianness, CaseOptions caseOption)
        {
            Sender = sender;
            HashFactory = hashFactory;
            CaseOption = caseOption;

            Hashes = new HashSet<uint>();
            Prefixes = new HashSet<string>(txtPrefixes.SplitBy(new[] { ',' }, '\\'));
            Suffixes = new HashSet<string>(txtSuffixes.SplitBy(new[] { ',' }, '\\'));
            WordsBetweenVariations = new HashSet<string>(txtWordsBetweenVariations.SplitBy(new[] { ',' }, '\\'));
            ProcessorCount = Convert.ToInt32(processorCount);
            VariationsGroups = new List<Variation>();
            VariationModel = new Variation
            {
                MinVariations = Convert.ToInt32(txtMinVariations),
                MaxVariations = Convert.ToInt32(txtMaxVariations),
                GenerateOption = generateOption,
            };

            UnhashingEndianness = unhashingEndianness;

            CheckForHashesInFile = checkForHashesInFile;
            TryToBruteForce = tryToBruteForce;

            InitializeVariatons(txtVariations.SplitBy(new[] { ',' }, '\\'));
        }

        private void InitializeVariatons(IEnumerable<string> variations)
        {
            var regexPattern = @"^\[" +                                            // Start
                               @"(?<min>([\d]*))" +                                // MinVariations
                               @"(?<separator1>\-)" +                              // Separator
                               @"(?<max>([\d]*))" +                                // MaxVariations
                               @"(?<separator2>\-)" +                              // Separator
                               @"(?<generateOption>([0-1]))" +                     // GenerateOption
                               @"\]$";                                             // End

            var variationsGroups = variations.Where(c => c.StartsWith("{") && c.EndsWith("}"));
            var simpleVariations = variations.Where(c => !(c.StartsWith("{") && c.EndsWith("}")) && !(c.StartsWith("[") && c.EndsWith("]")));

            if (variationsGroups.Any())
            {
                var variation = new List<string>();
                Match regex;
                var min = 0;
                var max = 0;
                var generateOption = GenerateOption.WithoutRepetition;
                Variation variationModel;

                foreach (var variationGroup in variationsGroups)
                {
                    variation = variationGroup.Trim(new[] { '{', '}' }).SplitBy(new[] { ';' }, '\\').ToList();

                    regex = Regex.Match(variation.Last(), regexPattern);

                    if (variation.Any() && regex.Success)
                    {
                        min = Convert.ToInt32(regex.Groups["min"].ToString());
                        max = Convert.ToInt32(regex.Groups["max"].ToString());
                        generateOption = (GenerateOption)Convert.ToInt32(regex.Groups["generateOption"].ToString());
                        if (min > 0 && max > 0 && min <= max)
                        {
                            variation.RemoveAt(variation.Count - 1);
                            variationModel = new Variation
                            {
                                MinVariations = min,
                                MaxVariations = max,
                                GenerateOption = generateOption,
                            };
                            if (generateOption == GenerateOption.WithoutRepetition)
                                variationModel.Variations = variation;
                            else
                                variationModel.Variations = variation.ToHashSet();
                            VariationsGroups.Add(variationModel);
                        }
                    }
                }
            }

            var simpleVariationsWithSubstring = variations.Where(c => c.StartsWith("[") && c.EndsWith("]")).Select(c => c.Trim(new[] { '[', ']' }));
            var allSimpleVariationsWithSubstring = new HashSet<string>();

            foreach (var simpleVariation in simpleVariationsWithSubstring)
            { 
                for (int i = 0; i < simpleVariation.Length; i++)
                {
                    for (int j = i; j < simpleVariation.Length; j++)
                    {
                        allSimpleVariationsWithSubstring.Add(simpleVariation.Substring(i, j - i + 1));
                    }
                }
            }

            if (VariationsGroups.Any() || allSimpleVariationsWithSubstring.Any() || VariationModel.GenerateOption == GenerateOption.WithRepetition)
            {
                VariationModel.Variations = simpleVariations.Concat(allSimpleVariationsWithSubstring).ToHashSet();
            }
            else
            {
                VariationModel.Variations = simpleVariations.ToList();
            }

        }

        public void SplitHashes(string txtHashes)
        {
            var hashes = txtHashes.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(c => Regex.Replace(c, @"[^0-9A-Za-z]", "")).ToList();

            if (UnhashingEndianness == Endianness.BigEndian)
            {
                foreach (var hash in hashes)
                {
                    if (Helpers.Hashes.IsHash(hash))
                        Hashes.Add(Helpers.Hashes.Reverse(Convert.ToUInt32(hash, 16)));
                }
            }
            else
            {
                foreach (var hash in hashes)
                {
                    if (Helpers.Hashes.IsHash(hash))
                        Hashes.Add(Convert.ToUInt32(hash, 16));
                }
            }
        }

        public void BruteForceThread()
        {
            if (Hashes.Any())
            {
                if (CheckForHashesInFile)
                {
                    CheckFile();
                }
                if (TryToBruteForce)
                {
                    var variationModel = GenerateAllWordsVariations();
                    TryBruteforce(variationModel);
                }
            }
        }

        private void CheckFile()
        {
            Sender.GenericMessageBoxDuringBruteForce("Raid info", $"Hashes identified: {Hashes.Count}");
            var allParts = new AllStrings().ReadHashesFile(HashFactory, CaseOption);
            var results = new List<RaiderResult>();
            foreach (var hash in Hashes)
            {
                if (allParts.TryGetValue(hash, out var result))
                {
                    results.Add(new RaiderResult { Hash = hash, Value = result, IsKnown = true });
                }
                else
                {
                    results.Add(new RaiderResult { Hash = hash, Value = "HASH_UNKNOWN", IsKnown = false });
                }
            }

            Sender.UpdateFormDuringBruteforce(results);
        }

        private Variation GenerateAllWordsVariations()
        {
            var variationModel = new Variation()
            {
                MaxVariations = VariationModel.MaxVariations,
                MinVariations = VariationModel.MinVariations,
                GenerateOption = VariationModel.GenerateOption,
            };

            if (VariationsGroups.Any())
            {
                variationModel.Variations = new HashSet<string>(VariationModel.Variations);
                Sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"Found {VariationsGroups.Count} groups to generate variations!");
                var forceBreakPreventOutMemory = false;
                Variations<string> variations;
                var lastWordGenerated = string.Empty;
                foreach (var wordVariation in VariationsGroups)
                {
                    for (int variationsCount = wordVariation.MinVariations; variationsCount <= wordVariation.MaxVariations; variationsCount++)
                    {
                        variations = new Variations<string>(wordVariation.Variations, variationsCount, wordVariation.GenerateOption);
                        foreach (var variation in variations)
                        {
                            if (GC.GetTotalMemory(false) >= 1_500_000_000)
                            {
                                lastWordGenerated = string.Join("", variation);
                                variationModel.Variations.Add(lastWordGenerated);
                                forceBreakPreventOutMemory = true;
                                break;
                            }
                            variationModel.Variations.Add(string.Join("", variation));
                        }

                        if (forceBreakPreventOutMemory)
                            break;
                    }

                    if (forceBreakPreventOutMemory)
                        break;
                }

                if (forceBreakPreventOutMemory)
                    Sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"Not all variations were generated. Generations stopped to prevent out of memory exception." +
                        $"\r\nHashes identified: {Hashes.Count}" +
                        $"\r\nLast word generated: {lastWordGenerated}" +
                        $"\r\nTotal of strings to choose from: {variationModel.Variations.Count}");
                else
                    Sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"Generated all variations from groups!" +
                        $"\r\nHashes identified: {Hashes.Count}" +
                        $"\r\nTotal of strings to choose from: {variationModel.Variations.Count}");
            }
            else
            {
                variationModel.Variations = new List<string>(VariationModel.Variations);
                Sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"No groups found to generate variations!" +
                    $"\r\nHashes identified: {Hashes.Count}" +
                    $"\r\nTotal of strings to choose from: {variationModel.Variations.Count}");
            }

            return variationModel;
        }

        private void TryBruteforce(Variation variationsModel)
        {
            Variations<string> variations;
            OrderablePartitioner<IReadOnlyList<string>> rangePartitioner;
            for (int variationsCount = variationsModel.MinVariations; variationsCount <= variationsModel.MaxVariations; variationsCount++)
            {
                variations = new Variations<string>(variationsModel.Variations, variationsCount, VariationModel.GenerateOption);
                rangePartitioner = Partitioner.Create(variations);

                Parallel.ForEach(rangePartitioner, new ParallelOptions 
                {
                    MaxDegreeOfParallelism = ProcessorCount
                }, variation => CheckVariations(variation));
            }
        }

        private void CheckVariations(IReadOnlyList<string> variation)
        {
            string currentVariation;
            IEnumerable<string> generatedStrings;
            var results = new List<RaiderResult>();
            uint currentHash;

            foreach (var word in WordsBetweenVariations)
            {
                currentVariation = string.Join(word, variation);
                generatedStrings = GenerateStringsToCheck(currentVariation);

                foreach (var generatedString in generatedStrings)
                {
                    currentHash = HashFactory.Hash(generatedString);
                    if (Hashes.Contains(currentHash))
                    {
                        results.Add(new RaiderResult { Hash = currentHash, Value = generatedString, IsKnown = true });
                    }
                }
            }

            if (results.Any())
            {
                Sender.UpdateFormDuringBruteforce(results);
            }
        }

        private IEnumerable<string> GenerateStringsToCheck(string currentString)
        {
            foreach (var prefix in Prefixes)
            {
                foreach (var sufix in Suffixes)
                {
                    yield return $"{prefix}{currentString}{sufix}";
                }
            }
        }
    }
}
