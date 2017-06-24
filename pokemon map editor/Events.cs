using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace PokemonMapEditor
{
    public static class MapEvents
    {
        public static void Load(ROM game, Map map)
        {
            List<Person> People = new List<Person>();
            BinaryReader ReadROM = new BinaryReader(File.Open(game.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ReadROM.BaseStream.Position = map.EventData - 0x8000000;
            map.PersonCount = ReadROM.ReadByte();
            map.WarpCount = ReadROM.ReadByte();
            map.ScriptCount = ReadROM.ReadByte();
            map.SignpostCount = ReadROM.ReadByte();
            map.PersonData = ReadROM.ReadUInt32();
            map.WarpData = ReadROM.ReadUInt32();
            map.ScriptData = ReadROM.ReadUInt32();
            map.SignPostData = ReadROM.ReadUInt32();

            // Read people
            ReadROM.BaseStream.Position = map.PersonData - 0x8000000;
            for (int i = 0; i < map.PersonCount; i++)
            {
                Person p = new Person();

                p.PersonIndex = ReadROM.ReadByte();
                p.SpriteIndex = ReadROM.ReadByte();
                p.Filler = ReadROM.ReadUInt16();
                p.X = ReadROM.ReadUInt16();
                p.Y = ReadROM.ReadUInt16();
                p.Height = ReadROM.ReadByte();
                p.MovementType = ReadROM.ReadByte();
                p.Unknown = ReadROM.ReadByte();
                p.FillerByte = ReadROM.ReadByte();
                p.IsTrainer = ReadROM.ReadByte();
                p.FillerByte2 = ReadROM.ReadByte();
                p.ViewRange = ReadROM.ReadUInt16();
                p.Script = ReadROM.ReadUInt32();
                p.Flag = ReadROM.ReadUInt16();
                p.Filler2 = ReadROM.ReadUInt16();

                People.Add(p);
            }

            map.People = People.ToArray();

            ReadROM.Close();
        }
    }

    public class Person
    {
        [DisplayName("Person Index"), Description("The event number of this event."), Category("Properties")]
        public byte PersonIndex { get; set; }
        [DisplayName("Sprite Index"), Description("The sprite that is used by this event."), Category("Appearance")]
        public byte SpriteIndex { get; set; }
        [Description("Filler data that is unused."), Category("Unused")]
        public ushort Filler { get; set; }
        [Description("The x-coordinate of this event."), Category("Layout"), TypeConverter(typeof(HEXConverter16))]
        public ushort X { get; set; }
        [Description("The y-coordinate of this event."), Category("Layout"), TypeConverter(typeof(HEXConverter16))]
        public ushort Y { get; set; }
        [Description("The height level this event is on."), Category("Properties")]
        public byte Height { get; set; }
        [DisplayName("Movement Type"), Description("The type of movement this event does."), Category("Properties"), TypeConverter(typeof(MovementConverter))]
        public byte MovementType { get; set; }
        [Description("Currently unknown as to what this does."), Category("Properties")]
        public byte Unknown { get; set; }
        [Description("Filler data that is unused."), Category("Unused")]
        public byte FillerByte { get; set; }
        [DisplayName("Is Trainer"), Description("Indicates whether this event is a trainer."), Category("Properties")]
        public byte IsTrainer { get; set; }
        [Description("Filler data that is unused."), Category("Unused")]
        public byte FillerByte2 { get; set; }
        [DisplayName("View Range"), Description("The view range this event has if it is a trainer."), Category("Properties")]
        public ushort ViewRange { get; set; }
        [Description("The offset pointing to a script."), Category("Properties"), TypeConverter(typeof(HEXConverter32))]
        public uint Script { get; set; }
        [Description("The flag that is used by this event."), Category("Properties"), TypeConverter(typeof(HEXConverter16))]
        public ushort Flag { get; set; }
        [Description("Filler data that is unused."), Category("Unused")]
        public ushort Filler2 { get; set; }
    }

    public class HEXConverter16 : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            else
                return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            else
                return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
                return string.Format("0x{0:X4}", value);
            else
                return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value.GetType() == typeof(string))
            {
                string input = (string)value;

                if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                {
                    input = input.Substring(2);
                }

                return UInt16.Parse(input, System.Globalization.NumberStyles.HexNumber, culture);
            }
            else
                return base.ConvertFrom(context, culture, value);
        }
    }

    public class HEXConverter32 : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            else
                return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            else
                return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
                return string.Format("0x{0:X8}", value);
            else
                return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value.GetType() == typeof(string))
            {
                string input = (string)value;

                if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                {
                    input = input.Substring(2);
                }

                return UInt32.Parse(input, System.Globalization.NumberStyles.HexNumber, culture);
            }
            else
                return base.ConvertFrom(context, culture, value);
        }

    }

    public class MovementConverter : TypeConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new string[]{"No Movement", 
                                                     "Look around", 
                                                     "Walk around"});
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }
    }
}
