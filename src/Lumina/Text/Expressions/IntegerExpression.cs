using System;
using System.IO;
using System.Text;

namespace Lumina.Text.Expressions;

/// <summary>
/// Represent an unsigned int32 value.
/// </summary>
public class IntegerExpression : BaseExpression
{
    /// <summary>
    /// Construct a new IntegerExpression containing value 0.
    /// </summary>
    public IntegerExpression()
    {
        Value = 0;
    }

    /// <summary>
    /// Construct a new IntegerExpression containing the given value.
    /// </summary>
    public IntegerExpression( uint value )
    {
        Value = value;
    }

    /// <summary>
    /// Gets or sets the value represented by this IntegerExpression.
    /// </summary>
    public uint Value { get; }

    /// <inheritdoc />
    public override int Size => CalculateSize( Value );

    /// <inheritdoc />
    public override ExpressionType ExpressionType => CalculateTypeByte( Value );

    /// <inheritdoc />
    public override void Encode( Stream stream ) => EncodeStatic( stream, Value );

    /// <summary>
    /// Encode given value into the given stream.
    /// </summary>
    public static void EncodeStatic( Stream stream, uint value )
    {
        if( value < 0xCF )
        {
            stream.WriteByte( (byte)( value + 1 ) );
        }
        else
        {
            stream.WriteByte( (byte)CalculateTypeByte( value ) );

            byte v;
            if( ( v = unchecked( (byte)( value >> 24 ) ) ) != 0 ) stream.WriteByte( v );
            if( ( v = unchecked( (byte)( value >> 16 ) ) ) != 0 ) stream.WriteByte( v );
            if( ( v = unchecked( (byte)( value >> 8 ) ) ) != 0 ) stream.WriteByte( v );
            if( ( v = unchecked( (byte)( value >> 0 ) ) ) != 0 ) stream.WriteByte( v );
        }
    }

    /// <summary>
    /// Calculate the expression type marker of the given value.
    /// </summary>
    public static ExpressionType CalculateTypeByte( uint value )
    {
        if( value < 0xCF )
            return (ExpressionType)(byte)( 1 + value );
        return (ExpressionType)(byte)(
            ( 0xF0
              | ( ( value & 0xFF000000 ) == 0 ? 0 : 0x08 )
              | ( ( value & 0x00FF0000 ) == 0 ? 0 : 0x04 )
              | ( ( value & 0x0000FF00 ) == 0 ? 0 : 0x02 )
              | ( ( value & 0x000000FF ) == 0 ? 0 : 0x01 )
            ) - 1 );
    }

    /// <summary>
    /// Calculate the number of bytes required to represent the given value.
    /// </summary>
    /// <param name="value">The integer value.</param>
    /// <returns>Number of bytes.</returns>
    public static int CalculateSize( uint value )
    {
        if( value < 0xCF )
            return 1;
        return 1
               + ( ( value & 0xFF000000 ) == 0 ? 0 : 1 )
               + ( ( value & 0x00FF0000 ) == 0 ? 0 : 1 )
               + ( ( value & 0x0000FF00 ) == 0 ? 0 : 1 )
               + ( ( value & 0x000000FF ) == 0 ? 0 : 1 );
    }

    /// <inheritdoc />
    public override string ToString() => ( (int)Value ).ToString();

    /// <inheritdoc />
    public override void AppendMacroStringToStringBuilder( StringBuilder sb ) => sb.Append( (int) Value );

    /// <summary>
    /// Parse given Stream into an IntegerExpression.
    /// </summary>
    /// <param name="typeByte">Type marker byte.</param>
    /// <param name="stream">Stream to read from.</param>
    /// <returns>Parsed IntegerExpression.</returns>
    public static IntegerExpression Parse( byte typeByte, Stream stream )
    {
        uint ShiftAndThrowIfZero( int v, int shift )
        {
            return v switch
            {
                -1 => throw new ArgumentException( "Encountered premature end of input (unexpected EOF).", nameof( v ) ),
                0 => throw new ArgumentException( "Encountered premature end of input (unexpected null character).", nameof( v ) ),
                _ => (uint)v << shift
            };
        }

        switch( typeByte )
        {
            case > 0 and < 0xD0:
                return new IntegerExpression( (uint)( typeByte - 1 ) );
            case >= 0xF0 and <= 0xFE:
            {
                typeByte += 1;
                var value = 0u;
                if( ( typeByte & 8 ) != 0 ) value |= ShiftAndThrowIfZero( stream.ReadByte(), 24 );
                if( ( typeByte & 4 ) != 0 ) value |= ShiftAndThrowIfZero( stream.ReadByte(), 16 );
                if( ( typeByte & 2 ) != 0 ) value |= ShiftAndThrowIfZero( stream.ReadByte(), 8 );
                if( ( typeByte & 1 ) != 0 ) value |= ShiftAndThrowIfZero( stream.ReadByte(), 0 );
                return new IntegerExpression( value );
            }
            default:
                throw new ArgumentException( $"Given type does not indicate a {nameof( IntegerExpression )}.", nameof( typeByte ) );
        }
    }
}