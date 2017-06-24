using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonMapEditor
{
    public class Maps
    {
        public static string[] MapNameList;

        private static void LoadMapNames(ROM game, BinaryReader readFile, ComboBox nameComboBox)
        {
            byte[] MapNameBuffer = new byte[18];

            MapNameList = new string[0xFF];
            nameComboBox.Items.Clear();

            int counter = 0;
            while (true)
            {
                if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
                    readFile.BaseStream.Position = game.MapNames + (counter * 4);
                else
                    readFile.BaseStream.Position = game.MapNames + (counter * 8) + 4;

                uint NamePointer = readFile.ReadUInt32();
                if (NamePointer >= 0x8000000 && NamePointer != 0xFFFFFFFF)
                {
                    readFile.BaseStream.Position = NamePointer - 0x8000000;
                    MapNameBuffer = readFile.ReadBytes(18);
                    MapNameList[counter] = PokeText.Sapp2Asc(MapNameBuffer, 18);
                    nameComboBox.Items.Add(MapNameList[counter]);
                    counter++;
                }
                else
                    break;
            }
        }

        public static void PopulateMapList(ROM game, TreeView mapList, ComboBox mapNames)
        {
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

            mapList.Nodes.Clear();
            LoadMapNames(game, ReadROM, mapNames); // Load map names and store 'em

            int Bank = 0;
            while (true) // Go through the map banks
            {
                TreeNode BankNode = new TreeNode("Bank " + Bank.ToString(), 0, 0);

                ReadROM.BaseStream.Position = Convert.ToUInt32(game.MapBank + (Bank * 4));
                uint CurrentMapBank = ReadROM.ReadUInt32();
                uint NextMapBank = ReadROM.ReadUInt32();

                if ((CurrentMapBank & 0xFF000000) >= 0x8000000 && CurrentMapBank != 0xFFFFFFFF && CurrentMapBank != 0xF7F7F7F7) // Continue reading if valid map bank
                {
                    int Map = 0;
                    TreeNode MapNode = null;
                    do // Go through maps
                    {
                        ReadROM.BaseStream.Position = CurrentMapBank - 0x8000000;
                        uint MapOffset = ReadROM.ReadUInt32();

                        if ((MapOffset & 0xFF000000) >= 0x8000000 && MapOffset != 0xFFFFFFFF && MapOffset != 0xF7F7F7F7) // Continue if valid map
                        {
                            if (MapOffset == 0x77777777)
                                MapNode = new TreeNode("Map " + Map.ToString() + " - RESERVED", 1, 1);
                            else
                            {
                                ReadROM.BaseStream.Position = MapOffset - 0x8000000 + 20;
                                int MapIndex = ReadROM.ReadByte();

                                if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
                                    MapIndex -= 0x58;

                                MapNode = new TreeNode("Map " + Map.ToString() + " - " + MapNameList[MapIndex], 1, 1);
                            }

                            Map++;
                            CurrentMapBank += 4;
                            BankNode.Nodes.Add(MapNode);
                        }
                        else
                            break;
                    } while (CurrentMapBank < NextMapBank);

                    mapList.Nodes.Add(BankNode);
                    Bank++;
                }
                else
                    break;
            }

            ReadROM.Close();
        }

        public static Map LoadMap(ROM game, int bank, int map)
        {
            Map LoadedMap = new Map();
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ReadROM.BaseStream.Position = game.MapBank + (bank * 4);
            LoadedMap.MapBankOffset = ReadROM.ReadUInt32() - 0x8000000;
            ReadROM.BaseStream.Position = LoadedMap.MapBankOffset + (map * 4);
            LoadedMap.MapHeaderOffset = ReadROM.ReadUInt32() - 0x8000000;

            ReadROM.BaseStream.Position = LoadedMap.MapHeaderOffset;
            LoadedMap.LayoutData = ReadROM.ReadUInt32();
            LoadedMap.EventData = ReadROM.ReadUInt32();
            LoadedMap.MapScripts = ReadROM.ReadUInt32();
            LoadedMap.ConnectionData = ReadROM.ReadUInt32();
            LoadedMap.MapSong = ReadROM.ReadUInt16();
            LoadedMap.MapIndex = ReadROM.ReadUInt16();
            LoadedMap.MapNameIndex = ReadROM.ReadByte();
            LoadedMap.CaveBehaviour = ReadROM.ReadByte();
            LoadedMap.Weather = ReadROM.ReadByte();
            LoadedMap.MapType = ReadROM.ReadByte();
            if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
            {
                LoadedMap.UnknownFiller = ReadROM.ReadByte();
                LoadedMap.ShowName = ReadROM.ReadByte();
                LoadedMap.FloorLevel = ReadROM.ReadSByte();

            }
            else
            {
                LoadedMap.Filler = ReadROM.ReadUInt16();
                LoadedMap.ShowName = ReadROM.ReadByte();
            }
            LoadedMap.BattleStyle = ReadROM.ReadByte();

            ReadROM.BaseStream.Position = LoadedMap.LayoutData - 0x8000000;
            LoadedMap.Width = ReadROM.ReadUInt32();
            LoadedMap.Height = ReadROM.ReadUInt32();
            LoadedMap.Border = ReadROM.ReadUInt32();
            LoadedMap.MapData = ReadROM.ReadUInt32();
            LoadedMap.MajorTileset = ReadROM.ReadUInt32();
            LoadedMap.MinorTileset = ReadROM.ReadUInt32();
            if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
            {
                LoadedMap.BorderWidth = ReadROM.ReadByte();
                LoadedMap.BorderHeight = ReadROM.ReadByte();
            }
            else
            {
                LoadedMap.BorderWidth = 0x2;
                LoadedMap.BorderHeight = 0x2;
            }

            ReadROM.Close();
            return LoadedMap;
        }

        public static void SaveMap(ROM game, Map map)
        {
            BinaryWriter WriteROM = new BinaryWriter(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            WriteROM.BaseStream.Position = map.MapHeaderOffset + 16;

            WriteROM.Write(map.MapSong);
            WriteROM.Write(map.MapIndex);
            WriteROM.Write(map.MapNameIndex);
            WriteROM.Write(map.CaveBehaviour);
            WriteROM.Write(map.Weather);
            WriteROM.Write(map.MapType);

            if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
            {
                WriteROM.Write(map.UnknownFiller);
                WriteROM.Write(map.ShowName);
                WriteROM.Write(map.FloorLevel);
            }
            else
            {
                WriteROM.Write(map.Filler);
                WriteROM.Write(map.ShowName);
            }

            WriteROM.Write(map.BattleStyle);

            WriteROM.BaseStream.Position = map.MapData - 0x8000000; // Write map data
            for (int y = 0; y < map.Height; y++)
                for (int x = 0; x < map.Width; x++)
                    WriteROM.Write(map.MapTileData[x, y]);

            WriteROM.BaseStream.Position = map.Border - 0x8000000; // Write border data
            for (int by = 0; by < map.BorderHeight; by++)
                for (int bx = 0; bx < map.BorderWidth; bx++)
                    WriteROM.Write(map.BorderData[bx, by]);

            WriteROM.Close();
        }

        public static void SaveHeader(ROM game, Map map)
        {
            BinaryWriter WriteROM = new BinaryWriter(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            WriteROM.BaseStream.Position = map.MapHeaderOffset;
            WriteROM.Write(map.LayoutData);
            WriteROM.Write(map.EventData);
            WriteROM.Write(map.MapScripts);
            WriteROM.Write(map.ConnectionData);

            WriteROM.BaseStream.Position = map.LayoutData - 0x8000000 + 8;
            WriteROM.Write(map.Border);
            WriteROM.Write(map.MapData);
            WriteROM.Write(map.MajorTileset);
            WriteROM.Write(map.MinorTileset);

            WriteROM.Close();
        }

        public static void Resize(ROM game, uint offset, int width, int height, Map map)
        {
            int NewAmount = width * height * 2;
            int Amount = (int)(map.Width * map.Height * 2);
            BinaryWriter WriteROM = new BinaryWriter(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ushort[,] NewMap = new ushort[width, height];

            for (int y = 0; y < map.Height; y++) // Copying data to a new array
                for (int x = 0; x < map.Width; x++)
                {
                    if (x < width && y < height)
                        NewMap[x, y] = map.MapTileData[x, y];
                }

            WriteROM.BaseStream.Position = map.MapData - 0x8000000; // Erase old map data
            for (int y = 0; y < map.Height; y++)
                for (int x = 0; x < map.Width; x++)
                    WriteROM.Write((ushort)0xFFFF);

            if (NewAmount > Amount)
                map.MapData = offset + 0x8000000;

            map.Width = (uint)width;
            map.Height = (uint)height;
            map.MapTileData = NewMap;

            WriteROM.BaseStream.Position = map.LayoutData - 0x8000000;
            WriteROM.Write(map.Width);
            WriteROM.Write(map.Height);
            WriteROM.Write(map.Border);
            WriteROM.Write(map.MapData);

            WriteROM.BaseStream.Position = map.MapData - 0x8000000; // Write new resized map data to ROM
            for (int y = 0; y < map.Height; y++)
                for (int x = 0; x < map.Width; x++)
                    WriteROM.Write(map.MapTileData[x, y]);

            WriteROM.Close();
        }

        public static void ResizeBorder(ROM game, uint offset, int width, int height, Map map)
        {
            int NewAmount = width * height * 2;
            int Amount = (int)(map.BorderWidth * map.BorderHeight * 2);
            BinaryWriter WriteROM = new BinaryWriter(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ushort[,] NewBorder = new ushort[width, height];

            for (int y = 0; y < map.BorderHeight; y++) // Copying data to a new array
                for (int x = 0; x < map.BorderWidth; x++)
                {
                    if (x < width && y < height)
                        NewBorder[x, y] = map.BorderData[x, y];
                }

            WriteROM.BaseStream.Position = map.Border - 0x8000000; // Erase old map data
            for (int y = 0; y < map.BorderHeight; y++)
                for (int x = 0; x < map.BorderWidth; x++)
                    WriteROM.Write((ushort)0xFFFF);

            if (NewAmount > Amount)
                map.Border = offset + 0x8000000;

            map.BorderWidth = (byte)width;
            map.BorderHeight = (byte)height;
            map.BorderData = NewBorder;

            WriteROM.BaseStream.Position = map.LayoutData - 0x8000000 + 8;
            WriteROM.Write(map.Border);
            WriteROM.BaseStream.Position = map.LayoutData - 0x8000000 + 24;
            WriteROM.Write(map.BorderWidth);
            WriteROM.Write(map.BorderHeight);

            WriteROM.BaseStream.Position = map.Border - 0x8000000; // Write new resized map data to ROM
            for (int y = 0; y < map.BorderHeight; y++)
                for (int x = 0; x < map.BorderWidth; x++)
                    WriteROM.Write(map.BorderData[x, y]);

            WriteROM.Close();
        }

        public static ushort[,] RenderMap(ROM game, Bitmap mapImage, Bitmap tileset, Map map)
        {
            FastPixel mp = new FastPixel(mapImage);
            FastPixel tp = new FastPixel(tileset);
            ushort[,] MapData = new ushort[map.Width, map.Height];
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            mp.rgbValues = new byte[mapImage.Width * mapImage.Height * 4];
            tp.rgbValues = new byte[tileset.Width * tileset.Height * 4];

            mp.Lock();
            tp.Lock();

            int SrcX, SrcY, DestX, DestY;
            ReadROM.BaseStream.Position = map.MapData - 0x8000000;
            for (int y = 0; y < map.Height; y++)
            {
                DestY = y * 16;
                for (int x = 0; x < map.Width; x++)
                {
                    MapData[x, y] = ReadROM.ReadUInt16();

                    int Tile = MapData[x, y] & 0x3FF;
                    SrcX = (Tile % 8) * 16;
                    SrcY = (Tile / 8) * 16;
                    DestX = x * 16;

                    for (int px = 0; px < 16; px++)
                        for (int py = 0; py < 16; py++)
                            mp.SetPixel(DestX + px, DestY + py, tp.GetPixel(SrcX + px, SrcY + py));
                }
            }

            mp.Unlock(true);
            tp.Unlock(true);
            ReadROM.Close();
            return MapData;
        }

        public static ushort[,] RenderMap(ROM game, Bitmap mapImage, Bitmap tileset, Bitmap attributeImage, Bitmap attributeBlocks, Map map)
        {
            FastPixel tp = new FastPixel(tileset);
            FastPixel mp = new FastPixel(mapImage);
            FastPixel ap = new FastPixel(attributeImage);
            FastPixel abp = new FastPixel(attributeBlocks);
            ushort[,] MapData = new ushort[map.Width, map.Height];
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            tp.rgbValues = new byte[tileset.Width * tileset.Height * 4];
            mp.rgbValues = new byte[mapImage.Width * mapImage.Height * 4];
            ap.rgbValues = new byte[attributeImage.Width * attributeImage.Height * 4];
            abp.rgbValues = new byte[attributeBlocks.Width * attributeBlocks.Height * 4];

            mp.Lock();
            tp.Lock();
            ap.Lock();
            abp.Lock();

            int TileSrcX, TileSrcY, AttSrcX, AttSrcY, DestX, DestY;
            ReadROM.BaseStream.Position = map.MapData - 0x8000000;
            for (int y = 0; y < map.Height; y++)
            {
                DestY = y * 16;
                for (int x = 0; x < map.Width; x++)
                {
                    MapData[x, y] = ReadROM.ReadUInt16();

                    int Tile = MapData[x, y] & 0x3FF;
                    int Attribute = MapData[x, y] >> 10;

                    TileSrcX = (Tile % 8) * 16;
                    TileSrcY = (Tile / 8) * 16;
                    AttSrcX = (Attribute % 8) * 16;
                    AttSrcY = (Attribute / 8) * 16;
                    DestX = x * 16;

                    for (int px = 0; px < 16; px++)
                        for (int py = 0; py < 16; py++)
                        {
                            mp.SetPixel(DestX + px, DestY + py, tp.GetPixel(TileSrcX + px, TileSrcY + py)); // Draw map
                            ap.SetPixel(DestX + px, DestY + py, abp.GetPixel(AttSrcX + px, AttSrcY + py)); // Draw attribute map
                        }
                }
            }

            mp.Unlock(true);
            tp.Unlock(true);
            ap.Unlock(true);
            abp.Unlock(true);

            ReadROM.Close();
            return MapData;
        }

        public static void RenderAttributes(Bitmap attributeImage, Bitmap attributeBlocks, Map map)
        {
            FastPixel ap = new FastPixel(attributeImage);
            FastPixel abp = new FastPixel(attributeBlocks);

            ap.rgbValues = new byte[attributeImage.Width * attributeImage.Height * 4];
            abp.rgbValues = new byte[attributeBlocks.Width * attributeBlocks.Height * 4];

            ap.Lock();
            abp.Lock();

            int SrcX, SrcY, DestX, DestY;
            for (int y = 0; y < map.Height; y++)
            {
                DestY = y * 16;
                for (int x = 0; x < map.Width; x++)
                {
                    int Att = map.MapTileData[x, y] >> 10;

                    SrcX = (Att % 8) * 16;
                    SrcY = (Att / 8) * 16;
                    DestX = x * 16;

                    for (int px = 0; px < 16; px++)
                        for (int py = 0; py < 16; py++)
                            ap.SetPixel(DestX + px, DestY + py, abp.GetPixel(SrcX + px, SrcY + py));
                }
            }

            ap.Unlock(true);
            abp.Unlock(true);
        }

        public static ushort[,] RenderBorder(ROM game, Graphics border, Bitmap tileset, Map map)
        {
            ushort[,] BorderData = new ushort[map.BorderWidth, map.BorderHeight];
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ReadROM.BaseStream.Position = map.Border - 0x8000000;
            for (int y = 0; y < map.BorderHeight; y++)
                for (int x = 0; x < map.BorderWidth; x++)
                {
                    BorderData[x, y] = ReadROM.ReadUInt16();

                    int Tile = BorderData[x, y] & 0x3FF;
                    Rectangle SrcRect = new Rectangle((Tile % 8) * 16, (Tile / 8) * 16, 16, 16);
                    Rectangle DestRect = new Rectangle(x * 16, y * 16, 16, 16);

                    border.DrawImage(tileset, DestRect, SrcRect, GraphicsUnit.Pixel);
                }

            ReadROM.Close();
            return BorderData;
        }
    }

    public class Map
    {
        public uint MapBankOffset { get; set; } // Map bank that the map resides in
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

        public ushort[,] MapTileData { get; set; }
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

        public Person[] People { get; set; }
    }
}