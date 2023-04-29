using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.FEng
{
    public class BuildFEng : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var fngs = new HashSet<string>(FileRead.ReadFiles(files));

            fngs.UnionWith(new HashSet<string>(fngs.Select(c => c.ToUpperInvariant())));

            return fngs;
        }
    }
}
