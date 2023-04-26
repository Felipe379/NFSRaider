using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.AcidEffects
{
    public class BuildAcidEffects : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var acidEffects = new HashSet<string>(FileRead.ReadFiles(files));

            return acidEffects;
        }
    }
}
