using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.EAGLAnimations
{
    public class BuildEAGLAnimations : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var eaglAnimations = new HashSet<string>(FileRead.ReadFiles(files));

            return eaglAnimations;
        }
    }
}
