using System;
using System.Runtime.InteropServices;

namespace Lumina.Extensions
{
    public static class SpanExtensions
    {

        public static unsafe T ReadStructure< T >( this Span< byte > span ) where T : struct
        {
#if NETSTANDARD
            fixed( byte* bp = &span.GetPinnableReference() )
            {
                return Marshal.PtrToStructure< T >( new IntPtr( bp ) );
            }
#else
            return MemoryMarshal.Read< T >( span );
#endif
        }

        public static unsafe T ReadStructure< T >( this Span< byte > span, int offset ) where T : struct
        {
#if NETSTANDARD
            fixed( byte* bp = &span.GetPinnableReference() )
            {
                return Marshal.PtrToStructure< T >( new IntPtr( bp + offset ) );
            }
#else
            return MemoryMarshal.Read< T >( span.Slice( offset ) );
#endif

        }
    }
}