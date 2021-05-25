using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists.Underground1
{
    public class BuildUnderground1PartsList
    {
        public HashSet<string> GetAllUnderground1Parts()
        {
            var parts = new HashSet<string>(
                Brakes.List
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

            foreach (var lod in Lods.List)
            {
                foreach (var brake in Brakes.List)
                {
                    parts.Add(brake + lod);
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
