﻿using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.CarsPositionMarkers
{
    public class BuildCarsPositionMarkers : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var carsPositionMarkers = new HashSet<string>(FileRead.ReadFiles(files));

            return carsPositionMarkers;
        }
    }
}
