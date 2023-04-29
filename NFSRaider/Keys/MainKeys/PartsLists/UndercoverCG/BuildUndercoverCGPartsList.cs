using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists.UndercoverCG
{
    public class BuildUndercoverCGPartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.UndercoverCG));
        public HashSet<string> GetAllUndercoverCGParts()
        {
            var parts = new HashSet<string>(
                Brakes.List
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(PrecompVinyls.List)
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

            //foreach (var lod in Lods.List)
            //{
            //    foreach (var car in CarList)
            //    {
            //        parts.Add(car + lod);
            //        foreach (var part in Parts.List)
            //        {
            //            parts.Add(car + part + lod);
            //        }
            //    }
            //}

            return parts;
        }
    }
}
