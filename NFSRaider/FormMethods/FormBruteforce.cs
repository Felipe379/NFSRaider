using Combinatorics.Collections;
using NFSRaider.Enum;
using NFSRaider.GeneratedStrings;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NFSRaider.FormMethods
{
    public class FormBruteforce
    {
        private int MinVariations { get; set; }
        private int MaxVariations { get; set; }
        private HashSet<uint> Hashes { get; set; }
        private HashSet<string> Prefixes { get; set; }
        private HashSet<string> Sufixes { get; set; }
        private HashSet<string> Variations { get; set; }
        private HashSet<string> WordsBetweenVariations { get; set; }
        private GenerateOption GenerateOption { get; set; }
        private Endianness UnhashingEndianness { get; set; }
        private HashFactory HashFactory { get; set; }

        private bool CheckForHashesInFile { get; set; }
        private bool TryToBruteForce { get; set; }

        private NFSRaiderForm Sender { get; set; }

        public FormBruteforce(NFSRaiderForm sender, HashFactory hashFactory, bool checkForHashesInFile, bool tryToBruteForce, string txtPrefixes, string txtSufixes, string txtVariations, string txtWordsBetweenVariations, string txtMinVariations, string txtMaxVariations, GenerateOption generateOption, Endianness unhashingEndianness)
        {
            Sender = sender;
            HashFactory = hashFactory;

            Hashes = new HashSet<uint>();
            Prefixes = new HashSet<string>(txtPrefixes.Split(new[] { ',' }));
            Sufixes = new HashSet<string>(txtSufixes.Split(new[] { ',' }));
            Variations = new HashSet<string>(txtVariations.Split(new[] { ',' }));
            WordsBetweenVariations = new HashSet<string>(txtWordsBetweenVariations.Split(new[] { ',' }));
            MinVariations = Convert.ToInt32(txtMinVariations);
            MaxVariations = Convert.ToInt32(txtMaxVariations);

            GenerateOption = generateOption;
            UnhashingEndianness = unhashingEndianness;

            CheckForHashesInFile = checkForHashesInFile;
            TryToBruteForce = tryToBruteForce;
        }

        public void Unhash(string txtHashes)
        {
            if (UnhashingEndianness == Endianness.BigEndian)
            {
                foreach (var hash in txtHashes.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Hashes.Add(Helpers.Hashes.Reverse(Convert.ToUInt32(hash, 16)));
                }
            }
            else
            {
                foreach (var hash in txtHashes.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Hashes.Add(Convert.ToUInt32(hash, 16));
                }
            }
        }

        public void BruteForceThread()
        {
            if (CheckForHashesInFile)
            {
                CheckFile();
            }
            if (TryToBruteForce)
            {
                TryBruteforce();
            }
        }

        private void CheckFile()
        {
            var allParts = new AllParts().ReadHashesFile(HashFactory);

            foreach (var hash in Hashes)
            {
                if (allParts.TryGetValue(hash, out var result))
                {
                    Sender.UpdateFormDuringBruteforce(hash, result);
                }
            }
        }

        private void TryBruteforce()
        {
            var currentVariation = string.Empty;
            IEnumerable<string> generatedStrings;
            uint currentHash;

            for (int variationsCount = MinVariations; variationsCount <= MaxVariations; variationsCount++)
            {
                var variations = new Variations<string>(Variations, variationsCount, GenerateOption);

                foreach (var variation in variations)
                {
                    foreach (var word in WordsBetweenVariations)
                    {
                        currentVariation = string.Join(word, variation);
                        generatedStrings = GenerateStringsToCheck(currentVariation);

                        foreach (var generatedString in generatedStrings)
                        {
                            currentHash = HashFactory.Hash(generatedString);
                            if (Hashes.Contains(currentHash))
                            {
                                Sender.UpdateFormDuringBruteforce(currentHash, generatedString);
                            }
                        }
                    }
                }
            }
        }

        private IEnumerable<string> GenerateStringsToCheck(string currentString)
        {
            foreach (var prefix in Prefixes)
            {
                foreach (var sufix in Sufixes)
                {
                    yield return $"{prefix}{currentString}{sufix}";
                }
            }
        }
    }
}
