using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.BarrierGroups
{
    public class BuildBarrierGroups
    {
        public HashSet<string> GetAllSceneryBarrierGroups()
        {
            var sceneryBarrierGroups = new HashSet<string>(
                Underground2.List
                .Concat(Carbon.List)
                .Concat(World.List)
                );

            return sceneryBarrierGroups;
        }
    }
}
