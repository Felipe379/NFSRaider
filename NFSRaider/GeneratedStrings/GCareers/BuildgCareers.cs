using NFSRaider.GeneratedStrings.GCareers.Underground2;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.GCareers
{
    public class BuildGCareers
    {
        public HashSet<string> GetAllGCarrers()
        {
            var gCareers = new HashSet<string>(
                new BuildUnderground2GCareers().GetAllUnderground2GCareers());

            return gCareers;
        }
    }
}
