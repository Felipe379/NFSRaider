using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Files
{
    public class BuildFiles
    {
        public HashSet<string> GetAllFiles()
        {
            var files = new HashSet<string>(Files.List);

            files.UnionWith(new HashSet<string>(Localized.Languages.List
                .SelectMany(languages => languages.EnglishName
                    .SelectMany(englishName => languages.ThreeLettersCode
                    .SelectMany(threeLettersCode => languages.TwoLettersCode
                    .SelectMany(twoLettersCode => Localized.Files.List
                    .Select(g => g.Replace("(EnglishName)", englishName).Replace("(ThreeLettersCode)", threeLettersCode).Replace("(TwoLettersCode)", twoLettersCode)
                    )))))
                ));

            files.UnionWith(new HashSet<string>(Shared.Cars.List
                .SelectMany(c => Cars.Files.List
                    .Select(d => d.Replace("(Car)", c)))
                ));

            return files;
        }
    }
}
