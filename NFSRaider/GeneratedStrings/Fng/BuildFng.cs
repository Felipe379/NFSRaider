using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Materials
{
    public class BuildFng
    {
        public HashSet<string> GetAllFng()
        {
            var fngs = new HashSet<string>(
                MostWanted.List
                .Concat(Carbon.List)
                );

            return fngs;
        }
    }
}
