using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.Smokeable
{
    public class BuildSmokeable
    {
        public HashSet<string> GetAllSmokeable()
        {
            var smokeable = new HashSet<string>(Underground2.ListSmokeableCategory
                .Concat(Underground2.ListSmokeableInfos)
                .Concat(Underground2.ListSkidTypes)
                );

            return smokeable;
        }
    }
}
