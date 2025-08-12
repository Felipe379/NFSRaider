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

            CreateMergedFile(new[] { Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "VltList") }, Path.Combine(mergedFilesFolder, "VltKeys.txt"));
            CreateMergedFile(new[] { Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Files") }, Path.Combine(mergedFilesFolder, "DisculatorKeys.txt"));
            CreateMergedFile(new[]
            {
                // TODO : CarsTextures and PartsLists

                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Global", "Attributes.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Global", "DataTables.txt"),

                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Brands", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Cars", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Cars", "Underground1.Deleted.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Cars", "Underground1.Leftovers.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "CarsPartGroups", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "CarsPositionMarkers", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "CarsSlotTypes", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "FEng", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "FEng", "Underground1.Arcade.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "FEng", "Underground1.Deleted.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "GCareers", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "LanguageLabels", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Materials", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Materials", "Underground1.Deleted.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Presets", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Presets", "Underground1.Deleted.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "SunInfos", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Textures", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Textures", "Underground1.Arcade.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Textures", "Underground1.Deleted.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Tracks", "Textures", "Underground1.txt"),
                Path.Combine(nfsRaiderPath, "NFSRaider", "Keys", "MainKeys", "Tracks", "Textures", "Underground1.Deleted.txt"),
            }, Path.Combine(mergedFilesFolder, "BinaryMainKeysUnderground1.txt"));
        }

        private static void CreateMergedFile(string[] directoriesPath, string outputFile)
        {
            try
            {
                var keys = new HashSet<string>();

                foreach (var directoryPath in directoriesPath)
                {
                    var files = new List<string>();
                    if (File.Exists(directoryPath))
                    {
                        files.Add(directoryPath);
                    }
                    else if (Directory.Exists(directoryPath))
                    {
                        files.AddRange(Directory.GetFiles(directoryPath, "*.txt", SearchOption.AllDirectories));
                    }
                    else
                    {
                        Console.WriteLine($"Error: The directory or file '{directoryPath}' does not exist.");
                        continue;
                    }

                    if (!files.Any())
                    {
                        Console.Error.WriteLine($"Error: No .txt files found in '{directoryPath}'.");
                        continue;
                    }

                    foreach (var file in files)
                    {
                        var lines = File.ReadAllLines(file);
                        keys.UnionWith(lines);
                    }
                }

                keys = keys.OrderBy(x => x).ToHashSet();

                File.WriteAllLines(outputFile, keys);

                Console.WriteLine($"{outputFile} created successfully.");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
