using Gba.Core.Extensions;
using System.IO;

namespace Gba.Core
{
    public class ROM
    {
        public string GameTitle { get; set; }
        public string GameCode { get; set; }
        public string MakerCode { get; set; }
        public byte MainUnitCode { get; set; }
        public byte DeviceType { get; set; }
        public byte Version { get; set; }
        public int Checksum { get; set; }

        public string FilePath { get; private set; }

        public static ROM Load(string path)
        {
            using var input = File.OpenRead(path);
            using var reader = new BinaryReader(input);

            return new ROM
            {
                FilePath = path,

                GameTitle = reader.ReadString(0xA0, 12),
                GameCode = reader.ReadString(4),
                MakerCode = reader.ReadString(2),
                MainUnitCode = reader.ReadByte(0xB3),
                DeviceType = reader.ReadByte(),
                Version = reader.ReadByte(0xBC),
                Checksum = reader.ReadByte()                
            };
        }
    }
}
