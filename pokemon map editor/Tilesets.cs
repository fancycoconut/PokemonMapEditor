using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Text;

namespace PokemonMapEditor
{
    public class Tilesets
    {
        public static byte[] Decode(byte[] rawData)
        {
            List<byte> DecodedData = new List<byte>();

            for (int i = 0; i < rawData.Length; i++)
            {
                DecodedData.Add((byte)(rawData[i] % 0x10));
                DecodedData.Add((byte)(rawData[i] / 0x10));
            }

            return DecodedData.ToArray();
        }

        public static void DrawTile8(FastPixel fpDrawer, byte[] gfxData, int tileindex, int x, int y, bool flipX, bool flipY, int palIndex, Color[] palette)
        {
            int mx = 0;
            int my = 0;

            if (flipX)
                x += 7;
            if (flipY)
                y += 7;

            int TileSeeker = tileindex * 64;
            if (TileSeeker + 64 > gfxData.Length)
                return;

            for (int i = 0; i < 64; i++)
            {
                if (gfxData[TileSeeker + i] > 0)
                    fpDrawer.SetPixel(x + (flipX ? -mx : mx), y + (flipY ? -my : my), palette[gfxData[TileSeeker + i] + (palIndex * 16)]);

                mx++;
                if (mx == 8)
                {
                    mx = 0;
                    my++;
                }
            }
        }

        public static Tileset Load(ROM game, uint offset, uint tilesetHeader)
        {
            Tileset NewTileset = new Tileset();
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ReadROM.BaseStream.Position = offset;
            NewTileset.LZ77Compressed = ReadROM.ReadByte();
            NewTileset.MajorTileset = ReadROM.ReadByte();
            NewTileset.Filler = ReadROM.ReadUInt16();
            NewTileset.Image = ReadROM.ReadUInt32();
            NewTileset.Palette = ReadROM.ReadUInt32();
            NewTileset.BlockData = ReadROM.ReadUInt32();
            if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
            {
                NewTileset.Animation = ReadROM.ReadUInt32();
                NewTileset.BehaviourData = ReadROM.ReadUInt32();
            }
            else
            {
                NewTileset.BehaviourData = ReadROM.ReadUInt32();
                NewTileset.Animation = ReadROM.ReadUInt32();
            }

            if (game.GameCode.Substring(0, 3) == "BPE")
                NewTileset.Number = (offset - tilesetHeader + 8) / 0x18;
            else
                NewTileset.Number = (offset - tilesetHeader) / 0x18;

            ReadROM.Close();
            return NewTileset;
        }

        public static void Save(ROM game, uint offset, Tileset tileset)
        {
            BinaryWriter WriteROM = new BinaryWriter(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            WriteROM.BaseStream.Position = offset;

            WriteROM.Write(tileset.LZ77Compressed);
            WriteROM.Write(tileset.MajorTileset);
            WriteROM.Write(tileset.Filler);
            WriteROM.Write(tileset.Image);
            WriteROM.Write(tileset.Palette);
            WriteROM.Write(tileset.BlockData);
            if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
            {
                WriteROM.Write(tileset.Animation);
                WriteROM.Write(tileset.BehaviourData);
            }
            else
            {
                WriteROM.Write(tileset.BehaviourData);
                WriteROM.Write(tileset.Animation);
            }

            WriteROM.Close();
        }

        public static Bitmap Render(ROM game, Tileset major, Tileset minor, Map map)
        {
            Bitmap TilesetImage = new Bitmap(128, 2560);
            Graphics tsGraphics = Graphics.FromImage(TilesetImage);
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            tsGraphics.Clear(Color.FromArgb(24, 48, 80)); // Background color

            // Reading Palettes
            ushort[] GBAPalettes = new ushort[256];

            ReadROM.BaseStream.Position = minor.Palette - 0x8000000;
            for (int i = 0; i < 208; i++)
                GBAPalettes[i] = ReadROM.ReadUInt16();

            int[] BlockLimit = new int[2]; // Block limits for the 2 tilesets
            int[] TilesetSize = new int[2]; // Tileset filesize of the 2 tilesets

            int MajorPalettes; // Number of palettes for the major tileset
            if (game.GameCode.Substring(0, 3) == "BPR" || game.GameCode.Substring(0, 3) == "BPG")
            {
                MajorPalettes = 112;
                BlockLimit[0] = 640;
                BlockLimit[1] = 512;
                TilesetSize[0] = 0x5000;
                TilesetSize[1] = 0X5000;
            }
            else
            {
                MajorPalettes = 96;
                BlockLimit[0] = 512;
                BlockLimit[1] = 512;
                TilesetSize[0] = 0x4000;
                TilesetSize[1] = 0X5000;
            }

            ReadROM.BaseStream.Position = major.Palette - 0x8000000;
            for (int i = 0; i < MajorPalettes; i++)
                GBAPalettes[i] = ReadROM.ReadUInt16();

            PaletteHook(GBAPalettes, map);

            // Reading Tileset
            uint[] TilesetImageOffsets = new uint[2] { major.Image - 0x8000000, minor.Image - 0x8000000 };
            List<byte> Gfx = new List<byte>();

            for (int i = 0; i < 2; i++)
            {
                ReadROM.BaseStream.Position = TilesetImageOffsets[i];
                byte[] RawGfx = ReadROM.ReadBytes(TilesetSize[i]);

                if (RawGfx[0] == 0x10) // Check for LZ77 compression
                    Gfx.AddRange(Decode(LZ77.Uncompress(RawGfx)));
                else
                    Gfx.AddRange(Decode(RawGfx));

                if (i == 0 && Gfx.Count < 0x8000)
                {
                    for (int ii = 0; ii < 640; ii++)
                        Gfx.Add(0x0);
                }
            }

            byte[] TilesetGfx = Gfx.ToArray();

            // Decoding Palettes
            Color[] Palettes = new Color[256];

            for (int i = 0; i < 256; i++)
                Palettes[i] = GBAGraphics.DecodePalette(GBAPalettes[i]);

            // Drawing Tileset
            FastPixel fp = new FastPixel(TilesetImage);
            uint[] TilesetBlockDataOffset = new uint[2] { major.BlockData - 0x8000000, minor.BlockData - 0x8000000 };

            int x = 0;
            int y = 0;

            byte[] PositionX = new byte[4] { 0, 8, 0, 8 };
            byte[] PositionY = new byte[4] { 0, 0, 8, 8 };

            fp.rgbValues = new byte[TilesetImage.Width * TilesetImage.Height * 4];
            fp.Lock();

            for (int Tileset = 0; Tileset < 2; Tileset++) // 2 Tilesets
            {
                ReadROM.BaseStream.Position = TilesetBlockDataOffset[Tileset];
                for (int i = 0; i < BlockLimit[Tileset]; i++) // Amount of tiles for each tileset (block number)
                {
                    for (int Layer = 0; Layer < 2; Layer++) // 2 Layers (Bottom & Top)
                    {
                        for (int Tile = 0; Tile < 4; Tile++) // 4 Tiles for each layer
                        {
                            ushort TileData = ReadROM.ReadUInt16();

                            int TileIndex = TileData & 0x3FF;
                            int FlipX = (TileData & 0x400) >> 10;
                            int FlipY = (TileData & 0x800) >> 11;
                            int PalIndex = (TileData & 0xF000) >> 12;

                            DrawTile8(fp, TilesetGfx, TileIndex, x * 16 + PositionX[Tile], y * 16 + PositionY[Tile], FlipX == 1, FlipY == 1, PalIndex, Palettes);
                        }
                    }

                    x++;
                    if (x == 8)
                    {
                        x = 0;
                        y++;
                    }
                }
            }

            fp.Unlock(true);
            ReadROM.Close();
            return TilesetImage;
        }

        private static void PaletteHook(ushort[] Palette, Map map)
        {
            if (frmMain.PaletteSet[0] == 1) // Normal
                return;

            if (map.MapType == 0 || map.MapType == 4 || map.MapType == 8 || map.MapType == 9)
                return;

            for (int i = 0; i < 256; i++)
            {
                int Red = 0x1E & Palette[i];
                int Blue = (0x1E << 0x5) & Palette[i];
                int Green = (0x1E << 0xA) & Palette[i];

                if (frmMain.PaletteSet[1] == 1) // Morning
                    Green = Green >> 0x1;
                else if (frmMain.PaletteSet[2] == 1) // Afternoon
                {
                    Blue = Blue >> 0x1;
                    Green = Green >> 0x1;
                }
                else if (frmMain.PaletteSet[3] == 1) // Evening
                {
                    Red = Red >> 0x1;
                    Blue = Blue >> 0x1;
                }
                else if (frmMain.PaletteSet[4] == 1) // Night
                {
                    Red = Red >> 0x1;
                    Blue = Blue >> 0x1;
                    Green = Green >> 0x1;
                }
                else if (frmMain.PaletteSet[5] == 1) // Auto
                {
                    if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 6) // Morning
                        Green = Green >> 0x1;
                    else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 17) // Day
                        return;
                    else if (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 18) // Afternoon
                    {
                        Blue = Blue >> 0x1;
                        Green = Green >> 0x1;
                    }
                    else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 22) // Evening
                    {
                        Red = Red >> 0x1;
                        Blue = Blue >> 0x1;
                    }
                    else if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 4) // Night
                    {
                        Red = Red >> 0x1;
                        Blue = Blue >> 0x1;
                        Green = Green >> 0x1;
                    }
                }

                Palette[i] = (ushort)(Red | Blue | Green);
            }
            
        }
    }

    public class Tileset
    {
        public byte LZ77Compressed { get; set; }
        public byte MajorTileset { get; set; }
        public ushort Filler { get; set; }
        public uint Image { get; set; }
        public uint Palette { get; set; }
        public uint BlockData { get; set; }
        public uint BehaviourData { get; set; }
        public uint Animation { get; set; }

        public uint Number { get; set; }
    }
}
