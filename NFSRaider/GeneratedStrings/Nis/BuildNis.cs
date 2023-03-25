using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Nis
{
    public class BuildNis
    {
        public HashSet<string> GetAllNis()
        {
            var nis = new HashSet<string>(
                HotPursuit2.List.Concat(HotPursuit2.ListCut)
                .Concat(Underground2.List)
                .Concat(MostWanted.List).Concat(MostWanted.ListCut)
                .Concat(Carbon.List).Concat(Carbon.ListCut)
                .Concat(ProStreet.List).Concat(ProStreet.ListCut)
                .Concat(UndercoverOldGen.List).Concat(UndercoverOldGen.ListCut)
                .Concat(Undercover.List).Concat(Undercover.ListCut)
                .Concat(World.ListCut)
                );

            return nis;
        }
    }
}
