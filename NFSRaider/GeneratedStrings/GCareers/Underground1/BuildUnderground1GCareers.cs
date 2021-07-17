using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.GCareers.Underground1
{
    public class BuildUnderground1GCareers
    {
        public HashSet<string> GetAllUnderground1GCareers()
        {
            var gCareers = new HashSet<string>(
                Magazine.List
                );

            return gCareers;
        }
    }
}
