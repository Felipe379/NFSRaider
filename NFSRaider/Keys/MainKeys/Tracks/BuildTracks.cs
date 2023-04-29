using NFSRaider.Enums;
using NFSRaider.Keys.MainKeys.Tracks.Animations;
using NFSRaider.Keys.MainKeys.Tracks.BarrierGroups;
using NFSRaider.Keys.MainKeys.Tracks.CollisionVolumes;
using NFSRaider.Keys.MainKeys.Tracks.EventTriggers;
using NFSRaider.Keys.MainKeys.Tracks.LightFlaresPack;
using NFSRaider.Keys.MainKeys.Tracks.LightSourcesPack;
using NFSRaider.Keys.MainKeys.Tracks.ParameterSets;
using NFSRaider.Keys.MainKeys.Tracks.PositionMarkers;
using NFSRaider.Keys.MainKeys.Tracks.SceneryGroups;
using NFSRaider.Keys.MainKeys.Tracks.Smokeable;
using NFSRaider.Keys.MainKeys.Tracks.SolidInfos;
using NFSRaider.Keys.MainKeys.Tracks.Textures;
using NFSRaider.Keys.MainKeys.Tracks.TroughBoundaries;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Keys.MainKeys.Tracks
{
    public class BuildTracks : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var streamFiles = new HashSet<string>(
                new BuildParameterSets().GetKeys(gameFilter, cancellationToken)
                .Concat(new BuildPositionMarkers().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildCollisionVolumes().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildAnimations().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildEventTriggers().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildLightFlaresPack().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildLightSourcesPack().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildBarrierGroups().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildSceneryGroups().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildSolidInfos().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildSmokeable().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildTextures().GetKeys(gameFilter, cancellationToken))
                .Concat(new BuildTroughBoundaries().GetKeys(gameFilter, cancellationToken))
                );

            return streamFiles;
        }
    }
}
