using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Materials
{
    public class BuildMaterials
    {
        public HashSet<string> GetAllMaterials()
        {
            var materials = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(World.List)
                .Concat(Typos.List)
                );

            return materials;
        }
    }
}
