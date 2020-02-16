using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Extensions
{
    public static class SpanExtensions
    {
#if NETSTANDARD
        public static unsafe T ReadStructure< T >( this Span< byte > span ) where T : struct
        {
            fixed( byte* bp = &span.GetPinnableReference() )
            {
                return Marshal.PtrToStructure< T >( new IntPtr( bp ) );
            }
        }

        public static unsafe T ReadStructure< T >( this Span< byte > span, int offset ) where T : struct
        {
            fixed( byte* bp = &span.GetPinnableReference() )
            {
                return Marshal.PtrToStructure< T >( new IntPtr( bp + offset ) );
            }
        }
#elif NETCOREAPP
        public static T ReadStructure< T >( this Span< byte > span ) where T : struct
        {
            return MemoryMarshal.AsRef< T >( span );
        }

        public static T ReadStructure< T >( this Span< byte > span, int offset ) where T : struct
        {
            return MemoryMarshal.AsRef< T >( span.Slice( offset ) );
        }
#endif
    }
}