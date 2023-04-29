using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.AcidEffects;
using NFSRaider.Keys.MainKeys.Brands;
using NFSRaider.Keys.MainKeys.Cars;
using NFSRaider.Keys.MainKeys.CarsPartGroups;
using NFSRaider.Keys.MainKeys.CarsPositionMarkers;
using NFSRaider.Keys.MainKeys.CarsSlotTypes;
using NFSRaider.Keys.MainKeys.CarsTextures;
using NFSRaider.Keys.MainKeys.FEng;
using NFSRaider.Keys.MainKeys.Files;
using NFSRaider.Keys.MainKeys.GCareers;
using NFSRaider.Keys.MainKeys.Global;
using NFSRaider.Keys.MainKeys.LanguageLabels;
using NFSRaider.Keys.MainKeys.Materials;
using NFSRaider.Keys.MainKeys.Nis;
using NFSRaider.Keys.MainKeys.PartsLists;
using NFSRaider.Keys.MainKeys.Presets;
using NFSRaider.Keys.MainKeys.PresetSkins;
using NFSRaider.Keys.MainKeys.SunInfos;
using NFSRaider.Keys.MainKeys.Textures;
using NFSRaider.Keys.MainKeys.Tracks;
using NFSRaider.Keys.MainKeys.VltList;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NFSRaider.Keys.MainKeys
{
    public class BuildMainKeys : Builder
    {
        private readonly int _processorCount;
        private readonly object _lockObject = new object();

        public BuildMainKeys(int processorCount)
        {
            _processorCount = processorCount;
        }

        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var mainKeys = new HashSet<string>(20_000_000);

            for (int i = 0; i < 256; i++)
            {
                mainKeys.Add(i.ToString("D2"));
                mainKeys.Add(i.ToString());
            }

            //hashSet.UnionWith(new BuildPartsListOld().GetAllParts());
            mainKeys.UnionWith(new BuildPartsList().GetAllParts());
            mainKeys.UnionWith(new BuildFiles().GetAllFiles());

            var builders = new List<Builder>
            {
                new BuildAcidEffects(),
                new BuildBrands(),
                new BuildCars(),
                new BuildCarsPartGroups(),
                new BuildCarsPositionMarkers(),
                new BuildCarsSlotTypes(),
                new BuildCarsTextures(),
                new BuildFEng(),
                new BuildGCareers(),
                new BuildGlobal(),
                new BuildLanguageLabels(),
                new BuildMaterials(),
                new BuildNis(),
                new BuildPresets(),
                new BuildPresetSkins(),
                new BuildSunInfos(),
                new BuildTextures(),
                new BuildTracks(),
                new BuildVlt(),
            };

            Parallel.ForEach(builders, new ParallelOptions
            {
                MaxDegreeOfParallelism = _processorCount,
                CancellationToken = cancellationToken
            }, builder =>
            {
                var keys = builder.GetKeys();

                lock (_lockObject)
                {
                    mainKeys.UnionWith(keys);
                }
            });

            return mainKeys;
        }
    }
}
