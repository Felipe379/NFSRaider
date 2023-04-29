using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.TruncatedStrings
{
    public class BuildTruncatedStrings
    {
        private Dictionary<uint, HashSet<string>> _hashes = new Dictionary<uint, HashSet<string>>();

        public Dictionary<uint, string> GetAllTruncatedStrings()
        {
            void AddHashes(uint key, string value, string type)
            {
                if (_hashes.ContainsKey(key))
                {
                    _hashes[key].Add($"{value} (TRUNCATED, {type})");
                }
                else
                {
                    _hashes.Add(key, new HashSet<string>() { $"{value} (TRUNCATED, {type})" });
                }
            }

            foreach (var hash in Underground2.BinKeysTextures)
            {
                AddHashes(hash.Key, hash.Value, "BIN");
            }

            foreach (var hash in Carbon.VltKeysTrackCollision)
            {
                AddHashes(hash.Key, hash.Value, "VLT");
            }

            foreach (var hash in World.VltKeysTrackCollision)
            {
                AddHashes(hash.Key, hash.Value, "VLT");
            }

            return _hashes.ToDictionary(c => c.Key, c => string.Join(" / ", c.Value));
        }
    }
}
