using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.Tracks.SolidInfos
{
    public class BuildSolidInfos : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var solidInfos = new HashSet<string>(FileRead.ReadFiles(files));

            return solidInfos;
        }
    }
}
