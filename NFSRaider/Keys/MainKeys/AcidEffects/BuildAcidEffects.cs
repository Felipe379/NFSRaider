using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.AcidEffects
{
    public class BuildAcidEffects : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var acidEffects = new HashSet<string>(FileRead.ReadFiles(files));

            return acidEffects;
        }
    }
}
