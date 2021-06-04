using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.LanguageLabels
{
    public class BuildLanguageLabels
    {
        public HashSet<string> GetAllLabels()
        {
            var languageLabels = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(Undercover.List)
                .Concat(UndercoverOldGen.List)
                .Concat(World.List)
                .Concat(World.ListAsian)
                .Concat(World.ListRemoved)
                );

            languageLabels.UnionWith(new HashSet<string>(languageLabels.Select(c => c.ToUpperInvariant())));

            return languageLabels;
        }
    }
}
