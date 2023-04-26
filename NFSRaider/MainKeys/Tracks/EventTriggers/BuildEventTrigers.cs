using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Tracks.EventTriggers
{
    public class BuildEventTriggers : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null)
        {
            var files = GetDirectory(this.GetType());
            var eventTriggers = new HashSet<string>(FileRead.ReadFiles(files));

            return eventTriggers;
        }
    }
}
