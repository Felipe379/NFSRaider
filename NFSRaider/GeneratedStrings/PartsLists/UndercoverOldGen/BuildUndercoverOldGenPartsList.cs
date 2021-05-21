using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists.UndercoverOldGen
{
    public class BuildUndercoverOldGenPartsList
    {
        public HashSet<string> GetAllUndercoverOldGenParts()
        {
            var parts = new HashSet<string>(
                Brakes.List
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(RoofScoops.List)
                .Concat(VectorVinyls.List)
                .Concat(Vinyls.List)
                .Concat(Wheels.List)
                .Concat(WheelsManufacturers.List)
                .Concat(WindowTint.List)
                );

            foreach (var lod in Lods.List)
            {
                foreach (var brake in Brakes.List)
                {
                    parts.Add(brake + lod);
                }

                foreach (var plate in Plates.List)
                {
                    parts.Add(plate + lod);
                }

                foreach (var exhaust in Exhausts.List)
                {
                    foreach (var exhaustType in ExhaustsType.List)
                    {
                        parts.Add(exhaust + "_" + exhaustType + lod);
                    }
                }

                foreach (var roofscoop in RoofScoops.List)
                {
                    parts.Add(roofscoop + lod);
                    parts.Add(roofscoop + "_CF" + lod);
                    foreach (var roofscoopType in RoofScoopsType.List)
                    {
                        parts.Add(roofscoop + "_" + roofscoopType + lod);
                        parts.Add(roofscoop + "_" + roofscoopType + "_CF" + lod);
                    }
                }

                foreach (var spoiler in Spoilers.List)
                {
                    parts.Add("SPOILER" + "_" + spoiler + lod);
                    parts.Add("SPOILER" + "_" + spoiler + "_CF" + lod);
                    parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + lod);
                    parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_CF" + lod);
                    foreach (var spoilerType in SpoilersType.List)
                    {
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + lod);
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + "_CF" + lod);
                        parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_" + spoilerType + lod);
                        parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_" + spoilerType + "_CF" + lod);
                    }
                }
            }


            foreach (var decal in Decals.List)
            {
                foreach (var decalType in DecalsType.List)
                {
                    parts.Add(decal + "_" + decalType);
                }
            }

            foreach (var wheel in Wheels.List)
            {
                foreach (var lod in Lods.List)
                {
                    foreach (var wheelType in WheelsType.List)
                    {
                        parts.Add(wheel + "_" + wheelType + lod);
                    }
                }

                parts.Add(wheel + "_WHEEL");
                parts.Add(wheel + "_WHEEL_INNER_MASK");
            }

            return parts;
        }
    }
}
