using NFSRaider.MainKeys.Tracks.BarrierGroups;
using NFSRaider.MainKeys.Tracks.CollisionVolumes;
using NFSRaider.MainKeys.Tracks.EAGLAnimations;
using NFSRaider.MainKeys.Tracks.EventTriggers;
using NFSRaider.MainKeys.Tracks.LightFlaresPack;
using NFSRaider.MainKeys.Tracks.LightSourcesPack;
using NFSRaider.MainKeys.Tracks.ParameterSets;
using NFSRaider.MainKeys.Tracks.PositionMarkers;
using NFSRaider.MainKeys.Tracks.SceneryGroups;
using NFSRaider.MainKeys.Tracks.Smokeable;
using NFSRaider.MainKeys.Tracks.SolidInfos;
using NFSRaider.MainKeys.Tracks.Textures;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.Tracks
{
    public class BuildStreamFiles
    {
        public HashSet<string> GetAllStreamFiles()
        {
            var streamFiles = new HashSet<string>(
                new BuildParameterSets().GetKeys()
                .Concat(new BuildPositionMarkers().GetKeys())
                .Concat(new BuildCollisionVolumes().GetKeys())
                .Concat(new BuildEAGLAnimations().GetKeys())
                .Concat(new BuildEventTriggers().GetKeys())
                .Concat(new BuildLightFlaresPack().GetKeys())
                .Concat(new BuildLightSourcesPack().GetKeys())
                .Concat(new BuildBarrierGroups().GetKeys())
                .Concat(new BuildSceneryGroups().GetKeys())
                .Concat(new BuildSolidInfos().GetKeys())
                .Concat(new BuildSmokeable().GetKeys())
                .Concat(new BuildTextures().GetKeys())
                );

            return streamFiles;
        }
    }
}
