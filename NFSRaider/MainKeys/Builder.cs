using NFSRaider.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NFSRaider.MainKeys
{
    public abstract class Builder
    {
        public abstract HashSet<string> GetKeys(Game? gameFilter = null);
        internal static string[] GetDirectory(Type builderClass)
        {
            var directory = builderClass.Namespace.Replace($"{Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.", string.Empty).Replace('.', '\\');

            if (!Directory.Exists(directory))
            {
                return Array.Empty<string>();
            }

            var files = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);

            return files;
        }
    }
}
