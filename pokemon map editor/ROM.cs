using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PokemonMapEditor
{
    public class ROM
    {
        public string GameTitle;
        public string GameCode;
        public string MakerCode;
        public byte GameVersion;

        public string FilePath;
        public bool EnlargedROM;

        #region Offsets
        public uint TilesetHeader;
        public uint MapBankOrigin;
        public uint MapNamesOrigin;

        public uint MapBank;
        public uint MapNames;
        #endregion

        public ROM()
        {
            GameTitle = String.Empty;
            GameCode = String.Empty;
            MakerCode = String.Empty;

            FilePath = String.Empty;
        }
        
        public void Load(string filename)
        {
            BinaryReader ReadROM = new BinaryReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

            ReadROM.BaseStream.Seek(0xA0, SeekOrigin.Begin);
            char[] TextBuffer = ReadROM.ReadChars(12); // Read Game Title
            GameTitle = new string(TextBuffer);
            TextBuffer = ReadROM.ReadChars(4); // Read Game Code
            GameCode = new string(TextBuffer);

            ReadROM.BaseStream.Position = 0xBC;
            GameVersion = ReadROM.ReadByte(); // Read Game Version

            ReadROM.BaseStream.Seek(0x0, SeekOrigin.End); // Check ROM Size
            if (ReadROM.BaseStream.Position > 0x1000000)
                EnlargedROM = true;
            else
                EnlargedROM = false;

            FilePath = filename;
            ReadROM.Close();
        }

        public uint Search(uint offset, int count, byte value, int chunksize)
        {
            using (BinaryReader ReadROM = new BinaryReader(File.Open(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)))
            {
                int Position = 0;
                int ReadLimit = (int)ReadROM.BaseStream.Length / chunksize;

                for (int i = 0; i < ReadLimit; i++) // Read ROM in chunks so its faster
                {
                    ReadROM.BaseStream.Position = offset;
                    byte[] Chunk = ReadROM.ReadBytes(chunksize);
                    int SizeOfChunk = Chunk.Length;

                    if (SizeOfChunk < count) // If reached end of file
                        return 0;

                    int j = 0;
                    int FoundBytes = 0;
                    while (j < SizeOfChunk)
                    {
                        if (Chunk[j] != value)
                            FoundBytes = 0;
                        else
                            FoundBytes++;

                        if (FoundBytes == count)
                        {                          
                            Position = (j + 1) - FoundBytes;
                            return (uint)(offset + Position);
                        }

                        j++;
                    }

                    offset += (uint) j;
                }
            }

            return 0;
        }
    }
}
