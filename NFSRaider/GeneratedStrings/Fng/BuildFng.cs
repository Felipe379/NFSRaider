using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Fng
{
    public class BuildFng
    {
        public HashSet<string> GetAllFng()
        {
            var fngs = new HashSet<string>(
                Underground1.ListPrelease
                .Concat(Underground1.List)
                .Concat(Underground2.ListPrelease)
                .Concat(Underground2.List)
                .Concat(MostWanted.ListPrelease)
                .Concat(MostWanted.List)
                .Concat(Carbon.ListPrelease)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(UndercoverOldGen.List)
                .Concat(Undercover.List)
                );

            fngs.UnionWith(new HashSet<string>(fngs.Select(c => c.ToUpperInvariant())));

            return fngs;
        }
    }
}
