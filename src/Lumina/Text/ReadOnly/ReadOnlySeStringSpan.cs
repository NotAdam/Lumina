using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Lumina.Text.Payloads;

namespace Lumina.Text.ReadOnly;

/// <summary>A <see cref="string"/>-like immutable implementation of SeString.</summary>
[SuppressMessage( "ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator", Justification = "Avoid heap allocation" )]
public readonly ref struct ReadOnlySeStringSpan
{
    /// <summary>Read-only byte data for the SeString.</summary>
    public readonly ReadOnlySpan< byte > Data;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeStringSpan"/> struct.</summary>
    /// <param name="data">Raw SeString data.</param>
    /// <remarks>No further mutations to the underlying data behind <paramref name="data"/> is expected.</remarks>
    public ReadOnlySeStringSpan( ReadOnlySpan< byte > data ) => Data = data;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeStringSpan"/> struct.</summary>
    /// <param name="pointer">Pointer to the raw SeString data.</param>
    /// <remarks>A SeString is a null-terminated byte sequence, so passing length is not necessary.</remarks>
    public unsafe ReadOnlySeStringSpan( byte* pointer ) : this( MemoryMarshal.CreateReadOnlySpanFromNullTerminated( pointer ) )
    { }

    /// <summary>Gets a value indicating whether this <see cref="ReadOnlySeStringSpan"/> is empty.</summary>
    public bool IsEmpty {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get => Data.IsEmpty;
    }

    /// <summary>Gets the number of bytes in this <see cref="ReadOnlySeStringSpan"/>.</summary>
    public int ByteLength {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get => Data.Length;
    }

    /// <summary>Gets the number of direct child payloads in this <see cref="ReadOnlySeStringSpan"/>.</summary>
    public int PayloadCount {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get {
            var res = 0;
            foreach( var _ in this )
                res++;
            return res;
        }
    }

    /// <summary>Gets the read-only byte memory view of this instance of <see cref="ReadOnlySeStringSpan"/>.</summary>
    /// <param name="s">The string to get a byte span view of.</param>
    /// <returns>The read-only byte span view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySpan< byte >( ReadOnlySeStringSpan s ) => s.Data;

    /// <summary>Creates a new instance of <see cref="ReadOnlySeStringSpan"/> struct from the given byte span view.</summary>
    /// <param name="s">The source byte span view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeStringSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeStringSpan( ReadOnlySpan< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeStringSpan"/> struct from the given byte span view.</summary>
    /// <param name="s">The source byte span view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeStringSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeStringSpan( Span< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeStringSpan"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeStringSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeStringSpan( ReadOnlyMemory< byte > s ) => new( s.Span );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeStringSpan"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeStringSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeStringSpan( Memory< byte > s ) => new( s.Span );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeStringSpan"/> struct from the given byte array.</summary>
    /// <param name="s">The source byte array.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeStringSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks><paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeStringSpan( byte[] s ) => new( s );

    /// <summary>Returns a value that indicates whether the specified strings are equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeStringSpan left, ReadOnlySeStringSpan right ) => left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified strings are equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeStringSpan left, ReadOnlySeString right ) => left.Equals( right.AsSpan() );

    /// <summary>Returns a value that indicates whether the specified strings are equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeString left, ReadOnlySeStringSpan right ) => left.AsSpan().Equals( right );

    /// <summary>Returns a value that indicates whether the specified strings are not equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeStringSpan left, ReadOnlySeStringSpan right ) => !left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified strings are not equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeStringSpan left, ReadOnlySeString right ) => !left.Equals( right.AsSpan() );

    /// <summary>Returns a value that indicates whether the specified strings are not equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeString left, ReadOnlySeStringSpan right ) => !left.AsSpan().Equals( right );

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeString left, ReadOnlySeStringSpan right )
    {
        var res = new byte[left.ByteLength + right.ByteLength];
        left.Data.CopyTo( res );
        right.Data.CopyTo( res.AsSpan( left.ByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeStringSpan left, ReadOnlySeString right )
    {
        var res = new byte[left.ByteLength + right.ByteLength];
        left.Data.CopyTo( res );
        right.Data.CopyTo( res.AsMemory( left.ByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeStringSpan left, ReadOnlySeStringSpan right )
    {
        var res = new byte[left.ByteLength + right.ByteLength];
        left.Data.CopyTo( res );
        right.Data.CopyTo( res.AsSpan( left.ByteLength ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeStringSpan left, ReadOnlySpan< char > right )
    {
        var rnb = Encoding.UTF8.GetByteCount( right );
        var res = new byte[left.ByteLength + rnb];
        left.Data.CopyTo( res );
        Encoding.UTF8.GetBytes( right, res.AsSpan( left.Data.Length ) );
        return new( res );
    }

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySpan< char > left, ReadOnlySeStringSpan right )
    {
        var lnb = Encoding.UTF8.GetByteCount( left );
        var res = new byte[lnb + right.ByteLength];
        Encoding.UTF8.GetBytes( left, res );
        right.Data.CopyTo( res.AsSpan( lnb ) );
        return new( res );
    }

    /// <summary>Validates whether this instance of SeString is well-formed.</summary>
    /// <returns><c>true</c> if this instance of <see cref="ReadOnlySeStringSpan"/> is structurally valid.</returns>
    public bool Validate()
    {
        foreach( var p in this )
        {
            if( !p.Validate() )
                return false;
        }

        return false;
    }

    /// <summary>Extracts the text contained in this instance of <see cref="ReadOnlySeStringSpan"/>, ignoring any payload that does not have a direct equivalent string
    /// representation.</summary>
    /// <returns>The extracted text.</returns>
    public string ExtractText()
    {
        var len = 0;
        foreach( var v in this )
        {
            switch( v.Type )
            {
                case ReadOnlySePayloadType.Text:
                    len += Encoding.UTF8.GetCharCount( v.Body );
                    break;
                case ReadOnlySePayloadType.Macro:
                {
                    switch( v.MacroCode )
                    {
                        case MacroCode.NewLine:
                            len += Environment.NewLine.Length;
                            break;
                        case MacroCode.NonBreakingSpace:
                        case MacroCode.Hyphen:
                        case MacroCode.SoftHyphen:
                            len += 1;
                            break;
                    }

                    break;
                }
            }
        }

        var buf = new char[len];
        var bufspan = buf.AsSpan();
        foreach( var v in this )
        {
            switch( v.Type )
            {
                case ReadOnlySePayloadType.Text:
                    bufspan = bufspan[ Encoding.UTF8.GetChars( v.Body, bufspan ) .. ];
                    break;
                case ReadOnlySePayloadType.Macro:
                {
                    switch( v.MacroCode )
                    {
                        case MacroCode.NewLine:
                            Environment.NewLine.CopyTo( bufspan );
                            bufspan = bufspan[ Environment.NewLine.Length .. ];
                            break;

                        case MacroCode.NonBreakingSpace:
                            bufspan[ 0 ] = '\u00A0';
                            bufspan = bufspan[ 1.. ];
                            break;

                        case MacroCode.Hyphen:
                            bufspan[ 0 ] = '-';
                            bufspan = bufspan[ 1.. ];
                            break;

                        case MacroCode.SoftHyphen:
                            bufspan[ 0 ] = '\u00AD';
                            bufspan = bufspan[ 1.. ];
                            break;
                    }

                    break;
                }
            }
        }

        return new( buf );
    }

    /// <inheritdoc cref="object.Equals(object?)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Equals( ReadOnlySeStringSpan other ) => Data.SequenceEqual( other.Data );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override bool Equals( object? obj ) => false;

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override int GetHashCode()
    {
        var hc = default( HashCode );
        hc.AddBytes( Data );
        return hc.ToHashCode();
    }

    /// <summary>Gets the encodeable macro representation of this instance of <see cref="ReadOnlySeStringSpan"/>.</summary>
    /// <returns>The encodeable macro representation.</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        AppendMacroStringToStringBuilder( sb, false );
        return sb.ToString();
    }

    /// <summary>Writes the encodeable macro representation of this instance of <see cref="ReadOnlySeStringSpan"/> to the given string builder.</summary>
    /// <param name="sb">Target string builder.</param>
    /// <param name="forStringExpression">Whether this is being encoded to be used as a string expression.</param>
    /// <returns>The encodeable macro representation.</returns>
    public void AppendMacroStringToStringBuilder( StringBuilder sb, bool forStringExpression )
    {
        foreach( var v in this )
            v.AppendMacroStringToStringBuilder( sb, forStringExpression );
    }

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public Enumerator GetEnumerator() => new( new( this ) );

    /// <summary>Gets an enumerator that enumerates payloads with their offsets.</summary>
    /// <returns>An enumerator that enumerates payloads with their offsets.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public OffsetEnumerator GetOffsetEnumerator() => new( this );

    /// <summary>A pair of offset in <see cref="Data"/> and the corresponding instance of <see cref="ReadOnlySePayloadSpan"/>.</summary>
    public readonly ref struct OffsetAndPayload
    {
        /// <summary>The offset in <see cref="Data"/> that <see cref="Payload"/> is at.</summary>
        public readonly int Offset;

        /// <summary>The payload.</summary>
        public readonly ReadOnlySePayloadSpan Payload;

        /// <summary>Initializes a new instance of the <see cref="OffsetAndPayload"/> struct.</summary>
        /// <param name="offset">The offset.</param>
        /// <param name="payload">The expression.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetAndPayload( int offset, ReadOnlySePayloadSpan payload )
        {
            Offset = offset;
            Payload = payload;
        }
    }

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySeStringSpan"/> by payloads with offsets.</summary>
    public ref struct OffsetEnumerator
    {
        private readonly ReadOnlySeStringSpan _obj;
        private int _nextIndex;

        /// <summary>Initializes a new instance of the <see cref="OffsetEnumerator"/> struct.</summary>
        /// <param name="obj">An instance of <see cref="ReadOnlySeStringSpan"/> to enumerate.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator( ReadOnlySeStringSpan obj )
        {
            _obj = obj;
            _nextIndex = 0;
        }

        /// <summary>Gets the byte offset of the current payload.</summary>
        public OffsetAndPayload Current { get; private set; }

        /// <inheritdoc cref="IEnumerator.MoveNext"/>
        public bool MoveNext()
        {
            if( _nextIndex >= _obj.Data.Length )
                return false;

            var subspan = _obj.Data[ _nextIndex.. ];
            switch( subspan[ 0 ] )
            {
                // A valid SeString never "contains a null byte; it is always the terminator.
                // Take one byte, and consider it as an invalid payload.
                case 0:
                    Current = new(
                        _nextIndex,
                        new( ReadOnlySePayloadType.Invalid, default, _obj.Data.Slice( _nextIndex, 1 ) ) );
                    _nextIndex += 1;
                    break;

                // Start byte.
                case ReadOnlySeString.Stx:
                {
                    // A macro payload is always at least 4 bytes. (STX, macro type, body length, ETX)
                    // If we cannot produce a well-formed macro payload, consider the current byte as a single byte invalid payload.
                    if( subspan.Length < 4 )
                        goto case 0;

                    var macroCode = (MacroCode) subspan[ 1 ];
                    if( !SeExpressionUtilities.TryDecodeInt( subspan[ 2.. ], out var bodyLength, out var bodyLengthLength ) )
                        goto case 0;

                    // See above comments on if( Length < 4 ). 
                    if( 2 + bodyLengthLength + bodyLength + 1 > subspan.Length )
                        goto case 0;

                    // The payload is not terminating with an ETX. Consider it invalid.
                    if( subspan[ 2 + bodyLengthLength + bodyLength ] != ReadOnlySeString.Etx )
                        goto case 0;

                    Current = new(
                        _nextIndex,
                        new( ReadOnlySePayloadType.Macro, macroCode, _obj.Data.Slice( _nextIndex + 2 + bodyLengthLength, bodyLength ) ) );
                    _nextIndex += 2 + bodyLengthLength + bodyLength + 1;
                    break;
                }

                // Raw text that will be followed by a payload or a null character.
                case var _ when subspan.IndexOfAny( (byte) 2, (byte) 0 ) is var i and >= 0:
                    Current = new(
                        _nextIndex,
                        new( ReadOnlySePayloadType.Text, default, _obj.Data.Slice( _nextIndex, i ) ) );
                    _nextIndex += i;
                    break;

                // Final raw text.
                default:
                    Current = new(
                        _nextIndex,
                        new( ReadOnlySePayloadType.Text, default, _obj.Data[ _nextIndex.. ] ) );
                    _nextIndex = _obj.Data.Length;
                    break;
            }

            return true;
        }

        /// <inheritdoc cref="IEnumerator.Reset"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Reset() => _nextIndex = 0;

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator GetEnumerator() => new( _obj );
    }

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySeStringSpan"/> by payloads.</summary>
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
        public ReadOnlySePayloadSpan Current {
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            get => _offsetEnumerator.Current.Payload;
        }

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public Enumerator GetEnumerator() => new( _offsetEnumerator );
    }
}