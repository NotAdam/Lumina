using System;
using System.IO;
using System.Text;

namespace Lumina.Text.Expressions;

/// <summary>
/// Base class for expressions embedded inside payloads for SeString.
/// </summary>
public abstract class BaseExpression
{
    /// <summary>
    /// Number of bytes occupied to represent this expression in an array of bytes.
    /// </summary>
    public abstract int Size { get; }

    /// <summary>
    /// Expression type marker, in byte type.
    /// </summary>
    public abstract ExpressionType ExpressionType { get; }

    /// <summary>
    /// Encode this expression into the given Stream.
    /// </summary>
    /// <param name="stream">Target to write this expression to.</param>
    public abstract void Encode( Stream stream );

    /// <summary>Represent this expression as a part of macro string.</summary>
    /// <param name="sb">Target string builder.</param>
    public abstract void AppendMacroStringToStringBuilder( StringBuilder sb );

    /// <inheritdoc/>
    public override string ToString()
    {
        var sb = new StringBuilder();
        AppendMacroStringToStringBuilder( sb );
        return sb.ToString();
    }

    /// <summary>
    /// Parse given Stream into an Expression.
    /// </summary>
    /// <param name="stream">Stream to read from.</param>
    /// <returns>Parsed Expression.</returns>
    public static BaseExpression Parse( Stream stream )
    {
        var typeByte = (byte)stream.ReadByte();
        return typeByte switch
        {
            0 => throw new ArgumentException( "Encountered premature end of input (unexpected null character).", nameof( stream ) ),
            > 0 and < 0xD0 => IntegerExpression.Parse( typeByte, stream ),
            >= 0xD0 and <= 0xDF => PlaceholderExpression.Parse( typeByte, stream ),
            >= 0xE0 and <= 0xE5 => BinaryExpression.Parse( typeByte, stream ),
            >= 0xE6 and <= 0xE7 => throw new NotImplementedException( $"Type marker 0x{typeByte:X02} is not implemented." ),
            >= 0xE8 and <= 0xEB => ParameterExpression.Parse( typeByte, stream ),
            0xEC => PlaceholderExpression.Parse( typeByte, stream ),
            >= 0xED and <= 0xEF => throw new NotImplementedException( $"Type marker 0x{typeByte:X02} is not implemented." ),
            >= 0xF0 and <= 0xFE => IntegerExpression.Parse( typeByte, stream ),
            0xFF => StringExpression.Parse( typeByte, stream )
        };
    }
}