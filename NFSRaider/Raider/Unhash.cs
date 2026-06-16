using Combinatorics.Collections;
using NFSRaider.Case;
using NFSRaider.Consts;
using NFSRaider.Enums;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using NFSRaider.Keys;
using NFSRaider.Raider.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace NFSRaider.Raider
{
    public class Unhash
    {
        private readonly NFSRaiderForm _sender;
        private readonly int _processorCount;
        private readonly HashFactory _hashFactory;
        private readonly CaseFactory _caseFactory;

        private readonly HashSet<string> _prefixes;
        private readonly HashSet<string> _suffixes;
        private readonly HashSet<string> _wordsBetweenVariations;
        private readonly Endianness _endianness;

        private Variation Variation { get; set; }
        private List<Variation> VariationsGroups { get; set; } = new List<Variation>();

        private readonly bool _checkMainKeys;
        private readonly bool _checkUserKeys;
        private readonly bool _checkMergedKeys;
        private readonly bool _tryBruteForce;

        private HashSet<uint> Hashes { get; set; } = new HashSet<uint>();
        private List<RaiderResult> Results { get; set; } = new List<RaiderResult>();
        private bool LockObjectIsUpdating { get; set; } = false;
        private object LockResults { get; } = new object();

        private static readonly char[] SubstringTrimChars = new[] { '[', ']' };
        private static readonly char[] CaseTrimChars = new[] { '<', '>' };

        public Unhash(
            NFSRaiderForm sender, HashFactory hashFactory, CaseFactory caseFactory, GenerateOption generateOption, Endianness endianness,
            bool checkMainKeys, bool checkUserKeys, bool checkMergedKeys, bool tryBruteForce, string prefixes, string suffixes, string variations, string wordsBetweenVariations,
            decimal minVariations, decimal maxVariations, decimal processorCount)
        {
            _sender = sender;
            _hashFactory = hashFactory;
            _caseFactory = caseFactory;
            _endianness = endianness;

            _prefixes = new HashSet<string>(prefixes.SplitBy(new[] { ',' }, '\\'));
            _suffixes = new HashSet<string>(suffixes.SplitBy(new[] { ',' }, '\\'));
            _wordsBetweenVariations = new HashSet<string>(wordsBetweenVariations.SplitBy(new[] { ',' }, '\\'));
            _processorCount = Convert.ToInt32(processorCount);
            Variation = new Variation
            {
                MinVariations = Convert.ToInt32(minVariations),
                MaxVariations = Convert.ToInt32(maxVariations),
                GenerateOption = generateOption,
            };

            _checkMainKeys = checkMainKeys;
            _checkUserKeys = checkUserKeys;
            _checkMergedKeys = checkMergedKeys;
            _tryBruteForce = tryBruteForce;

            InitializeVariatons(variations.SplitBy(new[] { ',' }, '\\'));
        }

        private void InitializeVariatons(IEnumerable<string> variations)
        {
            InitalizeVariationsGroups(variations);

            var simpleVariations = variations
                .Where(c => !(c.StartsWith('{') && c.EndsWith('}')))
                .Where(c => !(c.StartsWith('[') && c.EndsWith(']')))
                .Where(c => !(c.StartsWith('<') && c.EndsWith('>')));

            var allSimpleVariations = GenerateCaseVariations(variations)
                .Concat(GenerateSubstringVariations(variations));

            if (VariationsGroups.Any() || allSimpleVariations.Any() || Variation.GenerateOption == GenerateOption.WithRepetition)
            {
                Variation.Variations = simpleVariations.Concat(allSimpleVariations).ToHashSet();
            }
            else
            {
                Variation.Variations = simpleVariations.ToList();
            }

        }

        private void InitalizeVariationsGroups(IEnumerable<string> variations)
        {
            var regexPattern = @"^\[" +                                // Start
                   @"(?<min>([\d]*))" +                                // MinVariations
                   @"(?<separator1>\-)" +                              // Separator
                   @"(?<max>([\d]*))" +                                // MaxVariations
                   @"(?<separator2>\-)" +                              // Separator
                   @"(?<generateOption>([0-1]))" +                     // GenerateOption
                   @"\]$";                                             // End

            var variationsGroups = variations.Where(c => c.StartsWith('{') && c.EndsWith('}'));

            if (!variationsGroups.Any())
            {
                return;
            }

            var variation = new List<string>();
            Match regex;
            var min = 0;
            var max = 0;
            var generateOption = GenerateOption.WithoutRepetition;
            Variation variationModel;
            var valuesToTrim = new[] { '{', '}' };

            foreach (var variationGroup in variationsGroups)
            {
                variation = variationGroup.Trim(valuesToTrim).SplitBy(new[] { ';' }, '\\').ToList();

                regex = Regex.Match(variation.Last(), regexPattern);

                if (!(variation.Any() && regex.Success))
                {
                    continue;
                }

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

        private static HashSet<string> GenerateSubstringVariations(IEnumerable<string> variations)
        {
            var allSimpleVariationsWithSubstring = new HashSet<string>();
            var simpleVariationsWithSubstring = variations
                .Where(c => c.StartsWith('[') && c.EndsWith(']'))
                .Where(c => !HasInvalidNesting(c))
                .Select(c => c.Trim(SubstringTrimChars))
                .Where(c => !string.IsNullOrWhiteSpace(c));

            foreach (var simpleVariation in simpleVariationsWithSubstring)
            {
                if (simpleVariation.StartsWith('<') && simpleVariation.EndsWith('>'))
                {
                    foreach (var caseVariation in GenerateCaseVariations(new[] { simpleVariation }))
                    {
                        AddSubstrings(caseVariation, allSimpleVariationsWithSubstring);
                    }
                }
                else
                {
                    AddSubstrings(simpleVariation, allSimpleVariationsWithSubstring);
                }
            }

            return allSimpleVariationsWithSubstring;

            static void AddSubstrings(string value, HashSet<string> output)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = i; j < value.Length; j++)
                    {
                        output.Add(value.Substring(i, j - i + 1));
                    }
                }
            }
        }

        private static HashSet<string> GenerateCaseVariations(IEnumerable<string> variations)
        {
            var allSimpleVariationsWithCase = new HashSet<string>();
            var simpleVariationsWithCase = variations
                .Where(c => c.StartsWith('<') && c.EndsWith('>'))
                .Where(c => !HasInvalidNesting(c))
                .Select(c => c.Trim(CaseTrimChars))
                .Where(c => !string.IsNullOrWhiteSpace(c));

            foreach (var simpleVariation in simpleVariationsWithCase)
            {
                if (simpleVariation.StartsWith('[') && simpleVariation.EndsWith(']'))
                {
                    var substringVariations = GenerateSubstringVariations(new[]
                    {
                        simpleVariation,
                        simpleVariation.ToUpperInvariant(),
                        simpleVariation.ToLowerInvariant()
                    });

                    allSimpleVariationsWithCase.UnionWith(substringVariations);
                }
                else
                {
                    allSimpleVariationsWithCase.Add(simpleVariation);
                    allSimpleVariationsWithCase.Add(simpleVariation.ToUpperInvariant());
                    allSimpleVariationsWithCase.Add(simpleVariation.ToLowerInvariant());
                }
            }

            return allSimpleVariationsWithCase;
        }

        private static bool HasInvalidNesting(string value)
        {
            return value.Count(c => c == '[') > 1 ||
                   value.Count(c => c == ']') > 1 ||
                   value.Count(c => c == '<') > 1 ||
                   value.Count(c => c == '>') > 1;
        }

        public void SplitHashes(string txtHashes, int numericBase)
        {
            var hashes = txtHashes.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(c => Regex.Replace(c, @"[^0-9A-Za-z]", "")).ToList();

            if (_endianness == Endianness.BigEndian)
            {
                foreach (var hash in hashes)
                {
                    if (Helpers.Hashes.IsHash(hash, numericBase))
                        Hashes.Add(Helpers.Hashes.Reverse(Convert.ToUInt32(hash, numericBase)));
                }
            }
            else
            {
                foreach (var hash in hashes)
                {
                    if (Helpers.Hashes.IsHash(hash, numericBase))
                        Hashes.Add(Convert.ToUInt32(hash, numericBase));
                }
            }

            _sender.GenericMessageBoxDuringBruteForce("Info", $"{Hashes.Count} unique hashes identified");
        }

        public void Raid(CancellationToken cancellationToken)
        {
            if (Hashes.Any())
            {
                if (_checkMainKeys || _checkUserKeys || _checkMergedKeys)
                {
                    CheckKeysFiles(cancellationToken);
                }
                if (_tryBruteForce)
                {
                    var variationModel = GenerateAllWordsVariations(cancellationToken);
                    TryBruteforce(variationModel, cancellationToken);
                }
            }
        }

        private void CheckKeysFiles(CancellationToken cancellationToken)
        {
            var allParts = new BuildKeys(_hashFactory, _caseFactory, _checkMainKeys, _checkUserKeys, _checkMergedKeys, _processorCount).GetKeyValue(cancellationToken: cancellationToken);
            var results = new List<RaiderResult>();
            foreach (var hash in Hashes)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (allParts.TryGetValue(hash, out var result))
                {
                    results.Add(new RaiderResult { Hash = hash, Value = result, IsKnown = true });
                }
                else
                {
                    results.Add(new RaiderResult { Hash = hash, Value = RaiderConsts.HashUnknown, IsKnown = false });
                }
            }

            _sender.UpdateFormDuringBruteforce(results);
        }

        private Variation GenerateAllWordsVariations(CancellationToken cancellationToken)
        {
            var variatons = new Variation()
            {
                MaxVariations = Variation.MaxVariations,
                MinVariations = Variation.MinVariations,
                GenerateOption = Variation.GenerateOption,
            };

            if (VariationsGroups.Any())
            {
                variatons.Variations = new HashSet<string>(Variation.Variations);
                _sender.GenericMessageBoxDuringBruteForce("Bruteforce info", $"{VariationsGroups.Count} variaton groups found");
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
                            cancellationToken.ThrowIfCancellationRequested();

                            if (GC.GetTotalMemory(false) >= 1_500_000_000)
                            {
                                lastWordGenerated = string.Join("", variation);
                                variatons.Variations.Add(lastWordGenerated);
                                forceBreakPreventOutMemory = true;
                                break;
                            }
                            variatons.Variations.Add(string.Join("", variation));
                        }

                        if (forceBreakPreventOutMemory)
                            break;
                    }

                    if (forceBreakPreventOutMemory)
                        break;
                }

                if (forceBreakPreventOutMemory)
                    _sender.GenericMessageBoxDuringBruteForce("Info", $"Not all variations were generated. Generations stopped to prevent out of memory exception." +
                        $"{Environment.NewLine}Last word generated: {lastWordGenerated}" +
                        $"{Environment.NewLine}Total of strings to choose from: {variatons.Variations.Count}");
                else
                    _sender.GenericMessageBoxDuringBruteForce("Info", $"Generated all variations from groups!" +
                        $"{Environment.NewLine}Total of strings to choose from: {variatons.Variations.Count}");
            }
            else
            {
                variatons.Variations = new List<string>(Variation.Variations);
                _sender.GenericMessageBoxDuringBruteForce("Info", $"No groups found to generate variations!" +
                    $"{Environment.NewLine}Total of strings to choose from: {variatons.Variations.Count}");
            }

            return variatons;
        }

        private void TryBruteforce(Variation variationsModel, CancellationToken cancellationToken)
        {
            Variations<string> variations;
            OrderablePartitioner<IReadOnlyList<string>> rangePartitioner;
            for (int variationsCount = variationsModel.MinVariations; variationsCount <= variationsModel.MaxVariations; variationsCount++)
            {
                variations = new Variations<string>(variationsModel.Variations, variationsCount, Variation.GenerateOption);
                rangePartitioner = Partitioner.Create(variations);

                Parallel.ForEach(rangePartitioner, new ParallelOptions
                {
                    MaxDegreeOfParallelism = _processorCount,
                    CancellationToken = cancellationToken,
                }, variation => CheckVariations(variation));
            }

            UpdateMainForm();
        }

        private void CheckVariations(IReadOnlyList<string> variation)
        {
            string currentVariation, generatedString;
            uint currentHash;
            int wi, pi, si;
            var currentBlock = new HashSet<string>();

            for (wi = 0; wi < _wordsBetweenVariations.Count; wi++)
            {
                currentVariation = string.Join(_wordsBetweenVariations.ElementAt(wi), variation);
                for (pi = 0; pi < _prefixes.Count; pi++)
                {
                    for (si = 0; si < _suffixes.Count; si++)
                    {
                        generatedString = $"{_prefixes.ElementAt(pi)}{currentVariation}{_suffixes.ElementAt(si)}";
                        currentHash = _hashFactory.Hash(generatedString);
                        if (Hashes.Contains(currentHash))
                        {
                            currentBlock.Add(generatedString);
                            lock (LockResults)
                            {
                                Results.Add(new RaiderResult { Hash = currentHash, Value = generatedString, IsKnown = true });
                            }
                        }
                    }
                }
            }
        }

        public void UpdateTimeElapsed(object sender, ElapsedEventArgs e)
        {
            if (!LockObjectIsUpdating)
            {
                LockObjectIsUpdating = true;
                UpdateMainForm();
            }
        }

        private void UpdateMainForm()
        {
            if (Results.Any())
            {
                lock (LockResults)
                {
                    _sender.UpdateFormDuringBruteforce(Results);
                    Results.Clear();
                }
                GC.Collect();
            }
            LockObjectIsUpdating = false;
        }
    }
}
