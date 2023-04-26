using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.Fng
{
    public class BuildFng : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var fngs = new HashSet<string>(FileRead.ReadFiles(files));

            fngs.UnionWith(new HashSet<string>(fngs.Select(c => c.ToUpperInvariant())));

            return fngs;
        }
    }
}
