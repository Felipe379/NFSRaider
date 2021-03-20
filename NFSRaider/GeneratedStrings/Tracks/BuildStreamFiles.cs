using NFSRaider.GeneratedStrings.Tracks.CollisionVolumes;
using NFSRaider.GeneratedStrings.Tracks.EAGLAnimations;
using NFSRaider.GeneratedStrings.Tracks.LightSourcesPack;
using NFSRaider.GeneratedStrings.Tracks.ParameterSets;
using NFSRaider.GeneratedStrings.Tracks.BarrierGroups;
using NFSRaider.GeneratedStrings.Tracks.Smokeable;
using System.Collections.Generic;
using System.Linq;
using NFSRaider.GeneratedStrings.Tracks.EventTriggers;

namespace NFSRaider.GeneratedStrings.Tracks
{
    public class BuildStreamFiles
    {
        public HashSet<string> GetAllStreamFiles()
        {
            var streamFiles = new HashSet<string>(
                new BuildParameterSets().GetAllParameterSets()
                .Concat(new BuildCollisionVolumes().GetAllCollisionVolumes())
                .Concat(new BuildEAGLAnimations().GetAllEAGLAnimations())
                .Concat(new BuildEventTriggers().GetAllEventTriggers())
                .Concat(new BuildLightSourcesPack().GetAllLightSourcesPack())
                .Concat(new BuildBarrierGroups().GetAllSceneryBarrierGroups())
                .Concat(new BuildSmokeable().GetAllSmokeable())
                );

            return streamFiles;
        }
    }
}
