using NFSRaider.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace NFSRaider.Keys
{
    public abstract class Builder
    {
        public abstract HashSet<string> GetKeys(Game? gameFilter = null, CancellationToken cancellationToken = default);

        internal static string GetDirectory(Type builderClass)
        {
            var directory = builderClass.Namespace.Replace($"{Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.", string.Empty).Replace('.', '\\');

            return directory;
        }

        internal static string[] GetDirectoryFiles(string directory)
        {
            if (!Directory.Exists(directory))
            {
                return Array.Empty<string>();
            }

            var files = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);

            return files;
        }
    }
}
