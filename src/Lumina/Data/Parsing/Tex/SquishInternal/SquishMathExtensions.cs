using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal static class SquishMathExtensions
{
    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static Vector3 DropW( this Vector4 value ) => new( value.X, value.Y, value.Z );

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static Vector3 ClampElements( in this Vector3 value, in Vector3 min, in Vector3 max ) => new(
        Math.Clamp( value.X, min.X, max.X ),
        Math.Clamp( value.Y, min.Y, max.Y ),
        Math.Clamp( value.Z, min.Z, max.Z ) );

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static Vector3 TruncateElements( in this Vector3 value ) =>
        new(
            value.X > 0f ? MathF.Floor( value.X ) : MathF.Ceiling( value.X ),
            value.Y > 0f ? MathF.Floor( value.Y ) : MathF.Ceiling( value.Y ),
            value.Z > 0f ? MathF.Floor( value.Z ) : MathF.Ceiling( value.Z ) );

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static Vector4 ClampElements( in this Vector4 value, in Vector4 min, in Vector4 max ) => new(
        Math.Clamp( value.X, min.X, max.X ),
        Math.Clamp( value.Y, min.Y, max.Y ),
        Math.Clamp( value.Z, min.Z, max.Z ),
        Math.Clamp( value.W, min.W, max.W ) );

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static Vector4 TruncateElements( in this Vector4 value ) =>
        new(
            value.X > 0f ? MathF.Floor( value.X ) : MathF.Ceiling( value.X ),
            value.Y > 0f ? MathF.Floor( value.Y ) : MathF.Ceiling( value.Y ),
            value.Z > 0f ? MathF.Floor( value.Z ) : MathF.Ceiling( value.Z ),
            value.W > 0f ? MathF.Floor( value.W ) : MathF.Ceiling( value.W ) );

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static bool AnyLessThan( in this Vector4 l, in Vector4 r ) =>
        l.X < r.X || l.Y < r.Y || l.Z < r.Z || l.W < r.W;

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    public static int FloatToInt( float a, int limit ) =>
        // Use ANSI round-to-zero behaviour to get round-to-nearest.
        Math.Clamp( (int) ( a + .5f ), 0, limit );
}