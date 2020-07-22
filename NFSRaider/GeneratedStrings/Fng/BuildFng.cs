using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Fng
{
    public class BuildFng
    {
        public HashSet<string> GetAllFng()
        {
            var fngs = new HashSet<string>(
                Underground2.List
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                );

            return fngs;
        }
    }
}
