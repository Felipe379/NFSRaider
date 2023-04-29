using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists.Undercover
{
    public class BuildUndercoverPartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.Undercover));
        public HashSet<string> GetAllUndercoverParts()
        {
            var parts = new HashSet<string>(
                BrakeRotor.List
                .Concat(Brakes.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(RoofScoop.List)
                .Concat(Seat.List)
                .Concat(SpoilersType.List)
                .Concat(Wheels.List)
                .Concat(Vinyls.List)
                .Concat(Vinyls.ListA161)
                .Concat(Vinyls.ListRemoved)
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
                    parts.Add(wheel + "_" + "KIT00_WHEEL_TIRE_FRONT" + lod);
                    parts.Add(wheel + "_" + "KIT00_WHEEL_TIRE_REAR" + lod);
                }
                parts.Add(wheel + "_" + "KIT00_WHEEL");
                parts.Add(wheel + "_" + "KIT00");
            }

            foreach (var spoiler in Spoilers.List)
            {
                foreach (var spoilerType in SpoilersType.List)
                {
                    parts.Add("SPOILER" + "_" + spoilerType);
                    parts.Add(spoiler + "_" + spoilerType);
                    foreach (var lod in Lods.List)
                    {
                        parts.Add(spoiler + "_" + spoilerType + lod);
                    }
                }
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
