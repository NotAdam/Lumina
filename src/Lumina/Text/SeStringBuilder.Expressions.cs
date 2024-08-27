using System;
using Lumina.Text.Expressions;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder
{
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

    /// <summary>Appends a nullary expression.</summary>
    /// <param name="expressionType">A nullary expression type.</param>
    /// <returns>A reference of this instance after the append operation is completed.</returns>
    public SeStringBuilder AppendNullaryExpression( ExpressionType expressionType )
    {
        EnsureExpressionWritableStateOrThrow();
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
        EnsureExpressionWritableStateOrThrow();
        if( expressionType.GetArity() != ExpressionArity.Unary )
            throw new ArgumentOutOfRangeException( nameof( expressionType ), expressionType, "Only unary expression types are allowed." );

        PushMemoryStreamStack( StackType.Expression, 1 );
        AllocateExpressionSpan( 1 )[ 0 ] = (byte) expressionType;
        return this;
    }

    /// <summary>Starts writing a binary expression.</summary>
    /// <param name="expressionType">A binary expression type.</param>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder BeginBinaryExpression( ExpressionType expressionType )
    {
        EnsureExpressionWritableStateOrThrow();
        if( expressionType.GetArity() != ExpressionArity.Binary )
            throw new ArgumentOutOfRangeException( nameof( expressionType ), expressionType, "Only binary expression types are allowed." );

        PushMemoryStreamStack( StackType.Expression, 2 );
        AllocateExpressionSpan( 1 )[ 0 ] = (byte) expressionType;
        return this;
    }

    /// <summary>Changes the type of the binary expression being written.</summary>
    /// <param name="expressionType">A binary expression type.</param>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder ChangeBinaryExpression( ExpressionType expressionType )
    {
        if( _mss[ ^1 ].Type is not StackType.Expression || ( (ExpressionType) _mss[ ^1 ].Stream.GetBuffer()[ 0 ] ).GetArity() != ExpressionArity.Binary )
            throw new InvalidOperationException( "Current scope is not a binary expression." );
        if( expressionType.GetArity() != ExpressionArity.Binary )
            throw new ArgumentOutOfRangeException( nameof( expressionType ), expressionType, "Only binary expression types are allowed." );
        _mss[ ^1 ].Stream.GetBuffer()[ 0 ] = (byte) expressionType;
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

        PushMemoryStreamStack( StackType.String, 0 );
        return this;
    }

    /// <summary>Ends writing a unary, binary, or string expression.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    /// <remarks>Use <see cref="AbortExpression"/> to cancel writing this expression instead.</remarks>
    public SeStringBuilder EndExpression()
    {
        switch( _mss[ ^1 ].Type )
        {
            case StackType.String:
            {
                if( _mss.Count == 1 || _mss[ ^1 ].Type != StackType.String )
                    throw new InvalidOperationException( "String expression is not currently being built." );

                var span = PopMemoryStreamStack(out _);
                var buf = AllocateExpressionSpan( 1 + SeExpressionUtilities.CalculateLengthInt( span.Length ) + span.Length );
                buf = buf[ SeExpressionUtilities.WriteRaw( buf, 0xFF ).. ];
                buf = buf[ SeExpressionUtilities.EncodeInt( buf, span.Length ).. ];
                span.CopyTo( buf );
                break;
            }

            case StackType.Expression:
            {
                if( _mss[ ^1 ].Ident != 0 )
                    throw new InvalidOperationException( $"{_mss[ ^1 ].Ident} more expression(s) must be written." );

                var span = PopMemoryStreamStack(out _);
                _mss[ ^1 ].Stream.Write( span );
                break;
            }

            default:
                throw new InvalidOperationException( "No expression is being written." );
        }

        OneExpressionWritten();
        return this;
    }

    /// <summary>Aborts an expression build by discarding the current expression data and exiting the expression scope.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder AbortExpression()
    {
        if( _mss[ ^1 ].Type is not (StackType.String or StackType.Expression) )
            throw new InvalidOperationException( "No expression is being written." );

        PopMemoryStreamStack(out _);
        return this;
    }

    private void EnsureExpressionWritableStateOrThrow()
    {
        if( _mss[ ^1 ].Type is not StackType.Payload and not StackType.Expression )
            throw new InvalidOperationException( "Expression cannot be appended in current state." );
        if( _mss[ ^1 ].Type == StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
    }
}