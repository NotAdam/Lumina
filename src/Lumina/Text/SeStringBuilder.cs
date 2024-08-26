using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;
using Microsoft.Extensions.ObjectPool;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder : IResettable
{
    private readonly List< (StackType Type, int Ident, MemoryStream Stream) > _mss = [( StackType.String, 0, new() )];
    private readonly List< MemoryStream > _mssFree = [];

    private enum StackType
    {
        String,
        Payload,
        Expression,
    }

    /// <summary>Begins a macro.</summary>
    /// <param name="macroCode">The macro code.</param>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder BeginMacro( MacroCode macroCode )
    {
        if( !Enum.IsDefined( macroCode ) )
            throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode, "Invalid macro code specified." );
        if( _mss[ ^1 ].Type != StackType.String )
            throw new InvalidOperationException( "A payload can be added only in the context of SeString." );
        if( _mssFree.Count == 0 )
        {
            _mss.Add( ( StackType.Payload, (byte) macroCode, new() ) );
        }
        else
        {
            _mss.Add( ( StackType.Payload, (byte) macroCode, _mssFree[ ^1 ] ) );
            _mssFree.RemoveAt( _mssFree.Count - 1 );
        }

        return this;
    }

    /// <summary>Ends a macro.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder EndMacro()
    {
        if( _mss[ ^1 ].Type != StackType.Payload )
            throw new InvalidOperationException( "No payload is currently being built." );

        var stream = _mss[ ^1 ].Stream;
        var payload = new ReadOnlySePayloadSpan(
            ReadOnlySePayloadType.Macro,
            (MacroCode) _mss[ ^1 ].Ident,
            stream.GetBuffer().AsSpan( 0, (int) stream.Length ) );

        _mss.RemoveAt( _mss.Count - 1 );
        Append( payload );

        stream.SetLength( stream.Position = 0 );
        _mssFree.Add( stream );

        return this;
    }

    /// <summary>Aborts a macro build by discarding the current macro data and exiting the macro scope.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder AbortMacro()
    {
        if( _mss[ ^1 ].Type != StackType.Payload )
            throw new InvalidOperationException( "No payload is currently being built." + _mss[^1].Type );

        var stream = _mss[ ^1 ].Stream;
        _mss.RemoveAt( _mss.Count - 1 );
        stream.SetLength( stream.Position = 0 );
        _mssFree.Add( stream );

        return this;
    }

    /// <summary>Clears everything.</summary>
    /// <param name="zeroBuffer">Whether to fill the underlying buffer with zeroes.</param>
    /// <returns>A reference of this instance after the clear operation is completed.</returns>
    public SeStringBuilder Clear( bool zeroBuffer = false )
    {
        foreach( var ms in _mss )
            _mssFree.Add( ms.Stream );
        _mss.Clear();

        foreach( var m in _mssFree )
        {
            m.SetLength( m.Position = 0 );
            if( zeroBuffer )
                m.GetBuffer().AsSpan().Clear();
        }

        _mss.Add( ( StackType.String, 0, _mssFree[ ^1 ] ) );
        _mssFree.RemoveAt( _mssFree.Count - 1 );
        return this;
    }

    /// <summary>Gets the SeString as a new byte array.</summary>
    /// <returns>A new byte array.</returns>
    public byte[] ToArray()
    {
        if( _mss.Count != 1 )
            throw new InvalidOperationException( "The string is incomplete, due to non-empty stack." );
        return _mss[ 0 ].Stream.ToArray();
    }

    /// <summary>Gets the SeString as a new instance of <see cref="SeString"/>.</summary>
    /// <returns>A new instance of <see cref="SeString"/>.</returns>
    public SeString ToSeString() => new( ToArray() );

    /// <summary>Gets the SeString as a new instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/>.</returns>
    public ReadOnlySeString ToReadOnlySeString() => ToArray();

    /// <inheritdoc/>
    public bool TryReset()
    {
        Clear();
        return true;
    }

#if NET8_0
    /// <summary>Helper method for <see cref="Append{T}"/>.</summary>
    /// <param name="ssb">The target instance of <see cref="SeStringBuilder"/>.</param>
    /// <param name="value">The value to append.</param>
    /// <typeparam name="T">The span formattable type.</typeparam>
    private static void TypedAppendUtf8SpanFormattable< T >( SeStringBuilder ssb, scoped in T value ) where T : IUtf8SpanFormattable
    {
        for (var len = 128; ; len *= 2)
        {
            var buf = ArrayPool< byte >.Shared.Rent( len );
            if( value.TryFormat( buf, out var written, default, null ) )
            {
                ssb.Append( buf[ ..written ] );
                ArrayPool< byte >.Shared.Return( buf );
                return;
            }

            ArrayPool< byte >.Shared.Return( buf );
        }
    }
#endif

    /// <summary>Helper method for <see cref="Append{T}"/>.</summary>
    /// <param name="ssb">The target instance of <see cref="SeStringBuilder"/>.</param>
    /// <param name="value">The value to append.</param>
    /// <typeparam name="T">The span formattable type.</typeparam>
    private static void TypedAppendSpanFormattable< T >( SeStringBuilder ssb, scoped in T value ) where T : ISpanFormattable
    {
        for( var len = 128;; len *= 2 )
        {
            var buf = ArrayPool< char >.Shared.Rent( len );
            if( value.TryFormat( buf, out var written, default, null ) )
            {
                ssb.Append( buf[ ..written ] );
                ArrayPool< char >.Shared.Return( buf );
                return;
            }

            ArrayPool< char >.Shared.Return( buf );
        }
    }

    /// <summary>Allocates a byte span from the result of <see cref="GetStringStream"/>.</summary>
    /// <param name="length">Number of bytes to allocate.</param>
    /// <returns>The allocated byte span.</returns>
    private Span< byte > AllocateStringSpan( int length )
    {
        var stream = GetStringStream();
        var offset = unchecked( (int) stream.Position );
        stream.SetLength( stream.Position = offset + length );
        return stream.GetBuffer().AsSpan( offset, length );
    }

    /// <summary>Allocates a byte span from the result of <see cref="GetStringStream"/>.</summary>
    /// <param name="length">Number of bytes to allocate.</param>
    /// <returns>The allocated byte span.</returns>
    private Span< byte > AllocateExpressionSpan( int length )
    {
        var stream = GetExpressionStream();
        var offset = unchecked( (int) stream.Position );
        stream.SetLength( stream.Position = offset + length );
        return stream.GetBuffer().AsSpan( offset, length );
    }

    /// <summary>Ensures that the current stack top is a string.</summary>
    /// <returns>The string stream.</returns>
    private MemoryStream GetStringStream()
    {
        if( _mss[ ^1 ].Type != StackType.String )
            throw new InvalidOperationException( "Strings may not be appended in current state." );
        return _mss[ ^1 ].Stream;
    }

    /// <summary>Ensures that the current stack top is an expression or payload.</summary>
    /// <returns>The string stream.</returns>
    private MemoryStream GetExpressionStream()
    {
        if( _mss[ ^1 ].Type is not StackType.Payload and not StackType.Expression )
            throw new InvalidOperationException( "Expressions may not be appended in current state." );
        if( _mss[ ^1 ].Type is StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
        return _mss[ ^1 ].Stream;
    }

    private void OneExpressionWritten()
    {
        if( _mss[ ^1 ].Type is StackType.Expression )
            _mss[ ^1 ] = _mss[ ^1 ] with { Ident = _mss[ ^1 ].Ident - 1 };
    }
}