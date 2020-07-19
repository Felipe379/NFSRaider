using System.Collections.Generic;
using System.Linq;

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
