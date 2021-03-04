using NFSRaider.GeneratedStrings.Tracks.AcidEffects;
using NFSRaider.GeneratedStrings.Tracks.AcidEmitters;
using NFSRaider.GeneratedStrings.Tracks.CollisionVolumes;
using NFSRaider.GeneratedStrings.Tracks.EAGLAnimations;
using NFSRaider.GeneratedStrings.Tracks.LightSourcesPack;
using NFSRaider.GeneratedStrings.Tracks.ParameterSets;
using NFSRaider.GeneratedStrings.Tracks.BarrierGroups;
using NFSRaider.GeneratedStrings.Tracks.SmokeableInfos;
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
                .Concat(new BuildAcidEffects().GetAllAcidEffects())
                .Concat(new BuildAcidEmitters().GetAllAcidEmitters())
                .Concat(new BuildCollisionVolumes().GetAllCollisionVolumes())
                .Concat(new BuildEAGLAnimations().GetAllEAGLAnimations())
                .Concat(new BuildLightSourcesPack().GetAllLightSourcesPack())
                .Concat(new BuildBarrierGroups().GetAllSceneryBarrierGroups())
                .Concat(new BuildSmokeableInfos().GetAllSmokeableInfos())
                );

            return streamFiles;
        }
    }
}
