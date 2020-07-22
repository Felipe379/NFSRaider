using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Brands
{
    public class BuildBrands
    {
        public HashSet<string> GetAllBrands()
        {
            var brands = new HashSet<string>(
                HotPursuit2.List
                .Concat(Underground1.List)
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(World.List)
                );

            return brands;
        }
    }
}
