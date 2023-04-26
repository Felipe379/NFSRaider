using NFSRaider.Enums;
using NFSRaider.Helpers;
using System.Collections.Generic;

namespace NFSRaider.MainKeys.Materials
{
    public class BuildMaterials : Builder
    {
        public override HashSet<string> GetKeys(Game? gamefilter = null)
        {
            var files = GetDirectory(this.GetType());
            var materials = new HashSet<string>(FileRead.ReadFiles(files));

            return materials;
        }
    }
}
