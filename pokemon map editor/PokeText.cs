using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonMapEditor
{
    public class PokeText
    {
        private static byte[] TextTable;
        private static bool AsciiReady;
        private static string[] SappTable;
        private static bool SappReady;

        public static byte[] Asc2Sapp(string ascii, int length)
        {
            byte[] SappString = new byte[length];

            if (!AsciiReady)
                AscInit();

            for (int i = 0; i < length; i++)
            {
                char ch;

                try
                {
                    ch = Convert.ToChar(ascii.Substring(i, 1));
                }
                catch
                {
                    SappString[i] = 0xFF;
                    return SappString;
                }

                SappString[i] = TextTable[ch];
            }

            return SappString;
        }

        private static void AscInit()
        {
            TextTable = new byte[340];

            TextTable[0x20] = 0x0; // " "
            TextTable[0xC0] = 0x1; // "À"
            TextTable[0xC1] = 0x2; // "Á"
            TextTable[0xC2] = 0x3; // "Â"
            TextTable[0xC7] = 0x4; // "Ç"
            TextTable[0xC8] = 0x5; // "È"
            TextTable[0xC9] = 0x6; // "É"
            TextTable[0xCA] = 0x7; // "Ê"
            TextTable[0xCB] = 0x8; // "Ë"
            TextTable[0xCC] = 0x9; // "Ì"
            TextTable[0xCE] = 0xB; // "Î"
            TextTable[0xCF] = 0xC; // "Ï"
            TextTable[0xD2] = 0xD; // "Ò"
            TextTable[0xD3] = 0xE; // "Ó"
            TextTable[0xD4] = 0xF; // "Ô"
            TextTable[0x152] = 0x10; // "Œ"
            TextTable[0xD9] = 0x11; // "Ù"
            TextTable[0xDA] = 0x12; // "Ú"
            TextTable[0xDB] = 0x13; // "Û"
            TextTable[0xD1] = 0x14; // "Ñ"
            TextTable[0xDF] = 0x15; // "ß"
            TextTable[0xE0] = 0x16; // "à"
            TextTable[0xE1] = 0x17; // "á"
            TextTable[0xE7] = 0x19; // "ç"
            TextTable[0xE8] = 0x1A; // "è"
            TextTable[0xE9] = 0x1B; // "é"
            TextTable[0xEA] = 0x1C; // "ê"
            TextTable[0xEB] = 0x1D; // "ë"
            TextTable[0xEC] = 0x1E; // "ì"
            TextTable[0xEE] = 0x20; // "î"
            TextTable[0xEF] = 0x21; // "ï"
            TextTable[0xF2] = 0x22; // "ò"
            TextTable[0xF3] = 0x23; // "ó"
            TextTable[0xF4] = 0x24; // "ô"
            TextTable[0x153] = 0x25; // "œ"
            TextTable[0xF9] = 0x26; // "ù"
            TextTable[0xFA] = 0x27; // "ú"
            TextTable[0xFB] = 0x28; // "û"
            TextTable[0xF1] = 0x29; // "ñ"
            TextTable[0xBA] = 0x2A; // "º"
            TextTable[0xAA] = 0x2B; // "ª"
            TextTable[0x26] = 0x2D; // "&"
            TextTable[0x2B] = 0x2E; // "+"
            TextTable[0x3D] = 0x35; // "="
            TextTable[0x3B] = 0x36; // ";"
            TextTable[0xBF] = 0x51; // "¿"
            TextTable[0xA1] = 0x52; // "¡"
            TextTable[0xCD] = 0x5A; // "Í"
            TextTable[0x25] = 0x5B; // "%"
            TextTable[0x28] = 0x5C; // "("
            TextTable[0x29] = 0x5D; // ")"
            TextTable[0xE2] = 0x68; // "â"
            TextTable[0xED] = 0x6F; // "í"
            TextTable[0x3C] = 0x85; // "<"
            TextTable[0x3E] = 0x86; // ">"
            TextTable[0x30] = 0xA1; // "0"
            TextTable[0x31] = 0xA2; // "1"
            TextTable[0x32] = 0xA3; // "2"
            TextTable[0x33] = 0xA4; // "3"
            TextTable[0x34] = 0xA5; // "4"
            TextTable[0x35] = 0xA6; // "5"
            TextTable[0x36] = 0xA7; // "6"
            TextTable[0x37] = 0xA8; // "7"
            TextTable[0x38] = 0xA9; // "8"
            TextTable[0x39] = 0xAA; // "9"
            TextTable[0x21] = 0xAB; // "!"
            TextTable[0x3F] = 0xAC; // "?"
            TextTable[0x2E] = 0xAD; // "."
            TextTable[0x2D] = 0xAE; // "-"
            TextTable[0xB7] = 0xAF; // "·"
            TextTable[0x22] = 0xB2; // """
            TextTable[0x27] = 0xB4; // "'"
            TextTable[0x2C] = 0xB8; // ","
            TextTable[0x2F] = 0xBA; // "/"
            TextTable[0x41] = 0xBB; // "A"
            TextTable[0x42] = 0xBC; // "B"
            TextTable[0x43] = 0xBD; // "C"
            TextTable[0x44] = 0xBE; // "D"
            TextTable[0x45] = 0xBF; // "E"
            TextTable[0x46] = 0xC0; // "F"
            TextTable[0x47] = 0xC1; // "G"
            TextTable[0x48] = 0xC2; // "H"
            TextTable[0x49] = 0xC3; // "I"
            TextTable[0x4A] = 0xC4; // "J"
            TextTable[0x4B] = 0xC5; // "K"
            TextTable[0x4C] = 0xC6; // "L"
            TextTable[0x4D] = 0xC7; // "M"
            TextTable[0x4E] = 0xC8; // "N"
            TextTable[0x4F] = 0xC9; // "O"
            TextTable[0x50] = 0xCA; // "P"
            TextTable[0x51] = 0xCB; // "Q"
            TextTable[0x52] = 0xCC; // "R"
            TextTable[0x53] = 0xCD; // "S"
            TextTable[0x54] = 0xCE; // "T"
            TextTable[0x55] = 0xCF; // "U"
            TextTable[0x56] = 0xD0; // "V"
            TextTable[0x57] = 0xD1; // "W"
            TextTable[0x58] = 0xD2; // "X"
            TextTable[0x59] = 0xD3; // "Y"
            TextTable[0x5A] = 0xD4; // "Z"
            TextTable[0x61] = 0xD5; // "a"
            TextTable[0x62] = 0xD6; // "b"
            TextTable[0x63] = 0xD7; // "c"
            TextTable[0x64] = 0xD8; // "d"
            TextTable[0x65] = 0xD9; // "e"
            TextTable[0x66] = 0xDA; // "f"
            TextTable[0x67] = 0xDB; // "g"
            TextTable[0x68] = 0xDC; // "h"
            TextTable[0x69] = 0xDD; // "i"
            TextTable[0x6A] = 0xDE; // "j"
            TextTable[0x6B] = 0xDF; // "k"
            TextTable[0x6C] = 0xE0; // "l"
            TextTable[0x6D] = 0xE1; // "m"
            TextTable[0x6E] = 0xE2; // "n"
            TextTable[0x6F] = 0xE3; // "o"
            TextTable[0x70] = 0xE4; // "p"
            TextTable[0x71] = 0xE5; // "q"
            TextTable[0x72] = 0xE6; // "r"
            TextTable[0x73] = 0xE7; // "s"
            TextTable[0x74] = 0xE8; // "t"
            TextTable[0x75] = 0xE9; // "u"
            TextTable[0x76] = 0xEA; // "v"
            TextTable[0x77] = 0xEB; // "w"
            TextTable[0x78] = 0xEC; // "x"
            TextTable[0x79] = 0xED; // "y"
            TextTable[0x7A] = 0xEE; // "z"
            TextTable[0x3A] = 0xF0; // ":"
            TextTable[0xC4] = 0xF1; // "Ä"
            TextTable[0xD6] = 0xF2; // "Ö"
            TextTable[0xDC] = 0xF3; // "Ü"
            TextTable[0xE4] = 0xF4; // "ä"
            TextTable[0xF6] = 0xF5; // "ö"
            TextTable[0xFC] = 0xF6; // "ü"

            AsciiReady = true;
        }

        public static string Sapp2Asc(byte[] sappString, int length)
        {
            StringBuilder SappBuilder = new StringBuilder();

            if (!SappReady)
                SappInit();

            for (int i = 0; i < length; i++)
                SappBuilder.Append(SappTable[sappString[i]]);

            return SappBuilder.ToString();
        }

        private static void SappInit()
        {
            SappTable = new string[256];
            for (int i = 0; i < 256; i++)
                SappTable[i] = "\\h" + i.ToString().PadLeft(2);

            SappTable[0x0] = " ";
            SappTable[0x1] = "À";
            SappTable[0x2] = "Á";
            SappTable[0x3] = "Â";
            SappTable[0x4] = "Ç";
            SappTable[0x5] = "È";
            SappTable[0x6] = "É";
            SappTable[0x7] = "Ê";
            SappTable[0x8] = "Ë";
            SappTable[0x9] = "Ì";
            SappTable[0xB] = "Î";
            SappTable[0xC] = "Ï";
            SappTable[0xD] = "Ò";
            SappTable[0xE] = "Ó";
            SappTable[0xF] = "Ô";
            SappTable[0x10] = "Œ";
            SappTable[0x11] = "Ù";
            SappTable[0x12] = "Ú";
            SappTable[0x13] = "Û";
            SappTable[0x14] = "Ñ";
            SappTable[0x15] = "ß";
            SappTable[0x16] = "à";
            SappTable[0x17] = "á";
            SappTable[0x19] = "ç";
            SappTable[0x1A] = "è";
            SappTable[0x1B] = "é";
            SappTable[0x1C] = "ê";
            SappTable[0x1D] = "ë";
            SappTable[0x1E] = "ì";
            SappTable[0x20] = "î";
            SappTable[0x21] = "ï";
            SappTable[0x22] = "ò";
            SappTable[0x23] = "ó";
            SappTable[0x24] = "ô";
            SappTable[0x25] = "œ";
            SappTable[0x26] = "ù";
            SappTable[0x27] = "ú";
            SappTable[0x28] = "û";
            SappTable[0x29] = "ñ";
            SappTable[0x2A] = "º";
            SappTable[0x2B] = "ª";
            SappTable[0x2D] = "&";
            SappTable[0x2E] = "+";
            SappTable[0x34] = "[Lv]";
            SappTable[0x35] = "=";
            SappTable[0x36] = ";";
            SappTable[0x51] = "¿";
            SappTable[0x52] = "¡";
            SappTable[0x53] = "[PK]";
            SappTable[0x54] = "[MN]";
            SappTable[0x55] = "PO";
            SappTable[0x56] = "Ké";
            SappTable[0x57] = "BL";
            SappTable[0x58] = "OC";
            SappTable[0x59] = "K";
            SappTable[0x5A] = "Í";
            SappTable[0x5B] = "%";
            SappTable[0x5C] = "(";
            SappTable[0x5D] = ")";
            SappTable[0x5E] = "[Po]";
            SappTable[0x5F] = "[Ké]";
            SappTable[0x60] = "[ME]";
            SappTable[0x61] = "[LL]";
            SappTable[0x62] = "[A]";
            SappTable[0x63] = "[E]";
            SappTable[0x68] = "â";
            SappTable[0x6F] = "í";
            SappTable[0x79] = "[U]";
            SappTable[0x7A] = "[D]";
            SappTable[0x7B] = "[L]";
            SappTable[0x7C] = "[R]";
            SappTable[0x85] = "<";
            SappTable[0x86] = ">";
            SappTable[0xA1] = "0";
            SappTable[0xA2] = "1";
            SappTable[0xA3] = "2";
            SappTable[0xA4] = "3";
            SappTable[0xA5] = "4";
            SappTable[0xA6] = "5";
            SappTable[0xA7] = "6";
            SappTable[0xA8] = "7";
            SappTable[0xA9] = "8";
            SappTable[0xAA] = "9";
            SappTable[0xAB] = "!";
            SappTable[0xAC] = "?";
            SappTable[0xAD] = ".";
            SappTable[0xAE] = "-";
            SappTable[0xAF] = "·";
            SappTable[0xB0] = "[.]";
            //SappTable[0xB1] = "[" & ChrW$(34) & "]";
            //SappTable[0xB2) = ChrW$(34);
            SappTable[0xB3] = "[']";
            SappTable[0xB4] = "'";
            SappTable[0xB5] = "[m]";
            SappTable[0xB6] = "[f]";
            SappTable[0xB7] = "[$]";
            SappTable[0xB8] = ",";
            SappTable[0xB9] = "[x]";
            SappTable[0xBA] = "/";
            SappTable[0xBB] = "A";
            SappTable[0xBC] = "B";
            SappTable[0xBD] = "C";
            SappTable[0xBE] = "D";
            SappTable[0xBF] = "E";
            SappTable[0xC0] = "F";
            SappTable[0xC1] = "G";
            SappTable[0xC2] = "H";
            SappTable[0xC3] = "I";
            SappTable[0xC4] = "J";
            SappTable[0xC5] = "K";
            SappTable[0xC6] = "L";
            SappTable[0xC7] = "M";
            SappTable[0xC8] = "N";
            SappTable[0xC9] = "O";
            SappTable[0xCA] = "P";
            SappTable[0xCB] = "Q";
            SappTable[0xCC] = "R";
            SappTable[0xCD] = "S";
            SappTable[0xCE] = "T";
            SappTable[0xCF] = "U";
            SappTable[0xD0] = "V";
            SappTable[0xD1] = "W";
            SappTable[0xD2] = "X";
            SappTable[0xD3] = "Y";
            SappTable[0xD4] = "Z";
            SappTable[0xD5] = "a";
            SappTable[0xD6] = "b";
            SappTable[0xD7] = "c";
            SappTable[0xD8] = "d";
            SappTable[0xD9] = "e";
            SappTable[0xDA] = "f";
            SappTable[0xDB] = "g";
            SappTable[0xDC] = "h";
            SappTable[0xDD] = "i";
            SappTable[0xDE] = "j";
            SappTable[0xDF] = "k";
            SappTable[0xE0] = "l";
            SappTable[0xE1] = "m";
            SappTable[0xE2] = "n";
            SappTable[0xE3] = "o";
            SappTable[0xE4] = "p";
            SappTable[0xE5] = "q";
            SappTable[0xE6] = "r";
            SappTable[0xE7] = "s";
            SappTable[0xE8] = "t";
            SappTable[0xE9] = "u";
            SappTable[0xEA] = "v";
            SappTable[0xEB] = "w";
            SappTable[0xEC] = "x";
            SappTable[0xED] = "y";
            SappTable[0xEE] = "z";
            SappTable[0xEF] = "[>]";
            SappTable[0xF0] = ":";
            SappTable[0xF1] = "Ä";
            SappTable[0xF2] = "Ö";
            SappTable[0xF3] = "Ü";
            SappTable[0xF4] = "ä";
            SappTable[0xF5] = "ö";
            SappTable[0xF6] = "ü";
            //SappTable[0xF7] = "[u]"
            //SappTable[0xF8] = "[d]"
            //SappTable[0xF9] = "[l]"
            SappTable[0xFA] = "\\l";
            SappTable[0xFB] = "\\p";
            SappTable[0xFC] = " "; // \c
            SappTable[0xFD] = "\\v";
            SappTable[0xFE] = "\\n";
            SappTable[0xFF] = "\0";

            SappReady = true;
        }
    }
}
