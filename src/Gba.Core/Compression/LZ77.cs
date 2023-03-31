namespace Gba.Core.Compression
{
    public class LZ77
    {
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
}
