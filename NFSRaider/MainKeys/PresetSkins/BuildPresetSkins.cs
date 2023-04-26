using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.PresetSkins
{
    public class BuildPresetSkins : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var presetSkins = new HashSet<string>(FileRead.ReadFiles(files));

            return presetSkins;
        }
    }
}
