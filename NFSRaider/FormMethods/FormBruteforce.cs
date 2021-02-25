using Combinatorics.Collections;
using NFSRaider.Enum;
using NFSRaider.GeneratedStrings;
using NFSRaider.Hash;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NFSRaider.FormMethods
{
    public class VariationModel
    {
        public int MinVariations { get; set; }
        public int MaxVariations { get; set; }
        public ICollection<string> Variations { get; set; }
        public GenerateOption GenerateOption { get; set; }
    }

    public class FormBruteforce
    {
        private int ProcessorCount { get; set; }
        private HashSet<uint> Hashes { get; set; }
        private HashSet<string> Prefixes { get; set; }
        private HashSet<string> Suffixes { get; set; }
        private HashSet<string> WordsBetweenVariations { get; set; }
        private Endianness UnhashingEndianness { get; set; }
        private CaseOptions CaseOption { get; set; }
        private HashFactory HashFactory { get; set; }
        private VariationModel VariationModel { get; set; }
        private List<VariationModel> WordsVariations { get; set; }

        private bool CheckForHashesInFile { get; set; }
        private bool TryToBruteForce { get; set; }

        private NFSRaiderForm Sender { get; set; }

        public FormBruteforce(
            NFSRaiderForm sender, HashFactory hashFactory, bool checkForHashesInFile, bool tryToBruteForce, string txtPrefixes, string txtSuffixes, string txtVariations, 
            string txtWordsBetweenVariations, string txtMinVariations, string txtMaxVariations, string processorCount, GenerateOption generateOption, Endianness unhashingEndianness, CaseOptions caseOption)
        {
            Sender = sender;
            HashFactory = hashFactory;
            CaseOption = caseOption;

            Hashes = new HashSet<uint>();
            Prefixes = new HashSet<string>(txtPrefixes.Split(new[] { ',' }));
            Suffixes = new HashSet<string>(txtSuffixes.Split(new[] { ',' }));
            WordsBetweenVariations = new HashSet<string>(txtWordsBetweenVariations.Split(new[] { ',' }));
            ProcessorCount = Convert.ToInt32(processorCount);

            var variations = txtVariations.Split(new[] { ',' }).ToList();

            WordsVariations = new List<VariationModel>();

            var regexPattern = @"^\[" +                                            // Start
                               @"(?<min>([\d]*))" +                                // MinVariations
                               @"(?<separator1>\-)" +                              // Separator
                               @"(?<max>([\d]*))" +                                // MaxVariations
                               @"(?<separator2>\-)" +                              // Separator
                               @"(?<generateOption>([0-1]))" +                     // GenerateOption
                               @"\]$";                                             // End

            foreach (var variation in variations.Where(c => c.StartsWith("{") && c.EndsWith("}")))
            {
                variations = variation.Trim(new[] { '{', '}' }).Split(new[] { ';' }).ToList();

                var regex = Regex.Match(variations.Last(), regexPattern);

                if (variations.Any() && regex.Success)
                {
                    variations.RemoveAt(variations.Count - 1);
                    WordsVariations.Add(new VariationModel
                    {
                        Variations = variations,
                        MinVariations = Convert.ToInt32(regex.Groups["min"].ToString()),
                        MaxVariations = Convert.ToInt32(regex.Groups["max"].ToString()),
                        GenerateOption = (GenerateOption)Convert.ToInt32(regex.Groups["generateOption"].ToString()),
                    });
                }
            }

            VariationModel = new VariationModel
            {
                MinVariations = Convert.ToInt32(txtMinVariations),
                MaxVariations = Convert.ToInt32(txtMaxVariations),
                GenerateOption = generateOption,
            };

            if (WordsVariations.Any())
            {
                VariationModel.Variations = variations.Where(c => !c.StartsWith("{") && !c.EndsWith("}")).ToHashSet();
                Sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"Found {WordsVariations.Count} words to generate variations!");
            }
            else
            {
                VariationModel.Variations = variations.Where(c => !c.StartsWith("{") && !c.EndsWith("}")).ToList();
            }


            UnhashingEndianness = unhashingEndianness;

            CheckForHashesInFile = checkForHashesInFile;
            TryToBruteForce = tryToBruteForce;
        }

        public void Unhash(string txtHashes)
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
                    GenerateAllWordsVariations();
                    TryBruteforce();
                }
            }
        }

        private void CheckFile()
        {
            var allParts = new AllStrings().ReadHashesFile(HashFactory, CaseOption);

            foreach (var hash in Hashes)
            {
                if (allParts.TryGetValue(hash, out var result))
                {
                    Sender.UpdateFormDuringBruteforce(hash, result, true);
                }
                else
                {
                    Sender.UpdateFormDuringBruteforce(hash, "HASH_UNKNOWN", false);
                }
            }
        }

        private void GenerateAllWordsVariations()
        {
            if (WordsVariations.Any())
            {
                foreach (var wordVariation in WordsVariations)
                {
                    for (int variationsCount = wordVariation.MinVariations; variationsCount <= wordVariation.MaxVariations; variationsCount++)
                    {
                        var variations = new Variations<string>(wordVariation.Variations, variationsCount, wordVariation.GenerateOption);
                        foreach (var variation in variations)
                        {
                            VariationModel.Variations.Add(string.Join("", variation));
                        }
                    }
                }

                Sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"Generated all variations from the words!\r\nTotal of strings to choose from: {VariationModel.Variations.Count}");
            }
        }

        private void TryBruteforce()
        {
            for (int variationsCount = VariationModel.MinVariations; variationsCount <= VariationModel.MaxVariations; variationsCount++)
            {
                var variations = new Variations<string>(VariationModel.Variations, variationsCount, VariationModel.GenerateOption);
                var rangePartitioner = Partitioner.Create(variations);

                Parallel.ForEach(rangePartitioner, new ParallelOptions 
                {
                    MaxDegreeOfParallelism = ProcessorCount
                }, variation => CheckVariations(variation));
            }
        }

        private void CheckVariations(IList<string> variation)
        {
            string currentVariation;
            IEnumerable<string> generatedStrings;
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
                        Sender.UpdateFormDuringBruteforce(currentHash, generatedString, true);
                    }
                }
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
