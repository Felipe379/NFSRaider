using NFSRaider.Case;
using NFSRaider.Enums;
using NFSRaider.MainKeys.AcidEffects;
using NFSRaider.MainKeys.Brands;
using NFSRaider.MainKeys.Cars;
using NFSRaider.MainKeys.CarsPartGroups;
using NFSRaider.MainKeys.CarsPositionMarkers;
using NFSRaider.MainKeys.CarsSlotTypes;
using NFSRaider.MainKeys.CarsTextures;
using NFSRaider.MainKeys.Files;
using NFSRaider.MainKeys.Fng;
using NFSRaider.MainKeys.GCareers;
using NFSRaider.MainKeys.Global;
using NFSRaider.MainKeys.LanguageLabels;
using NFSRaider.MainKeys.Materials;
using NFSRaider.MainKeys.Nis;
using NFSRaider.MainKeys.PartsLists;
using NFSRaider.MainKeys.PartsListsOld;
using NFSRaider.MainKeys.Presets;
using NFSRaider.MainKeys.PresetSkins;
using NFSRaider.MainKeys.SunInfos;
using NFSRaider.MainKeys.Textures;
using NFSRaider.MainKeys.Tracks;
using NFSRaider.MainKeys.TruncatedStrings;
using NFSRaider.MainKeys.VltList;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NFSRaider.MainKeys
{
    public class AllStrings
    {
        public static string FileName { get; set; } = "Hashes.txt";
        public static string UserKeyssDir { get; set; } = "UserKeys";
        public static string UserFileName { get; set; } = $"{UserKeyssDir}\\ExampleHashes.txt";

        public void GetStrings()
        {
            if (File.Exists(FileName))
            {
                FileDelete.DestroyFile(FileName);
            }

            var hashSet = new HashSet<string>(20_000_000);

            for (int i = 0; i < 256; i++)
            {
                hashSet.Add(i.ToString("D2"));
                hashSet.Add(i.ToString());
            }

            hashSet.UnionWith(new BuildPartsList().GetAllParts());

            hashSet.UnionWith(new BuildAcidEffects().GetKeys());
            hashSet.UnionWith(new BuildBrands().GetKeys());
            hashSet.UnionWith(new BuildCarsPartGroups().GetKeys());
            hashSet.UnionWith(new BuildCarsSlotTypes().GetKeys());
            hashSet.UnionWith(new BuildCars().GetKeys());
            hashSet.UnionWith(new BuildCarsTextures().GetKeys());
            hashSet.UnionWith(new BuildCarsPositionMarkers().GetKeys());
            hashSet.UnionWith(new BuildFng().GetKeys());
            hashSet.UnionWith(new BuildGCareers().GetKeys());
            hashSet.UnionWith(new BuildGlobal().GetKeys());
            hashSet.UnionWith(new BuildLanguageLabels().GetKeys());
            hashSet.UnionWith(new BuildMaterials().GetKeys());
            hashSet.UnionWith(new BuildNis().GetKeys());
            hashSet.UnionWith(new BuildPresetSkins().GetKeys());
            hashSet.UnionWith(new BuildPresets().GetKeys());
            hashSet.UnionWith(new BuildStreamFiles().GetAllStreamFiles());
            hashSet.UnionWith(new BuildSunInfos().GetKeys());
            hashSet.UnionWith(new BuildTextures().GetKeys());
            hashSet.UnionWith(new BuildVlt().GetKeys());

            hashSet.UnionWith(new BuildFiles().GetAllFiles());

            //hashSet.UnionWith(new BuildPartsListOld().GetAllParts());

            try
            {
                using (var writer = new StreamWriter(FileName))
                {
                    foreach (var hashString in hashSet)
                    {
                        writer.Write($"{hashString}{Environment.NewLine}");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Failed to write to Hashes.txt. Error:{Environment.NewLine}{exp.Message}");
            }
        }

        public Dictionary<uint, string> ReadHashesFile(HashFactory hashFactory, CaseOptions caseOption, CancellationToken cancellationToken = default)
        {
            var hashes = new BuildTruncatedStrings().GetAllTruncatedStrings();

            if (!Directory.Exists(UserKeyssDir))
            {
                Directory.CreateDirectory(UserKeyssDir);

                if (!File.Exists(UserFileName))
                {
                    File.Create(UserFileName).Close();
                }
            }

            if (!File.Exists(FileName))
            {
                GetStrings();
                GC.Collect();
            }

            var files = new List<string>() { FileName }.Concat(Directory.GetFiles(UserKeyssDir, "*.txt", SearchOption.AllDirectories)).ToArray();
            var caseFactory = CaseFactory.GetCaseType(caseOption);

            var collisions = new HashSet<string>();
            uint currentHexValue;

            foreach (var file in files)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using var fileStream = File.OpenRead(file);
                using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true);
                var line = string.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    line = caseFactory.ChangeCase(line);
                    currentHexValue = hashFactory.Hash(line);

                    if (hashes.ContainsKey(currentHexValue))
                    {
                        if (hashes[currentHexValue] != line)
                        {
                            collisions.Add(line);
                        }
                    }
                    else
                    {
                        hashes.Add(currentHexValue, line);
                    }
                }
            }

            foreach (var collision in collisions)
            {
                cancellationToken.ThrowIfCancellationRequested();
                currentHexValue = hashFactory.Hash(collision);
                hashes[currentHexValue] += " / " + collision;
            }

            return hashes;
        }
    }
}
