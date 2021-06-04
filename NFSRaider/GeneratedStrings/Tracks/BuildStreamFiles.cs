using NFSRaider.GeneratedStrings.Tracks.BarrierGroups;
using NFSRaider.GeneratedStrings.Tracks.CollisionVolumes;
using NFSRaider.GeneratedStrings.Tracks.EAGLAnimations;
using NFSRaider.GeneratedStrings.Tracks.EventTriggers;
using NFSRaider.GeneratedStrings.Tracks.LightFlaresPack;
using NFSRaider.GeneratedStrings.Tracks.LightSourcesPack;
using NFSRaider.GeneratedStrings.Tracks.ParameterSets;
using NFSRaider.GeneratedStrings.Tracks.PositionMarkers;
using NFSRaider.GeneratedStrings.Tracks.Smokeable;
using NFSRaider.GeneratedStrings.Tracks.SolidInfos;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks
{
    public class BuildStreamFiles
    {
        public HashSet<string> GetAllStreamFiles()
        {
            var streamFiles = new HashSet<string>(
                new BuildParameterSets().GetAllParameterSets()
                .Concat(new BuildPositionMarkers().GetAllBuildPositionMarkers())
                .Concat(new BuildCollisionVolumes().GetAllCollisionVolumes())
                .Concat(new BuildEAGLAnimations().GetAllEAGLAnimations())
                .Concat(new BuildEventTriggers().GetAllEventTriggers())
                .Concat(new BuildLightFlaresPack().GetAllLightFlaresPack())
                .Concat(new BuildLightSourcesPack().GetAllLightSourcesPack())
                .Concat(new BuildBarrierGroups().GetAllSceneryBarrierGroups())
                .Concat(new BuildSolidInfos().GetAllSolidInfos())
                .Concat(new BuildSmokeable().GetAllSmokeable())
                );

            return streamFiles;
        }
    }
}
