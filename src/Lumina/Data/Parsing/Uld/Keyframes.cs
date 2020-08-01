using System;
using System.IO;
using Lumina.Extensions;

// ReSharper disable NotAccessedField.Global
// ReSharper disable MemberCanBePrivate.Global
namespace Lumina.Data.Parsing.Uld {
    public interface IKeyframe { }

    public static class Keyframes {
        public class BaseKeyframeData : IKeyframe {
            public uint Time;
            public ushort Offset;
            public byte Interpolation;
            public byte Unk1;
            public float Acceleration;
            public float Deceleration;

            public static BaseKeyframeData Read( BinaryReader br ) {
                BaseKeyframeData ret = new BaseKeyframeData();
                ret.Time = br.ReadUInt32();
                ret.Offset = br.ReadUInt16();
                ret.Interpolation = br.ReadByte();
                ret.Unk1 = br.ReadByte();
                ret.Acceleration = br.ReadSingle();
                ret.Deceleration = br.ReadSingle();
                return ret;
            }
        }

        public struct Float1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public float Value;

            public static Float1Keyframe Read( BinaryReader br ) {
                Float1Keyframe ret = new Float1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadSingle();
                return ret;
            }
        }

        public struct Float2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public float[] Value;

            public static Float2Keyframe Read( BinaryReader br ) {
                Float2Keyframe ret = new Float2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Single >( 2 ).ToArray();
                return ret;
            }
        }

        public struct Float3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public float[] Value;

            public static Float3Keyframe Read( BinaryReader br ) {
                Float3Keyframe ret = new Float3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Single >( 3 ).ToArray();
                return ret;
            }
        }

        public struct SByte1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public sbyte Value;
            public byte[] Padding;

            public static SByte1Keyframe Read( BinaryReader br ) {
                SByte1Keyframe ret = new SByte1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadSByte();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct SByte2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public sbyte[] Value;

            public static SByte2Keyframe Read( BinaryReader br ) {
                SByte2Keyframe ret = new SByte2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< SByte >( 2 ).ToArray();
                return ret;
            }
        }

        public struct SByte3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public sbyte[] Value;
            public byte Padding;

            public static SByte3Keyframe Read( BinaryReader br ) {
                SByte3Keyframe ret = new SByte3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< SByte >( 3 ).ToArray();
                ret.Padding = br.ReadByte();
                return ret;
            }
        }

        public struct Byte1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public byte Value;
            public byte[] Padding;

            public static Byte1Keyframe Read( BinaryReader br ) {
                Byte1Keyframe ret = new Byte1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadByte();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct Byte2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public byte[] Value;
            public byte[] Padding;

            public static Byte2Keyframe Read( BinaryReader br ) {
                Byte2Keyframe ret = new Byte2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadBytes( 2 );
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct Byte3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public byte[] Value;
            public byte Padding;

            public static Byte3Keyframe Read( BinaryReader br ) {
                Byte3Keyframe ret = new Byte3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadBytes( 3 );
                ret.Padding = br.ReadByte();
                return ret;
            }
        }

        public struct Short1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public short Value;
            public byte[] Padding;

            public static Short1Keyframe Read( BinaryReader br ) {
                Short1Keyframe ret = new Short1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadInt16();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct Short2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public short[] Value;

            public static Short2Keyframe Read( BinaryReader br ) {
                Short2Keyframe ret = new Short2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Int16 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct Short3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public short[] Value;
            public byte[] Padding;

            public static Short3Keyframe Read( BinaryReader br ) {
                Short3Keyframe ret = new Short3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Int16 >( 3 ).ToArray();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct UShort1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public ushort Value;
            public byte[] Padding;

            public static UShort1Keyframe Read( BinaryReader br ) {
                UShort1Keyframe ret = new UShort1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadUInt16();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct UShort2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public ushort[] Value;

            public static UShort2Keyframe Read( BinaryReader br ) {
                UShort2Keyframe ret = new UShort2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< UInt16 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct UShort3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public ushort[] Value;
            public byte[] Padding;

            public static UShort3Keyframe Read( BinaryReader br ) {
                UShort3Keyframe ret = new UShort3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< UInt16 >( 3 ).ToArray();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct Int1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public int Value;

            public static Int1Keyframe Read( BinaryReader br ) {
                Int1Keyframe ret = new Int1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadInt32();
                return ret;
            }
        }

        public struct Int2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public int[] Value;

            public static Int2Keyframe Read( BinaryReader br ) {
                Int2Keyframe ret = new Int2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Int32 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct Int3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public int[] Value;

            public static Int3Keyframe Read( BinaryReader br ) {
                Int3Keyframe ret = new Int3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Int32 >( 3 ).ToArray();
                return ret;
            }
        }

        public struct UInt1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public uint Value;

            public static UInt1Keyframe Read( BinaryReader br ) {
                UInt1Keyframe ret = new UInt1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadUInt32();
                return ret;
            }
        }

        public struct UInt2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public uint[] Value;

            public static UInt2Keyframe Read( BinaryReader br ) {
                UInt2Keyframe ret = new UInt2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< UInt32 >( 2 ).ToArray();
                return ret;
            }
        }

        public struct UInt3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public uint[] Value;

            public static UInt3Keyframe Read( BinaryReader br ) {
                UInt3Keyframe ret = new UInt3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< UInt32 >( 3 ).ToArray();
                return ret;
            }
        }

        public struct Bool1Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public bool Value;
            public byte[] Padding;

            public static Bool1Keyframe Read( BinaryReader br ) {
                Bool1Keyframe ret = new Bool1Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadBoolean();
                ret.Padding = br.ReadBytes( 3 );
                return ret;
            }
        }

        public struct Bool2Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public bool[] Value;
            public byte[] Padding;

            public static Bool2Keyframe Read( BinaryReader br ) {
                Bool2Keyframe ret = new Bool2Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Boolean >( 2 ).ToArray();
                ret.Padding = br.ReadBytes( 2 );
                return ret;
            }
        }

        public struct Bool3Keyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public bool[] Value;
            public byte Padding;

            public static Bool3Keyframe Read( BinaryReader br ) {
                Bool3Keyframe ret = new Bool3Keyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.Value = br.ReadStructures< Boolean >( 3 ).ToArray();
                ret.Padding = br.ReadByte();
                return ret;
            }
        }

        public struct ColorKeyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public short MultiplyRed;
            public short MultiplyGreen;
            public short MultiplyBlue;
            public short AddRed;
            public short AddGreen;
            public short AddBlue;

            public static ColorKeyframe Read( BinaryReader br ) {
                ColorKeyframe ret = new ColorKeyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.MultiplyRed = br.ReadInt16();
                ret.MultiplyGreen = br.ReadInt16();
                ret.MultiplyBlue = br.ReadInt16();
                ret.AddRed = br.ReadInt16();
                ret.AddGreen = br.ReadInt16();
                ret.AddBlue = br.ReadInt16();
                return ret;
            }
        }

        public struct LabelKeyframe : IKeyframe {
            public BaseKeyframeData Keyframe;
            public ushort LabelId;
            public byte LabelCommand;
            public byte JumpId;

            public static LabelKeyframe Read( BinaryReader br ) {
                LabelKeyframe ret = new LabelKeyframe();
                ret.Keyframe = BaseKeyframeData.Read( br );
                ret.LabelId = br.ReadUInt16();
                ret.LabelCommand = br.ReadByte();
                ret.JumpId = br.ReadByte();
                return ret;
            }
        }
    }
}