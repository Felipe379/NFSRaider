using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Cars
{
    public class BuildCars : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));

            if (gameFilter != null)
                files = files.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith(gameFilter.ToString())).ToArray();

            var cars = new HashSet<string>(FileRead.ReadFiles(files));

            return cars;
        }
    }
}
