using NFSRaider.Keys.MainKeys.Cars;
using NFSRaider.Keys.MainKeys.PartsLists.Carbon;
using NFSRaider.Keys.MainKeys.PartsLists.MostWanted;
using NFSRaider.Keys.MainKeys.PartsLists.ProStreet;
using NFSRaider.Keys.MainKeys.PartsLists.Undercover;
using NFSRaider.Keys.MainKeys.PartsLists.UndercoverCG;
using NFSRaider.Keys.MainKeys.PartsLists.Underground1;
using NFSRaider.Keys.MainKeys.PartsLists.Underground2;
using NFSRaider.Keys.MainKeys.PartsLists.World;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Keys.MainKeys.PartsLists
{
    public class BuildPartsList
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys());

        public HashSet<string> GetAllParts()
        {
            var parts = new HashSet<string>(
                new BuildUnderground1PartsList().GetAllUnderground1Parts()
                .Concat(new BuildUnderground2PartsList().GetAllUnderground2Parts())
                .Concat(new BuildMostWantedPartsList().GetAllMostWantedParts())
                .Concat(new BuildCarbonPartsList().GetAllCarbonParts())
                .Concat(new BuildProStreetPartsList().GetAllProStreetParts())
                .Concat(new BuildUndercoverCGPartsList().GetAllUndercoverCGParts())
                .Concat(new BuildUndercoverPartsList().GetAllUndercoverParts())
                .Concat(new BuildWorldPartsList().GetAllWorldParts())
                );

            foreach (var lod in Lods.List)
            {
                foreach (var car in CarList)
                {
                    parts.Add(car + lod);
                    foreach (var part in Parts.List)
                    {
                        parts.Add(car + part + lod);
                    }
                }
            }

            return parts;
        }
    }
}
