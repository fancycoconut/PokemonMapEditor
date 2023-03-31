using System.Collections.Generic;

namespace PokemonMapEditor.Core.Configuration
{
    public class SupportedROMsConfiguration
    {
        public Dictionary<string, SupportedROM> ROMs { get; set; }
    }

    public class SupportedROM
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int Version { get; set; }
        public string TilesetHeader { get; set; }
        public string MapBankOrigin { get; set; }
        public string MapNamesOrigin { get; set; }
    }
}
