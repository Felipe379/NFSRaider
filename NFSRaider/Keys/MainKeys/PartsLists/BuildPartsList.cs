using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Cars;
using NFSRaider.Keys.MainKeys.PartsLists.Carbon;
using NFSRaider.Keys.MainKeys.PartsLists.HotPursuit2;
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
        private readonly HashSet<string> CarList = new HashSet<string>(
            new BuildCars().GetKeys(Game.Carbon)
            .Concat(new BuildCars().GetKeys(Game.ProStreet))
            .Concat(new BuildCars().GetKeys(Game.UndercoverCG))
            .Concat(new BuildCars().GetKeys(Game.Undercover))
            );

        public HashSet<string> GetAllParts()
        {
            var allParts = new HashSet<string>(
                new BuildCarbonPartsList().GetAllCarbonParts()
                .Concat(new BuildProStreetPartsList().GetAllProStreetParts())
                .Concat(new BuildUndercoverCGPartsList().GetAllUndercoverCGParts())
                .Concat(new BuildUndercoverPartsList().GetAllUndercoverParts())
                );

            foreach (var lod in Lods.List)
            {
                foreach (var car in CarList)
                {
                    allParts.Add(car + lod);
                    foreach (var part in Parts.List)
                    {
                        allParts.Add(car + part + lod);
                    }
                }
            }

            var parts = new HashSet<string>(
                new BuildHotPursuit2PartsList().GetAllHotPursuit2Parts()
                .Concat(new BuildUnderground1PartsList().GetAllUnderground1Parts())
                .Concat(new BuildUnderground2PartsList().GetAllUnderground2Parts())
                .Concat(new BuildMostWantedPartsList().GetAllMostWantedParts())
                .Concat(new BuildWorldPartsList().GetAllWorldParts())
                );

            parts.UnionWith(allParts);

            return parts;
        }
    }
}
