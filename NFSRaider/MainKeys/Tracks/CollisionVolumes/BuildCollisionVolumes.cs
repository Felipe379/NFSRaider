using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.CollisionVolumes
{
    public class BuildCollisionVolumes : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var collisionVolumes = new HashSet<string>(FileRead.ReadFiles(files));

            return collisionVolumes;
        }
    }
}
