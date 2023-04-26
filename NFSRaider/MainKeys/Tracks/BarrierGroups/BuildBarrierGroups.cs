using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.BarrierGroups
{
    public class BuildBarrierGroups : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var sceneryBarrierGroups = new HashSet<string>(FileRead.ReadFiles(files));

            return sceneryBarrierGroups;
        }
    }
}
