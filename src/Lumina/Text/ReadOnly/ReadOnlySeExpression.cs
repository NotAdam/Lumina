using System;
using System.Runtime.CompilerServices;

namespace Lumina.Text.ReadOnly;

/// <summary>Represents an expression in a <see cref="ReadOnlySeString"/>.</summary>
public readonly struct ReadOnlySeExpression : IEquatable< ReadOnlySeExpression >
{
    /// <summary>Read-only byte data for the SeString expression.</summary>
    public readonly ReadOnlyMemory< byte > Body;

    /// <summary>Initializes a new instance of the <see cref="ReadOnlySeExpression"/> struct.</summary>
    /// <param name="body">Raw SeString expression data.</param>
    public ReadOnlySeExpression( ReadOnlyMemory< byte > body ) => Body = body;

    /// <summary>Gets the read-only byte memory view of this instance of <see cref="ReadOnlySeExpression"/>.</summary>
    /// <param name="s">The expression to get a byte memory view of.</param>
    /// <returns>The read-only byte memory view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlyMemory< byte >( ReadOnlySeExpression s ) => s.Body;

    /// <summary>Gets the read-only byte span view of this instance of <see cref="ReadOnlySeExpression"/>.</summary>
    /// <param name="s">The expression to get a byte span view of.</param>
    /// <returns>The read-only byte span view of <paramref name="s"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySpan< byte >( ReadOnlySeExpression s ) => s.Body.Span;

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpression"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpression"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpression( ReadOnlyMemory< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpression"/> struct from the given byte memory view.</summary>
    /// <param name="s">The source byte memory view.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpression"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks>The backing data of <paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpression( Memory< byte > s ) => new( s );

    /// <summary>Creates a new instance of <see cref="ReadOnlySeExpression"/> struct from the given byte array.</summary>
    /// <param name="s">The source byte array.</param>
    /// <returns>A new instance of <see cref="ReadOnlySeExpression"/> wrapping <paramref name="s"/>.</returns>
    /// <remarks><paramref name="s"/> is not expected to be mutated once the cast is done.</remarks>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static implicit operator ReadOnlySeExpression( byte[] s ) => new( s );

    /// <summary>Returns a value that indicates whether the specified expressions are equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator ==( ReadOnlySeExpression left, ReadOnlySeExpression right ) => left.Equals( right );

    /// <summary>Returns a value that indicates whether the specified expressions are not equal.</summary>
    /// <param name="left">The first expression to compare.</param>
    /// <param name="right">The second expression to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool operator !=( ReadOnlySeExpression left, ReadOnlySeExpression right ) => !left.Equals( right );

    /// <summary>Gets a <see cref="ReadOnlySeExpressionSpan"/> from this <see cref="ReadOnlySeExpression"/>.</summary>
    /// <returns>A new instance of <see cref="ReadOnlySeExpressionSpan"/>.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public ReadOnlySeExpressionSpan AsSpan() => new( Body.Span );

    /// <summary>Attempts to get an integer value from this expression.</summary>
    /// <param name="value">The parsed integer value.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetUInt( out uint value ) => SeExpressionUtilities.TryDecodeUInt( Body.Span, out value, out _ );

    /// <inheritdoc cref="TryGetUInt(out uint)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetInt( out int value ) => SeExpressionUtilities.TryDecodeInt( Body.Span, out value, out _ );

    /// <summary>Attempts to get a SeString value from this expression.</summary>
    /// <param name="value">The parsed <see cref="ReadOnlySeString"/> value.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetString( out ReadOnlySeString value ) => SeExpressionUtilities.TryDecodeString( Body, out value, out _ );

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
    public bool TryGetParameterExpression( out byte expressionType, out ReadOnlySeExpression operand ) =>
        SeExpressionUtilities.TryDecodeUnary( Body, out expressionType, out operand, out _ );

    /// <summary>Attempts to get a binary expression from this expression.</summary>
    /// <param name="expressionType">The parsed expression type.</param>
    /// <param name="operand1">The operand 1.</param>
    /// <param name="operand2">The operand 2.</param>
    /// <returns><c>true</c> if successful.</returns>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool TryGetBinaryExpression( out byte expressionType, out ReadOnlySeExpression operand1, out ReadOnlySeExpression operand2 ) =>
        SeExpressionUtilities.TryDecodeBinary( Body, out expressionType, out operand1, out operand2, out _ );

    /// <inheritdoc cref="ReadOnlySeExpressionSpan.Validate"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Validate() => AsSpan().Validate();

    /// <inheritdoc cref="object.Equals(object?)"/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public bool Equals( ReadOnlySeExpression other ) => AsSpan().Equals( other.AsSpan() );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override bool Equals( object? obj ) => obj is ReadOnlySeExpression other && Equals( other );

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override int GetHashCode() => AsSpan().GetHashCode();

    /// <inheritdoc/>
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public override string ToString() => AsSpan().ToString();
}