using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Textures
{
    public class BuildTextures : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var textures = new HashSet<string>(FileRead.ReadFiles(files));

            return textures;
        }
    }
}
