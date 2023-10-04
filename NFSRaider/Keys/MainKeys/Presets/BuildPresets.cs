using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Presets
{
    public class BuildPresets : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var presets = new HashSet<string>(FileRead.ReadFiles(files));

            presets.UnionWith(new HashSet<string>(presets.Select(c => c.ToUpperInvariant())));

            return presets;
        }
    }
}
