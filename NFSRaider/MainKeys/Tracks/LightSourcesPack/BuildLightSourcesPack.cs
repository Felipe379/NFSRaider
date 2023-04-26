using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.LightSourcesPack
{
    public class BuildLightSourcesPack : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var lightSourcesPack = new HashSet<string>(FileRead.ReadFiles(files));

            return lightSourcesPack;
        }
    }
}
