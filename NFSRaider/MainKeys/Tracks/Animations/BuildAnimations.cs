using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.Animations
{
    public class BuildAnimations : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var animations = new HashSet<string>(FileRead.ReadFiles(files));

            return animations;
        }
    }
}
