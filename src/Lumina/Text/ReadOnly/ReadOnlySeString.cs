using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Text.Payloads;

namespace Lumina.Text.ReadOnly;

/// <summary>A <see cref="string"/>-like immutable implementation of SeString.</summary>
[SuppressMessage( "ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator", Justification = "Avoid heap allocation" )]
public readonly struct ReadOnlySeString : IEquatable< ReadOnlySeString >, IReadOnlyCollection< ReadOnlySePayload >, ICollection< ReadOnlySePayload >,
    ICollection
{
    /// <summary>STX, which is used as a sentinel value in a SeString to signify that a macro payload will follow.</summary>
    public const byte Stx = 2;

    /// <summary>ETX, which is used as a sentinel value in a SeString to signify that a macro payload will end.</summary>
    public const byte Etx = 3;

    /// <summary>Read-only byte data for the SeString.</summary>
    public readonly ReadOnlyMemory< byte > Data;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeString"/> struct.</summary>
    /// <param name="data">Raw SeString data to copy from.</param>
    /// <remarks>Data is copied from <paramref name="data"/>; this function is not allocation-free.</remarks>
    public ReadOnlySeString( ReadOnlySpan< byte > data ) => Data = data.ToArray();

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlySpan{byte})"/>
    public ReadOnlySeString( Span< byte > data ) => Data = data.ToArray();

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeString"/> struct.</summary>
    /// <param name="data">Raw SeString data.</param>
    /// <remarks>No further mutations to the underlying data behind <paramref name="data"/> is expected.</remarks>
    public ReadOnlySeString( ReadOnlyMemory< byte > data ) => Data = data;

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlyMemory{byte})"/>
    public ReadOnlySeString( Memory< byte > data ) => Data = data;

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlyMemory{byte})"/>
    public ReadOnlySeString( byte[] data ) => Data = data;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeString"/> struct.</summary>
    /// <param name="data">Raw UTF-16 string data to copy from.</param>
    /// <remarks>Data is copied from <paramref name="data"/>; this function is not allocation-free.</remarks>
    public ReadOnlySeString( ReadOnlySpan< char > data )
    {
        if( data.IndexOfAny( (char) Stx, (char) Etx ) != -1 )
            throw new ArgumentException( "STX and ETX cannot be contained in the string.", nameof( data ) );
        var d = new byte[Encoding.UTF8.GetByteCount( data )];
        Encoding.UTF8.GetBytes( data, d );
        Data = d;
    }

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlySpan{char})"/>
    public ReadOnlySeString( Span< char > data ) : this( (ReadOnlySpan< char >) data )
    { }

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlySpan{char})"/>
    public ReadOnlySeString( ReadOnlyMemory< char > data ) : this( data.Span )
    { }

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlySpan{char})"/>
    public ReadOnlySeString( Memory< char > data ) : this( data.Span )
    { }

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlySpan{char})"/>
    public ReadOnlySeString( char[] data ) : this( data.AsSpan() )
    { }

    /// <inheritdoc cref="ReadOnlySeString(ReadOnlySpan{char})"/>
    public ReadOnlySeString( string? data ) : this( data.AsSpan() )
    { }

    /// <summary>Gets a value indicating whether this <see cref="ReadOnlySeString"/> is empty.</summary>
    public bool IsEmpty {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get => Data.IsEmpty;
    }

    /// <summary>Gets the number of bytes in this <see cref="ReadOnlySeString"/>.</summary>
    public int ByteLength {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get => Data.Length;
    }

    /// <summary>Gets the number of direct child payloads in this <see cref="ReadOnlySeString"/>.</summary>
    public int PayloadCount {
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        get {
            var res = 0;
            foreach( var _ in this )
                res++;
            return res;
        }
    }

    /// <inheritdoc/>
    int IReadOnlyCollection< ReadOnlySePayload >.Count => PayloadCount;

    /// <inheritdoc/>
    int ICollection.Count => PayloadCount;

    /// <inheritdoc/>
    int ICollection< ReadOnlySePayload >.Count => PayloadCount;

    /// <inheritdoc/>
    bool ICollection.IsSynchronized => true;

    /// <inheritdoc/>
    object ICollection.SyncRoot => new();

    /// <inheritdoc/>
    bool ICollection< ReadOnlySePayload >.IsReadOnly => true;

    /// <summary>Gets the read-only byte memory view of this instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="s">The string to get a byte memory view of.</param>
    /// <returns>The read-only byte memory view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlyMemory< byte >( ReadOnlySeString s ) => s.Data;

    /// <summary>Gets the read-only byte span view of this instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="s">The string to get a byte span view of.</param>
    /// <returns>The read-only byte span view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySpan< byte >( ReadOnlySeString s ) => s.Data.Span;

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( ReadOnlyMemory< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( Memory< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given byte span view.</summary>
    /// <param name="s">The source byte span view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/>.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( ReadOnlySpan< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given byte span view.</summary>
    /// <param name="s">The source byte span view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/>.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( Span< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given byte array.</summary>
    /// <param name="s">The source byte array.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks><paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( byte[] s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given char memory view.</summary>
    /// <param name="s">The source char memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/> encoded in UTF-8.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( ReadOnlyMemory< char > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given char memory view.</summary>
    /// <param name="s">The source char memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/> encoded in UTF-8.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( Memory< char > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given char span view.</summary>
    /// <param name="s">The source char span view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/> encoded in UTF-8.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( ReadOnlySpan< char > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given char span view.</summary>
    /// <param name="s">The source char span view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/> encoded in UTF-8.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( Span< char > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given char array.</summary>
    /// <param name="s">The source char array.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/> encoded in UTF-8.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( char[] s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeString"/> struct from the given char array.</summary>
    /// <param name="s">The source char array.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/> with <paramref name="s"/> encoded in UTF-8.</returns>
    /// <remarks>Data of <paramref name="s"/> is copied; this function is not allocation-free.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeString( string? s ) => new( s );

    /// <summary>Returns a value that indicates whether the specified strings are equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeString left, ReadOnlySeString right ) => left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified strings are not equal.</summary>
    /// <param name="left">The first string to compare.</param>
    /// <param name="right">The second string to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeString left, ReadOnlySeString right ) => !left.Equals( right );

    /// <summary>Returns a concatenated instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <param name="left">The string that comes first.</param>
    /// <param name="right">The string that comes second.</param>
    /// <returns>The concatenated string.</returns>
    public static ReadOnlySeString operator +( ReadOnlySeString left, ReadOnlySeString right )
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
    public static ReadOnlySeString operator +( ReadOnlySeString left, ReadOnlySpan< char > right )
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
    public static ReadOnlySeString operator +( ReadOnlySpan< char > left, ReadOnlySeString right )
    {
        var lnb = Encoding.UTF8.GetByteCount( left );
        var res = new byte[lnb + right.ByteLength];
        Encoding.UTF8.GetBytes( left, res );
        right.Data.CopyTo( res.AsMemory( lnb ) );
        return new( res );
    }

    /// <summary>Creates a new instance of the <see cref="ReadOnlySeString"/> struct from the given text in UTF-8.</summary>
    /// <param name="text">Text to create a new <see cref="ReadOnlySeString"/> from.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/>, independent of the backing memory of <paramref name="text"/>.</returns>
    public static ReadOnlySeString FromText( ReadOnlySpan< byte > text )
    {
        if( text.IndexOfAny( Stx, Etx ) != -1 )
            throw new ArgumentException( "STX and ETX cannot be contained in the string.", nameof( text ) );
        return new( text );
    }

    /// <summary>Creates a new instance of the <see cref="ReadOnlySeString"/> struct from the given text in UTF-16.</summary>
    /// <param name="text">Text to create a new <see cref="ReadOnlySeString"/> from.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/>, independent of the backing memory of <paramref name="text"/>.</returns>
    public static ReadOnlySeString FromText( ReadOnlySpan< char > text ) => new( text );

    /// <summary>Gets a <see cref="ReadOnlySeStringSpan"/> from this <see cref="ReadOnlySeString"/>.</summary>
    /// <returns>A new instance of <see cref="ReadOnlySeStringSpan"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public ReadOnlySeStringSpan AsSpan() => new( Data.Span );

    /// <inheritdoc cref="ReadOnlySeStringSpan.Validate"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Validate() => AsSpan().Validate();

    /// <inheritdoc cref="ReadOnlySeStringSpan.ExtractText"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public string ExtractText() => AsSpan().ExtractText();

    /// <inheritdoc cref="object.Equals(object?)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Equals( ReadOnlySeString other ) => AsSpan().Equals( other.AsSpan() );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override bool Equals( object? obj ) => obj is ReadOnlySeString other && Equals( other );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override int GetHashCode() => AsSpan().GetHashCode();

    /// <summary>Gets the encodeable macro representation of this instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <returns>The encodeable macro representation.</returns>
    public override string ToString() => AsSpan().ToString();

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public Enumerator GetEnumerator() => new( new( this ) );

    /// <inheritdoc/>
    IEnumerator< ReadOnlySePayload > IEnumerable< ReadOnlySePayload >.GetEnumerator() => GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Gets an enumerator that enumerates payloads with their offsets.</summary>
    /// <returns>An enumerator that enumerates payloads with their offsets.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public OffsetEnumerator GetOffsetEnumerator() => new( this );

    /// <inheritdoc/>
    public bool Contains( ReadOnlySePayload item )
    {
        foreach( var e in this )
        {
            if( e == item )
                return true;
        }

        return false;
    }

    /// <inheritdoc/>
    public void CopyTo( ReadOnlySePayload[] array, int arrayIndex )
    {
        if( array is null )
            throw new ArgumentNullException( nameof( array ) );
        if( arrayIndex < 0 )
            throw new ArgumentOutOfRangeException( nameof( arrayIndex ), arrayIndex, null );
        if( arrayIndex + PayloadCount > array.Length )
            throw new ArgumentException( "The number of payloads is greater than the available space.", nameof( array ) );
        foreach( var p in this )
            array[ arrayIndex++ ] = p;
    }

    /// <inheritdoc/>
    void ICollection< ReadOnlySePayload >.Add( ReadOnlySePayload item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    void ICollection< ReadOnlySePayload >.Clear() => throw new NotSupportedException();

    /// <inheritdoc/>
    bool ICollection< ReadOnlySePayload >.Remove( ReadOnlySePayload item ) => throw new NotSupportedException();

    /// <inheritdoc/>
    void ICollection.CopyTo( Array? array, int index ) => CopyTo( ( array as ReadOnlySePayload[] ) switch
    {
        { } a => a,
        null when array is not null => throw new ArrayTypeMismatchException(),
        null => throw new ArgumentNullException( nameof( array ) ),
    }, index );

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySeString"/> by payloads with offsets.</summary>
    public struct OffsetEnumerator : IEnumerator< (int Offset, ReadOnlySePayload Payload) >, IEnumerable< (int Offset, ReadOnlySePayload Payload) >
    {
        private readonly ReadOnlySeString _obj;
        private int _nextIndex;

        /// <summary>Initializes a new instance of the <see cref="OffsetEnumerator"/> struct.</summary>
        /// <param name="obj">An instance of <see cref="ReadOnlySeString"/> to enumerate.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public OffsetEnumerator( ReadOnlySeString obj )
        {
            _obj = obj;
            _nextIndex = 0;
        }

        /// <summary>Gets the byte offset of the current payload.</summary>
        public (int Offset, ReadOnlySePayload Payload) Current { get; private set; }

        /// <inheritdoc/>
        object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public bool MoveNext()
        {
            if( _nextIndex >= _obj.Data.Length )
                return false;

            var subspan = _obj.Data.Span[ _nextIndex.. ];
            switch( subspan[ 0 ] )
            {
                // A valid SeString never "contains a null byte; it is always the terminator.
                // Take one byte, and consider it as an invalid payload.
                case 0:
                    Current = (
                        _nextIndex,
                        new( ReadOnlySePayloadType.Invalid, default, _obj.Data.Slice( _nextIndex, 1 ) ) );
                    _nextIndex += 1;
                    break;

                // Start byte.
                case Stx:
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
                    if( subspan[ 2 + bodyLengthLength + bodyLength ] != Etx )
                        goto case 0;

                    Current = (
                        _nextIndex,
                        new( ReadOnlySePayloadType.Macro, macroCode, _obj.Data.Slice( _nextIndex + 2 + bodyLengthLength, bodyLength ) ) );
                    _nextIndex += 2 + bodyLengthLength + bodyLength + 1;
                    break;
                }

                // Raw text that will be followed by a payload or a null character.
                case var _ when subspan.IndexOfAny( (byte) 2, (byte) 0 ) is var i and >= 0:
                    Current = (
                        _nextIndex,
                        new( ReadOnlySePayloadType.Text, default, _obj.Data.Slice( _nextIndex, i ) ) );
                    _nextIndex += i;
                    break;

                // Final raw text.
                default:
                    Current = (
                        _nextIndex,
                        new( ReadOnlySePayloadType.Text, default, _obj.Data[ _nextIndex.. ] ) );
                    _nextIndex = _obj.Data.Length;
                    break;
            }

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
        IEnumerator< (int Offset, ReadOnlySePayload Payload) > IEnumerable< (int Offset, ReadOnlySePayload Payload) >.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>Enumerator for enumerating a <see cref="ReadOnlySeString"/> by payloads.</summary>
    public struct Enumerator : IEnumerator< ReadOnlySePayload >, IEnumerable< ReadOnlySePayload >
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
        public ReadOnlySePayload Current {
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            get => _offsetEnumerator.Current.Payload;
        }

        /// <inheritdoc/>
        object IEnumerator.Current => _offsetEnumerator.Current.Payload;

        /// <inheritdoc/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public void Dispose() => _offsetEnumerator.Dispose();

        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public Enumerator GetEnumerator() => new( _offsetEnumerator );

        /// <inheritdoc/>
        IEnumerator< ReadOnlySePayload > IEnumerable< ReadOnlySePayload >.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}