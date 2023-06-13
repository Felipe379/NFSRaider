using NFSRaider.Enums;
using NFSRaider.Keys.Legacy.Files;
using NFSRaider.Keys.Legacy.PartsList;
using System.Collections.Generic;
using System.Threading;

namespace NFSRaider.Keys.UserKeys
{
    public class BuildLegacyKeys : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var legacyKeys = new HashSet<string>();

            legacyKeys.UnionWith(new BuildFiles().GetAllFiles());
            legacyKeys.UnionWith(new BuildPartsList().GetAllParts());

            return legacyKeys;
        }
    }
}
