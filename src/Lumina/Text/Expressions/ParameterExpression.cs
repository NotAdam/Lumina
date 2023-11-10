using System;
using System.IO;

namespace Lumina.Text.Expressions;

/// <summary>
/// Represent an Expression containing a parameter with one argument(operand).
/// </summary>
public class ParameterExpression : BaseExpression
{
    /// <summary>
    /// Construct a new ParameterExpression with given type and operand.
    /// </summary>
    public ParameterExpression( ExpressionType typeByte, BaseExpression operand )
    {
        if( !IsParameterType( typeByte ) )
            throw new ArgumentException( $"Given value does not indicate a {nameof( ParameterExpression )}.", nameof( typeByte ) );
        ExpressionType = typeByte;
        Operand = operand;
    }

    /// <summary>
    /// The operand.
    /// </summary>
    public BaseExpression Operand { get; }

    /// <inheritdoc />
    public override int Size => 1 + Operand.Size;

    /// <inheritdoc />
    public override ExpressionType ExpressionType { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        return ExpressionType switch
        {
            ExpressionType.IntegerParameter => $"lnum{Operand}",
            ExpressionType.PlayerParameter => $"gnum{Operand}",
            ExpressionType.StringParameter => $"lstr{Operand}",
            ExpressionType.ObjectParameter => $"gstr{Operand}",
            _ => throw new NotImplementedException() // cannot reach, as this instance is immutable and this field is filtered from constructor
        };
    }

    /// <summary>
    /// Identify whether the given type byte indicates an ParameterExpression.
    /// </summary>
    /// <param name="typeByte">Type byte to identify.</param>
    /// <returns>True if it indicates a ParameterExpression.</returns>
    public static bool IsParameterType( ExpressionType typeByte )
    {
        return (byte)typeByte switch
        {
            >= 0xE8 and <= 0xEB => true,
            _ => false
        };
    }

    /// <inheritdoc />
    public override void Encode( Stream stream )
    {
        stream.WriteByte( (byte)ExpressionType );
        Operand.Encode( stream );
    }

    /// <summary>
    /// Parse given Stream into a ParameterExpression.
    /// </summary>
    /// <param name="typeByte">Type marker byte.</param>
    /// <param name="stream">Stream to read from.</param>
    /// <returns>Parsed ParameterExpression.</returns>
    public static ParameterExpression Parse( byte typeByte, Stream stream )
    {
        var operand = BaseExpression.Parse( stream );
        return new ParameterExpression( (ExpressionType)typeByte, operand );
    }
}