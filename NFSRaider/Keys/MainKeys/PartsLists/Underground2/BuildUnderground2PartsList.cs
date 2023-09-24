using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists.Underground2
{
    public class BuildUnderground2PartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.Underground2));
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
                .Concat(Wheels.LabelsOnly)
                .Concat(Wheels.ListDemo)
                .Concat(WheelsManufacturers.List)
                .Concat(WindowTint.List)
                );

            foreach (var brake in Brakes.List)
            {
                //parts.Add(brake);
                foreach (var lod in Lods.List)
                {
                    parts.Add(brake + "_" + lod);
                }
            }

            foreach (var exhaust in Exhausts.List)
            {
                //parts.Add(exhaust);
                foreach (var lod in Lods.List)
                {
                    parts.Add(exhaust + "_" + lod);
                }
            }

            foreach (var exhaust in Exhausts.List)
            {
                //parts.Add(exhaust);
                foreach (var lod in Lods.List)
                {
                    parts.Add(exhaust + "_" + lod);
                }
            }

            foreach (var plate in Plates.List)
            {
                //parts.Add(plate);
                foreach (var lod in Lods.List)
                {
                    parts.Add(plate + "_" + lod);
                }
            }

            foreach (var mirror in Mirrors.List)
            {
                parts.Add(mirror + "_" + "MIRROR");
                parts.Add(mirror + "_" + "MIRROR" + "_CF");
                foreach (var mirrorType in MirrorsType.List)
                {
                    parts.Add(mirror + "_" + "MIRROR" + "_" + mirrorType);
                    parts.Add(mirror + "_" + "MIRROR" + "_" + mirrorType + "_CF");
                    foreach (var lod in Lods.List)
                    {
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "LEFT" + "_" + mirror + "_" + lod);
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "LEFT" + "_" + mirror + "_CF" + "_" + lod);
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "RIGHT" + "_" + mirror + "_" + lod);
                        parts.Add("MIRROR" + "_" + mirrorType + "_" + "RIGHT" + "_" + mirror + "_CF" + "_" + lod);
                    }
                }
            }

            foreach (var roofscoop in RoofScoops.List.Concat(RoofScoops.ListDemo))
            {
                //parts.Add(roofscoop);
                parts.Add(roofscoop + "_CF");
                foreach (var lod in Lods.List)
                {
                    parts.Add(roofscoop + "_" + lod);
                    parts.Add(roofscoop + "_CF" + "_" + lod);
                }

                foreach (var roofscoopType in RoofScoopsType.List)
                {
                    parts.Add(roofscoop + "_" + roofscoopType);
                    parts.Add(roofscoop + "_" + roofscoopType + "_CF");
                    foreach (var lod in Lods.List)
                    {
                        parts.Add(roofscoop + "_" + roofscoopType + "_" + lod);
                        parts.Add(roofscoop + "_" + roofscoopType + "_CF" + "_" + lod);
                    }
                }
            }

            foreach (var spoiler in Spoilers.List)
            {
                //parts.Add(spoiler);
                parts.Add(spoiler + "_CF");
                foreach (var lod in Lods.List)
                {
                    parts.Add(spoiler + "_" + lod);
                    parts.Add(spoiler + "_CF" + "_" + lod);
                }

                foreach (var spoilerType in SpoilersType.List)
                {
                    parts.Add(spoiler + "_" + spoilerType);
                    parts.Add(spoiler + "_" + spoilerType + "_CF");

                    foreach (var lod in Lods.List)
                    {
                        parts.Add(spoiler + "_" + spoilerType + "_" + lod);
                        parts.Add(spoiler + "_" + spoilerType + "_CF" + "_" + lod);
                    }
                }
            }

            foreach (var audio in Audio.List.Concat(Audio.ListGeometry))
            {
                //parts.Add(audio);
                parts.Add(audio + "_" + "PAINT");
                foreach (var lod in Lods.List)
                {
                    parts.Add(audio + "_" + lod);
                    parts.Add(audio + "_" + "PAINT" + "_" + lod);
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
                foreach (var wheelType in WheelsType.List)
                {
                    parts.Add(wheel + "_" + wheelType);
                    foreach (var lod in Lods.List)
                    {
                        parts.Add(wheel + "_" + wheelType + "_" + lod);
                    }
                }

                parts.Add(wheel + "_WHEEL");
                parts.Add(wheel + "_WHEEL_INNER_MASK");
            }

            foreach (var wheel in Wheels.LabelsOnly)
            {
                foreach (var wheelType in WheelsType.List)
                {
                    parts.Add(wheel + "_" + wheelType);
                }
            }

            foreach (var wheel in Wheels.ListDemo)
            {

                foreach (var wheelType in WheelsType.ListDemo)
                {
                    parts.Add(wheel + "_" + wheelType);
                    foreach (var lod in Lods.List)
                    {
                        parts.Add(wheel + "_" + wheelType + "_" + lod);
                        parts.Add(wheel + "_" + wheelType + "_" + "SPIN" + "_" + lod);
                    }
                }

                parts.Add(wheel + "_WHEEL");
                parts.Add(wheel + "_WHEEL_INNER_MASK");
            }

            foreach (var partAnimation in PartsAnimations.List)
            {
                foreach (var car in CarList)
                {
                    parts.Add(car + partAnimation);
                    parts.Add(car + partAnimation + "_" + "q");
                    parts.Add(car + partAnimation + "_" + "t");
                }
            }

            foreach (var car in CarList)
            {
                foreach (var partAttributes in PartsAttributes.List.Concat(PartsAttributes.ListCut).Concat(PartsAttributes.ListTraffic))
                {
                    parts.Add(car + "_" + partAttributes);
                }

                //NOTE: Yes, whitespace
                foreach (var partAttributes in PartsAttributes.ListTraffic)
                {
                    parts.Add(car + " " + partAttributes);
                }

                foreach (var lod in Lods.List)
                {
                    foreach (var part in Parts.List.Concat(Parts.ListCut).Concat(Parts.ListTraffic))
                    {
                        parts.Add(car + "_" + part + "_" + lod);
                    }
                }
            }

            return parts;
        }
    }
}
