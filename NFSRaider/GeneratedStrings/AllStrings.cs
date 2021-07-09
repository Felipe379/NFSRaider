using NFSRaider.Case;
using NFSRaider.Enum;
using NFSRaider.GeneratedStrings.AcidEffects;
using NFSRaider.GeneratedStrings.AcidEmitters;
using NFSRaider.GeneratedStrings.Brands;
using NFSRaider.GeneratedStrings.Cars;
using NFSRaider.GeneratedStrings.CarsPartGroups;
using NFSRaider.GeneratedStrings.CarsPositionMarkers;
using NFSRaider.GeneratedStrings.CarsSlotTypes;
using NFSRaider.GeneratedStrings.Files;
using NFSRaider.GeneratedStrings.Fng;
using NFSRaider.GeneratedStrings.GCareers;
using NFSRaider.GeneratedStrings.Global;
using NFSRaider.GeneratedStrings.LanguageLabels;
using NFSRaider.GeneratedStrings.Materials;
using NFSRaider.GeneratedStrings.PartsLists;
using NFSRaider.GeneratedStrings.PartsListsOld;
using NFSRaider.GeneratedStrings.Presets;
using NFSRaider.GeneratedStrings.PresetSkins;
using NFSRaider.GeneratedStrings.SunInfos;
using NFSRaider.GeneratedStrings.Textures;
using NFSRaider.GeneratedStrings.Tracks;
using NFSRaider.GeneratedStrings.TruncatedStrings;
using NFSRaider.GeneratedStrings.VltList;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NFSRaider.GeneratedStrings
{
    public class AllStrings
    {
        public string FileName { get; set; } = "Hashes.txt";
        public string UserFileName { get; set; } = "UserHashes.txt";

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

            hashSet.UnionWith(new BuildAcidEffects().GetAllAcidEffects());
            hashSet.UnionWith(new BuildAcidEmitters().GetAllAcidEmitters());
            hashSet.UnionWith(new BuildBrands().GetAllBrands());
            hashSet.UnionWith(new BuildCarsPartGroups().GetAllCarsPartGroups());
            hashSet.UnionWith(new BuildCarsSlotTypes().GetAllCarsSlotTypes());
            hashSet.UnionWith(new BuildCars().GetAllCars());
            hashSet.UnionWith(new BuildCarsPositionMarkers().GetAllCarsPositionMarkers());
            hashSet.UnionWith(new BuildFng().GetAllFng());
            hashSet.UnionWith(new BuildGCareers().GetAllGCarrers());
            hashSet.UnionWith(new BuildGlobal().GetAllGlobal());
            hashSet.UnionWith(new BuildLanguageLabels().GetAllLabels());
            hashSet.UnionWith(new BuildMaterials().GetAllMaterials());
            hashSet.UnionWith(new BuildPresetSkins().GetAllPresetSkins());
            hashSet.UnionWith(new BuildPresets().GetAllPresets());
            hashSet.UnionWith(new BuildStreamFiles().GetAllStreamFiles());
            hashSet.UnionWith(new BuildSunInfos().GetSunInfos());
            hashSet.UnionWith(new BuildTextures().GetAllTextures());
            hashSet.UnionWith(new BuildVlt().GetAllVlt());

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

        public Dictionary<uint, string> ReadHashesFile(HashFactory hashFactory, CaseOptions caseOption)
        {
            var hashes = new BuildTruncatedStrings().GetAllTruncatedStrings();

            if (!File.Exists(UserFileName))
            {
                File.Create(UserFileName).Close();
            }

            if (!File.Exists(FileName))
            {
                GetStrings();
                GC.Collect();
            }

            var files = new List<string>() { UserFileName, FileName };
            var caseFactory = CaseFactory.GetCaseType(caseOption);

            var collisions = new HashSet<string>();
            uint currentHexValue;

            foreach (var file in files)
            {
                using (var fileStream = File.OpenRead(file))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
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
            }

            foreach (var collision in collisions)
            {
                currentHexValue = hashFactory.Hash(collision);
                hashes[currentHexValue] += " / " + collision;
            }

            return hashes;
        }
    }
}
