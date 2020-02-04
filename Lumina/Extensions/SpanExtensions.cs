using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Extensions
{
    public static class SpanExtensions
    {
        public static T ReadStructure< T >( this Span< byte > span ) where T : struct
        {
            return MemoryMarshal.AsRef< T >( span );
        }

        public static T ReadStructure< T >( this Span< byte > span, int offset ) where T : struct
        {
            return MemoryMarshal.AsRef< T >( span.Slice( offset ) );
        }
    }
}