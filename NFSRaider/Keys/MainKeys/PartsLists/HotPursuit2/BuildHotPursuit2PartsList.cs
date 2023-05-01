using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;

namespace NFSRaider.Keys.MainKeys.PartsLists.HotPursuit2
{
    public class BuildHotPursuit2PartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys(Game.HotPursuit2));
        public HashSet<string> GetAllHotPursuit2Parts()
        {
            var parts = new HashSet<string>(Parts.List);

            foreach (var lod in Lods.List)
            {
                foreach (var part in Parts.List)
                {
                    parts.Add(part + "_" + lod);
                }

                foreach (var car in CarList)
                {
                    parts.Add(car + "_" + lod);

                    foreach (var part in Parts.List)
                    {
                        parts.Add(car + "_" + part + "_" + lod);
                    }
                }
            }

            return parts;
        }
    }
}
