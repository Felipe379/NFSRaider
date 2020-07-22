using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Presets
{
    public class BuildPresets
    {
        public HashSet<string> GetAllPresets()
        {
            var presets = new HashSet<string>(
                Underground2.List
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(CarbonArcade.List)
                .Concat(UndercoverOldGen.List)
                );

            return presets;
        }
    }
}
