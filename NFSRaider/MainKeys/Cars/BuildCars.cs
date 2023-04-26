using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NFSRaider.MainKeys.Cars
{
    public class BuildCars : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());

            if (gameFilter != null)
                files = files.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith(gameFilter.ToString())).ToArray();

            var cars = new HashSet<string>(FileRead.ReadFiles(files));

            return cars;
        }
    }
}
