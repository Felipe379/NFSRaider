using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.CarsPartGroups
{
    public class BuildCarsPartGroups
    {
        public HashSet<string> GetAllCarsPartGroups()
        {
            var carsPartGroups = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(Carbon.ListArcade)
                .Concat(ProStreet.List)
                .Concat(UndercoverOldGen.List)
                .Concat(Undercover.List)
                .Concat(World.List)
                );

            return carsPartGroups;
        }
    }
}
