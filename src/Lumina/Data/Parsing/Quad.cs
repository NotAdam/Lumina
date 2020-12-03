using System.Runtime.InteropServices;

namespace Lumina.Data.Parsing
{
    [StructLayout( LayoutKind.Explicit )]
    public struct Quad
    {
        [FieldOffset(0x0)]
        public ulong Data;

        [FieldOffset(0x0)]
        public ushort U16A;
        [FieldOffset(0x2)]
        public ushort U16B;
        [FieldOffset(0x4)]
        public ushort U16C;
        [FieldOffset(0x6)]
        public ushort U16D;
        
        [FieldOffset(0x0)]
        public byte U8A;
        [FieldOffset(0x1)]
        public byte U8B;
        [FieldOffset(0x2)]
        public byte U8C;
        [FieldOffset(0x3)]
        public byte U8D;
        [FieldOffset(0x4)]
        public byte U8E;
        [FieldOffset(0x5)]
        public byte U8F;
        [FieldOffset(0x6)]
        public byte U8G;
        [FieldOffset(0x7)]
        public byte U8H;
        
        [FieldOffset(0x0)]
        public uint U32A;
        [FieldOffset(0x1)]
        public uint U32B;

        public ushort A => U16A;
        public ushort B => U16B;
        public ushort C => U16C;
        public ushort D => U16D;

        public override string ToString()
        {
            return $"{D}, {C}, {B}, {A}";
        }

        public static explicit operator Quad( ulong data ) => new Quad { Data = data };
        public static explicit operator Quad( long data ) => new Quad { Data = (ulong)data };

        public static implicit operator ulong( Quad quad ) => quad.Data;
    }

    public static class QuadExtensions
    {
        public static Quad AsQuad( this ulong value ) => (Quad)value;

        public static Quad AsQuad( this uint value ) => new() { U32A = value };
    }
}