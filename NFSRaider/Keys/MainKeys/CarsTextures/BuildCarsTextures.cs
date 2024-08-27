using NFSRaider.Enums;
using NFSRaider.Helpers;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.CarsTextures
{
    public class BuildCarsTextures : Builder
    {
        private readonly HashSet<string> CarListAll = new HashSet<string>(new BuildCars().GetKeys());
        private readonly HashSet<string> CarListMostWanted = new HashSet<string>(new BuildCars().GetKeys(Game.MostWanted));
        private readonly HashSet<string> CarListCarbon = new HashSet<string>(new BuildCars().GetKeys(Game.Carbon));
        private readonly HashSet<string> CarListUnderground1 = new HashSet<string>(new BuildCars().GetKeys(Game.Underground1));
        private readonly HashSet<string> CarListUnderground2 = new HashSet<string>(new BuildCars().GetKeys(Game.Underground2));

        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var carsTextures = new HashSet<string>();

            var universal = files.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith("Universal")).ToArray();
            var vinyls = files.Where(f => Path.GetFileNameWithoutExtension(f).Contains("Vinyls")).ToArray();

            var universalCarsTextures = new HashSet<string>(FileRead.ReadFiles(universal));
            var vinylsUnderground1 = new HashSet<string>(FileRead.ReadFiles(vinyls.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith("Underground1"))));
            var vinylsUnderground2 = new HashSet<string>(FileRead.ReadFiles(vinyls.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith("Underground2"))));
            var vinylsMostWanted = new HashSet<string>(FileRead.ReadFiles(vinyls.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith("MostWanted"))));
            var vinylsCarbon = new HashSet<string>(FileRead.ReadFiles(vinyls.Where(f => Path.GetFileNameWithoutExtension(f).StartsWith("Carbon"))));

            foreach (var car in CarListAll)
            {
                foreach (var texture in universalCarsTextures)
                    carsTextures.Add(car + texture);
            }

            foreach (var car in CarListUnderground1)
            {
                foreach (var vinyl in vinylsUnderground1)
                    carsTextures.Add(car + vinyl);
            }

            foreach (var car in CarListUnderground2)
            {
                foreach (var vinyl in vinylsUnderground2)
                    carsTextures.Add(car + vinyl);
            }

            foreach (var car in CarListMostWanted)
            {
                foreach (var vinyl in vinylsMostWanted)
                    carsTextures.Add(car + vinyl);
            }

            foreach (var car in CarListCarbon)
            {
                foreach (var vinyl in vinylsCarbon)
                    carsTextures.Add(car + vinyl);
            }

            return carsTextures;
        }
    }
}
