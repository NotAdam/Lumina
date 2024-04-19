using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Text.Payloads;

namespace Lumina.Text.ReadOnly;

/// <summary>Represents a payload in a <see cref="ReadOnlySeStringSpan"/>.</summary>
[SuppressMessage( "ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator", Justification = "Avoid heap allocation" )]
public readonly ref struct ReadOnlySePayloadSpan
{
    /// <summary>Type of this payload.</summary>
    public readonly ReadOnlySePayloadType Type;

    /// <summary>Type of the macro contained within, if <see cref="Type"/> is <see cref="ReadOnlySePayloadType.Macro"/>.</summary>
    public readonly MacroCode MacroCode;

    /// <summary>Payload body, excluding envelope head and tail if <see cref="ReadOnlySePayloadType.Macro"/>.</summary>
    public readonly ReadOnlySpan< byte > Body;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySePayloadSpan"/> struct.</summary>
    /// <param name="type">Type of this payload.</param>
    /// <param name="macroCode">Macro code for this payload.</param>
    /// <param name="body">Raw SeString payload data.</param>
    /// <remarks>No further mutations to the underlying data behind <paramref name="body"/> is expected.</remarks>
    public ReadOnlySePayloadSpan( ReadOnlySePayloadType type, MacroCode macroCode, ReadOnlySpan< byte > body )
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
                if( !Enum.IsDefined( macroCode ) || macroCode == 0 )
                    throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode, null );
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

    /// <summary>Returns a value that indicates whether the specified payloads are equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySePayloadSpan left, ReadOnlySePayloadSpan right ) => left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified payloads are equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySePayloadSpan left, ReadOnlySePayload right ) => left.Equals( right.AsSpan() );

    /// <summary>Returns a value that indicates whether the specified payloads are equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySePayload left, ReadOnlySePayloadSpan right ) => left.AsSpan().Equals( right );

    /// <summary>Returns a value that indicates whether the specified payloads are not equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySePayloadSpan left, ReadOnlySePayloadSpan right ) => !left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified payloads are not equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySePayloadSpan left, ReadOnlySePayload right ) => !left.Equals( right.AsSpan() );

    /// <summary>Returns a value that indicates whether the specified payloads are not equal.</summary>
    /// <param name="left">The first payload to compare.</param>
    /// <param name="right">The second payload to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySePayload left, ReadOnlySePayloadSpan right ) => !left.AsSpan().Equals( right );

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The payload that comes first.</param>
    /// <param name="right">The payload that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySePayloadSpan left, ReadOnlySePayloadSpan right )
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
    public static ReadOnlySeString operator +( ReadOnlySeString left, ReadOnlySePayloadSpan right )
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
    public static ReadOnlySeString operator +( ReadOnlySePayloadSpan left, ReadOnlySeString right )
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
    public static ReadOnlySeString operator +( ReadOnlySpan< char > left, ReadOnlySePayloadSpan right )
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
    public static ReadOnlySeString operator +( ReadOnlySePayloadSpan left, ReadOnlySpan< char > right )
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
    public static ReadOnlySeString operator +( ReadOnlySeStringSpan left, ReadOnlySePayloadSpan right )
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
    public static ReadOnlySeString operator +( ReadOnlySePayloadSpan left, ReadOnlySeStringSpan right )
    {
        var res = new byte[left.EnvelopeByteLength + right.ByteLength];
        left.WriteEnvelopeTo( res );
        right.Data.CopyTo( res.AsSpan( left.EnvelopeByteLength ) );
        return new( res );
    }

    /// <summary>Creates a new instance of <see cref="ReadOnlySePayloadSpan"/> from a given UTF-8 string.</summary>
    /// <param name="utf8String">The UTF-8 string.</param>
    /// <returns>A new instance of <see cref="ReadOnlySePayloadSpan"/></returns>.
    public static ReadOnlySePayloadSpan FromText( ReadOnlySpan< byte > utf8String )
    {
        if( utf8String.IndexOfAny( SeString.StartByte, (byte) 0 ) != -1 )
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

    /// <summary>Gets the expression forming this payload.</summary>
    /// <param name="expr1">The resolved expression.</param>
    /// <returns><c>true</c> if the expression is resolved.</returns>
    public bool TryGetExpression( out ReadOnlySeExpressionSpan expr1 )
    {
        expr1 = default;

        var enu = GetEnumerator();
        if( !enu.MoveNext() )
            return false;
        expr1 = enu.Current;
        return true;
    }

    /// <summary>Gets the expressions forming this payload.</summary>
    /// <param name="expr1">The resolved expression 1.</param>
    /// <param name="expr2">The resolved expression 2.</param>
    /// <returns><c>true</c> if all expressions are resolved.</returns>
    public bool TryGetExpression( out ReadOnlySeExpressionSpan expr1, out ReadOnlySeExpressionSpan expr2 )
    {
        expr1 = expr2 = default;

        var enu = GetEnumerator();
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
        out ReadOnlySeExpressionSpan expr1,
        out ReadOnlySeExpressionSpan expr2,
        out ReadOnlySeExpressionSpan expr3 )
    {
        expr1 = expr2 = expr3 = default;

        var enu = GetEnumerator();
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
        out ReadOnlySeExpressionSpan expr1,
        out ReadOnlySeExpressionSpan expr2,
        out ReadOnlySeExpressionSpan expr3,
        out ReadOnlySeExpressionSpan expr4 )
    {
        expr1 = expr2 = expr3 = expr4 = default;

        var enu = GetEnumerator();
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
        out ReadOnlySeExpressionSpan expr1,
        out ReadOnlySeExpressionSpan expr2,
        out ReadOnlySeExpressionSpan expr3,
        out ReadOnlySeExpressionSpan expr4,
        out ReadOnlySeExpressionSpan expr5 )
    {
        expr1 = expr2 = expr3 = expr4 = expr5 = default;

        var enu = GetEnumerator();
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

    /// <summary>Validates whether this instance of <see cref="ReadOnlySePayloadSpan"/> is well-formed.</summary>
    /// <returns><c>true</c> if this instance of <see cref="ReadOnlySePayloadSpan"/> is structurally valid.</returns>
    public bool Validate()
    {
        switch( Type )
        {
            case ReadOnlySePayloadType.Invalid:
            default:
                return false;

            case ReadOnlySePayloadType.Text:
                // A text may not contain NUL or STX.
                return Body.IndexOfAny( (byte) 0, (byte) 2 ) == -1;

            case ReadOnlySePayloadType.Macro:
                foreach( var v in this )
                {
                    if( !v.Validate() )
                        return false;
                }

                return true;
        }
    }

    /// <summary>Writes the data in envelope to the given byte span.</summary>
    /// <param name="target">The optional target that should be at least of size <see cref="EnvelopeByteLength"/>.</param>
    /// <returns>Number of bytes (that has to be) written.</returns>
    public int WriteEnvelopeTo( Span< byte > target )
    {
        switch( Type )
        {
            case ReadOnlySePayloadType.Invalid:
            case ReadOnlySePayloadType.Text:
            default:
                if( !target.IsEmpty )
                    Body.CopyTo( target );
                return Body.Length;
            case ReadOnlySePayloadType.Macro:
                var len = 0;
                len += SeExpressionUtilities.WriteRaw( target.IsEmpty ? target : target[ len.. ], SeString.StartByte );
                len += SeExpressionUtilities.WriteRaw( target.IsEmpty ? target : target[ len.. ], (byte) MacroCode );
                len += SeExpressionUtilities.EncodeInt( target.IsEmpty ? target : target[ len.. ], Body.Length );
                len += SeExpressionUtilities.WriteRaw( target.IsEmpty ? target : target[ len.. ], Body );
                len += SeExpressionUtilities.WriteRaw( target.IsEmpty ? target : target[ len.. ], SeString.EndByte );
                return len;
        }
    }

    /// <inheritdoc cref="object.Equals(object?)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Equals( ReadOnlySePayloadSpan other ) => Type == other.Type && MacroCode == other.MacroCode && Body.SequenceEqual( other.Body );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override bool Equals( object? obj ) => false;

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override int GetHashCode()
    {
        var hc = default( HashCode );
        hc.Add( Type );
        hc.Add( MacroCode );
        hc.AddBytes( Body );
        return hc.ToHashCode();
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        switch( Type )
        {
            case ReadOnlySePayloadType.Text:
                return Encoding.UTF8.GetString( Body ).Replace( "<", "\\<" );

            case ReadOnlySePayloadType.Macro:
            {
                var sb = new StringBuilder( "<" );

                // Not using ternary operator here, as it's better to let StringBuilder handle the string interpolation.
                if( MacroCode.GetEncodeName() is { } encodeName )
                    sb.Append( encodeName );
                else
                    sb.Append( $"x{(uint) MacroCode:X02}" );

                var expre = GetEnumerator();
                if( expre.MoveNext() )
                {
                    sb.Append( '(' );
                    sb.Append( expre.Current.ToString() );
                    while( expre.MoveNext() )
                        sb.Append( ", " ).Append( expre.Current.ToString() );
                    sb.Append( ')' );
                }

                return sb.Append( '>' ).ToString();
            }

            case var _ when Body.Length == 0:
                return "<?>";

            default:
            {
                var sb = new StringBuilder( 3 * Body.Length + 3 );
                sb.Append( "<?" );
                foreach (var b in Body)
                    sb.Append( $" {b:X02}" );
                return sb.Append( '>' ).ToString();
            }
        }
    }

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public Enumerator GetEnumerator() => new( new( this ) );

    /// <summary>Gets an enumerator that enumerates expressions with their offsets.</summary>
    /// <returns>An enumerator that enumerates expressions with their offsets.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public OffsetEnumerator GetOffsetEnumerator() => new( this );

    /// <summary>A pair of offset in <see cref="Data"/> and the corresponding instance of <see cref="ReadOnlySeExpressionSpan"/>.</summary>
    public readonly ref struct OffsetAndExpression
    {
        /// <summary>The offset in <see cref="Data"/> that <see cref="Expression"/> is at.</summary>
        public readonly int Offset;

        /// <summary>The expression.</summary>
        public readonly ReadOnlySeExpressionSpan Expression;

        /// <summary>Initializes a new instance of the <see cref="OffsetAndExpression"/> struct.</summary>
        /// <param name="offset">The offset.</param>
        /// <param name="expression">The expression.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetAndExpression( int offset, ReadOnlySeExpressionSpan expression )
        {
            Offset = offset;
            Expression = expression;
        }
    }

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySePayloadSpan"/> by expressions with offsets.</summary>
    public ref struct OffsetEnumerator
    {
        private readonly ReadOnlySePayloadSpan _obj;
        private int _nextIndex;

        /// <summary>Initializes a new instance of the <see cref="OffsetEnumerator"/> struct.</summary>
        /// <param name="obj">An instance of <see cref="ReadOnlySePayloadSpan"/> to enumerate.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator( ReadOnlySePayloadSpan obj ) => _obj = obj;

        /// <inheritdoc cref="IEnumerator.Current"/>
        public OffsetAndExpression Current { get; private set; }

        /// <inheritdoc cref="IEnumerator.MoveNext"/>
        public bool MoveNext()
        {
            if( _nextIndex >= _obj.Body.Length )
                return false;

            var submemory = _obj.Body[ _nextIndex.. ];
            if( !SeExpressionUtilities.TryDecodeLength( submemory, out var length ) )
                length = 1;

            Current = new( _nextIndex, new( submemory[ ..length ] ) );
            _nextIndex += length;
            return true;
        }

        /// <inheritdoc cref="IEnumerator.Reset"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Reset() => _nextIndex = 0;

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator GetEnumerator() => new( _obj );
    }

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySePayloadSpan"/> by payloads.</summary>
    public ref struct Enumerator
    {
        private OffsetEnumerator _offsetEnumerator;

        /// <summary>Initializes a new instance of the <see cref="Enumerator"/> struct.</summary>
        /// <param name="offsetEnumerator">An instance of <see cref="OffsetEnumerator"/>.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public Enumerator( OffsetEnumerator offsetEnumerator ) => _offsetEnumerator = offsetEnumerator;

        /// <inheritdoc cref="IEnumerator.MoveNext"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public bool MoveNext() => _offsetEnumerator.MoveNext();

        /// <inheritdoc cref="IEnumerator.Reset"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Reset() => _offsetEnumerator.Reset();

        /// <inheritdoc cref="IEnumerator.Current"/>
        public ReadOnlySeExpressionSpan Current {
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            get => _offsetEnumerator.Current.Expression;
        }

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public Enumerator GetEnumerator() => new( _offsetEnumerator );
    }
}