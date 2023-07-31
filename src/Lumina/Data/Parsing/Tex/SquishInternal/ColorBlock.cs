using System;
using System.Numerics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal static class ColorBlock
{
    public static int FloatTo565( in Vector3 color )
    {
        // get the components in the correct range
        var r = SquishMathExtensions.FloatToInt( 31f * color.X, 31 );
        var g = SquishMathExtensions.FloatToInt( 63f * color.Y, 63 );
        var b = SquishMathExtensions.FloatToInt( 31f * color.Z, 31 );

        // pack into a single value
        return ( r << 11 ) | ( g << 5 ) | b;
    }

    public static void WriteColorBlock( int a, int b, ReadOnlySpan< byte > indices, Span< byte > bytes )
    {
        // write the endpoints
        bytes[ 0 ] = (byte) ( a & 0xff );
        bytes[ 1 ] = (byte) ( a >> 8 );
        bytes[ 2 ] = (byte) ( b & 0xff );
        bytes[ 3 ] = (byte) ( b >> 8 );

        // write the indices
        for( var i = 0; i < 4; ++i )
        {
            var ind = indices[ ( 4 * i ).. ];
            bytes[ 4 + i ] =
                unchecked( (byte) ( ind[ 0 ] | ( ind[ 1 ] << 2 ) | ( ind[ 2 ] << 4 ) | ( ind[ 3 ] << 6 ) ) );
        }
    }

    public static void WriteColorBlock3(
        in Vector3 start,
        in Vector3 end,
        ReadOnlySpan< byte > indices,
        Span< byte > block )
    {
        // get the packed values
        var a = FloatTo565( start );
        var b = FloatTo565( end );

        // remap the indices
        Span< byte > remapped = stackalloc byte[16];
        if( a <= b )
        {
            // use the indices directly
            indices.CopyTo( remapped );
        }
        else
        {
            // swap a and b
            ( a, b ) = ( b, a );
            for( var i = 0; i < 16; ++i )
            {
                remapped[ i ] = indices[ i ] switch
                {
                    0 => 1,
                    1 => 0,
                    _ => indices[ i ],
                };
            }
        }

        // write the block
        WriteColorBlock( a, b, remapped, block );
    }

    public static void WriteColorBlock4(
        in Vector3 start,
        in Vector3 end,
        ReadOnlySpan< byte > indices,
        Span< byte > block )
    {
        // get the packed values
        var a = FloatTo565( start );
        var b = FloatTo565( end );

        // remap the indices
        Span< byte > remapped = stackalloc byte[16];
        if( a < b )
        {
            // swap a and b
            ( a, b ) = ( b, a );
            for( var i = 0; i < 16; ++i )
                remapped[ i ] = unchecked( (byte) ( ( indices[ i ] ^ 0x1 ) & 0x3 ) );
        }
        else if( a == b )
        {
            // use index 0
            remapped.Clear();
        }
        else
        {
            // use the indices directly
            indices.CopyTo( remapped );
        }

        // write the block
        WriteColorBlock( a, b, remapped, block );
    }

    private static int Unpack565( ReadOnlySpan< byte > packed, Span< byte > color )
    {
        // Build the packed value.
        var value = packed[ 0 ] | ( packed[ 1 ] << 8 );

        // Get the components in the stored range.
        var red = (byte) ( ( value >> 11 ) & 0x1F );
        var green = (byte) ( ( value >> 5 ) & 0x3F );
        var blue = (byte) ( value & 0x1F );

        // Scale up to 8 bits
        color[ 0 ] = (byte) ( ( red << 3 ) | ( red >> 2 ) );
        color[ 1 ] = (byte) ( ( green << 2 ) | ( green >> 4 ) );
        color[ 2 ] = (byte) ( ( blue << 3 ) | ( blue >> 2 ) );
        color[ 3 ] = 255;

        return value;
    }

    public static void DecompressColor( Span< byte > pixelBuffer, ReadOnlySpan< byte > block, SquishOptions2 options )
    {
        // Unpack the endpoints
        Span< byte > codes = stackalloc byte[16];
        var a = Unpack565( block, codes );
        var b = Unpack565( block[ 2.. ], codes[ 4.. ] );

        // Generate the midpoints.
        for( var i = 0; i < 3; ++i )
        {
            var c = codes[ i ];
            var d = codes[ 4 + i ];

            if( options.Method == SquishMethod.Dxt1 && a <= b )
            {
                codes[ 8 + i ] = (byte) ( ( c + d ) / 2 );
                codes[ 12 + i ] = 0;
            }
            else
            {
                codes[ 8 + i ] = (byte) ( ( 2 * c + d ) / 3 );
                codes[ 12 + i ] = (byte) ( ( c + 2 * d ) / 3 );
            }
        }

        // Fill in alpha for the intermediate values.
        codes[ 8 + 3 ] = 255;
        codes[ 12 + 3 ] = (byte) ( options.Method == SquishMethod.Dxt1 && a <= b ? 0 : 255 );

        // Unpack the indices
        Span< byte > indices = stackalloc byte[16];
        for( var i = 0; i < 4; i++ )
        {
            var packed = block[ 4 + i ];

            indices[ 4 * i + 0 ] = (byte) ( packed & 0x3 );
            indices[ 4 * i + 1 ] = (byte) ( ( packed >> 2 ) & 0x3 );
            indices[ 4 * i + 2 ] = (byte) ( ( packed >> 4 ) & 0x3 );
            indices[ 4 * i + 3 ] = (byte) ( ( packed >> 6 ) & 0x3 );
        }

        // Store the Colors
        for( var i = 0; i < 16; ++i )
            codes.Slice( 4 * indices[ i ], 4 ).CopyTo( pixelBuffer.Slice( 4 * i, 4 ) );
    }
}