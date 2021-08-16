using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.SceneryGroups
{
    public class BuildSceneryGroups
    {
        public HashSet<string> GetAllSceneryGroups()
        {
            var sceneryGroups = new HashSet<string>(
                MostWanted.List
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(World.List)
                );

            return sceneryGroups;
        }
    }
}
