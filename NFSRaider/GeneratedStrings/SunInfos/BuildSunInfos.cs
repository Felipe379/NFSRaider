using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.SunInfos
{
    public class BuildSunInfos
    {
        public HashSet<string> GetSunInfos()
        {
            var sunInfos = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(UndercoverOldGen.List)
                .Concat(Undercover.List)
                .Concat(World.List)
                );

            return sunInfos;
        }
    }
}
