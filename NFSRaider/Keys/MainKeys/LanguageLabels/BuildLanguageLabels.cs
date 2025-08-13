using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.LanguageLabels
{
    public class BuildLanguageLabels : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));

            if (gameFilter != null)
                files = FilterPerGame(files, gameFilter.Value).Select(d => d.file).ToArray();

            var languageLabels = new HashSet<string>(FileRead.ReadFiles(files));

            languageLabels.UnionWith(new HashSet<string>(languageLabels.Select(c => c.ToUpperInvariant())));

            return languageLabels;
        }
    }
}
