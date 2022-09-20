using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.CollisionVolumes
{
    public class BuildCollisionVolumes
    {
        public HashSet<string> GetAllCollisionVolumes()
        {
            var collisionVolumes = new HashSet<string>(
                Underground2.List
                .Concat(CollisionKeys.List)
                );

            return collisionVolumes;
        }
    }
}
