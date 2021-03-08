using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.AcidEffects
{
    public class BuildAcidEffects
    {
        public HashSet<string> GetAllAcidEffects()
        {
            var acidEffects = new HashSet<string>(Underground2.List);

            return acidEffects;
        }
    }
}
