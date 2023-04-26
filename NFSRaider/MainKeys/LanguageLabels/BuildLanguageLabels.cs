using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.LanguageLabels
{
    public class BuildLanguageLabels : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var languageLabels = new HashSet<string>(FileRead.ReadFiles(files));

            languageLabels.UnionWith(new HashSet<string>(languageLabels.Select(c => c.ToUpperInvariant())));

            return languageLabels;
        }
    }
}
