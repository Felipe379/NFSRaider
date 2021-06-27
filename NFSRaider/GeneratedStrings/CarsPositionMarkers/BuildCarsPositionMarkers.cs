using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.CarsPositionMarkers
{
    public class BuildCarsPositionMarkers
    {
        public HashSet<string> GetAllCarsPositionMarkers()
        {
            var carsPositionMarkers = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(UndercoverOldGen.List)
                .Concat(Undercover.List)
                .Concat(World.List)
                );

            return carsPositionMarkers;
        }
    }
}
