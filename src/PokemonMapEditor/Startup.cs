using Microsoft.Extensions.DependencyInjection;

namespace PokemonMapEditor
{
    public class Startup
    {
        public void Configure(IServiceCollection services)
        {
            // TODO Make this fancy...
            services.AddSingleton<Forms.Main>();
        }
    }
}
