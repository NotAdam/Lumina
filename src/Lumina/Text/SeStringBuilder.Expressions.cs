using System;
using Lumina.Text.Expressions;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder
{
    /// <summary>Appends an integer calculated from RGBA values as an expression.</summary>
    /// <param name="rgba">A normalized RGBA <see cref="System.Numerics.Vector4"/> value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendRgbaIntExpression( System.Numerics.Vector4 rgba ) =>
        AppendRgbaIntExpression(
            (byte) Math.Clamp( 256 * rgba.X, 0, 255 ),
            (byte) Math.Clamp( 256 * rgba.Y, 0, 255 ),
            (byte) Math.Clamp( 256 * rgba.Z, 0, 255 ),
            (byte) Math.Clamp( 256 * rgba.W, 0, 255 ) );

    /// <summary>Appends an integer as an expression.</summary>
    /// <param name="value">An integer value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendIntExpression( int value ) => AppendUIntExpression( (uint) value );

    /// <summary>Appends an unsigned integer as an expression.</summary>
    /// <param name="value">An unsigned integer value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendUIntExpression( uint value )
    {
        SeExpressionUtilities.EncodeUInt( AllocateExpressionSpan( SeExpressionUtilities.CalculateLengthUInt( value ) ), value );
        OneExpressionWritten();
        return this;
    }

    /// <summary>Appends an integer calculated from RGBA values as an expression.</summary>
    /// <param name="r">A red byte value to append.</param>
    /// <param name="g">A red byte value to append.</param>
    /// <param name="b">A red byte value to append.</param>
    /// <param name="a">A red byte value to append.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendRgbaIntExpression( byte r, byte g, byte b, byte a ) =>
        AppendUIntExpression( ( (uint) a << 24 ) | ( (uint) b << 16 ) | ( (uint) g << 8 ) | r );

    /// <summary>Appends a nullary expression.</summary>
    /// <param name="expressionType">A nullary expression type.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendNullaryExpression( ExpressionType expressionType )
    {
        if( _mss[ ^1 ].Type is not StackType.Payload and not StackType.Expression )
            throw new InvalidOperationException("Expression cannot be appended in current state.");
        if( _mss[ ^1 ].Type == StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
        if( expressionType.GetArity() != ExpressionArity.Nullary )
            throw new ArgumentOutOfRangeException( nameof( expressionType ), expressionType, "Only nullary expression types are allowed." );
        AllocateExpressionSpan( 1 )[ 0 ] = (byte) expressionType;
        OneExpressionWritten();
        return this;
    }

    /// <summary>Starts writing an unary expression.</summary>
    /// <param name="expressionType">An unary expression type.</param>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder BeginUnaryExpression( ExpressionType expressionType )
    {
        if( _mss[ ^1 ].Type is not StackType.Payload and not StackType.Expression )
            throw new InvalidOperationException("Expression cannot be appended in current state.");
        if( _mss[ ^1 ].Type == StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
        if( expressionType.GetArity() != ExpressionArity.Unary )
            throw new ArgumentOutOfRangeException( nameof( expressionType ), expressionType, "Only unary expression types are allowed." );
        if( _mssFree.Count == 0 )
        {
            _mss.Add( ( StackType.Expression, 1, new() ) );
        }
        else
        {
            _mss.Add( ( StackType.Expression, 1, _mssFree[ ^1 ] ) );
            _mssFree.RemoveAt( _mssFree.Count - 1 );
        }

        AllocateExpressionSpan( 1 )[ 0 ] = (byte) expressionType;
        return this;
    }

    /// <summary>Starts writing a binary expression.</summary>
    /// <param name="expressionType">A binary expression type.</param>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder BeginBinaryExpression( ExpressionType expressionType )
    {
        if( _mss[ ^1 ].Type is not StackType.Payload and not StackType.Expression )
            throw new InvalidOperationException("Expression cannot be appended in current state.");
        if( _mss[ ^1 ].Type == StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
        if( expressionType.GetArity() != ExpressionArity.Binary )
            throw new ArgumentOutOfRangeException( nameof( expressionType ), expressionType, "Only unary expression types are allowed." );
        if( _mssFree.Count == 0 )
        {
            _mss.Add( ( StackType.Expression, 2, new() ) );
        }
        else
        {
            _mss.Add( ( StackType.Expression, 2, _mssFree[ ^1 ] ) );
            _mssFree.RemoveAt( _mssFree.Count - 1 );
        }

        AllocateExpressionSpan( 1 )[ 0 ] = (byte) expressionType;
        return this;
    }

    /// <summary>Starts writing a string expression.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder BeginStringExpression()
    {
        if( _mss[ ^1 ].Type is not StackType.Expression and not StackType.Payload )
            throw new InvalidOperationException( "A string expression can be added only in the context of expression or payload." );
        if( _mss[ ^1 ].Type == StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
        if( _mssFree.Count == 0 )
        {
            _mss.Add( ( StackType.String, 0, new() ) );
        }
        else
        {
            _mss.Add( ( StackType.String, 0, _mssFree[ ^1 ] ) );
            _mssFree.RemoveAt( _mssFree.Count - 1 );
        }

        return this;
    }

    /// <summary>Ends writing an unary, binary, or string expression.</summary>
    /// <returns></returns>
    /// <remarks>Use </remarks>
    public SeStringBuilder EndExpression()
    {
        var stream = _mss[ ^1 ].Stream;
        var span = stream.GetBuffer().AsSpan( 0, (int) stream.Length );

        switch( _mss[ ^1 ].Type )
        {
            case StackType.String:
                if( _mss.Count == 1 || _mss[ ^1 ].Type != StackType.String )
                    throw new InvalidOperationException( "String expression is not currently being built." );

                _mss.RemoveAt( _mss.Count - 1 );
                var buf = AllocateExpressionSpan( 1 + SeExpressionUtilities.CalculateLengthInt( span.Length ) + span.Length );
                buf = buf[ SeExpressionUtilities.WriteRaw( buf, 0xFF ).. ];
                buf = buf[ SeExpressionUtilities.EncodeInt( buf, span.Length ).. ];
                span.CopyTo( buf );
                break;

            case StackType.Expression:
                if( _mss[ ^1 ].Ident != 0 )
                    throw new InvalidOperationException( $"{_mss[ ^1 ].Ident} more expression(s) must be written." );

                _mss.RemoveAt( _mss.Count - 1 );
                _mss[ ^1 ].Stream.Write( span );
                break;

            default:
                throw new InvalidOperationException( "No expression is being written." );
        }

        stream.SetLength( stream.Position = 0 );
        _mssFree.Add( stream );

        OneExpressionWritten();
        return this;
    }
}