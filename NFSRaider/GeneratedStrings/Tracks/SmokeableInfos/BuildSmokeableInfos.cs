using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.Tracks.SmokeableInfos
{
    public class BuildSmokeableInfos
    {
        public HashSet<string> GetAllSmokeableInfos()
        {
            var smokeableInfos = new HashSet<string>(Underground2.List);

            return smokeableInfos;
        }
    }
}
