using NFSRaider.GeneratedStrings.StreamFiles.ParameterSets;
using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.StreamFiles
{
    public class BuildStreamFiles
    {
        public HashSet<string> GetAllStreamFiles()
        {
            var streamFiles = new HashSet<string>(new BuildParameterSets().GetAllParameterSets());

            return streamFiles;
        }
    }
}
