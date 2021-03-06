﻿using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists.ProStreet
{
    public class BuildProStreetPartsList
    {
        public HashSet<string> GetAllProStreetParts()
        {
            var parts = new HashSet<string>(
                BrakeRotor.List
                .Concat(Brakes.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Exhausts.List)
                .Concat(PaintGroups.List)
                .Concat(PaintSwatch.List)
                .Concat(RoofScoop.List)
                .Concat(Seat.List)
                .Concat(Wheels.List)
                .Concat(Vinyls.List)
                );

            foreach (var lod in Lods.List)
            {
                foreach (var wheel in Wheels.List)
                {
                    parts.Add(wheel + "_TIRE_FRONT" + lod);
                    parts.Add(wheel + "_TIRE_REAR" + lod);
                    parts.Add(wheel + "_WHEEL");
                }

                foreach (var roofscoop in RoofScoop.List)
                {
                    parts.Add(roofscoop + lod);
                }

                foreach (var exhaust in Exhausts.List)
                {
                    parts.Add(exhaust + lod);
                }
            }

            foreach (var spoiler in Spoilers.List)
            {
                foreach (var spoilerType in SpoilersType.List)
                {
                    parts.Add(spoiler + "_" + spoilerType);
                    foreach (var lod in Lods.List)
                    {
                        parts.Add(spoiler + "_" + spoilerType + lod);
                    }
                    
                    foreach (var windtunnel in Windtunnels.List)
                    {
                        parts.Add(spoiler + "_" + spoilerType + "_" + windtunnel);
                        foreach (var lod in Lods.List)
                        {
                            parts.Add(spoiler + "_" + spoilerType + "_" + windtunnel + lod);
                        }
                    }
                }
            }


            return parts;
        }
    }
}
