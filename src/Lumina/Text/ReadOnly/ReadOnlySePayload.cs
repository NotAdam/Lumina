using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Text.Payloads;

namespace Lumina.Text.ReadOnly;

/// <summary>Represents a payload in a <see cref="ReadOnlySeString"/>.</summary>
[SuppressMessage( "ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator", Justification = "Avoid heap allocation" )]
public readonly struct ReadOnlySePayload : IEquatable< ReadOnlySePayload >, IReadOnlyCollection< ReadOnlySeExpression >, ICollection< ReadOnlySeExpression >,
    ICollection
{
    /// <summary>Type of this payload.</summary>
    public readonly ReadOnlySePayloadType Type;

    /// <summary>Type of the macro contained within, if <see cref="Type"/> is <see cref="ReadOnlySePayloadType.Macro"/>.</summary>
    public readonly MacroCode MacroCode;

    /// <summary>Payload body, excluding envelope head and tail if <see cref="ReadOnlySePayloadType.Macro"/>.</summary>
    public readonly ReadOnlyMemory< byte > Body;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySePayload"/> struct.</summary>
    /// <param name="type">Type of this payload.</param>
    /// <param name="macroCode">Macro code for this payload.</param>
    /// <param name="body">Raw SeString payload data.</param>
    /// <remarks>No further mutations to the underlying data behind <paramref name="body"/> is expected.</remarks>
    public ReadOnlySePayload( ReadOnlySePayloadType type, MacroCode macroCode, ReadOnlyMemory< byte > body )
    {
        switch( type )
        {
            case ReadOnlySePayloadType.Invalid:
                if( macroCode != default )
                    throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode, "MacroCode may not be defined if the payload is of invalid type." );
                break;
            case ReadOnlySePayloadType.Text:
                if( macroCode != default )
                    throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode, "MacroCode may not be defined if the payload is of text type." );
                break;
            case ReadOnlySePayloadType.Macro:
                if( macroCode == default )
                    throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode, "MacroCode must be defined if the payload is of macro type." );
                if( (byte) macroCode >= 0xCF )
                {
                    throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode,
                        "Whether MacroCode is an integer expression is unknown. Change it when it happens." );
                }

                break;
            default:
                throw new ArgumentOutOfRangeException( nameof( type ), type, null );
        }

        Type = type;
        MacroCode = macroCode;
        Body = body;
    }

    /// <summary>Gets the number of bytes, including the envelope head and tail.</summary>
    public int EnvelopeByteLength {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get {
            return Type switch
            {
                ReadOnlySePayloadType.Invalid => Body.Length,
                ReadOnlySePayloadType.Text => Body.Length,
                ReadOnlySePayloadType.Macro => 2 + SeExpressionUtilities.CalculateLengthInt( Body.Length ) + Body.Length + 1,
                _ => Body.Length,
            };
        }
    }

    /// <summary>Gets the number of direct child expressions contained within this payload.</summary>
    public int ExpressionCount {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get {
            if( Type != ReadOnlySePayloadType.Macro )
                return 0;
            var res = 0;
            foreach( var _ in this )
                res++;
            return res;
        }
    }

    /// <inheritdoc/>
    int IReadOnlyCollection< ReadOnlySeExpression >.Count => ExpressionCount;

    /// <inheritdoc/>
    int ICollection.Count => ExpressionCount;

    /// <inheritdoc/>
    int ICollection< ReadOnlySeExpression >.Count => ExpressionCount;

    /// <inheritdoc/>
    bool ICollection.IsSynchronized => true;

    /// <inheritdoc/>
    object ICollection.SyncRoot => new();

    /// <inheritdoc/>
    bool ICollection< ReadOnlySeExpression >.IsReadOnly => true;

    /// <summary>Returns a value that indicates whether the specified payloads are equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySePayload left, ReadOnlySePayload right ) => left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified payloads are not equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySePayload left, ReadOnlySePayload right ) => !left.Equals( right );

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The payload that comes first.</param>
    /// <param name="right">The payload that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySePayload left, ReadOnlySePayload right )
    {
        var res = new byte[left.EnvelopeByteLength + right.EnvelopeByteLength];
        left.WriteEnvelopeTo( res );
        right.WriteEnvelopeTo( res.AsSpan( left.EnvelopeByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The payload that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeString left, ReadOnlySePayload right )
    {
        var res = new byte[left.ByteLength + right.EnvelopeByteLength];
        left.Data.CopyTo( res );
        right.WriteEnvelopeTo( res.AsSpan( left.ByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The payload that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySePayload left, ReadOnlySeString right )
    {
        var res = new byte[left.EnvelopeByteLength + right.ByteLength];
        left.WriteEnvelopeTo( res );
        right.Data.CopyTo( res.AsMemory( left.EnvelopeByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The payload that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySpan< char > left, ReadOnlySePayload right )
    {
        var lnb = Encoding.UTF8.GetByteCount( left );
        var res = new byte[lnb + right.EnvelopeByteLength];
        Encoding.UTF8.GetBytes( left, res );
        right.WriteEnvelopeTo( res.AsSpan( lnb ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The payload that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySePayload left, ReadOnlySpan< char > right )
    {
        var rnb = Encoding.UTF8.GetByteCount( right );
        var res = new byte[left.EnvelopeByteLength + rnb];
        left.WriteEnvelopeTo( res );
        Encoding.UTF8.GetBytes( right, res.AsSpan( left.EnvelopeByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The payload that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeStringSpan left, ReadOnlySePayload right )
    {
        var res = new byte[left.ByteLength + right.EnvelopeByteLength];
        left.Data.CopyTo( res );
        right.WriteEnvelopeTo( res.AsSpan( left.ByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The payload that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySePayload left, ReadOnlySeStringSpan right )
    {
        var res = new byte[left.EnvelopeByteLength + right.ByteLength];
        left.WriteEnvelopeTo( res );
        right.Data.CopyTo( res.AsSpan( left.EnvelopeByteLength ) );
        return new( res );
    }

    /// <summary>Creates a new instance of <see cref="ReadOnlySePayload"/> from a given UTF-8 string.</summary>
    /// <param name="utf8String">The UTF-8 string.</param>
    /// <returns>A new instance of <see cref="ReadOnlySePayload"/></returns>.
    public static ReadOnlySePayload FromText( ReadOnlySpan< byte > utf8String )
    {
        if( utf8String.IndexOfAny( SeString.StartByte, (byte) 0 ) != -1 )
            throw new ArgumentException( "A SeString cannot contain STX or NUL.", nameof( utf8String ) );
        return new( ReadOnlySePayloadType.Text, default, utf8String.ToArray() );
    }

    /// <summary>Creates a new instance of <see cref="ReadOnlySePayload"/> from a given UTF-8 string.</summary>
    /// <param name="utf8String">The UTF-8 string.</param>
    /// <returns>A new instance of <see cref="ReadOnlySePayload"/></returns>.
    public static ReadOnlySePayload FromText( ReadOnlyMemory< byte > utf8String )
    {
        if( utf8String.Span.IndexOfAny( SeString.StartByte, (byte) 0 ) != -1 )
            throw new ArgumentException( "A SeString cannot contain STX or NUL.", nameof( utf8String ) );
        return new( ReadOnlySePayloadType.Text, default, utf8String );
    }

    /// <summary>Creates a new instance of <see cref="ReadOnlySePayloadSpan"/> from a given UTF-16 string.</summary>
    /// <param name="utf16String">The UTF-16 string.</param>
    /// <returns>A new instance of <see cref="ReadOnlySePayloadSpan"/></returns>.
    public static ReadOnlySePayloadSpan FromText( ReadOnlySpan< char > utf16String )
    {
        if( utf16String.IndexOfAny( (char) SeString.StartByte, (char) 0 ) != -1 )
            throw new ArgumentException( "A SeString cannot contain STX or NUL.", nameof( utf16String ) );
        var buf = new byte[Encoding.UTF8.GetByteCount( utf16String )];
        Encoding.UTF8.GetBytes( utf16String, buf );
        return new( ReadOnlySePayloadType.Text, default, buf );
    }

    /// <summary>Gets a <see cref="ReadOnlySePayloadSpan"/> from this <see cref="ReadOnlySePayload"/>.</summary>
    /// <returns>A new instance of <see cref="ReadOnlySePayloadSpan"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public ReadOnlySePayloadSpan AsSpan() => new( Type, MacroCode, Body.Span );

    /// <summary>Gets the expression forming this payload.</summary>
    /// <param name="expr1">The resolved expression.</param>
    /// <returns><c>true</c> if the expression is resolved.</returns>
    public bool TryGetExpression( out ReadOnlySeExpression expr1 )
    {
        expr1 = default;

        using var enu = GetEnumerator();
        if( !enu.MoveNext() )
            return false;
        expr1 = enu.Current;
        return true;
    }

    /// <summary>Gets the expressions forming this payload.</summary>
    /// <param name="expr1">The resolved expression 1.</param>
    /// <param name="expr2">The resolved expression 2.</param>
    /// <returns><c>true</c> if all expressions are resolved.</returns>
    public bool TryGetExpression( out ReadOnlySeExpression expr1, out ReadOnlySeExpression expr2 )
    {
        expr1 = expr2 = default;

        using var enu = GetEnumerator();
        if( !enu.MoveNext() )
            return false;
        expr1 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr2 = enu.Current;
        return true;
    }

    /// <summary>Gets the expressions forming this payload.</summary>
    /// <param name="expr1">The resolved expression 1.</param>
    /// <param name="expr2">The resolved expression 2.</param>
    /// <param name="expr3">The resolved expression 3.</param>
    /// <returns><c>true</c> if all expressions are resolved.</returns>
    public bool TryGetExpression(
        out ReadOnlySeExpression expr1,
        out ReadOnlySeExpression expr2,
        out ReadOnlySeExpression expr3 )
    {
        expr1 = expr2 = expr3 = default;

        using var enu = GetEnumerator();
        if( !enu.MoveNext() )
            return false;
        expr1 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr2 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr3 = enu.Current;
        return true;
    }

    /// <summary>Gets the expressions forming this payload.</summary>
    /// <param name="expr1">The resolved expression 1.</param>
    /// <param name="expr2">The resolved expression 2.</param>
    /// <param name="expr3">The resolved expression 3.</param>
    /// <param name="expr4">The resolved expression 4.</param>
    /// <returns><c>true</c> if all expressions are resolved.</returns>
    public bool TryGetExpression(
        out ReadOnlySeExpression expr1,
        out ReadOnlySeExpression expr2,
        out ReadOnlySeExpression expr3,
        out ReadOnlySeExpression expr4 )
    {
        expr1 = expr2 = expr3 = expr4 = default;

        using var enu = GetEnumerator();
        if( !enu.MoveNext() )
            return false;
        expr1 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr2 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr3 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr4 = enu.Current;
        return true;
    }

    /// <summary>Gets the expressions forming this payload.</summary>
    /// <param name="expr1">The resolved expression 1.</param>
    /// <param name="expr2">The resolved expression 2.</param>
    /// <param name="expr3">The resolved expression 3.</param>
    /// <param name="expr4">The resolved expression 4.</param>
    /// <param name="expr5">The resolved expression 5.</param>
    /// <returns><c>true</c> if all expressions are resolved.</returns>
    public bool TryGetExpression(
        out ReadOnlySeExpression expr1,
        out ReadOnlySeExpression expr2,
        out ReadOnlySeExpression expr3,
        out ReadOnlySeExpression expr4,
        out ReadOnlySeExpression expr5 )
    {
        expr1 = expr2 = expr3 = expr4 = expr5 = default;

        using var enu = GetEnumerator();
        if( !enu.MoveNext() )
            return false;
        expr1 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr2 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr3 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr4 = enu.Current;
        if( !enu.MoveNext() )
            return false;
        expr5 = enu.Current;
        return true;
    }

    /// <inheritdoc cref="ReadOnlySePayloadSpan.Validate"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Validate() => AsSpan().Validate();

    /// <inheritdoc cref="ReadOnlySePayloadSpan.WriteEnvelopeTo"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public int WriteEnvelopeTo( Span< byte > target ) => AsSpan().WriteEnvelopeTo( target );

    /// <inheritdoc cref="object.Equals(object?)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Equals( ReadOnlySePayload other ) => AsSpan().Equals( other.AsSpan() );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override bool Equals( object? obj ) => obj is ReadOnlySePayload other && Equals( other );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override int GetHashCode() => AsSpan().GetHashCode();

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override string ToString() => AsSpan().ToString();

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public Enumerator GetEnumerator() => new( new( this ) );

    /// <inheritdoc/>
    IEnumerator< ReadOnlySeExpression > IEnumerable< ReadOnlySeExpression >.GetEnumerator() => GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Gets an enumerator that enumerates expressions with their offsets.</summary>
    /// <returns>An enumerator that enumerates expressions with their offsets.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public OffsetEnumerator GetOffsetEnumerator() => new( this );

    /// <inheritdoc/>
    public bool Contains( ReadOnlySeExpression item )
    {
        foreach( var e in this )
        {
            if( e == item )
                return true;
        }

        return false;
    }

    /// <inheritdoc/>
    public void CopyTo( ReadOnlySeExpression[] array, int arrayIndex )
    {
        if( array is null )
            throw new ArgumentNullException( nameof( array ) );
        if( arrayIndex < 0 )
            throw new ArgumentOutOfRangeException( nameof( arrayIndex ), arrayIndex, null );
        if( arrayIndex + ExpressionCount > array.Length )
            throw new ArgumentException( "The number of expressions is greater than the available space.", nameof( array ) );
        foreach( var p in this )
            array[ arrayIndex++ ] = p;
    }

    /// <inheritdoc/>
    void ICollection< ReadOnlySeExpression >.Add( ReadOnlySeExpression item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    void ICollection< ReadOnlySeExpression >.Clear() => throw new NotSupportedException();

    /// <inheritdoc/>
    bool ICollection< ReadOnlySeExpression >.Remove( ReadOnlySeExpression item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    void ICollection.CopyTo( Array? array, int index ) => CopyTo( ( array as ReadOnlySeExpression[] ) switch
    {
        { } a => a,
        null when array is not null => throw new ArrayTypeMismatchException(),
        null => throw new ArgumentNullException( nameof( array ) ),
    }, index );

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySePayload"/> by expressions with offsets.</summary>
    public struct OffsetEnumerator : IEnumerator< (int Offset, ReadOnlySeExpression Expression) >, IEnumerable< (int Offset, ReadOnlySeExpression Expression) >
    {
        private readonly ReadOnlySePayload _obj;
        private int _nextIndex;

        /// <summary>Initializes a new instance of the <see cref="OffsetEnumerator"/> struct.</summary>
        /// <param name="obj">An instance of <see cref="ReadOnlySePayload"/> to enumerate.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator( ReadOnlySePayload obj ) => _obj = obj;

        /// <inheritdoc cref="IEnumerator.Current"/>
        public (int Offset, ReadOnlySeExpression Expression) Current { get; private set; }

        /// <inheritdoc/>
        object IEnumerator.Current => Current;

        /// <inheritdoc cref="IEnumerator.MoveNext"/>
        public bool MoveNext()
        {
            if( _nextIndex >= _obj.Body.Length )
                return false;

            var submemory = _obj.Body[ _nextIndex.. ];
            if( !SeExpressionUtilities.TryDecodeLength( submemory, out var length ) )
                length = 1;

            Current = ( _nextIndex, new( submemory[ ..length ] ) );
            _nextIndex += length;
            return true;
        }

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Reset() => _nextIndex = 0;

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Dispose()
        { }

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator GetEnumerator() => new( _obj );

        /// <inheritdoc/>
        IEnumerator< (int Offset, ReadOnlySeExpression Expression) > IEnumerable< (int Offset, ReadOnlySeExpression Expression) >.GetEnumerator() =>
            GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySePayload"/> by payloads.</summary>
    public struct Enumerator : IEnumerator< ReadOnlySeExpression >, IEnumerable< ReadOnlySeExpression >
    {
        private OffsetEnumerator _offsetEnumerator;

        /// <summary>Initializes a new instance of the <see cref="Enumerator"/> struct.</summary>
        /// <param name="offsetEnumerator">An instance of <see cref="OffsetEnumerator"/>.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public Enumerator( OffsetEnumerator offsetEnumerator ) => _offsetEnumerator = offsetEnumerator;

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public bool MoveNext() => _offsetEnumerator.MoveNext();

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Reset() => _offsetEnumerator.Reset();

        /// <inheritdoc/>
        public ReadOnlySeExpression Current {
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            get => _offsetEnumerator.Current.Expression;
        }

        /// <inheritdoc/>
        object IEnumerator.Current => _offsetEnumerator.Current.Expression;

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Dispose() => _offsetEnumerator.Dispose();

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public Enumerator GetEnumerator() => new( _offsetEnumerator );

        /// <inheritdoc/>
        IEnumerator< ReadOnlySeExpression > IEnumerable< ReadOnlySeExpression >.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}