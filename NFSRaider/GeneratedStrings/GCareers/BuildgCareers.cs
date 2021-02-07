using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.GCareers
{
    public class BuildGCareers
    {
        public HashSet<string> GetAllGCarrers()
        {
            var gCareers = new HashSet<string>(
                Underground2.List);

            return gCareers;
        }
    }
}
