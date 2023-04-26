using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.VltList
{
    public class BuildVlt : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var vlt = new HashSet<string>(FileRead.ReadFiles(files));

            return vlt;
        }
    }
}
