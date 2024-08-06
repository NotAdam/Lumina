using System;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Text.Expressions;

namespace Lumina.Text.ReadOnly;

/// <summary>Represents an expression in a <see cref="ReadOnlySeStringSpan"/>.</summary>
public readonly ref struct ReadOnlySeExpressionSpan
{
    /// <summary>Read-only byte data for the SeString expression.</summary>
    public readonly ReadOnlySpan< byte > Body;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeExpressionSpan"/> struct.</summary>
    /// <param name="body">Raw SeString expression data.</param>
    public ReadOnlySeExpressionSpan( ReadOnlySpan< byte > body ) => Body = body;

    /// <summary>Gets the read-only byte memory view of this instance of <see cref="ReadOnlySeExpressionSpan"/>.</summary>
    /// <param name="s">The expression to get a byte memory view of.</param>
    /// <returns>The read-only byte memory view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySpan< byte >( ReadOnlySeExpressionSpan s ) => s.Body;

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpressionSpan"/> struct from the given byte span view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpressionSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpressionSpan( ReadOnlySpan< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpressionSpan"/> struct from the given byte span view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpressionSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpressionSpan( Span< byte > s ) => new( s );

    /// <summary>Gets the read-only byte span view of this instance of <see cref="ReadOnlySeExpression"/>.</summary>
    /// <param name="s">The expression to get a byte span view of.</param>
    /// <returns>The read-only byte span view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpressionSpan( ReadOnlySeExpression s ) => s.AsSpan();

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpressionSpan"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpressionSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpressionSpan( ReadOnlyMemory< byte > s ) => new( s.Span );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpressionSpan"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpressionSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpressionSpan( Memory< byte > s ) => new( s.Span );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpressionSpan"/> struct from the given byte array.</summary>
    /// <param name="s">The source byte array.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpressionSpan"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks><paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpressionSpan( byte[] s ) => new( s );

    /// <summary>Returns a value that indicates whether the specified expressions are equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeExpressionSpan left, ReadOnlySeExpressionSpan right ) => left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified expressions are equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeExpressionSpan left, ReadOnlySeExpression right ) => left.Equals( right.AsSpan() );

    /// <summary>Returns a value that indicates whether the specified expressions are equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeExpression left, ReadOnlySeExpressionSpan right ) => left.AsSpan().Equals( right );

    /// <summary>Returns a value that indicates whether the specified expressions are not equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeExpressionSpan left, ReadOnlySeExpressionSpan right ) => !left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified expressions are not equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeExpressionSpan left, ReadOnlySeExpression right ) => !left.Equals( right.AsSpan() );

    /// <summary>Returns a value that indicates whether the specified expressions are not equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeExpression left, ReadOnlySeExpressionSpan right ) => !left.AsSpan().Equals( right );

    /// <summary>Attempts to get an integer value from this expression.</summary>
    /// <param name="value">The parsed integer value.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetUInt( out uint value ) => SeExpressionUtilities.TryDecodeUInt( Body, out value, out _ );

    /// <inheritdoc cref="TryGetUInt(out uint)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetInt( out int value ) => SeExpressionUtilities.TryDecodeInt( Body, out value, out _ );

    /// <summary>Attempts to get a SeString value from this expression.</summary>
    /// <param name="value">The parsed <see cref="ReadOnlySeStringSpan"/> value.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetString( out ReadOnlySeStringSpan value ) => SeExpressionUtilities.TryDecodeString( Body, out value, out _ );

    /// <summary>Attempts to get a placeholder type from this expression.</summary>
    /// <param name="expressionType">The parsed expression type.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetPlaceholderExpression( out byte expressionType ) => SeExpressionUtilities.TryDecodeNullary( Body, out expressionType, out _ );

    /// <summary>Attempts to get a paramter expression from this expression.</summary>
    /// <param name="expressionType">The parsed expression type.</param>
    /// <param name="operand">The operand.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetParameterExpression( out byte expressionType, out ReadOnlySeExpressionSpan operand ) =>
        SeExpressionUtilities.TryDecodeUnary( Body, out expressionType, out operand, out _ );

    /// <summary>Attempts to get a binary expression from this expression.</summary>
    /// <param name="expressionType">The parsed expression type.</param>
    /// <param name="operand1">The operand 1.</param>
    /// <param name="operand2">The operand 2.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetBinaryExpression( out byte expressionType, out ReadOnlySeExpressionSpan operand1, out ReadOnlySeExpressionSpan operand2 ) =>
        SeExpressionUtilities.TryDecodeBinary( Body, out expressionType, out operand1, out operand2, out _ );

    /// <summary>Validates whether this instance of <see cref="ReadOnlySeExpressionSpan"/> is well-formed.</summary>
    /// <returns><c>true</c> if this instance of <see cref="ReadOnlySeExpressionSpan"/> is structurally valid.</returns>
    public bool Validate()
    {
        if( TryGetInt( out _ ) )
            return true;
        if( TryGetString( out var s ) )
            return s.Validate();
        if( TryGetPlaceholderExpression( out _ ) )
            return true;
        if( TryGetParameterExpression( out _, out var e1 ) )
            return e1.Validate();
        if( TryGetBinaryExpression( out _, out e1, out var e2 ) )
            return e1.Validate() && e2.Validate();
        return false;
    }

    /// <inheritdoc cref="object.Equals(object?)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Equals( ReadOnlySeExpressionSpan other ) => Body.SequenceEqual( other.Body );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override bool Equals( object? obj ) => false;

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override int GetHashCode()
    {
        var hc = default( HashCode );
        hc.AddBytes( Body );
        return hc.ToHashCode();
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        var sb = new StringBuilder();
        AppendMacroStringToStringBuilder( sb );
        return sb.ToString();
    }

    /// <summary>Writes the encodeable macro representation of this instance of <see cref="ReadOnlySePayloadSpan"/> to the given string builder.</summary>
    /// <param name="sb">Target string builder.</param>
    /// <returns>The encodeable macro representation.</returns>
    public void AppendMacroStringToStringBuilder( StringBuilder sb )
    {
        if( Body.IsEmpty )
        {
            sb.Append( "<expr: invalid empty>" );
            return;
        }

        if( TryGetUInt( out var u32 ) )
        {
            sb.Append( u32 );
            return;
        }

        if( TryGetString( out var s ) )
        {
            s.AppendMacroStringToStringBuilder( sb, true );
            return;
        }

        if( TryGetPlaceholderExpression( out var exprType ) )
        {
            if( ( (ExpressionType) exprType ).GetNativeName() is { } nativeName )
                sb.Append( nativeName );
            else
                sb.Append( $"<expr: 0x{exprType:X02} is unsupported>" );
            return;
        }

        if( TryGetParameterExpression( out exprType, out var e1 ) )
        {
            if( ( (ExpressionType) exprType ).GetNativeName() is not { } nativeName )
                throw new InvalidOperationException( "All native names must be defined for unary expressions." );
            sb.Append( nativeName );
            e1.AppendMacroStringToStringBuilder( sb );
            return;
        }

        if( TryGetBinaryExpression( out exprType, out e1, out var e2 ) )
        {
            sb.Append( '[' );
            e1.AppendMacroStringToStringBuilder( sb );
            switch( (ExpressionType)exprType )
            {
                case ExpressionType.GreaterThanOrEqualTo:
                    sb.Append( ">=" );
                    break;
                case ExpressionType.GreaterThan:
                    sb.Append( '>' );
                    break;
                case ExpressionType.LessThanOrEqualTo:
                    sb.Append( "<=" );
                    break;
                case ExpressionType.LessThan:
                    sb.Append( '<' );
                    break;
                case ExpressionType.Equal:
                    sb.Append( "==" );
                    break;
                case ExpressionType.NotEqual:
                    sb.Append( "!=" );
                    break;
                default:
                    throw new NotSupportedException("should not happen");
            }

            e2.AppendMacroStringToStringBuilder( sb );
            sb.Append( ']' );
            return;
        }

        sb.EnsureCapacity( sb.Length + 7 + 3 * Body.Length );
        sb.Append( "<expr:" );
        foreach (var t in Body)
            sb.Append( $" {t:X02}" );
        sb.Append( '>' );
    }
}