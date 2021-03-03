using NFSRaider.GeneratedStrings.StreamFiles.AcidEffects;
using NFSRaider.GeneratedStrings.StreamFiles.AcidEmitters;
using NFSRaider.GeneratedStrings.StreamFiles.CollisionVolumes;
using NFSRaider.GeneratedStrings.StreamFiles.EAGLAnimations;
using NFSRaider.GeneratedStrings.StreamFiles.LightSourcesPack;
using NFSRaider.GeneratedStrings.StreamFiles.ParameterSets;
using NFSRaider.GeneratedStrings.StreamFiles.BarrierGroups;
using NFSRaider.GeneratedStrings.StreamFiles.SmokeableInfos;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.StreamFiles
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
