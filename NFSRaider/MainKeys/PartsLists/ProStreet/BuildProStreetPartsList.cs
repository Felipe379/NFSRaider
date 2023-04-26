using NFSRaider.Enums;
using NFSRaider.MainKeys.Cars;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.PartsLists.ProStreet
{
    public class BuildProStreetPartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.ProStreet));
        public HashSet<string> GetAllProStreetParts()
        {
            var parts = new HashSet<string>(
                BrakeRotor.List
                .Concat(Brakes.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Exhausts.List)
                .Concat(Paints.List)
                .Concat(PaintGroups.List)
                .Concat(PaintSwatch.List)
                .Concat(Plates.List)
                .Concat(RoofScoop.List)
                .Concat(SpoilersType.List)
                .Concat(Seat.List)
                .Concat(Wheels.List)
                .Concat(Vinyls.List)
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

                foreach (var exhaust in Exhausts.List)
                {
                    parts.Add(exhaust + lod);
                }

                foreach (var plate in Plates.List)
                {
                    parts.Add(plate + lod);
                }

                foreach (var roofscoop in RoofScoop.List)
                {
                    parts.Add(roofscoop + lod);
                }

                foreach (var seat in Seat.List)
                {
                    parts.Add(seat + lod);
                }

                foreach (var wheel in Wheels.List)
                {
                    parts.Add(wheel + "_TIRE_FRONT" + lod);
                    parts.Add(wheel + "_TIRE_REAR" + lod);
                    parts.Add(wheel + "_WHEEL");
                }
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
