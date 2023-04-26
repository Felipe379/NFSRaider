using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.SceneryGroups
{
    public class BuildSceneryGroups : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var sceneryGroups = new HashSet<string>(FileRead.ReadFiles(files));

            return sceneryGroups;
        }
    }
}
