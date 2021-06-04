using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.Tracks.PositionMarkers
{
    public class BuildPositionMarkers
    {
        public HashSet<string> GetAllBuildPositionMarkers()
        {
            var positionMarkers = new HashSet<string>(PositionMarkers.List);

            return positionMarkers;
        }
    }
}
