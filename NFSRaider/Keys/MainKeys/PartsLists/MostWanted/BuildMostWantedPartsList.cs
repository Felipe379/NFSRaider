using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists.MostWanted
{
    public class BuildMostWantedPartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.MostWanted));
        public HashSet<string> GetAllMostWantedParts()
        {
            var parts = new HashSet<string>(
                Brakes.List
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(Numbers.List)
                .Concat(Huds.List)
                .Concat(HudsPaint.List)
                .Concat(HudsPaint.ListDemo)
                .Concat(HudsPaint.ListA124)
                .Concat(Paints.List)
                .Concat(Paints.ListDemo)
                .Concat(Plates.List)
                .Concat(RoofScoops.List)
                .Concat(Spoilers.List)
                .Concat(Vinyls.List)
                .Concat(Vinyls.ListDemo)
                .Concat(Wheels.List)
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

            foreach (var roofscoop in RoofScoops.List)
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


            foreach (var car in CarList)
            {
                foreach (var partAttributes in PartsAttributes.List)
                {
                    parts.Add(car + "_" + partAttributes);
                }

                foreach (var lod in Lods.List)
                {
                    foreach (var part in Parts.List)
                    {
                        parts.Add(car + "_" + part + "_" + lod);
                    }
                }
            }

            return parts;
        }
    }
}
