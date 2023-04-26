using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.GCareers
{
    public class BuildGCareers : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var gCareers = new HashSet<string>(FileRead.ReadFiles(files));

            return gCareers;
        }
    }
}
