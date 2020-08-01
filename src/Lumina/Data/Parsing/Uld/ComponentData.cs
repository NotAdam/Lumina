using System;
using System.IO;
using Lumina.Extensions;

// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable MemberCanBePrivate.Global
namespace Lumina.Data.Parsing.Uld {
    public interface IComponent { }

    public static class ComponentData {
        public enum ComponentType : byte {
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

        public struct ButtonComponent : IComponent {
            public uint[] Data;

            public static ButtonComponent Read( BinaryReader br ) {
                ButtonComponent ret = new ButtonComponent();
                ret.Data = br.ReadStructures< UInt32 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct WindowComponent : IComponent {
            public uint[] Data;

            public static WindowComponent Read( BinaryReader br ) {
                WindowComponent ret = new WindowComponent();
                ret.Data = br.ReadStructures< UInt32 >( 8 ).ToArray();
                return ret;
            }
        }

        public struct CheckBoxComponent : IComponent {
            public uint[] Data;

            public static CheckBoxComponent Read( BinaryReader br ) {
                CheckBoxComponent ret = new CheckBoxComponent();
                ret.Data = br.ReadStructures< UInt32 >( 3 ).ToArray();
                return ret;
            }
        }

        public struct RadioButtonComponent : IComponent {
            public uint[] Data;

            public static RadioButtonComponent Read( BinaryReader br ) {
                RadioButtonComponent ret = new RadioButtonComponent();
                ret.Data = br.ReadStructures< UInt32 >( 4 ).ToArray();
                return ret;
            }
        }

        public struct GaugeComponent : IComponent {
            public uint[] Data;
            public ushort VerticalMargin;
            public ushort HorizontalMargin;
            public bool IsVertical;
            public byte[] Padding;

            public static GaugeComponent Read( BinaryReader br ) {
                GaugeComponent ret = new GaugeComponent();
                ret.Data = br.ReadStructures< UInt32 >( 6 ).ToArray();
                ret.VerticalMargin = br.ReadUInt16();
                ret.HorizontalMargin = br.ReadUInt16();
                ret.IsVertical = br.ReadBoolean();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct SliderComponent : IComponent {
            public uint[] Data;
            public bool IsVertical;
            public byte LeftOffset;
            public byte RightOffset;
            public sbyte Padding;

            public static SliderComponent Read( BinaryReader br ) {
                SliderComponent ret = new SliderComponent();
                ret.Data = br.ReadStructures< UInt32 >( 4 ).ToArray();
                ret.IsVertical = br.ReadBoolean();
                ret.LeftOffset = br.ReadByte();
                ret.RightOffset = br.ReadByte();
                ret.Padding = br.ReadSByte();
                return ret;
            }
        }

        public struct TextInputComponent : IComponent {
            public uint[] Data;
            public uint Color;
            public uint IMEColor;

            public static TextInputComponent Read( BinaryReader br ) {
                TextInputComponent ret = new TextInputComponent();
                ret.Data = br.ReadStructures< UInt32 >( 16 ).ToArray();
                ret.Color = br.ReadUInt32();
                ret.IMEColor = br.ReadUInt32();
                return ret;
            }
        }

        public struct NumericInputComponent : IComponent {
            public uint[] Data;
            public uint Color;

            public static NumericInputComponent Read( BinaryReader br ) {
                NumericInputComponent ret = new NumericInputComponent();
                ret.Data = br.ReadStructures< UInt32 >( 5 ).ToArray();
                ret.Color = br.ReadUInt32();
                return ret;
            }
        }

        public struct ListComponent : IComponent {
            public uint[] Data;
            public byte Wrap;
            public byte Orientation;
            public byte[] Padding;

            public static ListComponent Read( BinaryReader br ) {
                ListComponent ret = new ListComponent();
                ret.Data = br.ReadStructures< UInt32 >( 5 ).ToArray();
                ret.Wrap = br.ReadByte();
                ret.Orientation = br.ReadByte();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct DropDownComponent : IComponent {
            public uint[] Data;

            public static DropDownComponent Read( BinaryReader br ) {
                DropDownComponent ret = new DropDownComponent();
                ret.Data = br.ReadStructures< UInt32 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct TabComponent : IComponent {
            public uint[] Data;

            public static TabComponent Read( BinaryReader br ) {
                TabComponent ret = new TabComponent();
                ret.Data = br.ReadStructures< UInt32 >( 4 ).ToArray();
                return ret;
            }
        }

        public struct TreeListComponent : IComponent {
            public uint[] Data;
            public byte Wrap;
            public byte Orientation;
            public byte[] Padding;

            public static TreeListComponent Read( BinaryReader br ) {
                TreeListComponent ret = new TreeListComponent();
                ret.Data = br.ReadStructures< UInt32 >( 5 ).ToArray();
                ret.Wrap = br.ReadByte();
                ret.Orientation = br.ReadByte();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct ScrollBarComponent : IComponent {
            public uint[] Data;
            public ushort Margin;
            public bool IsVertical;
            public sbyte Padding;

            public static ScrollBarComponent Read( BinaryReader br ) {
                ScrollBarComponent ret = new ScrollBarComponent();
                ret.Data = br.ReadStructures< UInt32 >( 4 ).ToArray();
                ret.Margin = br.ReadUInt16();
                ret.IsVertical = br.ReadBoolean();
                ret.Padding = br.ReadSByte();
                return ret;
            }
        }

        public struct ListItemComponent : IComponent {
            public uint[] Data;

            public static ListItemComponent Read( BinaryReader br ) {
                ListItemComponent ret = new ListItemComponent();
                ret.Data = br.ReadStructures< UInt32 >( 4 ).ToArray();
                return ret;
            }
        }

        public struct IconComponent : IComponent {
            public uint[] Data;

            public static IconComponent Read( BinaryReader br ) {
                IconComponent ret = new IconComponent();
                ret.Data = br.ReadStructures< UInt32 >( 8 ).ToArray();
                return ret;
            }
        }

        public struct IconWithTextComponent : IComponent {
            public uint[] Data;

            public static IconWithTextComponent Read( BinaryReader br ) {
                IconWithTextComponent ret = new IconWithTextComponent();
                ret.Data = br.ReadStructures< UInt32 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct DragDropComponent : IComponent {
            public uint[] Data;

            public static DragDropComponent Read( BinaryReader br ) {
                DragDropComponent ret = new DragDropComponent();
                ret.Data = br.ReadStructures< UInt32 >( 1 ).ToArray();
                return ret;
            }
        }

        public struct LeveCardComponent : IComponent {
            public uint[] Data;

            public static LeveCardComponent Read( BinaryReader br ) {
                LeveCardComponent ret = new LeveCardComponent();
                ret.Data = br.ReadStructures< UInt32 >( 3 ).ToArray();
                return ret;
            }
        }

        public struct NineGridComponent : IComponent {
            public uint[] Data;

            public static NineGridComponent Read( BinaryReader br ) {
                NineGridComponent ret = new NineGridComponent();
                ret.Data = br.ReadStructures< UInt32 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct JournalComponent : IComponent {
            public uint[] Data;
            public ushort Margin;
            public ushort Unk1;
            public ushort Unk2;
            public ushort Padding;

            public static JournalComponent Read( BinaryReader br ) {
                JournalComponent ret = new JournalComponent();
                ret.Data = br.ReadStructures< UInt32 >( 32 ).ToArray();
                ret.Margin = br.ReadUInt16();
                ret.Unk1 = br.ReadUInt16();
                ret.Unk2 = br.ReadUInt16();
                ret.Padding = br.ReadUInt16();
                return ret;
            }
        }

        public struct MultipurposeComponent : IComponent {
            public uint[] Data;

            public static MultipurposeComponent Read( BinaryReader br ) {
                MultipurposeComponent ret = new MultipurposeComponent();
                ret.Data = br.ReadStructures< UInt32 >( 3 ).ToArray();
                return ret;
            }
        }

        public struct MapComponent : IComponent {
            public uint[] Data;

            public static MapComponent Read( BinaryReader br ) {
                MapComponent ret = new MapComponent();
                ret.Data = br.ReadStructures< UInt32 >( 10 ).ToArray();
                return ret;
            }
        }

        public struct PreviewComponent : IComponent {
            public uint[] Data;

            public static PreviewComponent Read( BinaryReader br ) {
                PreviewComponent ret = new PreviewComponent();
                ret.Data = br.ReadStructures< UInt32 >( 2 ).ToArray();
                return ret;
            }
        }
    }
}