using NFSRaider.Enums;
using NFSRaider.Helpers;
using NFSRaider.Keys.MainKeys.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.CarsVinyls
{
    public class BuildCarsVinyls : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var carsVinyls = new HashSet<string>();
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            (string file, Game matchedFlag)[] filteredFiles;

            if (gameFilter != null)
                filteredFiles = FilterPerGame(files, gameFilter.Value).ToArray();
            else
                filteredFiles = FilterPerGame(files, (Game)int.MaxValue).ToArray();

            var sharedFiles = filteredFiles.Where(f => f.matchedFlag == Game.Shared).ToArray();
            var groups = filteredFiles.GroupBy(f => f.matchedFlag);
            var missingGroups = Enum.GetValues(typeof(Game)).Cast<Game>().Except(groups.Select(g => g.Key)).DefaultIfEmpty((Game)0).Aggregate((acc, g) => acc | g);

            foreach (var group in groups)
            {
                if (gameFilter != null && group.Key == Game.Shared && gameFilter != Game.Shared)
                    continue;

                var filter = group.Key == Game.Shared
                    ? missingGroups
                    : group.Key;

                var filesToProcess = group.Select(f => f.file).Concat(sharedFiles.Select(f => f.file));

                var carList = new HashSet<string>(new BuildCars().GetKeys(filter));
                var vinyls = new HashSet<string>(FileRead.ReadFiles(filesToProcess));

                foreach (var car in carList)
                {
                    foreach (var vinyl in vinyls)
                        carsVinyls.Add(car + vinyl);
                }
            }

            return carsVinyls;
        }
    }
}
