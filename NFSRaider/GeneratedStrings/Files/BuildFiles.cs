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
                .SelectMany(c => Localized.Files.List
                    .Select(d => d.Replace("(EnglishName)", c.EnglishName)
                    .Replace("(ThreeLettersCode)", c.ThreeLettersCode)
                    .Replace("(TwoLettersCode)", c.TwoLettersCode)))
                ));

            files.UnionWith(new HashSet<string>(Shared.Cars.List
                .SelectMany(c => Cars.Files.List
                    .Select(d => d.Replace("(Car)", c)))
                ));

            return files;
        }
    }
}
