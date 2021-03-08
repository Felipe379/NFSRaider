using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.AcidEmitters
{
    public class BuildAcidEmitters
    {
        public HashSet<string> GetAllAcidEmitters()
        {
            var acidEmitters = new HashSet<string>(Underground2.List);

            return acidEmitters;
        }
    }
}
