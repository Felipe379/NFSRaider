using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.CarsSlotTypes
{
    public class BuildCarsSlotTypes
    {
        public HashSet<string> GetAllCarsSlotTypes()
        {
            var carsSlotTypes = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(Carbon.ListArcade)
                .Concat(ProStreet.List)
                .Concat(UndercoverOldGen.List)
                .Concat(Undercover.List)
                );

            return carsSlotTypes;
        }
    }
}
