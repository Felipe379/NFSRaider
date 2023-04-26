using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.PositionMarkers
{
    public class BuildPositionMarkers : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var positionMarkers = new HashSet<string>(FileRead.ReadFiles(files));

            return positionMarkers;
        }
    }
}
