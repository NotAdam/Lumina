using System.IO;

// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBePrivate.Global
namespace Lumina.Data.Parsing.Uld
{
    public interface INode
    {
    }

    public static class NodeData
    {
        // https://www.reddit.com/r/FFXIVExplorers/comments/3z2wce/fonts_used_in_ffxiv/
        public enum FontType : byte
        {
            Axis = 0x0,
            MiedingerMed = 0x1,
            Miedinger = 0x2,
            TrumpGothic = 0x3,
            Jupiter = 0x4,
            JupiterLarge = 0x5,
        }

        // i guess this can be a ushort
        public enum CollisionType : ushort
        {
            Hit = 0x0,
            Focus = 0x1,
            Move = 0x2,
        }

        public enum GridPartsType : byte
        {
            Divide = 0x0,
            Compose = 0x1,
        }

        public enum GridRenderType : byte
        {
            Scale = 0x0,
            Tile = 0x1,
        }

        public enum SheetType : byte
        {
            Addon = 0x0,
            Lobby = 0x1,
        }

        public struct ImageNode : INode
        {
            // id of part list, id/num of part i think
            public uint PartListId;
            public uint PartId;
            public bool FlipH;
            public bool FlipV;
            public byte Wrap;
            public byte Unk1;

            public static ImageNode Read( BinaryReader br )
            {
                ImageNode ret = new ImageNode();
                ret.PartListId = br.ReadUInt32();
                ret.PartId = br.ReadUInt32();
                ret.FlipH = br.ReadBoolean();
                ret.FlipV = br.ReadBoolean();
                ret.Wrap = br.ReadByte();
                ret.Unk1 = br.ReadByte();
                return ret;
            }
        }

        public struct NineGridNode : INode
        {
            public uint PartListId;
            public uint PartId;
            public GridPartsType GridPartsType;
            public GridRenderType GridRenderType;
            public short TopOffset;
            public short BottomOffset;
            public short LeftOffset;
            public short RightOffset;
            public byte Unk1;
            public byte Unk2;

            public static NineGridNode Read( BinaryReader br )
            {
                NineGridNode ret = new NineGridNode();
                ret.PartListId = br.ReadUInt32();
                ret.PartId = br.ReadUInt32();
                ret.GridPartsType = (GridPartsType)br.ReadByte();
                ret.GridRenderType = (GridRenderType)br.ReadByte();
                ret.TopOffset = br.ReadInt16();
                ret.BottomOffset = br.ReadInt16();
                ret.LeftOffset = br.ReadInt16();
                ret.RightOffset = br.ReadInt16();
                ret.Unk1 = br.ReadByte();
                ret.Unk2 = br.ReadByte();
                return ret;
            }
        }

        public struct CounterNode : INode
        {
            public uint PartListId;
            public byte PartId;
            public byte NumberWidth;
            public byte CommaWidth;
            public byte SpaceWidth;
            public ushort Alignment;
            public ushort Unk1;

            public static CounterNode Read( BinaryReader br )
            {
                CounterNode ret = new CounterNode();
                ret.PartListId = br.ReadUInt32();
                ret.PartId = br.ReadByte();
                ret.NumberWidth = br.ReadByte();
                ret.CommaWidth = br.ReadByte();
                ret.SpaceWidth = br.ReadByte();
                ret.Alignment = br.ReadUInt16();
                ret.Unk1 = br.ReadUInt16();
                return ret;
            }
        }

        public struct TextNode : INode
        {
            public uint TextId;
            public uint Color;
            public ushort Alignment;
            public FontType Font;
            public byte FontSize;
            public uint EdgeColor;

            private byte field1;

            public bool Bold;
            public bool Italic;
            public bool Edge;
            public bool Glare;
            public bool Multiline;
            public bool Ellipsis;
            public bool Paragraph;
            public bool Emboss;

            public SheetType SheetType;
            public byte CharSpacing;
            public byte LineSpacing;

            public uint Unk2;

            public static TextNode Read( BinaryReader br )
            {
                TextNode ret = new TextNode();
                ret.TextId = br.ReadUInt32();
                ret.Color = br.ReadUInt32();
                ret.Alignment = br.ReadUInt16();
                ret.Font = (FontType)br.ReadByte();
                ret.FontSize = br.ReadByte();
                ret.EdgeColor = br.ReadUInt32();

                ret.field1 = br.ReadByte();

                ret.Bold = ( ret.field1 & 0x80 ) == 0x80;
                ret.Italic = ( ret.field1 & 0x40 ) == 0x40;
                ret.Edge = ( ret.field1 & 0x20 ) == 0x20;
                ret.Glare = ( ret.field1 & 0x10 ) == 0x10;
                ret.Multiline = ( ret.field1 & 0x08 ) == 0x08;
                ret.Ellipsis = ( ret.field1 & 0x04 ) == 0x04;
                ret.Paragraph = ( ret.field1 & 0x02 ) == 0x02;
                ret.Emboss = ( ret.field1 & 0x01 ) == 0x01;

                ret.SheetType = (SheetType)br.ReadByte();
                ret.CharSpacing = br.ReadByte();
                ret.LineSpacing = br.ReadByte();

                ret.Unk2 = br.ReadUInt32();
                return ret;
            }
        }

        public struct NumericInputNode : INode
        {
            public TextNode TextNode; //assuming this is an int (id) // don't know what i meant by this in 010
            public int Value;
            public int Max;
            public int Min;
            public uint FocusedColor;
            public int AddValue;
            public uint EndLetterId;

            private byte field1;

            public bool AllowFocus;
            public bool Comma;
            public byte Unk1;

            public byte[] Unk2;

            public static NumericInputNode Read( BinaryReader br )
            {
                NumericInputNode ret = new NumericInputNode();
                ret.TextNode = TextNode.Read( br );
                ret.Value = br.ReadInt32();
                ret.Max = br.ReadInt32();
                ret.Min = br.ReadInt32();
                ret.FocusedColor = br.ReadUInt32();
                ret.AddValue = br.ReadInt32();
                ret.EndLetterId = br.ReadUInt32();

                ret.field1 = br.ReadByte();

                ret.AllowFocus = ( ret.field1 & 0x80 ) == 0x80;
                ret.Comma = ( ret.field1 & 0x40 ) == 0x40;
                ret.Unk1 = (byte)( ret.field1 & 0x3F );

                ret.Unk2 = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct CollisionNode : INode
        {
            public CollisionType Type;
            public ushort Unk1;
            public int X;
            public int Y;
            public uint Radius;

            public static CollisionNode Read( BinaryReader br )
            {
                CollisionNode ret = new CollisionNode();
                ret.Type = (CollisionType)br.ReadUInt16();
                ret.Unk1 = br.ReadUInt16();
                ret.X = br.ReadInt32();
                ret.Y = br.ReadInt32();
                ret.Radius = br.ReadUInt32();
                return ret;
            }
        }

        public struct FocusNode : INode
        {
            public byte Index;
            public byte Up;
            public byte Down;
            public byte Left;
            public byte Right;
            public byte Cursor;

            private byte field1;

            public bool RepeatUp;
            public bool RepeatDown;
            public bool RepeatLeft;
            public bool RepeatRight;
            public byte Unk1;

            public byte Unk2;
            public short OffsetX;
            public short OffsetY;

            public static FocusNode Read( BinaryReader br )
            {
                FocusNode ret = new FocusNode();
                ret.Index = br.ReadByte();
                ret.Up = br.ReadByte();
                ret.Down = br.ReadByte();
                ret.Left = br.ReadByte();
                ret.Right = br.ReadByte();
                ret.Cursor = br.ReadByte();

                ret.field1 = br.ReadByte();

                ret.RepeatUp = ( ret.field1 & 0x80 ) == 0x80;
                ret.RepeatDown = ( ret.field1 & 0x40 ) == 0x40;
                ret.RepeatLeft = ( ret.field1 & 0x20 ) == 0x20;
                ret.RepeatRight = ( ret.field1 & 0x10 ) == 0x10;
                ret.Unk1 = (byte)( ret.field1 & 0x0F );

                ret.Unk2 = br.ReadByte();
                ret.OffsetX = br.ReadInt16();
                ret.OffsetY = br.ReadInt16();
                return ret;
            }
        }

        public struct TextInputNode : INode
        {
            public TextNode TextNode;
            public uint Color;
            public uint IMEColor;
            public uint MaxWidth;
            public uint MaxLine;
            public uint MaxSByte;
            public uint MaxChar;

            private byte field1;

            public bool Ufast;
            public bool Mask;
            public bool Phrase;
            public bool HistoryEnabled;
            public bool IMEEnabled;
            public bool EscapeClears;
            public bool CapsAllowed;
            public bool LowerAllowed;

            private byte field2;

            public bool NumbersAllowed;
            public bool SymbolsAllowed;
            public bool WordWrap;
            public bool Multi;
            public bool AutoMaxWidth;
            public byte Unk1;

            public ushort Charset;
            public char[] CharsetExtras;

            public static TextInputNode Read( BinaryReader br )
            {
                TextInputNode ret = new TextInputNode();
                ret.TextNode = TextNode.Read( br );
                ret.Color = br.ReadUInt32();
                ret.IMEColor = br.ReadUInt32();
                ret.MaxWidth = br.ReadUInt32();
                ret.MaxLine = br.ReadUInt32();
                ret.MaxSByte = br.ReadUInt32();
                ret.MaxChar = br.ReadUInt32();

                ret.field1 = br.ReadByte();

                ret.Ufast = ( ret.field1 & 0x80 ) == 0x80;
                ret.Mask = ( ret.field1 & 0x40 ) == 0x40;
                ret.Phrase = ( ret.field1 & 0x20 ) == 0x20;
                ret.HistoryEnabled = ( ret.field1 & 0x10 ) == 0x10;
                ret.IMEEnabled = ( ret.field1 & 0x08 ) == 0x08;
                ret.EscapeClears = ( ret.field1 & 0x04 ) == 0x04;
                ret.CapsAllowed = ( ret.field1 & 0x02 ) == 0x02;
                ret.LowerAllowed = ( ret.field1 & 0x01 ) == 0x01;

                ret.field2 = br.ReadByte();

                ret.NumbersAllowed = ( ret.field2 & 0x80 ) == 0x80;
                ret.SymbolsAllowed = ( ret.field2 & 0x40 ) == 0x40;
                ret.WordWrap = ( ret.field2 & 0x20 ) == 0x20;
                ret.Multi = ( ret.field2 & 0x10 ) == 0x10;
                ret.AutoMaxWidth = ( ret.field2 & 0x08 ) == 0x08;
                ret.Unk1 = (byte)( ret.field2 & 0x07 );

                ret.Charset = br.ReadUInt16();
                ret.CharsetExtras = br.ReadChars( 16 );
                return ret;
            }
        }

        public struct ComponentNode : INode
        {
            public byte Index;
            public byte Up;
            public byte Down;
            public byte Left;
            public byte Right;
            public byte Cursor;

            private byte field1;

            public bool RepeatUp;
            public bool RepeatDown;
            public bool RepeatLeft;
            public bool RepeatRight;
            public byte Unk1;

            public byte Unk2;
            public short OffsetX;
            public short OffsetY;

            public INode ComponentNodeData;

            public static ComponentNode Read( BinaryReader br, ComponentData.ComponentType parentType )
            {
                ComponentNode ret = new ComponentNode();
                ret.Index = br.ReadByte();
                ret.Up = br.ReadByte();
                ret.Down = br.ReadByte();
                ret.Left = br.ReadByte();
                ret.Right = br.ReadByte();
                ret.Cursor = br.ReadByte();

                ret.field1 = br.ReadByte();

                ret.RepeatUp = ( ret.field1 & 0x80 ) == 0x80;
                ret.RepeatDown = ( ret.field1 & 0x40 ) == 0x40;
                ret.RepeatLeft = ( ret.field1 & 0x20 ) == 0x20;
                ret.RepeatRight = ( ret.field1 & 0x10 ) == 0x10;
                ret.Unk1 = (byte)( ret.field1 & 0x0F );

                ret.Unk2 = br.ReadByte();
                ret.OffsetX = br.ReadInt16();
                ret.OffsetY = br.ReadInt16();

                // the commented types seem to not have extra data
                switch( parentType )
                {
                    case ComponentData.ComponentType.Button:
                        ret.ComponentNodeData = ButtonComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.Window:
                        ret.ComponentNodeData = WindowComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.CheckBox:
                        ret.ComponentNodeData = CheckBoxComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.RadioButton:
                        ret.ComponentNodeData = RadioButtonComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.Gauge:
                        ret.ComponentNodeData = GaugeComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.Slider:
                        ret.ComponentNodeData = SliderComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.TextInput:
                        ret.ComponentNodeData = TextInputComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.NumericInput:
                        ret.ComponentNodeData = NumericInputComponentNode.Read( br );
                        break;
                    case ComponentData.ComponentType.List:
                        ret.ComponentNodeData = ListComponentNode.Read( br );
                        break; //?
                    // case ComponentData.ComponentType.DropDown: ret.ComponentNodeData = DropDownComponentNode.Read( br ); break;
                    case ComponentData.ComponentType.Tabbed:
                        ret.ComponentNodeData = TabbedComponentNode.Read( br );
                        break;
                    // case ComponentData.ComponentType.TreeList: ret.ComponentNodeData = TreeListComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.ScrollBar: ret.ComponentNodeData = ScrollBarComponentNode.Read( br ); break;
                    case ComponentData.ComponentType.ListItem:
                        ret.ComponentNodeData = ListItemComponentNode.Read( br );
                        break;
                    // case ComponentData.ComponentType.Icon: ret.ComponentNodeData = IconComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.IconWithText: ret.ComponentNodeData = IconWithTextComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.DragDrop: ret.ComponentNodeData = DragDropComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.LeveCard: ret.ComponentNodeData = LeveCardComponentNode.Read( br ); break;
                    case ComponentData.ComponentType.NineGridText:
                        ret.ComponentNodeData = NineGridTextComponentNode.Read( br );
                        break;
                    // case ComponentData.ComponentType.Journal: ret.ComponentNodeData = JournalComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.Multipurpose: ret.ComponentNodeData = MultipurposeComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.Map: ret.ComponentNodeData = MapComponentNode.Read( br ); break;
                    // case ComponentData.ComponentType.Preview: ret.ComponentNodeData = PreviewComponentNode.Read( br ); break;
                    default:
                        // Console.WriteLine( $"No custom node for type {parentType}..." ); 
                        break;
                }

                return ret;
            }
        }

        public struct ButtonComponentNode : INode
        {
            public uint TextId;

            public static ButtonComponentNode Read( BinaryReader br )
            {
                ButtonComponentNode ret = new ButtonComponentNode();
                ret.TextId = br.ReadUInt32();
                return ret;
            }
        }

        public struct WindowComponentNode : INode
        {
            public uint TitleTextId;
            public uint SubtitleTextId;
            public bool CloseButton;
            public bool ConfigButton;
            public bool HelpButton;
            public bool Header;

            public static WindowComponentNode Read( BinaryReader br )
            {
                WindowComponentNode ret = new WindowComponentNode();
                ret.TitleTextId = br.ReadUInt32();
                ret.SubtitleTextId = br.ReadUInt32();
                ret.CloseButton = br.ReadBoolean();
                ret.ConfigButton = br.ReadBoolean();
                ret.HelpButton = br.ReadBoolean();
                ret.Header = br.ReadBoolean();
                return ret;
            }
        }

        public struct CheckBoxComponentNode : INode
        {
            public uint TextId;

            public static CheckBoxComponentNode Read( BinaryReader br )
            {
                CheckBoxComponentNode ret = new CheckBoxComponentNode();
                ret.TextId = br.ReadUInt32();
                return ret;
            }
        }

        public struct RadioButtonComponentNode : INode
        {
            public uint TextId;
            public uint GroupId;

            public static RadioButtonComponentNode Read( BinaryReader br )
            {
                RadioButtonComponentNode ret = new RadioButtonComponentNode();
                ret.TextId = br.ReadUInt32();
                ret.GroupId = br.ReadUInt32();
                return ret;
            }
        }

        public struct GaugeComponentNode : INode
        {
            public int Indicator;
            public int Min;
            public int Max;
            public int Value;

            public static GaugeComponentNode Read( BinaryReader br )
            {
                GaugeComponentNode ret = new GaugeComponentNode();
                ret.Indicator = br.ReadInt32();
                ret.Min = br.ReadInt32();
                ret.Max = br.ReadInt32();
                ret.Value = br.ReadInt32();
                return ret;
            }
        }

        public struct SliderComponentNode : INode
        {
            public int Min;
            public int Max;
            public int Step;

            public static SliderComponentNode Read( BinaryReader br )
            {
                SliderComponentNode ret = new SliderComponentNode();
                ret.Min = br.ReadInt32();
                ret.Max = br.ReadInt32();
                ret.Step = br.ReadInt32();
                return ret;
            }
        }

        public struct TextInputComponentNode : INode
        {
            public uint MaxWidth;
            public uint MaxLine;
            public uint MaxSByte;
            public uint MaxChar;

            private byte field1;

            public bool Capitalize;
            public bool Mask;
            public bool AutoTranslateEnabled;
            public bool HistoryEnabled;
            public bool IMEEnabled;
            public bool EscapeClears;
            public bool CapsAllowed;
            public bool LowerAllowed;

            private byte field2;

            public bool NumbersAllowed;
            public bool SymbolsAllowed;
            public bool WordWrap;
            public bool Multiline;
            public bool AutoMaxWidth;
            public byte Unk1;

            public ushort Charset;
            public char[] CharsetExtras;

            public static TextInputComponentNode Read( BinaryReader br )
            {
                TextInputComponentNode ret = new TextInputComponentNode();
                ret.MaxWidth = br.ReadUInt32();
                ret.MaxLine = br.ReadUInt32();
                ret.MaxSByte = br.ReadUInt32();
                ret.MaxChar = br.ReadUInt32();

                ret.field1 = br.ReadByte();

                ret.Capitalize = ( ret.field1 & 0x80 ) == 0x80;
                ret.Mask = ( ret.field1 & 0x40 ) == 0x40;
                ret.AutoTranslateEnabled = ( ret.field1 & 0x20 ) == 0x20;
                ret.HistoryEnabled = ( ret.field1 & 0x10 ) == 0x10;
                ret.IMEEnabled = ( ret.field1 & 0x08 ) == 0x08;
                ret.EscapeClears = ( ret.field1 & 0x04 ) == 0x04;
                ret.CapsAllowed = ( ret.field1 & 0x02 ) == 0x02;
                ret.LowerAllowed = ( ret.field1 & 0x01 ) == 0x01;

                ret.field2 = br.ReadByte();

                ret.NumbersAllowed = ( ret.field1 & 0x80 ) == 0x80;
                ret.SymbolsAllowed = ( ret.field2 & 0x40 ) == 0x40;
                ret.WordWrap = ( ret.field2 & 0x20 ) == 0x20;
                ret.Multiline = ( ret.field2 & 0x10 ) == 0x10;
                ret.AutoMaxWidth = ( ret.field2 & 0x08 ) == 0x08;
                ret.Unk1 = (byte)( ret.field2 & 0x07 );

                ret.Charset = br.ReadUInt16();
                ret.CharsetExtras = br.ReadChars( 16 );
                return ret;
            }
        }

        public struct NumericInputComponentNode : INode
        {
            public int Value;
            public int Max;
            public int Min;
            public int Add;
            public uint Unk1;
            public bool Comma;
            public byte[] Unk2;

            public static NumericInputComponentNode Read( BinaryReader br )
            {
                NumericInputComponentNode ret = new NumericInputComponentNode();
                ret.Value = br.ReadInt32();
                ret.Max = br.ReadInt32();
                ret.Min = br.ReadInt32();
                ret.Add = br.ReadInt32();
                ret.Unk1 = br.ReadUInt32();
                ret.Comma = br.ReadBoolean();
                ret.Unk2 = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct ListComponentNode : INode
        {
            public ushort RowNum;
            public ushort ColumnNum;

            public static ListComponentNode Read( BinaryReader br )
            {
                ListComponentNode ret = new ListComponentNode();
                ret.RowNum = br.ReadUInt16();
                ret.ColumnNum = br.ReadUInt16();
                return ret;
            }
        }

        public struct TabbedComponentNode : INode
        {
            public uint TextId;
            public uint GroupId;

            public static TabbedComponentNode Read( BinaryReader br )
            {
                TabbedComponentNode ret = new TabbedComponentNode();
                ret.TextId = br.ReadUInt32();
                ret.GroupId = br.ReadUInt32();
                return ret;
            }
        }

        public struct ListItemComponentNode : INode
        {
            public bool Toggle;
            public byte[] Unk1;

            public static ListItemComponentNode Read( BinaryReader br )
            {
                ListItemComponentNode ret = new ListItemComponentNode();
                ret.Toggle = br.ReadBoolean();
                ret.Unk1 = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct NineGridTextComponentNode : INode
        {
            uint TextId;

            public static NineGridTextComponentNode Read( BinaryReader br )
            {
                NineGridTextComponentNode ret = new NineGridTextComponentNode();
                ret.TextId = br.ReadUInt32();
                return ret;
            }
        }
    }
}