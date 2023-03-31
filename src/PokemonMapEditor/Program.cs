using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokemonMapEditor.Extensions;
using System;
using System.Windows.Forms;

namespace PokemonMapEditor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(config);
            services.AddConfiguration(config);

            var startup = new Startup();
            startup.Configure(services);

            using var provider = services.BuildServiceProvider();
            var main = provider.GetRequiredService<Forms.Main>();
            Application.Run(main);
        }
    }
}
