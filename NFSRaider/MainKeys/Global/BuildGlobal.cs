using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Global
{
    public class BuildGlobal : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var global = new HashSet<string>(FileRead.ReadFiles(files));

            return global;
        }
    }
}
