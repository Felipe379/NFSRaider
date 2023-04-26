using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.CarsSlotTypes
{
    public class BuildCarsSlotTypes : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var carsSlotTypes = new HashSet<string>(FileRead.ReadFiles(files));

            return carsSlotTypes;
        }
    }
}
