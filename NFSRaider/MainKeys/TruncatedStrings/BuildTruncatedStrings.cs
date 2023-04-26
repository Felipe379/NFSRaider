using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.TruncatedStrings
{
    public class BuildTruncatedStrings
    {
        private Dictionary<uint, HashSet<string>> _hashes = new Dictionary<uint, HashSet<string>>();

        public Dictionary<uint, string> GetAllTruncatedStrings()
        {
            void AddHashes(uint key, string value)
            {
                if (_hashes.ContainsKey(key))
                {
                    _hashes[key].Add(value + " (TRUNCATED)");
                }
                else
                {
                    _hashes.Add(key, new HashSet<string>() { value + " (TRUNCATED)" });
                }
            }

            foreach (var hash in Underground2.BinHashesTextures)
            {
                AddHashes(hash.Key, hash.Value);
            }

            return _hashes.ToDictionary(c => c.Key, c => string.Join(" / ", c.Value));
        }
    }
}
