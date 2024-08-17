using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Extensions;

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

    public static unsafe ref T UnsafeAt<T>( this Span<T> span, int index ) =>
        ref Unsafe.Add( ref MemoryMarshal.GetReference( span ), index );

    public static unsafe ref readonly T UnsafeAt<T>( this ReadOnlySpan<T> span, int index ) =>
        ref Unsafe.Add( ref MemoryMarshal.GetReference( span ), index );

    public static unsafe ref readonly T UnsafeAt<T>(this T[] array, int index) =>
        ref Unsafe.Add( ref MemoryMarshal.GetArrayDataReference( array ), index );
}