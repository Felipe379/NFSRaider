using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.AcidEffects
{
    public class BuildAcidEffects
    {
        public HashSet<string> GetAllAcidEffects()
        {
            var acidEffects = new HashSet<string>(Underground2.List
                .Concat(Underground2.ListEmitterNames)
                .Concat(Underground2.ListSpecialEffects)
                );

            return acidEffects;
        }
    }
}
