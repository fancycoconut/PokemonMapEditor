using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PokemonMapEditor.Infrastructure
{
    /// <summary>
    /// Caches all the loaded types of the current Application of the base application dll and the Freedom platform
    /// </summary>
    internal static class ApplicationTypeCache
    {
        private static readonly HashSet<Type> typesCache = new HashSet<Type>();

        public static IEnumerable<Type> GetTypes()
        {
            if (!typesCache.Any())
            {
                CacheTypes();
            }

            return typesCache;
        }

        private static void CacheTypes()
        {
            // TODO Maybe add filter mechanism on the files...
            var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");

            foreach (var dll in files)
            {
                var assembly = Assembly.LoadFrom(dll);
                foreach (var type in assembly.GetExportedTypes())
                {
                    typesCache.Add(type);
                }
            }
        }
    }
}
