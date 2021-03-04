using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.Tracks.CollisionVolumes
{
    public class BuildCollisionVolumes
    {
        public HashSet<string> GetAllCollisionVolumes()
        {
            var collisionVolumes = new HashSet<string>(Underground2.List);

            return collisionVolumes;
        }
    }
}
