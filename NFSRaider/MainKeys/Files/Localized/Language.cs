using System.Collections.Generic;

namespace NFSRaider.MainKeys.Files.Localized
{
    public class Language
    {
        public IEnumerable<string> EnglishName { get; set; }
        public IEnumerable<string> ThreeLettersCode { get; set; }
        public IEnumerable<string> TwoLettersCode { get; set; }
    }
}
