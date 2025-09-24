using PreBuildTask.ListsMerge;
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

            var generateMergedLists = false;

            if (generateMergedLists)
            {
                Merge.Run(mergedFilesFolder);
                return;
            }

            CreateMergedFile(new[] { new NFSRaider.Keys.MainKeys.VltList.BuildVlt().GetKeys() }, Path.Combine(mergedFilesFolder, "VltKeys.txt"));
            CreateMergedFile(new[] { new NFSRaider.Keys.MainKeys.Files.BuildFiles().GetKeys() }, Path.Combine(mergedFilesFolder, "DisculatorKeys.txt"));
            CreateMergedFile(new[]
            {
                // TODO : PartsLists
                new NFSRaider.Keys.MainKeys.Global.BuildGlobal().GetKeys(),
                new NFSRaider.Keys.MainKeys.Brands.BuildBrands().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.Cars.BuildCars().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.CarsPartGroups.BuildCarsPartGroups().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.CarsPositionMarkers.BuildCarsPositionMarkers().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.CarsSlotTypes.BuildCarsSlotTypes().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.CarsTextures.BuildCarsTextures().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.CarsVinyls.BuildCarsVinyls().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.FEng.BuildFEng().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.GCareers.BuildGCareers().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.LanguageLabels.BuildLanguageLabels().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.Materials.BuildMaterials().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.Presets.BuildPresets().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.SunInfos.BuildSunInfos().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.Textures.BuildTextures().GetKeys(NFSRaider.Enums.Game.Underground1),
                new NFSRaider.Keys.MainKeys.Tracks.Textures.BuildTextures().GetKeys(NFSRaider.Enums.Game.Underground1),
            }, Path.Combine(mergedFilesFolder, "BinaryMainKeysUnderground1.txt"));
        }

        private static void CreateMergedFile(HashSet<string>[] keys, string outputFile)
        {
            try
            {
                var keysMerged = new HashSet<string>();

                foreach (var key in keys)
                {
                    keysMerged.UnionWith(key);
                }

                keysMerged = keysMerged.OrderBy(x => x).ToHashSet();

                File.WriteAllLines(outputFile, keysMerged);

                Console.WriteLine($"{outputFile} created successfully.");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
