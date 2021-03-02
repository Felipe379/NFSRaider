using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Presets
{
    public class BuildPresets
    {
        public HashSet<string> GetAllPresets()
        {
            var presets = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(MostWanted.ListPrerelease)
                .Concat(Carbon.List)
                .Concat(Carbon.ListPrerelease)
                .Concat(CarbonArcade.List)
                .Concat(UndercoverOldGen.List)
                );

            return presets;
        }
    }
}
