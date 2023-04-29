using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Tracks.SolidInfos
{
    public class BuildSolidInfos : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var solidInfos = new HashSet<string>(FileRead.ReadFiles(files));

            return solidInfos;
        }
    }
}
