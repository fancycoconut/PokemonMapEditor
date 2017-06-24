using System;
using System.Drawing;
using System.Collections.Generic;

namespace PokemonMapEditor
{
    public static class LZ77
    {
        /* Needs to be tested */
        //public static byte[] Compress(byte[] source)
        //{
        //    int XIn = 0, TmpXIn = 0;
        //    int XOut = 0, TmpXOut = 0; // XOut = Poss./Length in new array
        //    int Length = 0, TmpLength = 0;
        //    int Offset = 0, TmpOffset = 0;
        //    byte Ctrl = 0;
        //    byte[,] XData = new byte[8, 2];

        //    byte[] TmpDest = new byte[0x8000];
        //    int DecmpSize = source.Length;

        //    XOut = 4; // The header
        //    TmpDest[0] = 0x10; // Unknown byte
        //    TmpDest[1] = (byte)(DecmpSize & 0xFF);
        //    TmpDest[2] = (byte)((DecmpSize >> 8) & 0xFF);
        //    TmpDest[3] = (byte)((DecmpSize >> 16) & 0xFF);

        //    while((DecmpSize - 1) >= TmpXIn)
        //    {
        //        Ctrl = 0;
        //        for (int i = 7; i 
        //    }
        //}

        public static byte[] Uncompress(byte[] source)
        {
            int xOut = 0;
            int xIn = 4;
            int xLen = (source[0] | source[1] << 8 | source[2] << 16 | source[3] << 24) >> 8;
            byte[] destination = new byte[xLen];

            while (xLen > 0)
            {
                byte d = source[xIn++];

                for (int i = 0; i < 8; i++)
                {
                    if ((d & 0x80) != 0)
                    {
                        int data = source[xIn] << 8 | source[xIn + 1];
                        xIn += 2;
                        int length = (data >> 12) + 3;
                        int offset = (data & 0xFFF);
                        int windowsOffset = xOut - offset - 1;

                        for (int j = 0; j < length; j++)
                        {
                            destination[xOut++] = destination[windowsOffset++];
                            xLen--;

                            if (xLen == 0)
                                return destination;
                        }
                    }
                    else
                    {
                        destination[xOut++] = source[xIn++];
                        xLen--;

                        if (xLen == 0)
                            return destination;
                    }

                    d = (byte)((d << 1) & 0xFF);
                }
            }

            return destination;
        }
    }

    public static class GBAGraphics
    {
        public static Color DecodePalette(ushort gbaPalette)
        {
            ushort red = Convert.ToUInt16((gbaPalette & 31) << 3);
            ushort green = Convert.ToUInt16(((gbaPalette >> 5) & 31) << 3);
            ushort blue = Convert.ToUInt16(((gbaPalette >> 10) & 31) << 3);

            return Color.FromArgb(red, green, blue);
        }
    }
}
