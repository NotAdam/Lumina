using System;
using System.IO;

namespace Lumina.Text.Expressions;

/// <summary>
/// Represent an Expression containing a placeholder value.
/// </summary>
public class PlaceholderExpression : BaseExpression
{
    /// <summary>
    /// Construct a new StringExpression containing the given value.
    /// </summary>
    public PlaceholderExpression( ExpressionType expressionType )
    {
        if( !IsPlaceholderType( expressionType ) )
            throw new ArgumentException( $"Given value does not indicate an {nameof( PlaceholderExpression )}.", nameof( expressionType ) );
        ExpressionType = expressionType;
    }

    /// <inheritdoc />
    public override int Size => 1;

    /// <inheritdoc />
    public override ExpressionType ExpressionType { get; }

    /// <inheritdoc />
    public override void Encode( Stream stream ) => stream.WriteByte( (byte)ExpressionType );

    /// <inheritdoc />
    public override string ToString()
    {
        return ExpressionType switch
        {
            ExpressionType.Millisecond => "t_msec",
            ExpressionType.Second => "t_sec",
            ExpressionType.Minute => "t_min",
            ExpressionType.Hour => "t_hour",
            ExpressionType.Day => "t_day",
            ExpressionType.Weekday => "t_wday",
            ExpressionType.Month => "t_mon",
            ExpressionType.Year => "t_year",
            ExpressionType.StackColor => "stackcolor",
            _ => $"Placeholder#{(byte)ExpressionType:X02}"
        };
    }

    /// <summary>
    /// Identify whether the given type byte indicates a PlaceholderExpression.
    /// </summary>
    /// <param name="typeByte">Type byte to identify.</param>
    /// <returns>True if it indicates a PlaceholderExpression.</returns>
    public static bool IsPlaceholderType( ExpressionType typeByte )
    {
        switch( (byte)typeByte )
        {
            case >= 0xD0 and <= 0xDF:
            case 0xEC:
                return true;
            default:
                return false;
        }
    }

    /// <summary>
    /// Parse given Stream into a PlaceholderExpression.
    /// </summary>
    /// <param name="typeByte">Type marker byte.</param>
    /// <param name="br">Stream to read from.</param>
    /// <returns>Parsed PlaceholderExpression.</returns>
    public static PlaceholderExpression Parse( byte typeByte, Stream stream ) => new((ExpressionType)typeByte);
}