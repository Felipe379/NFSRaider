using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.CarsPartGroups
{
    public class BuildCarsPartGroups : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var carsPartGroups = new HashSet<string>(FileRead.ReadFiles(files));

            return carsPartGroups;
        }
    }
}
