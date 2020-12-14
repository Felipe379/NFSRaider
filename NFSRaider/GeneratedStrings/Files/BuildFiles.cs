using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.Files
{
    public class BuildFiles
    {
        public HashSet<string> GetAllFiles()
        {
            var files = new HashSet<string>(Files.List);

            foreach (var language in Localized.Languages.List)
            {
                foreach (var file in Localized.Files.List)
                {
                    files.Add(file.Replace("(EnglishName)", language.EnglishName)
                                  .Replace("(ThreeLettersCode)", language.ThreeLettersCode)
                                  .Replace("(TwoLettersCode)", language.TwoLettersCode));
                }
            }

            foreach (var car in Shared.Cars.List)
            {
                foreach (var file in Cars.Files.List)
                {
                    files.Add(file.Replace("(Car)", car));
                }
            }

            return files;
        }
    }
}
