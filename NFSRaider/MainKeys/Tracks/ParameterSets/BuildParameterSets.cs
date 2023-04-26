using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.ParameterSets
{
    public class BuildParameterSets : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var parameterSets = new HashSet<string>(FileRead.ReadFiles(files));

            return parameterSets;
        }
    }
}
