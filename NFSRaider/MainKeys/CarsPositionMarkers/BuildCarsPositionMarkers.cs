using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.CarsPositionMarkers
{
    public class BuildCarsPositionMarkers : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var carsPositionMarkers = new HashSet<string>(FileRead.ReadFiles(files));

            return carsPositionMarkers;
        }
    }
}
