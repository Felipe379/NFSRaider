using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Tracks.PositionMarkers
{
    public class BuildPositionMarkers : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var positionMarkers = new HashSet<string>(FileRead.ReadFiles(files));

            return positionMarkers;
        }
    }
}
