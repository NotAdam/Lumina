using Lumina.Text.ReadOnly;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder
{
    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlySpan< char > value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( Span< char > value ) => AppendLine( (ReadOnlySpan< char >) value );

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlyMemory< char > value ) => AppendLine( value.Span );

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( Memory< char > value ) => AppendLine( value.Span );

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( char[] value ) => AppendLine( value.AsSpan() );

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( char[] value, int startIndex, int count )
        => AppendLine( value.AsSpan( startIndex, count ) );

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( string? value ) => AppendLine( value.AsSpan() );

    /// <summary>Adds the given UTF-16 char sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( string? value, int startIndex, int count )
        => AppendLine( value.AsSpan( startIndex, count ) );

    /// <summary>Adds the given UTF-8 byte sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlySpan< byte > value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given UTF-8 byte sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( Span< byte > value ) => AppendLine( (ReadOnlySpan< byte >) value );

    /// <summary>Adds the given UTF-8 byte sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlyMemory< byte > value ) => AppendLine( value.Span );

    /// <summary>Adds the given UTF-8 byte sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( Memory< byte > value ) => AppendLine( value.Span );

    /// <summary>Adds the given UTF-8 byte sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( byte[] value ) => AppendLine( value.AsSpan() );

    /// <summary>Adds the given UTF-8 byte sequence and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( byte[] value, int startIndex, int count )
        => AppendLine( value.AsSpan( startIndex, count ) );

    /// <summary>Adds the given SeString from the given StringBuilder and a line break.</summary>
    /// <param name="value">The string builder that contains the substring to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( StringBuilder value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given SeString from the given StringBuilder and a line break.</summary>
    /// <param name="value">The string builder that contains the substring to append.</param>
    /// <param name="startIndex">The starting position of the substring within <paramref name="value"/>.</param>
    /// <param name="count">The number of characters in <paramref name="value"/> to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( StringBuilder value, int startIndex, int count )
        => Append( value, startIndex, count ).AppendNewLine();

    /// <summary>Adds the given SeString and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( SeString value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given SeString and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlySeString value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given SeString payload, wrapping in envelope as needed, and a line break.</summary>
    /// <param name="value">Payload to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlySePayload value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given SeString expression, which is an invalid operation.</summary>
    /// <param name="value">Expression to add.</param>
    [Obsolete( "You cannot append a SeExpression to a SeString.", true )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global", Justification = "Trap for invalid append call from implicit casts with overloads." )]
    public void AppendLine( ReadOnlySeExpression value ) => throw new InvalidOperationException();

    /// <summary>Adds the given SeString and a line break.</summary>
    /// <param name="value">Text to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlySeStringSpan value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given SeString payload, wrapping in envelope as needed, and a line break.</summary>
    /// <param name="value">Payload to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( ReadOnlySePayloadSpan value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given SeString expression, which is an invalid operation.</summary>
    /// <param name="value">Expression to add.</param>
    [Obsolete( "You cannot append a SeExpression to a SeString.", true )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global", Justification = "Trap for invalid append call from implicit casts with overloads." )]
    public void AppendLine( ReadOnlySeExpressionSpan value ) => throw new InvalidOperationException();

    /// <summary>Adds the given value and a line break.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine( object? value ) => Append( value ).AppendNewLine();

    /// <summary>Adds the given value and a line break.</summary>
    /// <param name="value">Value to add.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendLine< T >( scoped in T value ) where T : struct
        => Append( value ).AppendNewLine();
}