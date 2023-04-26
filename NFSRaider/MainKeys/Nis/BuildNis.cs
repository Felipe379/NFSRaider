using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Nis
{
    public class BuildNis : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var nis = new HashSet<string>(FileRead.ReadFiles(files));

            return nis;
        }
    }
}
