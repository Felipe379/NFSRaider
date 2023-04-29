using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace NFSRaider.Keys.UserKeys
{
    public class BuildUserKeys : Builder
    {
        public override HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default)
        {
            var directory = GetDirectory(GetType());

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);

                return new HashSet<string>();
            }

            var files = GetDirectoryFiles(directory);

            var userKeys = new HashSet<string>(FileRead.ReadFiles(files));

            return userKeys;
        }
    }
}
