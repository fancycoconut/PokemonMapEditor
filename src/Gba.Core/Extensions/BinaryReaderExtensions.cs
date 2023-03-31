using System.IO;

namespace Gba.Core.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static void Seek(this BinaryReader reader, long offset)
        {
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
        }

        public static string ReadString(this BinaryReader reader, int length)
        {
            var text = reader.ReadChars(length);
            return new string(text);
        }

        public static string ReadString(this BinaryReader reader, int offset, int length)
        {
            Seek(reader, offset);
            return ReadString(reader, length);
        }

        public static byte ReadByte(this BinaryReader reader, int offset)
        {
            Seek(reader, offset);
            return reader.ReadByte();
        }
    }
}
