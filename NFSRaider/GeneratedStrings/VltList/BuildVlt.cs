using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.VltList
{
    public class BuildVlt
    {
        public HashSet<string> GetAllVlt()
        {
            var vlt = new HashSet<string>(Vlt.List);

            return vlt;
        }
    }
}
