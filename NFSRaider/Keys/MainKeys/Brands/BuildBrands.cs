using NFSRaider.Enums;
using System.Collections.Generic;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Brands
{
    public class BuildBrands : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var brands = new HashSet<string>(files);

            return brands;
        }
    }
}
