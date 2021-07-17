using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists.Underground2
{
    public class BuildUnderground2PartsList
    {
        public HashSet<string> GetAllUnderground2Parts()
        {
            var parts = new HashSet<string>(
                Audio.List
                .Concat(Audio.ListGeometry)
                .Concat(Brakes.List)
                .Concat(CarbonFibre.List)
                .Concat(CabinNeonFrame.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(DoorStyle.List)
                .Concat(Exhausts.List)
                .Concat(HeadlightBulb.List)
                .Concat(Huds.List)
                .Concat(HudsPaint.List)
                .Concat(Hydraulics.List)
                .Concat(Neons.List)
                .Concat(NosPurge.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(RoofScoops.List)
                .Concat(RoofScoops.ListDemo)
                .Concat(Spoilers.List)
                .Concat(Vinyls.List)
                .Concat(Vinyls.ListDemo)
                .Concat(Wheels.List)
                .Concat(Wheels.ListDemo)
                .Concat(WheelsManufacturers.List)
                .Concat(WindowTint.List)
                );

            foreach (var lod in Lods.List)
            {
                foreach (var brake in Brakes.List)
                {
                    parts.Add(brake + lod);
                }

                foreach (var exhaust in Exhausts.List)
                {
                    parts.Add(exhaust + lod);
                }

                foreach (var plate in Plates.List)
                {
                    parts.Add(plate + lod);
                }

                foreach (var mirror in Mirrors.List)
                {
                    parts.Add(mirror + "_" + "MIRROR" + lod);
                    parts.Add(mirror + "_" + "MIRROR" + "_CF" + lod);
                    foreach (var mirrorType in MirrorsType.List)
                    {
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "LEFT" + "_" + mirror + lod);
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "LEFT" + "_" + mirror + "_CF" + lod);
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "RIGHT" + "_" + mirror + lod);
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "RIGHT" + "_" + mirror + "_CF" + lod);
                        parts.Add(mirror + "_" + "MIRROR" + "_" + mirrorType + lod);
                        parts.Add(mirror + "_" + "MIRROR" + "_" + mirrorType + "_CF" + lod);
                    }
                }

                foreach (var roofscoop in RoofScoops.List.Concat(RoofScoops.ListDemo))
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
                    parts.Add(spoiler + lod);
                    parts.Add(spoiler + "_CF" + lod);
                    foreach (var spoilerType in SpoilersType.List)
                    {
                        parts.Add(spoiler + "_" + spoilerType + lod);
                        parts.Add(spoiler + "_" + spoilerType + "_CF" + lod);
                    }
                }
            }


            foreach (var audio in Audio.List.Concat(Audio.ListGeometry))
            {
                parts.Add(audio + "_" + "PAINT");
                foreach (var lod in Lods.List)
                {
                    parts.Add(audio + lod);
                    parts.Add(audio + "_" + "PAINT" + lod);
                }
            }

            foreach (var decal in Decals.List)
            {
                parts.Add(decal + "_" + "WHITE");
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

            foreach (var wheel in Wheels.ListDemo)
            {
                foreach (var lod in Lods.List)
                {
                    foreach (var wheelType in WheelsType.ListDemo)
                    {
                        parts.Add(wheel + "_" + wheelType + lod);
                        parts.Add(wheel + "_" + wheelType + "_" + "SPIN" + lod);
                    }
                }

                parts.Add(wheel + "_WHEEL");
                parts.Add(wheel + "_WHEEL_INNER_MASK");
            }

            return parts;
        }
    }
}
