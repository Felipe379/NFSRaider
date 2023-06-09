using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists.World
{
    public class BuildWorldPartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.World));
        public HashSet<string> GetAllWorldParts()
        {
            var parts = new HashSet<string>(
                Brakes.List
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(Effects.List)
                .Concat(Enhancers.List)
                .Concat(Neons.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(PlatesTextures.List)
                .Concat(PrecompVinyls.List)
                .Concat(RideHeightDrop.List)
                .Concat(RoofScoops.List)
                .Concat(VectorVinyls.ListAsianBeta)
                .Concat(Vinyls.List)
                .Concat(Vinyls.ListRemoved)
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

                foreach (var plate in Plates.List)
                {
                    //parts.Add(plate);
                    foreach (var lod in Lods.List)
                    {
                        parts.Add(plate + "_" + lod);
                    }
                }

                foreach (var exhaust in Exhausts.List)
                {
                    foreach (var exhaustType in ExhaustsType.List)
                    {
                        parts.Add(exhaust + "_" + exhaustType);
                        foreach (var lod in Lods.List)
                        {
                            parts.Add(exhaust + "_" + exhaustType + lod);
                        }
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
                    parts.Add("SPOILER" + "_" + spoiler);
                    parts.Add("SPOILER" + "_" + spoiler + "_CF");
                    parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler);
                    parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_CF");
                    foreach (var lod in Lods.List)
                    {
                        parts.Add("SPOILER" + "_" + spoiler + "_" + lod);
                        parts.Add("SPOILER" + "_" + spoiler + "_CF" + "_" + lod);
                    }

                    foreach (var spoilerType in SpoilersType.List)
                    {
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType);
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + "_CF");
                        parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_" + spoilerType);
                        parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_" + spoilerType + "_CF");
                        foreach (var lod in Lods.List)
                        {
                            parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + lod);
                            parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + "_CF" + lod);
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
                foreach (var partAttribute in PartsAttributes.List.Concat(PartsAttributes.ListCut))
                {
                    parts.Add(car + "_" + partAttribute);
                }

                foreach (var partAutosculpt in PartsAutosculpt.List.Concat(PartsAutosculpt.ListCut))
                {
                    parts.Add(car + "_" + partAutosculpt);

                    foreach (var autosculpt in Autosculpt.List)
                    {
                        parts.Add(car + "_" + partAutosculpt + "_" + autosculpt);
                    }
                }

                foreach (var lod in Lods.List)
                {
                    foreach (var part in Parts.List.Concat(Parts.ListCut))
                    {
                        parts.Add(car + "_" + part + "_" + lod);
                    }
                }
            }

            return parts;
        }
    }
}
