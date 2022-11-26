using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Cars
{
    public class BuildCars
    {
        public HashSet<string> GetAllCars()
        {
            var cars = new HashSet<string>(
                HotPursuit2.List
                .Concat(Underground1.List).Concat(Underground1.ListCut).Concat(Underground1.ListLeftovers)
                .Concat(Underground2.List).Concat(Underground2.ListCut)
                .Concat(MostWanted.List).Concat(MostWanted.ListCut)
                .Concat(Carbon.List).Concat(Carbon.ListCut).Concat(Carbon.ListLeftovers).Concat(Carbon.ListWtf)
                .Concat(ProStreet.List).Concat(ProStreet.ListCut)
                .Concat(UndercoverOldGen.List).Concat(UndercoverOldGen.ListCut).Concat(UndercoverOldGen.ListLeftovers)
                .Concat(Undercover.List).Concat(Undercover.ListCut)
                .Concat(World.List).Concat(World.ListCut).Concat(World.ListLeftovers)
                );

            return cars;
        }
    }
}
