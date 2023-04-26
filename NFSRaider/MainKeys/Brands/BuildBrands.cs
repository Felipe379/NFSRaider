using NFSRaider.Enums;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Brands
{
    public class BuildBrands : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var brands = new HashSet<string>(files);

            return brands;
        }
    }
}
