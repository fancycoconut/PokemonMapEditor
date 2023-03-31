using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokemonMapEditor.Infrastructure;
using System.Linq;

namespace PokemonMapEditor.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var configurationTypes = ApplicationTypeCache.GetTypes()
                .Where(x => x.Name.EndsWith("Configuration") || x.Name.EndsWith("Config") && x.IsClass);

            foreach (var type in configurationTypes)
            {
                var section = type.Name.Replace("Configuration", "");
                section = section.Replace("Config", "");

                var config = configuration.GetSection(section).Get(type);
                if (config == null) continue;

                services.Add(new ServiceDescriptor(type, config));
            }

            return services;
        }
    }
}
