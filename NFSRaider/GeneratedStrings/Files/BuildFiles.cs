using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.Files
{
    public class BuildFiles
    {
        public HashSet<string> GetAllFiles()
        {
            var files = new HashSet<string>(Files.List);

            return files;
        }
    }
}
