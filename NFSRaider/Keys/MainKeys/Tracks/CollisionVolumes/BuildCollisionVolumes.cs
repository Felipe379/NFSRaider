using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Tracks.CollisionVolumes
{
    public class BuildCollisionVolumes : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var files = GetDirectoryFiles(GetDirectory(GetType()));
            var collisionVolumes = new HashSet<string>(FileRead.ReadFiles(files));

            return collisionVolumes;
        }
    }
}
