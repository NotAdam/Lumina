using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Lumina.Text;

public sealed partial class SeStringBuilder
{
    /// <summary>Adds the given character.</summary>
    /// <param name="rune">Character to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( Rune rune )
    {
        rune.EncodeToUtf8( AllocateStringSpan( rune.Utf8SequenceLength ) );
        return this;
    }

    /// <summary>Adds the given character.</summary>
    /// <param name="rune">Character to add.</param>
    /// <param name="repeatCount">Number of times to append <paramref name="rune"/>.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( Rune rune, int repeatCount )
    {
        if( repeatCount == 0 )
            return this;

        if( repeatCount < 0 )
            throw new ArgumentOutOfRangeException( nameof( repeatCount ), repeatCount, null );

        var span = AllocateStringSpan( rune.Utf8SequenceLength * repeatCount );
        var sequence = span[ ..rune.EncodeToUtf8( span ) ];
        span = span[ sequence.Length.. ];
        while( !span.IsEmpty )
        {
            sequence.CopyTo( span );
            span = span[ sequence.Length.. ];
        }

        return this;
    }

    /// <summary>Adds the given <see cref="Rune"/>, or <see cref="Rune.ReplacementChar"/> if the value is not valid.</summary>
    /// <param name="utfValue">Character to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( UtfValue utfValue ) => AppendChar( utfValue.IntValue );

    /// <summary>Adds the given character.</summary>
    /// <param name="subsequence">Character to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( scoped in UtfEnumerator.Subsequence subsequence ) => Append( subsequence.EffectiveRune );

    #region I/Utf8/SpanFormattable

    /// <summary>Adds the string representation of a <paramref name="value"/> to this instance.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    public SeStringBuilder Append( bool value ) => Append( value ? "true"u8 : "false"u8 );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( char value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( byte value ) => AppendChar( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( ushort value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( uint value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( ulong value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( nuint value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( sbyte value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( short value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( int value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( long value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( nint value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public unsafe SeStringBuilder Append( void* value ) => Append( (nint) value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( Half value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( float value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( double value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( scoped in decimal value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( scoped in System.Numerics.BigInteger value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( DateOnly value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( TimeOnly value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( TimeSpan value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( DateTime value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( DateTimeOffset value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( scoped in Version value ) => AppendSpanFormattableAuto( value );

#if NET7_0_OR_GREATER
    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( scoped in System.Numerics.Complex value ) => AppendSpanFormattableAuto( value );
#endif

#if NET8_0_OR_GREATER
    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( scoped in UInt128 value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( scoped in Int128 value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( System.Net.IPAddress value ) => AppendSpanFormattableAuto( value );

    /// <inheritdoc cref="Append(bool)" />
    public SeStringBuilder Append( System.Net.IPNetwork value ) => AppendSpanFormattableAuto( value );
#endif

    #endregion

    /// <summary>Adds the given value.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( object? value ) => Append( value?.ToString() );

    /// <summary>Adds the given value.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append< T >( scoped in T value ) => value switch
    {
#if NET8_0_OR_GREATER
        IUtf8SpanFormattable f => AppendSpanFormattableUtf8( f ),
#endif
        ISpanFormattable f => AppendSpanFormattableUtf16( f ),
        null => Append( "null"u8 ),
        _ => Append( value.ToString() )
    };

#if NET8_0_OR_GREATER
    /// <summary>Helper method for <see cref="Append{T}"/>.</summary>
    /// <param name="value">The value to append.</param>
    /// <typeparam name="T">The span formattable type.</typeparam>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    private SeStringBuilder AppendSpanFormattableUtf8< T >( scoped in T value ) where T : IUtf8SpanFormattable
    {
        var span = Span< byte >.Empty;
        for( var len = Unsafe.SizeOf< MemoryChunkStorage >(); len < Array.MaxLength >> 1; len *= 2 )
        {
            span = ReallocateStringSpan( span.Length, len );
            if( value.TryFormat( span, out var written, default, null ) )
            {
                ReallocateStringSpan( span.Length, written );
                return this;
            }
        }

        throw new OutOfMemoryException();
    }
#endif

    /// <summary>Helper method for <see cref="Append{T}"/>.</summary>
    /// <param name="value">The value to append.</param>
    /// <typeparam name="T">The span formattable type.</typeparam>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    private SeStringBuilder AppendSpanFormattableUtf16< T >( scoped in T value ) where T : ISpanFormattable
    {
        var span = MemoryChunkStorage.AsSpanUninitialized< char >( out _ );
        if( value.TryFormat( span, out var written, default, null ) )
        {
            Append( span[ ..written ] );
            return this;
        }

        for( var len = 2 * Unsafe.SizeOf< MemoryChunkStorage >(); len < Array.MaxLength >> 2; len *= 2 )
        {
            var buf = ArrayPool< char >.Shared.Rent( len );
            if( value.TryFormat( buf, out written, default, null ) )
            {
                Append( buf[ ..written ] );
                ArrayPool< char >.Shared.Return( buf );
                return this;
            }

            ArrayPool< char >.Shared.Return( buf );
        }

        throw new OutOfMemoryException();
    }

    /// <summary>Helper method for <see cref="Append{T}"/>.</summary>
    /// <param name="value">The value to append.</param>
    /// <typeparam name="T">The span formattable type.</typeparam>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
#if NET8_0_OR_GREATER
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    private SeStringBuilder AppendSpanFormattableAuto< T >( T value ) where T : IUtf8SpanFormattable => AppendSpanFormattableUtf8( value );
#else
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    private SeStringBuilder AppendSpanFormattableAuto< T >( T value ) where T : ISpanFormattable => AppendSpanFormattableUtf16( value );
#endif

    /// <summary>Dummy struct for reserving a chunk of memory in stack at compile-time the bat without having to stackalloc.</summary>
    [StructLayout( LayoutKind.Explicit, Size = 256, Pack = 1 )]
    private struct MemoryChunkStorage
    {
        /// <summary>Reinterprets a reference of <see cref="MemoryChunkStorage"/> as a <see cref="Span{T}"/> of <typeparamref name="T"/> without zero-initializing.
        /// </summary>
        /// <param name="storage">Backing storage.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        [SuppressMessage( "ReSharper", "OutParameterValueIsAlwaysDiscarded.Local", Justification = "Stack reservation" )]
        public static Span< T > AsSpanUninitialized< T >( out MemoryChunkStorage storage ) where T : struct
        {
            Unsafe.SkipInit( out storage );
            return MemoryMarshal.Cast< MemoryChunkStorage, T >( MemoryMarshal.CreateSpan( ref storage, 1 ) );
        }
    }
}