using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.LightFlaresPack
{
    public class BuildLightFlaresPack : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var lightFlaresPack = new HashSet<string>(FileRead.ReadFiles(files));

            return lightFlaresPack;
        }
    }
}
