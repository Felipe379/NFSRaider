using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists.Carbon
{
    public class BuildCarbonPartsList
    {
        public HashSet<string> GetAllCarbonParts()
        {
            var parts = new HashSet<string>(
                Beacons.List
                .Concat(Brakes.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(Decals.ListDemo)
                .Concat(Headlights.ListDemo)
                .Concat(Huds.ListDemo)
                .Concat(HudsPaint.ListDemo)
                .Concat(Numbers.ListDemo)
                .Concat(Paints.List)
                .Concat(Paints.ListDemo)
                .Concat(Plates.List)
                .Concat(PrecompVinyls.List)
                .Concat(RoofScoops.List)
                .Concat(VectorVinyls.List)
                .Concat(VectorVinyls.ListDemo)
                .Concat(VectorVinyls.ListPrerelease)
                .Concat(Vinyls.ListDemo)
                .Concat(Wheels.List)
                .Concat(WheelsManufacturers.List)
                .Concat(WindowTint.List)
                .Concat(WindowTint.ListDemo)
                );

            foreach (var lod in Lods.List)
            {
                foreach (var beacon in Beacons.List)
                {
                    parts.Add(beacon + lod);
                }

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

                    parts.Add("SPOILER" + "_" + spoiler + "_" + "AUTOSCULPT" + lod); // from demo
                    parts.Add("SPOILER" + "_" + spoiler + "_" + "AUTOSCULPT" + "_CF" + lod); //from demo

                    foreach (var spoilerType in SpoilersType.List)
                    {
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + lod);
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + "_CF" + lod);
                        parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_" + spoilerType + lod);
                        parts.Add("AUTOSCULPTSPOILER" + "_" + spoiler + "_" + spoilerType + "_CF" + lod);

                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + "_" + "AUTOSCULPT" + lod); // from demo
                        parts.Add("SPOILER" + "_" + spoiler + "_" + spoilerType + "_" + "AUTOSCULPT" + "_CF" + lod); //from demo
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
