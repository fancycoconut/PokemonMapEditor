using System;

namespace Plugins
{
    public interface IPlugin
    {
        IPluginHost Host { get; set; }

        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }

        void Show();
    }

    public interface IPluginHost
    {
    }
}
