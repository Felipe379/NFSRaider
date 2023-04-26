using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Presets
{
    public class BuildPresets : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var presets = new HashSet<string>(FileRead.ReadFiles(files));

            return presets;
        }
    }
}
