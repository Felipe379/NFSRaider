using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.StreamFiles.SolidInfos
{
    public class BuildSolidInfos
    {
        public HashSet<string> GetAllSolidInfos()
        {
            var solidInfos = new HashSet<string>(Underground2.List);

            return solidInfos;
        }
    }
}
