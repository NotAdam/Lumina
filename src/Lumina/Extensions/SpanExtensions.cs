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

    /// <summary>Gets the reference to the item at the given index in the given span, without boundary checks.</summary>
    /// <param name="span">Span to get an item reference from.</param>
    /// <param name="index">Index of the item that should be at least <c>0</c> and at most <c>span.Length - 1</c>.</param>
    /// <typeparam name="T">Type of elements.</typeparam>
    /// <returns>Reference to the item at the given index in the span.</returns>
    /// <remarks>If <paramref name="index"/> is negative or greater than or equal to <c>span.Length</c>, then the behavior is undefined.</remarks>
    public static ref T UnsafeAt< T >( this Span< T > span, int index ) =>
        ref Unsafe.Add( ref MemoryMarshal.GetReference( span ), index );

    /// <inheritdoc cref="UnsafeAt{T}(Span{T}, int)"/>
    public static ref readonly T UnsafeAt< T >( this ReadOnlySpan< T > span, int index ) =>
        ref Unsafe.Add( ref MemoryMarshal.GetReference( span ), index );

    /// <summary>Gets the reference to the item at the given index in the given array, without boundary checks.</summary>
    /// <param name="array">Array to get an item reference from.</param>
    /// <param name="index">Index of the item that should be at least <c>0</c> and at most <c>array.Length - 1</c>.</param>
    /// <typeparam name="T">Type of elements.</typeparam>
    /// <returns>Reference to the item at the given index in the array.</returns>
    /// <remarks>If <paramref name="index"/> is negative or greater than or equal to <c>array.Length</c>, then the behavior is undefined.</remarks>
    public static ref T UnsafeAt< T >( this T[] array, int index ) =>
        ref Unsafe.Add( ref MemoryMarshal.GetArrayDataReference( array ), index );
}