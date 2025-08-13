using NFSRaider.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            if (!typeof(Builder).Namespace.StartsWith(Assembly.GetExecutingAssembly().GetName().Name))
            {
                var assemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "";
                var solutionDir = Path.GetFullPath(Path.Combine(assemblyDir, @"..\..\..\..\"));
                directory = solutionDir + directory;
            }

            if (!Directory.Exists(directory))
            {
                return Array.Empty<string>();
            }

            var files = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);

            return files;
        }

        internal static IEnumerable<(string file, Game matchingFlag)> FilterPerGame(string[] files, Game gameFilter)
        {
            var allGameNames = Enum.GetNames(typeof(Game)).Except(new[] { Game.Shared.ToString() });
            var selectedGames = allGameNames
                .Where(name => gameFilter.HasFlag((Game)Enum.Parse(typeof(Game), name)))
                .ToList();

            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                Game matchedFlag;

                var matchedGame = selectedGames.SingleOrDefault(game => fileName.StartsWith($"{game}."));
                if (matchedGame != null)
                    matchedFlag = (Game)Enum.Parse(typeof(Game), matchedGame);
                else if (gameFilter.HasFlag(Game.Shared) && allGameNames.Except(selectedGames).All(game => !fileName.StartsWith($"{game}.")))
                    matchedFlag = Game.Shared;
                else
                    continue;


                yield return (file, matchedFlag);
            }
        }
    }
}
