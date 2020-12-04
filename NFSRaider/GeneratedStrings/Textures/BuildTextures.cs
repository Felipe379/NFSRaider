using NFSRaider.GeneratedStrings.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Textures
{
    public class BuildTextures
    {
        public HashSet<string> GetAllTextures()
        {
            var textures = new HashSet<string>(
                Underground1.GenericTextures.List
                .Concat(Underground2.GenericTextures.List)
                .Concat(MostWanted.GenericTextures.List)
                .Concat(Carbon.GenericTextures.List)
                .Concat(ProStreet.GenericTextures.List)
                .Concat(Shared.Typos.List)
                );

            foreach (var car in Cars.List)
            {
                foreach (var carTexture in Shared.Cars.List)
                {
                    textures.Add(car + carTexture);
                }

                foreach (var vinyl in Underground1.Vinyls.List)
                {
                    textures.Add(car + vinyl);
                }

                foreach (var vinyl in Underground2.Vinyls.List)
                {
                    textures.Add(car + vinyl);
                }

                foreach (var vinyl in MostWanted.Vinyls.List)
                {
                    textures.Add(car + vinyl);
                }

                foreach (var vinyl in Carbon.Vinyls.List)
                {
                    textures.Add(car + vinyl);
                }
            }

            return textures;
        }
    }
}
