using NFSRaider.GeneratedStrings.Cars;
using NFSRaider.GeneratedStrings.PartsLists.Carbon;
using NFSRaider.GeneratedStrings.PartsLists.MostWanted;
using NFSRaider.GeneratedStrings.PartsLists.ProStreet;
using NFSRaider.GeneratedStrings.PartsLists.Undercover;
using NFSRaider.GeneratedStrings.PartsLists.UndercoverOldGen;
using NFSRaider.GeneratedStrings.PartsLists.Underground1;
using NFSRaider.GeneratedStrings.PartsLists.Underground2;
using NFSRaider.GeneratedStrings.PartsLists.World;
using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PartsLists
{
    public class BuildPartsList
    {
        private static readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetAllCars());

        public HashSet<string> GetAllParts()
        {
            var parts = new HashSet<string>(
                new BuildUnderground1PartsList().GetAllUnderground1Parts()
                .Concat(new BuildUnderground2PartsList().GetAllUnderground2Parts())
                .Concat(new BuildMostWantedPartsList().GetAllMostWantedParts())
                .Concat(new BuildCarbonPartsList().GetAllCarbonParts())
                .Concat(new BuildProStreetPartsList().GetAllProStreetParts())
                .Concat(new BuildUndercoverOldGenPartsList().GetAllUndercoverOldGenParts())
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
