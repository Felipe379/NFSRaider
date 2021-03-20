using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.GeneratedStrings.Tracks.EventTriggers
{
    public class BuildEventTriggers
    {
        public HashSet<string> GetAllEventTriggers()
        {
            var eventTriggers = new HashSet<string>(Underground2.ListParameterKeys);

            return eventTriggers;
        }
    }
}
