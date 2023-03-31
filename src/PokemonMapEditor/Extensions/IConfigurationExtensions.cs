using Microsoft.Extensions.Configuration;

namespace PokemonMapEditor.Extensions
{
    public static class IConfigurationExtensions
    {
        public static T GetSection<T>(this IConfiguration configuration)
        {
            var type = typeof(T).Name;
            type = type.Replace("Configuration", "");
            type = type.Replace("Config", "");

            return configuration.GetSection(type).Get<T>();
        }
    }
}
