using System.Runtime.InteropServices;

namespace Lumina.Data.Parsing
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Quad
    {
        public ulong Data;

        public ushort A => (ushort)( Data >> 48 );
        public ushort B => (ushort)( Data >> 32 );
        public ushort C => (ushort)( Data >> 16 );
        public ushort D => (ushort)Data;

        public override string ToString()
        {
            return $"{A}, {B}, {C}, {D}";
        }

        public static explicit operator Quad( ulong data ) => new Quad { Data = data };
        public static explicit operator Quad( long data ) => new Quad { Data = (ulong)data };

        public static implicit operator ulong( Quad quad ) => quad.Data;
    }

    public static class QuadExtensions
    {
        public static Quad AsQuad( this ulong value )
        {
            return new Quad
            {
                Data = value
            };
        }
    }
}