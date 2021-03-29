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
                .Concat(Underground1.List)
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(UndercoverOldGen.List)
                .Concat(Undercover.List)
                .Concat(World.List)
                );

            return cars;
        }
    }
}
