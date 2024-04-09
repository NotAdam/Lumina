using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Text.ReadOnly;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder
{
    private static readonly ConditionalWeakTable< Type, Delegate > TypedAppendDelegates = new();

    private delegate void TypedAppendDelegate< T >( SeStringBuilder ssb, scoped in T value ) where T : struct;

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlySpan< char > value )
    {
        if( value.IndexOfAny( (char) ReadOnlySeString.Stx, '\0' ) != -1 )
            throw new ArgumentException( "A SeString may not contain STX or NUL for text.", nameof( value ) );
        Encoding.UTF8.GetBytes( value, AllocateStringSpan( Encoding.UTF8.GetByteCount( value ) ) );
        return this;
    }

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( Span< char > value ) => Append( (ReadOnlySpan< char >) value );

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlyMemory< char > value ) => Append( value.Span );

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( Memory< char > value ) => Append( value.Span );

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( char[] value ) => Append( value.AsSpan() );

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( char[] value, int startIndex, int count ) => Append( value.AsSpan( startIndex, count ) );

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( string? value ) => Append( value.AsSpan() );

    /// <summary>Adds the given UTF-16 char sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( string? value, int startIndex, int count ) => Append( value.AsSpan( startIndex, count ) );

    /// <summary>Adds the given UTF-8 byte sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlySpan< byte > value )
    {
        var stream = GetStringStream();
        if( value.IndexOfAny( ReadOnlySeString.Stx, (byte) 0 ) != -1 )
            throw new ArgumentException( "A SeString may not contain STX or NUL for text.", nameof( value ) );
        stream.Write( value );
        return this;
    }

    /// <summary>Adds the given UTF-8 byte sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( Span< byte > value ) => Append( (ReadOnlySpan< byte >) value );

    /// <summary>Adds the given UTF-8 byte sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlyMemory< byte > value ) => Append( value.Span );

    /// <summary>Adds the given UTF-8 byte sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( Memory< byte > value ) => Append( value.Span );

    /// <summary>Adds the given UTF-8 byte sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( byte[] value ) => Append( value.AsSpan() );

    /// <summary>Adds the given UTF-8 byte sequence.</summary>
    /// <param name="value">Text to add.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( byte[] value, int startIndex, int count ) => Append( value.AsSpan( startIndex, count ) );

    /// <summary>Adds the given SeString from the given StringBuilder.</summary>
    /// <param name="value">The string builder that contains the substring to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( StringBuilder value )
    {
        var len = 0;
        foreach( var chunk in value.GetChunks() )
        {
            if (chunk.Span.IndexOfAny( (char) ReadOnlySeString.Stx, '\0' ) != -1 )
                throw new ArgumentException( "A SeString may not contain STX or NUL for text.", nameof( value ) );
            len += Encoding.UTF8.GetByteCount( chunk.Span );
        }

        var span = AllocateStringSpan( len );
        foreach( var chunk in value.GetChunks() )
            span = span[ Encoding.UTF8.GetBytes( chunk.Span, span ).. ];
        return this;
    }

    /// <summary>Adds the given SeString from the given StringBuilder.</summary>
    /// <param name="value">The string builder that contains the substring to append.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( StringBuilder value, int startIndex, int count )
    {
        if( startIndex + count > value.Length )
            throw new ArgumentException( "Tried to append from out of StringBuilder data range.", nameof( count ) );

        var len = 0;
        {
            var index2 = startIndex;
            var count2 = count;
            foreach( var chunk in value.GetChunks() )
            {
                if( chunk.Length <= index2 )
                {
                    index2 -= chunk.Length;
                    continue;
                }

                var avail = Math.Min( count2, chunk.Length - index2 );
                if (chunk.Span.Slice( index2, avail ).IndexOfAny( (char) ReadOnlySeString.Stx, '\0' ) != -1 )
                    throw new ArgumentException( "A SeString may not contain STX or NUL for text.", nameof( value ) );
                len += Encoding.UTF8.GetByteCount( chunk.Span.Slice( index2, avail ) );
                index2 += avail;
                count2 -= avail;

                if( count2 == 0 )
                    break;
                Debug.Assert( count2 > 0, "Logic problems" );
            }
        }

        var span = AllocateStringSpan( len );
        {
            var index2 = startIndex;
            var count2 = count;
            foreach( var chunk in value.GetChunks() )
            {
                if( chunk.Length <= index2 )
                {
                    index2 -= chunk.Length;
                    continue;
                }

                var avail = Math.Min( count2, chunk.Length - index2 );
                span = span[ Encoding.UTF8.GetBytes( chunk.Span.Slice( index2, avail ), span ).. ];
                index2 += avail;
                count2 -= avail;

                if( count2 == 0 )
                    break;
                Debug.Assert( count2 > 0, "Logic problems" );
            }
        }

        return this;
    }

    /// <summary>Adds the given SeString.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( SeString value )
    {
        GetStringStream().Write( value.RawData );
        return this;
    }

    /// <summary>Adds the given SeString.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlySeString value )
    {
        GetStringStream().Write( value.Data.Span );
        return this;
    }

    /// <summary>Adds the given SeString payload, wrapping in envelope as needed.</summary>
    /// <param name="value">Payload to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlySePayload value )
    {
        value.WriteEnvelopeTo( AllocateStringSpan( value.EnvelopeByteLength ) );
        return this;
    }

    /// <summary>Adds the given SeString expression, which is an invalid operation.</summary>
    /// <param name="value">Expression to add.</param>
    [Obsolete( "You cannot append a SeExpression to a SeString.", true )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global", Justification = "Trap for invalid append call from implicit casts with overloads." )]
    public void Append( ReadOnlySeExpression value ) => throw new InvalidOperationException();

    /// <summary>Adds the given SeString.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlySeStringSpan value )
    {
        GetStringStream().Write( value.Data );
        return this;
    }

    /// <summary>Adds the given SeString payload, wrapping in envelope as needed.</summary>
    /// <param name="value">Payload to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( ReadOnlySePayloadSpan value )
    {
        value.WriteEnvelopeTo( AllocateStringSpan( value.EnvelopeByteLength ) );
        return this;
    }

    /// <summary>Adds the given SeString expression, which is an invalid operation.</summary>
    /// <param name="value">Expression to add.</param>
    [Obsolete( "You cannot append a SeExpression to a SeString.", true )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global", Justification = "Trap for invalid append call from implicit casts with overloads." )]
    public void Append( ReadOnlySeExpressionSpan value ) => throw new InvalidOperationException();

    /// <summary>Adds the given value.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append( object? value ) => Append( value?.ToString() );

    /// <summary>Adds the given value.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder Append< T >( scoped in T value ) where T : struct
    {
        ( (TypedAppendDelegate< T >) TypedAppendDelegates.GetValue( typeof( T ), static ty => {
#if NET8_0
            if( ty.IsAssignableTo( typeof( IUtf8SpanFormattable ) ) )
            {
                return typeof( SeStringBuilder )
                    .GetMethod( nameof( TypedAppendUtf8SpanFormattable ), BindingFlags.Static | BindingFlags.NonPublic )!
                    .MakeGenericMethod( typeof( T ) )
                    .CreateDelegate< TypedAppendDelegate< T > >();
            }
#endif

            if( ty.IsAssignableTo( typeof( ISpanFormattable ) ) )
            {
                return typeof( SeStringBuilder )
                    .GetMethod( nameof( TypedAppendSpanFormattable ), BindingFlags.Static | BindingFlags.NonPublic )!
                    .MakeGenericMethod( typeof( T ) )
                    .CreateDelegate< TypedAppendDelegate< T > >();
            }

            return new TypedAppendDelegate< T >( ( SeStringBuilder ssb, scoped in T value ) => ssb.Append( (object?) value ) );
        } ) ).Invoke( this, in value );
        return this;
    }
}