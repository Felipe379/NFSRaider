using NFSRaider.GeneratedStrings.Brands;
using NFSRaider.GeneratedStrings.Fng;
using NFSRaider.GeneratedStrings.Global;
using NFSRaider.GeneratedStrings.LanguageLabels;
using NFSRaider.GeneratedStrings.Materials;
using NFSRaider.GeneratedStrings.PartsLists;
using NFSRaider.GeneratedStrings.Presets;
using NFSRaider.GeneratedStrings.PresetSkins;
using NFSRaider.GeneratedStrings.Textures;
using NFSRaider.GeneratedStrings.TruncatedStrings;
using NFSRaider.GeneratedStrings.VltList;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NFSRaider.GeneratedStrings
{
    public class AllStrings
    {
        public string FileName { get; set; } = "Hashes.txt";

        public void GetStrings()
        {
            FileDelete.DestroyFile(FileName);

            var hashSet = new HashSet<string>(20000000);

            for (int i = 0; i < 256; i++)
            {
                hashSet.Add(i.ToString("D2"));
                hashSet.Add(i.ToString());
            }

            hashSet.UnionWith(new BuildPartsList().GetAllParts()); // TODO: Rework this
            hashSet.UnionWith(new BuildBrands().GetAllBrands());
            hashSet.UnionWith(new BuildPresets().GetAllPresets());
            hashSet.UnionWith(new BuildPresetSkins().GetAllPresetSkins());
            hashSet.UnionWith(new BuildLanguageLabels().GetAllLabels());
            hashSet.UnionWith(new BuildMaterials().GetAllMaterials());
            hashSet.UnionWith(new BuildGlobal().GetAllGlobal());
            hashSet.UnionWith(new BuildVlt().GetAllVlt());
            hashSet.UnionWith(new BuildTextures().GetAllTextures());
            hashSet.UnionWith(new BuildFng().GetAllFng());

            try
            {
                using (StreamWriter writer = new StreamWriter(FileName))
                {
                    foreach (var hashString in hashSet)
                    {
                        writer.Write($"{hashString}\r\n");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Failed to write to Hashes.txt. Error:\r\n {exp.Message}");
            }
        }

        public Dictionary<uint, string> ReadHashesFile(HashFactory hashFactory)
        {
            var hashes = new BuildTruncatedStrings().GetAllTruncatedStrings();
            var collisions = new HashSet<string>();
            uint currentHexValue;

            if (!File.Exists(FileName))
            {
                GetStrings();
                GC.Collect();
            }

            using (var fileStream = File.OpenRead(FileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
            {
                var line = string.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
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
                currentHexValue = hashFactory.Hash(collision);
                hashes[currentHexValue] += " / " + collision;
            }

            return hashes;
        }
    }
}
