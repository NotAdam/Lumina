using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lumina.Misc;

/// <summary>Dummy struct for reserving a chunk of memory in stack at compile-time the bat without having to stackalloc.</summary>
[StructLayout( LayoutKind.Explicit, Size = 256, Pack = 1 )]
internal struct MemoryChunkStorage
{
    /// <summary>Reinterprets a reference of <see cref="MemoryChunkStorage"/> as a <see cref="Span{T}"/> of <typeparamref name="T"/> without zero-initializing.
    /// </summary>
    /// <param name="storage">Backing storage.</param>
    /// <typeparam name="T">Element type.</typeparam>
    /// <returns><see cref="Span{T}"/>.</returns>
    /// <remarks>Multiple calls to this function with discard output may result in two instances sharing the memory buffer.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    [SuppressMessage( "ReSharper", "OutParameterValueIsAlwaysDiscarded.Local", Justification = "Stack reservation" )]
    public static Span< T > AsSpanUninitialized< T >( out MemoryChunkStorage storage ) where T : struct
    {
        Unsafe.SkipInit( out storage );
        return MemoryMarshal.Cast< MemoryChunkStorage, T >( MemoryMarshal.CreateSpan( ref storage, 1 ) );
    }
}