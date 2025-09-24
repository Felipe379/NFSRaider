using System;
using System.IO;

namespace PreBuildTask.ListsMerge
{
    public class Merge
    {
        public static void Run(string directory)
        {
            var merged = HashesListsMerge.MergeWithTruncatedHashList(Lists.Truncated, Lists.HashesToMerge);

            var filePath = Path.Combine(directory, $"MergedLists-{DateTime.Now:yyyy-MM-ddThh-mm-ss}.txt");

            using (var writer = new StreamWriter(filePath))
            {
                foreach (var hashString in merged)
                {
                    writer.Write($"0x{hashString.Key:x8} - {string.Join(" / ", hashString.Value)}\r\n");
                }
            }
        }
    }
}
