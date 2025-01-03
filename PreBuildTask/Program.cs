using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PreBuildTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nfsRaiderPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            if (!nfsRaiderPath.EndsWith("NFSRaider"))
            {
                nfsRaiderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            }

            var mergedFilesFolder = Path.Combine(nfsRaiderPath, "Merged");

            if (!Directory.Exists(mergedFilesFolder))
                Directory.CreateDirectory(mergedFilesFolder);

            CreateMergedFile(Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "VltList"), Path.Combine(mergedFilesFolder, "VltKeys.txt"));
            CreateMergedFile(Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Files"), Path.Combine(mergedFilesFolder, "DisculatorKeys.txt"));
        }

        private static void CreateMergedFile(string directoryPath, string outputFile)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Console.Error.WriteLine($"Error: The directory '{directoryPath}' does not exist.");
                    return;
                }

                var files = Directory.GetFiles(directoryPath, "*.txt", SearchOption.AllDirectories);

                if (!files.Any())
                {
                    Console.Error.WriteLine($"Error: No .txt files found in '{directoryPath}'.");
                    return;
                }

                var keys = new HashSet<string>();

                foreach (var file in files)
                {
                    var lines = File.ReadAllLines(file);
                    keys.UnionWith(lines);
                }

                keys = keys.OrderBy(x => x).ToHashSet();

                File.WriteAllLines(outputFile, keys);

                Console.WriteLine($"{outputFile} created successfully in '{directoryPath}'.");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
