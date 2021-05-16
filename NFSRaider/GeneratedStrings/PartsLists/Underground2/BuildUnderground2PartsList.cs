﻿using NFSRaider.GeneratedStrings.Shared;
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
                .Concat(Mirrors.List)
                .Concat(Neons.List)
                .Concat(NosPurge.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(RoofScoops.List)
                .Concat(Spoilers.List)
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

                foreach (var mirror in Mirrors.List)
                {
                    parts.Add(mirror + lod);
                    parts.Add(mirror + "_CF" + lod);
                    foreach (var mirrorType in MirrorsType.List)
                    {
                        parts.Add(mirror + "_" + mirrorType + lod);
                        parts.Add(mirror + "_" + mirrorType + "_CF" + lod);
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
                    parts.Add(spoiler + lod);
                    parts.Add(spoiler + "_CF" + lod);
                    foreach (var spoilerType in SpoilersType.List)
                    {
                        parts.Add(spoiler + "_" + spoilerType + lod);
                        parts.Add(spoiler + "_" + spoilerType + "_CF" + lod);
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
