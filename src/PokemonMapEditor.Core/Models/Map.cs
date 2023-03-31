namespace PokemonMapEditor.Core.Models
{
    public class Map
    {
        // Map bank that the map resides in
        public uint MapBankOffset { get; set; }
        public uint MapHeaderOffset { get; set; }

        // Map Header
        public uint LayoutData { get; set; }
        public uint EventData { get; set; }
        public uint MapScripts { get; set; }
        public uint ConnectionData { get; set; }
        public ushort MapSong { get; set; }
        public ushort MapIndex { get; set; } // Needs research
        public byte MapNameIndex { get; set; }
        public byte CaveBehaviour { get; set; }
        public byte Weather { get; set; }
        public byte MapType { get; set; }
        public ushort Filler { get; set; }
        public byte ShowName { get; set; }
        public byte BattleStyle { get; set; }

        // Fire Red & Leaf Green exclusive (follows after Map Type and finishes before battle style)
        public byte UnknownFiller { get; set; } // Is always at 0x1 so possibly filler
        public sbyte FloorLevel { get; set; }

        // Layout Data
        public uint Width { get; set; }
        public uint Height { get; set; }
        public uint Border { get; set; }
        public uint MapData { get; set; }
        public uint MajorTileset { get; set; }
        public uint MinorTileset { get; set; }
        public byte BorderWidth { get; set; } // Border width and height are for Fire Red & Leaf Green only
        public byte BorderHeight { get; set; }

        public ushort[,] TileData { get; set; }
        public ushort[,] BorderData { get; set; }

        // Events
        public byte PersonCount { get; set; }
        public byte WarpCount { get; set; }
        public byte ScriptCount { get; set; }
        public byte SignpostCount { get; set; }

        public uint PersonData { get; set; }
        public uint WarpData { get; set; }
        public uint ScriptData { get; set; }
        public uint SignPostData { get; set; }

        //public Person[] People { get; set; }
    }
}
