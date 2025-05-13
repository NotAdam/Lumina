using System.Linq;

// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBePrivate.Global
namespace Lumina.Data.Parsing.Uld
{
    /// <summary>
    /// Contains the root structures for a Uld file, to prevent clogging up UldFile.cs
    /// </summary>
    public static class UldRoot
    {
        public enum AlignmentType : byte
        {
            TopLeft = 0x0,
            Top = 0x1,
            TopRight = 0x2,
            Left = 0x3,
            Center = 0x4,
            Right = 0x5,
            BottomLeft = 0x6,
            Bottom = 0x7,
            BottomRight = 0x8,
        }

        public enum KeyGroupType : ushort
        {
            Float1 = 0x0,
            Float2 = 0x1,
            Float3 = 0x2,
            SByte1 = 0x3,
            SByte2 = 0x4,
            SByte3 = 0x5,
            Byte1 = 0x6,
            Byte2 = 0x7,
            Byte3 = 0x8,
            Short1 = 0x9,
            Short2 = 0xA,
            Short3 = 0xB,
            UShort1 = 0xC,
            UShort2 = 0xD,
            UShort3 = 0xE,
            Int1 = 0xF,
            Int2 = 0x10,
            Int3 = 0x11,
            UInt1 = 0x12,
            UInt2 = 0x13,
            UInt3 = 0x14,
            Bool1 = 0x15,
            Bool2 = 0x16,
            Bool3 = 0x17,
            Color = 0x18,
            Label = 0x19,
            Number = 0x1A,
        }

        public enum KeyUsage : ushort
        {
            Position = 0x0,
            Rotation = 0x1,
            Scale = 0x2,
            Alpha = 0x3,
            NodeColor = 0x4,
            TextColor = 0x5,
            EdgeColor = 0x6,
            Number = 0x7,
        }

        public struct UldHeader
        {
            public char[] Identifier;
            public char[] Version;
            public uint ComponentOffset;
            public uint WidgetOffset;

            public static UldHeader Read( LuminaBinaryReader br )
            {
                UldHeader ret = new UldHeader();
                ret.Identifier = br.ReadChars( 4 );
                ret.Version = br.ReadChars( 4 );
                ret.ComponentOffset = br.ReadUInt32();
                ret.WidgetOffset = br.ReadUInt32();
                return ret;
            }
        }

        public struct AtkHeader
        {
            public char[] Identifier;
            public char[] Version;

            // these are offsets to ashd, tphd, cohd, etc
            public uint AssetListOffset;
            public uint PartListOffset;
            public uint ComponentListOffset;
            public uint TimelineListOffset;
            public uint WidgetOffset;
            public uint RewriteDataOffset; //dunno what this is exactly
            public uint TimelineListSize;

            public static AtkHeader Read( LuminaBinaryReader br )
            {
                AtkHeader ret = new AtkHeader();
                ret.Identifier = br.ReadChars( 4 );
                ret.Version = br.ReadChars( 4 );
                ret.AssetListOffset = br.ReadUInt32();
                ret.PartListOffset = br.ReadUInt32();
                ret.ComponentListOffset = br.ReadUInt32();
                ret.TimelineListOffset = br.ReadUInt32();
                ret.WidgetOffset = br.ReadUInt32();
                ret.RewriteDataOffset = br.ReadUInt32();
                ret.TimelineListSize = br.ReadUInt32();
                return ret;
            }
        }

        public struct TextureEntry
        {
            public uint Id;
            public char[] Path; // 44? wtf?
            public uint IconId;
            public byte ThemeSupportBitmask; // Only used when WidgetData.AssetsHaveThemeSupport is true. Example: 4 (0b100) means it's only available in fourth/, while 7 (0b111) means it's available in light/, third/ and fourth/

            public static TextureEntry Read( LuminaBinaryReader br, uint version )
            {
                TextureEntry ret = new TextureEntry();
                ret.Id = br.ReadUInt32();
                ret.Path = br.ReadChars( 44 );
                ret.IconId = br.ReadUInt32();
                if ( version >= 100 )
                {
                    ret.ThemeSupportBitmask = br.ReadByte();
                    br.BaseStream.Position += 3;
                }
                else
                {
                    ret.ThemeSupportBitmask = 0;
                }
                return ret;
            }
        }


        public struct PartHeader
        {
            public char[] Identifier;
            public char[] Version;
            public uint ElementCount; // this lists kinda arbitrary things (cohd, ashd etc) so they are elements
            public int Unk1;

            public static PartHeader Read( LuminaBinaryReader br )
            {
                PartHeader ret = new PartHeader();
                ret.Identifier = br.ReadChars( 4 );
                ret.Version = br.ReadChars( 4 );
                ret.ElementCount = br.ReadUInt32();
                ret.Unk1 = br.ReadInt32();
                return ret;
            }
        }

        public struct PartsData
        {
            public uint Id;
            public uint PartCount;

            // a lot of these have like, offset to next element
            public uint Offset;

            public PartData[] Parts;

            public static PartsData Read( LuminaBinaryReader br )
            {
                PartsData ret = new PartsData();
                ret.Id = br.ReadUInt32();
                ret.PartCount = br.ReadUInt32();
                ret.Offset = br.ReadUInt32();
                ret.Parts = new PartData[ret.PartCount];
                for( int i = 0; i < ret.PartCount; i++ )
                    ret.Parts[ i ] = PartData.Read( br );
                return ret;
            }
        }

        public struct PartData
        {
            public uint TextureId;
            public ushort U;
            public ushort V;
            public ushort W;
            public ushort H;

            public static PartData Read( LuminaBinaryReader br )
            {
                PartData ret = new PartData();
                ret.TextureId = br.ReadUInt32();
                ret.U = br.ReadUInt16();
                ret.V = br.ReadUInt16();
                ret.W = br.ReadUInt16();
                ret.H = br.ReadUInt16();
                return ret;
            }
        }

        public struct NodeData
        {
            public uint NodeId;
            public int ParentId;
            public int NextSiblingId;
            public int PrevSiblingId;

            public int ChildNodeId;

            public int NodeType;
            public ushort NodeOffset;
            public short TabIndex;
            public int[] Unk1;
            public short X;
            public short Y;
            public ushort W;
            public ushort H;
            public float Rotation;
            public float ScaleX;
            public float ScaleY;
            public short OriginX;
            public short OriginY;
            public ushort Priority;

            public byte field1;

            // not sure on the order here, or any bitfield due to c#
            public bool Visible;
            public bool Enabled;
            public bool Clip;
            public bool Fill;
            public bool AnchorTop;
            public bool AnchorBottom;
            public bool AnchorLeft;
            public bool AnchorRight;

            public byte Unk2;

            public short MultiplyRed;
            public short MultiplyGreen;
            public short MultiplyBlue;
            public short AddRed;
            public short AddGreen;
            public short AddBlue;
            public byte Alpha;
            public byte ClipCount;

            public ushort TimelineId;

            public INode Node;

            // have to trial and error the nodes - this is to prevent failure to read
            public byte[] UnknownNodeData;

            public static NodeData Read( LuminaBinaryReader br, ComponentData[] definedComponentList )
            {
                long originalPos = br.BaseStream.Position;

                NodeData ret = new NodeData();
                ret.NodeId = br.ReadUInt32();
                ret.ParentId = br.ReadInt32();
                ret.NextSiblingId = br.ReadInt32();
                ret.PrevSiblingId = br.ReadInt32();
                ret.ChildNodeId = br.ReadInt32();
                ret.NodeType = br.ReadInt32();
                ret.NodeOffset = br.ReadUInt16();
                ret.TabIndex = br.ReadInt16();
                ret.Unk1 = br.ReadInt32Array( 4 );
                ret.X = br.ReadInt16();
                ret.Y = br.ReadInt16();
                ret.W = br.ReadUInt16();
                ret.H = br.ReadUInt16();
                ret.Rotation = br.ReadSingle();
                ret.ScaleX = br.ReadSingle();
                ret.ScaleY = br.ReadSingle();
                ret.OriginX = br.ReadInt16();
                ret.OriginY = br.ReadInt16();
                ret.Priority = br.ReadUInt16();

                ret.field1 = br.ReadByte();

                ret.Visible = ( ret.field1 & 0x80 ) == 0x80;
                ret.Enabled = ( ret.field1 & 0x40 ) == 0x40;
                ret.Clip = ( ret.field1 & 0x20 ) == 0x20;
                ret.Fill = ( ret.field1 & 0x10 ) == 0x10;
                ret.AnchorTop = ( ret.field1 & 0x08 ) == 0x08;
                ret.AnchorBottom = ( ret.field1 & 0x04 ) == 0x04;
                ret.AnchorLeft = ( ret.field1 & 0x02 ) == 0x02;
                ret.AnchorRight = ( ret.field1 & 0x01 ) == 0x01;

                ret.Unk2 = br.ReadByte();

                ret.MultiplyRed = br.ReadInt16();
                ret.MultiplyGreen = br.ReadInt16();
                ret.MultiplyBlue = br.ReadInt16();
                ret.AddRed = br.ReadInt16();
                ret.AddGreen = br.ReadInt16();
                ret.AddBlue = br.ReadInt16();
                ret.Alpha = br.ReadByte();
                ret.ClipCount = br.ReadByte();
                ret.TimelineId = br.ReadUInt16();

                switch( ret.NodeType )
                {
                    case 1: break;
                    case 2:
                        ret.Node = Uld.NodeData.ImageNode.Read( br );
                        break;
                    case 3:
                        ret.Node = Uld.NodeData.TextNode.Read( br );
                        break;
                    case 4:
                        ret.Node = Uld.NodeData.NineGridNode.Read( br );
                        break;
                    case 5:
                        ret.Node = Uld.NodeData.CounterNode.Read( br );
                        break;
                    case 8:
                        ret.Node = Uld.NodeData.CollisionNode.Read( br );
                        break;
                    default:
                        if( ret.NodeOffset <= 88 ) break;
                        //Console.WriteLine( $"{ret.NodeOffset - 88} extra bytes..." );
                        if( ret.NodeType > 1000 )
                        {
                            Uld.ComponentData.ComponentType compType =
                                definedComponentList.Where( c => c.Id == ret.NodeType ).Select( c => c.Type ).FirstOrDefault();
                            ret.Node = Uld.NodeData.ComponentNode.Read( br, compType );
                        }
                        else
                        {
                            ret.UnknownNodeData = br.ReadBytes( ret.NodeOffset - 88 );
                            //Console.WriteLine( $"Read {ret.NodeOffset - 88} bytes for an unknown of {ret.NodeType}" );    
                        }

                        break;
                }

                // adjust stream position to match actual data size
                br.BaseStream.Position = originalPos + ret.NodeOffset;

                return ret;
            }
        }

        public struct ComponentData
        {
            public uint Id;
            public bool ShouldIgnoreInput;
            public bool DragArrow;
            public bool DropArrow;
            public Uld.ComponentData.ComponentType Type;
            public uint NodeCount;
            public ushort Size; // these 2 were in another order previously, dunno what happened
            public ushort Offset;
            public IComponent Component;
            public NodeData[] Nodes;

            public static ComponentData Read( LuminaBinaryReader br, ComponentData[] definedComponentList )
            {
                long originalPos = br.BaseStream.Position;

                ComponentData ret = new ComponentData();
                ret.Id = br.ReadUInt32();
                ret.ShouldIgnoreInput = br.ReadBoolean();
                ret.DragArrow = br.ReadBoolean();
                ret.DropArrow = br.ReadBoolean();
                ret.Type = (Uld.ComponentData.ComponentType)br.ReadByte();
                ret.NodeCount = br.ReadUInt32();
                ret.Size = br.ReadUInt16();
                ret.Offset = br.ReadUInt16();

                switch( ret.Type )
                {
                    case Uld.ComponentData.ComponentType.Button:
                        ret.Component = Uld.ComponentData.ButtonComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Window:
                        ret.Component = Uld.ComponentData.WindowComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.CheckBox:
                        ret.Component = Uld.ComponentData.CheckBoxComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.RadioButton:
                        ret.Component = Uld.ComponentData.RadioButtonComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Gauge:
                        ret.Component = Uld.ComponentData.GaugeComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Slider:
                        ret.Component = Uld.ComponentData.SliderComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.TextInput:
                        ret.Component = Uld.ComponentData.TextInputComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.NumericInput:
                        ret.Component = Uld.ComponentData.NumericInputComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.List:
                        ret.Component = Uld.ComponentData.ListComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.DropDown:
                        ret.Component = Uld.ComponentData.DropDownComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Tabbed:
                        ret.Component = Uld.ComponentData.TabComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.TreeList:
                        ret.Component = Uld.ComponentData.TreeListComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.ScrollBar:
                        ret.Component = Uld.ComponentData.ScrollBarComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.ListItem:
                        ret.Component = Uld.ComponentData.ListItemComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Icon:
                        ret.Component = Uld.ComponentData.IconComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.IconWithText:
                        ret.Component = Uld.ComponentData.IconWithTextComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.DragDrop:
                        ret.Component = Uld.ComponentData.DragDropComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.LeveCard:
                        ret.Component = Uld.ComponentData.LeveCardComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.NineGridText:
                        ret.Component = Uld.ComponentData.NineGridComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Journal:
                        ret.Component = Uld.ComponentData.JournalComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Multipurpose:
                        ret.Component = Uld.ComponentData.MultipurposeComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Map:
                        ret.Component = Uld.ComponentData.MapComponent.Read( br );
                        break;
                    case Uld.ComponentData.ComponentType.Preview:
                        ret.Component = Uld.ComponentData.PreviewComponent.Read( br );
                        break;
                }

                // adjust position because of inconsisty within the same ComponentList version...
                br.BaseStream.Position = originalPos + ret.Offset;

                ret.Nodes = new NodeData[ret.NodeCount];
                for( int i = 0; i < ret.NodeCount; i++ )
                    ret.Nodes[ i ] = NodeData.Read( br, definedComponentList );
                return ret;
            }
        }

        public struct KeyGroup
        {
            public KeyUsage Usage;
            public KeyGroupType Type;
            public ushort Offset;
            public ushort KeyframeCount;
            public IKeyframe[] Frames;

            public static KeyGroup Read( LuminaBinaryReader br )
            {
                KeyGroup ret = new KeyGroup();
                ret.Usage = (KeyUsage)br.ReadUInt16();
                ret.Type = (KeyGroupType)br.ReadUInt16();
                ret.Offset = br.ReadUInt16();
                ret.KeyframeCount = br.ReadUInt16();

                ret.Frames = new IKeyframe[ret.KeyframeCount];

                switch( ret.Type )
                {
                    case KeyGroupType.Float1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Float1Keyframe.Read( br );
                        break;
                    case KeyGroupType.Float2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Float2Keyframe.Read( br );
                        break;
                    case KeyGroupType.Float3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Float3Keyframe.Read( br );
                        break;
                    case KeyGroupType.SByte1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Byte1Keyframe.Read( br );
                        break;
                    case KeyGroupType.SByte2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Byte2Keyframe.Read( br );
                        break;
                    case KeyGroupType.SByte3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Byte3Keyframe.Read( br );
                        break;
                    case KeyGroupType.Byte1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.SByte1Keyframe.Read( br );
                        break;
                    case KeyGroupType.Byte2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.SByte2Keyframe.Read( br );
                        break;
                    case KeyGroupType.Byte3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.SByte3Keyframe.Read( br );
                        break;
                    case KeyGroupType.Short1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Short1Keyframe.Read( br );
                        break;
                    case KeyGroupType.Short2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Short2Keyframe.Read( br );
                        break;
                    case KeyGroupType.Short3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Short3Keyframe.Read( br );
                        break;
                    case KeyGroupType.UShort1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.UShort1Keyframe.Read( br );
                        break;
                    case KeyGroupType.UShort2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.UShort2Keyframe.Read( br );
                        break;
                    case KeyGroupType.UShort3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.UShort3Keyframe.Read( br );
                        break;
                    case KeyGroupType.Int1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Int1Keyframe.Read( br );
                        break;
                    case KeyGroupType.Int2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Int2Keyframe.Read( br );
                        break;
                    case KeyGroupType.Int3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Int3Keyframe.Read( br );
                        break;
                    case KeyGroupType.UInt1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.UInt1Keyframe.Read( br );
                        break;
                    case KeyGroupType.UInt2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.UInt2Keyframe.Read( br );
                        break;
                    case KeyGroupType.UInt3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.UInt3Keyframe.Read( br );
                        break;
                    case KeyGroupType.Bool1:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Bool1Keyframe.Read( br );
                        break;
                    case KeyGroupType.Bool2:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Bool2Keyframe.Read( br );
                        break;
                    case KeyGroupType.Bool3:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.Bool3Keyframe.Read( br );
                        break;
                    case KeyGroupType.Color:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.ColorKeyframe.Read( br );
                        break;
                    case KeyGroupType.Label:
                        for( int i = 0; i < ret.KeyframeCount; i++ ) ret.Frames[ i ] = Keyframes.LabelKeyframe.Read( br );
                        break;
                }

                return ret;
            }
        }

        public struct FrameData
        {
            // idk if these are in reference to frame. but they will be.
            public uint StartFrame;
            public uint EndFrame;
            public uint Offset;
            public uint KeygroupCount;

            public KeyGroup[] KeyGroups;

            public static FrameData Read( LuminaBinaryReader br )
            {
                FrameData ret = new FrameData();
                ret.StartFrame = br.ReadUInt32();
                ret.EndFrame = br.ReadUInt32();
                ret.Offset = br.ReadUInt32();
                ret.KeygroupCount = br.ReadUInt32();
                ret.KeyGroups = new KeyGroup[ret.KeygroupCount];
                for( int i = 0; i < ret.KeygroupCount; i++ )
                    ret.KeyGroups[ i ] = KeyGroup.Read( br );
                return ret;
            }
        }

        public struct Timeline
        {
            public uint Id;
            public uint Offset;

            // might have to consider the possibility that these frame sets ARE independent
            private ushort numframes1;
            private ushort numframes2;

            public uint NumFrames;
            public FrameData[] FrameData;

            public static Timeline Read( LuminaBinaryReader br )
            {
                Timeline ret = new Timeline();
                ret.Id = br.ReadUInt32();
                ret.Offset = br.ReadUInt32();
                ret.numframes1 = br.ReadUInt16();
                ret.numframes2 = br.ReadUInt16();
                ret.NumFrames = (uint)( ret.numframes1 + ret.numframes2 );
                ret.FrameData = new FrameData[ret.NumFrames];
                for( int i = 0; i < ret.NumFrames; i++ )
                    ret.FrameData[ i ] = UldRoot.FrameData.Read( br );
                return ret;
            }
        }

        public struct WidgetData
        {
            public uint Id;
            public AlignmentType AlignmentType;
            public bool AssetsHaveThemeSupport;
            public short X;
            public short Y;
            public ushort NodeCount;
            public ushort Offset;

            public NodeData[] Nodes;

            public static WidgetData Read( LuminaBinaryReader br, ComponentData[] definedComponentList )
            {
                WidgetData ret = new WidgetData();
                ret.Id = br.ReadUInt32();
                ret.AlignmentType = (AlignmentType)br.ReadByte();
                ret.AssetsHaveThemeSupport = br.ReadBoolean();
                br.BaseStream.Position += 2;
                ret.X = br.ReadInt16();
                ret.Y = br.ReadInt16();
                ret.NodeCount = br.ReadUInt16();
                ret.Offset = br.ReadUInt16();
                ret.Nodes = new NodeData[ret.NodeCount];
                for( int i = 0; i < ret.NodeCount; i++ )
                    ret.Nodes[ i ] = NodeData.Read( br, definedComponentList );
                return ret;
            }
        }
    }
}