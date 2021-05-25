using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.GCareers.Underground2
{
    public class BuildUnderground2GCareers
    {
        public HashSet<string> GetAllUnderground2GCareers()
        {
            var gCareers = new HashSet<string>(
                BankTriggers.List
                .Concat(PartPerformances.List)
                );

            return gCareers;
        }
    }
}
