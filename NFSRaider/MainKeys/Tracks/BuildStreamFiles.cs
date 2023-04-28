using NFSRaider.Enums;
using NFSRaider.MainKeys.Tracks.Animations;
using NFSRaider.MainKeys.Tracks.BarrierGroups;
using NFSRaider.MainKeys.Tracks.CollisionVolumes;
using NFSRaider.MainKeys.Tracks.EventTriggers;
using NFSRaider.MainKeys.Tracks.LightFlaresPack;
using NFSRaider.MainKeys.Tracks.LightSourcesPack;
using NFSRaider.MainKeys.Tracks.ParameterSets;
using NFSRaider.MainKeys.Tracks.PositionMarkers;
using NFSRaider.MainKeys.Tracks.SceneryGroups;
using NFSRaider.MainKeys.Tracks.Smokeable;
using NFSRaider.MainKeys.Tracks.SolidInfos;
using NFSRaider.MainKeys.Tracks.Textures;
using NFSRaider.MainKeys.Tracks.TroughBoundaries;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.MainKeys.Tracks
{
    public class BuildStreamFiles : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var streamFiles = new HashSet<string>(
                new BuildParameterSets().GetKeys(gameFilter)
                .Concat(new BuildPositionMarkers().GetKeys(gameFilter))
                .Concat(new BuildCollisionVolumes().GetKeys(gameFilter))
                .Concat(new BuildAnimations().GetKeys(gameFilter))
                .Concat(new BuildEventTriggers().GetKeys(gameFilter))
                .Concat(new BuildLightFlaresPack().GetKeys(gameFilter))
                .Concat(new BuildLightSourcesPack().GetKeys(gameFilter))
                .Concat(new BuildBarrierGroups().GetKeys(gameFilter))
                .Concat(new BuildSceneryGroups().GetKeys(gameFilter))
                .Concat(new BuildSolidInfos().GetKeys(gameFilter))
                .Concat(new BuildSmokeable().GetKeys(gameFilter))
                .Concat(new BuildTextures().GetKeys(gameFilter))
                .Concat(new BuildTroughBoundaries().GetKeys(gameFilter))
                );

            return streamFiles;
        }
    }
}
