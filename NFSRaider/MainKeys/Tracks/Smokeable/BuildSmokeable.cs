using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.Smokeable
{
    public class BuildSmokeable : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var smokeable = new HashSet<string>(FileRead.ReadFiles(files));

            return smokeable;
        }
    }
}
