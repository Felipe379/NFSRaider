using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Helpers
{
    public static class HashesListsMerge
    {
        public static Dictionary<uint, HashSet<string>> MergeWithTruncatedHashList(Dictionary<uint, string> truncatedHashes, IEnumerable<(uint hash, string value)> hashesToMerge)
        {
            var hashes = new Dictionary<uint, HashSet<string>>();
            var resolved = new HashSet<string>();

            foreach (var truncatedHash in truncatedHashes)
            {
                resolved = hashesToMerge
                    .Where(c => c.hash == truncatedHash.Key)
                    .Where(c => c.value.Contains(truncatedHash.Value))
                    .Select(c => c.value)
                    .ToHashSet();

                if (hashes.ContainsKey(truncatedHash.Key))
                {
                    hashes[truncatedHash.Key].Concat(resolved);
                }
                else
                {
                    hashes.Add(truncatedHash.Key, new HashSet<string>() { truncatedHash.Value + " (TRUNCATED)" }.Concat(resolved).ToHashSet());
                }
            }

            return hashes;
        }

        public static Dictionary<uint, HashSet<string>> MergeWithHashList(IEnumerable<(uint hash, string value)> hashesToMerge)
        {
            var hashes = hashesToMerge
                .GroupBy(c => c.hash)
                .ToDictionary(c => c.Key, c => new HashSet<string>(c.Select(d => d.value)));

            return hashes;
        }
    }
}
