using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.PresetSkins
{
    public class BuildPresetSkins
    {
        public HashSet<string> GetAllPresetSkins()
        {
            var presetSkins = new HashSet<string>(
                Carbon.List
                .Concat(UndercoverOldGen.List)
                );

            return presetSkins;
        }
    }
}
