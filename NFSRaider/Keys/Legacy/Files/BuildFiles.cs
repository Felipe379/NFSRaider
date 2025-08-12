using NFSRaider.Keys.Legacy.Files.Localized;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NFSRaider.Keys.Legacy.Files
{
    public class BuildFiles
    {
        private readonly HashSet<string> CarList = new HashSet<string>(new BuildCars().GetKeys());

        public HashSet<string> GetAllFiles()
        {
            var files = new HashSet<string>(Files.List);

            files.UnionWith(new HashSet<string>(Languages.List
                .SelectMany(languages => languages.EnglishName
                    .SelectMany(englishName => languages.ThreeLettersCode
                    .SelectMany(threeLettersCode => languages.TwoLettersCode
                    .SelectMany(twoLettersCode => Localized.Files.List
                    .Select(g => g.Replace("(EnglishName)", englishName).Replace("(ThreeLettersCode)", threeLettersCode).Replace("(TwoLettersCode)", twoLettersCode)
                    )))))
                ));

            files.UnionWith(new HashSet<string>(CarList
                .SelectMany(c => Cars.Files.List
                    .Select(d => d.Replace("(Car)", c)))
                ));

            files.UnionWith(new HashSet<string>(files.Select(f => Path.GetFileName(f))));

            return files;
        }
    }
}
