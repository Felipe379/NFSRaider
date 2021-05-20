﻿using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists.Undercover
{
    public class BuildUndercoverPartsList
    {
        public HashSet<string> GetAllUndercoverParts()
        {
            var parts = new HashSet<string>(
                BrakeRotor.List
                .Concat(Brakes.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Plates.List)
                .Concat(RoofScoop.List)
                .Concat(Seat.List)
                .Concat(Wheels.List)
                .Concat(Vinyls.List)
                );

            foreach (var lod in Lods.List)
            {
                foreach (var brakeRotor in BrakeRotor.List)
                {
                    parts.Add(brakeRotor + lod);
                }

                foreach (var brake in Brakes.List)
                {
                    parts.Add(brake + lod);
                }

                foreach (var plate in Plates.List)
                {
                    parts.Add(plate + lod);
                }

                foreach (var seat in Seat.List)
                {
                    parts.Add(seat + lod);
                }
            }

            foreach (var wheel in Wheels.List)
            {
                foreach (var lod in Lods.List)
                {
                    parts.Add(wheel + "_KIT00_WHEEL_TIRE_FRONT" + lod);
                    parts.Add(wheel + "_KIT00_WHEEL_TIRE_REAR" + lod);
                }
                parts.Add(wheel + "_00_KIT00_WHEEL");
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
                }
            }

            return parts;
        }
    }
}
