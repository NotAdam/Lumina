// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable MemberCanBePrivate.Global
namespace Lumina.Data.Parsing.Uld
{
    public interface IComponent
    {
    }

    public static class ComponentData
    {
        public enum ComponentType : byte
        {
            Custom = 0x0,
            Button = 0x1,
            Window = 0x2,
            CheckBox = 0x3,
            RadioButton = 0x4,
            Gauge = 0x5,
            Slider = 0x6,
            TextInput = 0x7,
            NumericInput = 0x8,
            List = 0x9, //?
            DropDown = 0xA,
            Tabbed = 0xB,
            TreeList = 0xC,
            ScrollBar = 0xD,
            ListItem = 0xE,
            Icon = 0xF,
            IconWithText = 0x10,
            DragDrop = 0x11,
            LeveCard = 0x12,
            NineGridText = 0x13,
            Journal = 0x14,
            Multipurpose = 0x15,
            Map = 0x16,
            Preview = 0x17,
        }

        public struct ButtonComponent : IComponent
        {
            public uint[] Data;

            public static ButtonComponent Read( LuminaBinaryReader br )
            {
                ButtonComponent ret = new ButtonComponent();
                ret.Data = br.ReadUInt32s( 2 );
                return ret;
            }
        }

        public struct WindowComponent : IComponent
        {
            public uint[] Data;

            public static WindowComponent Read( LuminaBinaryReader br )
            {
                WindowComponent ret = new WindowComponent();
                ret.Data = br.ReadUInt32s( 8 );
                return ret;
            }
        }

        public struct CheckBoxComponent : IComponent
        {
            public uint[] Data;

            public static CheckBoxComponent Read( LuminaBinaryReader br )
            {
                CheckBoxComponent ret = new CheckBoxComponent();
                ret.Data = br.ReadUInt32s( 3 );
                return ret;
            }
        }

        public struct RadioButtonComponent : IComponent
        {
            public uint[] Data;

            public static RadioButtonComponent Read( LuminaBinaryReader br )
            {
                RadioButtonComponent ret = new RadioButtonComponent();
                ret.Data = br.ReadUInt32s( 4 );
                return ret;
            }
        }

        public struct GaugeComponent : IComponent
        {
            public uint[] Data;
            public ushort VerticalMargin;
            public ushort HorizontalMargin;
            public bool IsVertical;
            public byte[] Padding;

            public static GaugeComponent Read( LuminaBinaryReader br )
            {
                GaugeComponent ret = new GaugeComponent();
                ret.Data = br.ReadUInt32s( 6 );
                ret.VerticalMargin = br.ReadUInt16();
                ret.HorizontalMargin = br.ReadUInt16();
                ret.IsVertical = br.ReadBoolean();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct SliderComponent : IComponent
        {
            public uint[] Data;
            public bool IsVertical;
            public byte LeftOffset;
            public byte RightOffset;
            public sbyte Padding;

            public static SliderComponent Read( LuminaBinaryReader br )
            {
                SliderComponent ret = new SliderComponent();
                ret.Data = br.ReadUInt32s( 4 );
                ret.IsVertical = br.ReadBoolean();
                ret.LeftOffset = br.ReadByte();
                ret.RightOffset = br.ReadByte();
                ret.Padding = br.ReadSByte();
                return ret;
            }
        }

        public struct TextInputComponent : IComponent
        {
            public uint[] Data;
            public uint Color;
            public uint IMEColor;

            public static TextInputComponent Read( LuminaBinaryReader br )
            {
                TextInputComponent ret = new TextInputComponent();
                ret.Data = br.ReadUInt32s( 16 );
                ret.Color = br.ReadUInt32();
                ret.IMEColor = br.ReadUInt32();
                return ret;
            }
        }

        public struct NumericInputComponent : IComponent
        {
            public uint[] Data;
            public uint Color;

            public static NumericInputComponent Read( LuminaBinaryReader br )
            {
                NumericInputComponent ret = new NumericInputComponent();
                ret.Data = br.ReadUInt32s( 5 );
                ret.Color = br.ReadUInt32();
                return ret;
            }
        }

        public struct ListComponent : IComponent
        {
            public uint[] Data;
            public byte Wrap;
            public byte Orientation;
            public byte[] Padding;

            public static ListComponent Read( LuminaBinaryReader br )
            {
                ListComponent ret = new ListComponent();
                ret.Data = br.ReadUInt32s( 5 );
                ret.Wrap = br.ReadByte();
                ret.Orientation = br.ReadByte();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct DropDownComponent : IComponent
        {
            public uint[] Data;

            public static DropDownComponent Read( LuminaBinaryReader br )
            {
                DropDownComponent ret = new DropDownComponent();
                ret.Data = br.ReadUInt32s( 2 );
                return ret;
            }
        }

        public struct TabComponent : IComponent
        {
            public uint[] Data;

            public static TabComponent Read( LuminaBinaryReader br )
            {
                TabComponent ret = new TabComponent();
                ret.Data = br.ReadUInt32s( 4 );
                return ret;
            }
        }

        public struct TreeListComponent : IComponent
        {
            public uint[] Data;
            public byte Wrap;
            public byte Orientation;
            public byte[] Padding;

            public static TreeListComponent Read( LuminaBinaryReader br )
            {
                TreeListComponent ret = new TreeListComponent();
                ret.Data = br.ReadUInt32s( 5 );
                ret.Wrap = br.ReadByte();
                ret.Orientation = br.ReadByte();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct ScrollBarComponent : IComponent
        {
            public uint[] Data;
            public ushort Margin;
            public bool IsVertical;
            public sbyte Padding;

            public static ScrollBarComponent Read( LuminaBinaryReader br )
            {
                ScrollBarComponent ret = new ScrollBarComponent();
                ret.Data = br.ReadUInt32s( 4 );
                ret.Margin = br.ReadUInt16();
                ret.IsVertical = br.ReadBoolean();
                ret.Padding = br.ReadSByte();
                return ret;
            }
        }

        public struct ListItemComponent : IComponent
        {
            public uint[] Data;

            public static ListItemComponent Read( LuminaBinaryReader br )
            {
                ListItemComponent ret = new ListItemComponent();
                ret.Data = br.ReadUInt32s( 4 );
                return ret;
            }
        }

        public struct IconComponent : IComponent
        {
            public uint[] Data;

            public static IconComponent Read( LuminaBinaryReader br )
            {
                IconComponent ret = new IconComponent();
                ret.Data = br.ReadUInt32s( 8 );
                return ret;
            }
        }

        public struct IconWithTextComponent : IComponent
        {
            public uint[] Data;

            public static IconWithTextComponent Read( LuminaBinaryReader br )
            {
                IconWithTextComponent ret = new IconWithTextComponent();
                ret.Data = br.ReadUInt32s( 2 );
                return ret;
            }
        }

        public struct DragDropComponent : IComponent
        {
            public uint[] Data;

            public static DragDropComponent Read( LuminaBinaryReader br )
            {
                DragDropComponent ret = new DragDropComponent();
                ret.Data = br.ReadUInt32s( 1 );
                return ret;
            }
        }

        public struct LeveCardComponent : IComponent
        {
            public uint[] Data;

            public static LeveCardComponent Read( LuminaBinaryReader br )
            {
                LeveCardComponent ret = new LeveCardComponent();
                ret.Data = br.ReadUInt32s( 3 );
                return ret;
            }
        }

        public struct NineGridComponent : IComponent
        {
            public uint[] Data;

            public static NineGridComponent Read( LuminaBinaryReader br )
            {
                NineGridComponent ret = new NineGridComponent();
                ret.Data = br.ReadUInt32s( 2 );
                return ret;
            }
        }

        public struct JournalComponent : IComponent
        {
            public uint[] Data;
            public ushort Margin;
            public ushort Unk1;
            public ushort Unk2;
            public ushort Padding;

            public static JournalComponent Read( LuminaBinaryReader br )
            {
                JournalComponent ret = new JournalComponent();
                ret.Data = br.ReadUInt32s( 32 );
                ret.Margin = br.ReadUInt16();
                ret.Unk1 = br.ReadUInt16();
                ret.Unk2 = br.ReadUInt16();
                ret.Padding = br.ReadUInt16();
                return ret;
            }
        }

        public struct MultipurposeComponent : IComponent
        {
            public uint[] Data;

            public static MultipurposeComponent Read( LuminaBinaryReader br )
            {
                MultipurposeComponent ret = new MultipurposeComponent();
                ret.Data = br.ReadUInt32s( 3 );
                return ret;
            }
        }

        public struct MapComponent : IComponent
        {
            public uint[] Data;

            public static MapComponent Read( LuminaBinaryReader br )
            {
                MapComponent ret = new MapComponent();
                ret.Data = br.ReadUInt32s( 10 );
                return ret;
            }
        }

        public struct PreviewComponent : IComponent
        {
            public uint[] Data;

            public static PreviewComponent Read( LuminaBinaryReader br )
            {
                PreviewComponent ret = new PreviewComponent();
                ret.Data = br.ReadUInt32s( 2 );
                return ret;
            }
        }
    }
}