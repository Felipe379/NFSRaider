using NFSRaider.Case;
using NFSRaider.Enums;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using NFSRaider.Keys.MainKeys;
using NFSRaider.Keys.MainKeys.TruncatedStrings;
using NFSRaider.Keys.UserKeys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace NFSRaider.Keys
{
    public class BuildKeys : Builder
    {
        private readonly HashFactory _hashFactory;
        private readonly CaseFactory _caseFactory;
        private readonly bool _useMainKeys;
        private readonly bool _useUserKeys;
        private readonly bool _useMergedKeysFile;
        private readonly int _processorCount;

        private static readonly string MergedKeysFile = Path.Combine(GetDirectory(typeof(BuildKeys)), "Keys.txt");

        public BuildKeys(HashFactory hashFactory, CaseFactory caseFactory, bool useMainKeys, bool useUserKeys, bool useMergedKeysFile, decimal processorCount)
        {
            _hashFactory = hashFactory;
            _caseFactory = caseFactory;
            _useMainKeys = useMainKeys;
            _useUserKeys = useUserKeys;
            _useMergedKeysFile = useMergedKeysFile;
            _processorCount = Convert.ToInt32(processorCount);
        }

        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var keys = new HashSet<string>();

            if (_useMainKeys)
            {
                keys.UnionWith(new BuildMainKeys(_processorCount).GetKeys(gameFilter, cancellationToken));
            }

            if (_useUserKeys)
            {
                keys.UnionWith(new BuildUserKeys().GetKeys(gameFilter, cancellationToken));
            }

            return keys;
        }

        public Dictionary<uint, string> GetKeyValue(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var keyValuePairs = new BuildTruncatedStrings().GetAllTruncatedStrings();
            var keys = _useMergedKeysFile
                ? UseMergedKeysFile()
                : GetKeys(gameFilter, cancellationToken);
            var collisions = new HashSet<string>();
            uint currentHexValue;
            GC.Collect();

            IEnumerable<string> lines = null;
            foreach (var key in keys)
            {
                lines = _caseFactory.ChangeCase(key).Distinct();
                foreach (var line in lines)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    currentHexValue = _hashFactory.Hash(line);

                    if (keyValuePairs.ContainsKey(currentHexValue))
                    {
                        if (keyValuePairs[currentHexValue] != line && !string.IsNullOrWhiteSpace(line))
                        {
                            collisions.Add(line);
                        }
                    }
                    else
                    {
                        keyValuePairs.Add(currentHexValue, line);
                    }
                }
            }

            foreach (var collision in collisions)
            {
                cancellationToken.ThrowIfCancellationRequested();
                currentHexValue = _hashFactory.Hash(collision);
                keyValuePairs[currentHexValue] += " / " + collision;
            }

            return keyValuePairs;
        }

        private static HashSet<string> UseMergedKeysFile()
        {
            var mergedKeys = new HashSet<string>();
            if (!File.Exists(MergedKeysFile))
                File.Create(MergedKeysFile).Close();

            mergedKeys = FileRead.ReadFiles(new List<string> { MergedKeysFile });

            return mergedKeys;
        }

        public void WriteKeysToFile(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var keys = new HashSet<string>(GetKeys(gameFilter, cancellationToken));
            try
            {
                using (var writer = new StreamWriter(MergedKeysFile))
                {
                    foreach (var key in keys)
                    {
                        writer.Write($"{key}{Environment.NewLine}");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Failed to write keys file. Error:{Environment.NewLine}{exp.Message}");
            }
        }
    }
}
