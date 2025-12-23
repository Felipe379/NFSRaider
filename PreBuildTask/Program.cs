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

            var games = new[]
            {
                NFSRaider.Enums.Game.Shared,
                NFSRaider.Enums.Game.HotPursuit2,
                NFSRaider.Enums.Game.Underground1,
                NFSRaider.Enums.Game.Underground2,
                NFSRaider.Enums.Game.MostWanted,
                NFSRaider.Enums.Game.Carbon,
                NFSRaider.Enums.Game.ProStreet,
                NFSRaider.Enums.Game.Undercover,
                NFSRaider.Enums.Game.UndercoverCG,
                NFSRaider.Enums.Game.World
            };

            foreach (var game in games)
            {
                CreateMergedFile(new[]
                {
                    // TODO : PartsLists
                    new NFSRaider.Keys.MainKeys.Global.BuildGlobal().GetKeys(),
                    new NFSRaider.Keys.MainKeys.AcidEffects.BuildAcidEffects().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Brands.BuildBrands().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Cars.BuildCars().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.CarsPartGroups.BuildCarsPartGroups().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.CarsPositionMarkers.BuildCarsPositionMarkers().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.CarsSlotTypes.BuildCarsSlotTypes().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.CarsTextures.BuildCarsTextures().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.CarsVinyls.BuildCarsVinyls().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.FEng.BuildFEng().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.GCareers.BuildGCareers().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.LanguageLabels.BuildLanguageLabels().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Materials.BuildMaterials().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Nis.BuildNis().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Presets.BuildPresets().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.PresetSkins.BuildPresetSkins().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.SunInfos.BuildSunInfos().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Textures.BuildTextures().GetKeys(game),
                    new NFSRaider.Keys.MainKeys.Tracks.Textures.BuildTextures().GetKeys(game),
                }, Path.Combine(mergedFilesFolder, $"BinaryMainKeys{game}.txt"));
            }
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
