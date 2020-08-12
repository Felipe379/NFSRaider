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
                );

            var languageLabelsCount = languageLabels.Count();

            for (int i = 0; i < languageLabelsCount; i++)
            {
                languageLabels.Add(languageLabels.ElementAt(i).ToUpperInvariant());
            }

            return languageLabels;
        }
    }
}
