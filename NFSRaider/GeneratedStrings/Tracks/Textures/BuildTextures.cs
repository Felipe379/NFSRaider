using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.Textures
{
    public class BuildTextures
    {
        public HashSet<string> GetAllTextures()
        {
            var textures = new HashSet<string>(
                Underground1.List
                .Concat(Underground2.List)
                .Concat(MostWanted.List)
                .Concat(Carbon.List)
                .Concat(ProStreet.List)
                .Concat(Undercover.List)
                .Concat(World.List)
                );

            return textures;
        }
    }
}
