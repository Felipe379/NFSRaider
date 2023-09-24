using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists.Underground1
{
    public class BuildUnderground1PartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.Underground1));
        public HashSet<string> GetAllUnderground1Parts()
        {
            var parts = new HashSet<string>(
                Brakes.List
                .Concat(BrandLabels.List)
                .Concat(ConcatenatedStrings.List)
                .Concat(Decals.List)
                .Concat(Exhausts.List)
                .Concat(Neons.List)
                .Concat(Paints.List)
                .Concat(Plates.List)
                .Concat(Vinyls.List)
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

                //NOTE: Yes, whitespace
                foreach (var partAttributes in PartsAttributes.ListTraffic)
                {
                    parts.Add(car + " " + partAttributes);
                }

                foreach (var lod in Lods.List)
                {
                    foreach (var part in Parts.List.Concat(Parts.ListTraffic))
                    {
                        parts.Add(car + "_" + part + "_" + lod);
                    }
                }
            }

            return parts;
        }
    }
}
