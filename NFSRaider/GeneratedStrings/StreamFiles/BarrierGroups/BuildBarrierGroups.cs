﻿using System.Collections.Generic;

namespace NFSRaider.GeneratedStrings.StreamFiles.BarrierGroups
{
    public class BuildBarrierGroups
    {
        public HashSet<string> GetAllSceneryBarrierGroups()
        {
            var sceneryBarrierGroups = new HashSet<string>(Underground2.List);

            return sceneryBarrierGroups;
        }
    }
}
