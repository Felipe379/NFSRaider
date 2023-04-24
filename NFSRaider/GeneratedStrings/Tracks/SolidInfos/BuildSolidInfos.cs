using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.SolidInfos
{
    public class BuildSolidInfos
    {
        public HashSet<string> GetAllSolidInfos()
        {
            var solidInfos = new HashSet<string>(
                Underground2.List
                .Concat(Carbon.List)
                .Concat(World.List)
                .Concat(SolidNames.List)
                );

            return solidInfos;
        }
    }
}
