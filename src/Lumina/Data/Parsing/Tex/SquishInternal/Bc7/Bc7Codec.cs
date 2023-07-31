using System;
using System.Diagnostics;

namespace Lumina.Data.Parsing.Tex.SquishInternal.Bc7;

internal static class Bc7Codec
{
    public static void Decompress( ReadOnlySpan< byte > block, Span< byte > pixelBuffer )
    {
        Debug.Assert( block.Length >= 16 );
        Debug.Assert( pixelBuffer.Length >= 64 );

        var parsed = new Bc7ParsedBlock( stackalloc Vector4< byte >[Bc7ParsedBlock.MaxNumEndpoints] );
        if( !parsed.ReadBlock( block ) )
        {
            pixelBuffer[ ..64 ].Clear();
            return;
        }

        // if( parsed.Mode.Mode == 5 )
        // {
        //     pixelBuffer[ ..64 ].Clear();
        //     return;
        // }

        var colorBitCount = parsed.ColorIndexBitCount;
        var alphaBitCount = parsed.AlphaIndexBitCount;
        var xyzw = new Vector4< byte >();
        for( var i = 0; i < 16; i++ )
        {
            // decode partition data from explicit partition bits
            var subsetIndex = parsed.GetPartitionIndex( i );

            // endpoints are now complete.
            var endpoint0 = parsed.Endpoints[ 2 * subsetIndex + 0 ];
            var endpoint1 = parsed.Endpoints[ 2 * subsetIndex + 1 ];

            // Determine the palette index for this pixel
            var colorIndex = parsed.GetColorIndex( colorBitCount, i );
            var alphaIndex = parsed.GetAlphaIndex( alphaBitCount, i );

            // determine output
            xyzw.X = Interpolate( endpoint0.X, endpoint1.X, colorIndex, colorBitCount );
            xyzw.Y = Interpolate( endpoint0.Y, endpoint1.Y, colorIndex, colorBitCount );
            xyzw.Z = Interpolate( endpoint0.Z, endpoint1.Z, colorIndex, colorBitCount );
            xyzw.W = Interpolate( endpoint0.W, endpoint1.W, alphaIndex, alphaBitCount );

            // rotate accordingly
            xyzw = parsed.Rotation switch
            {
                Bc7RotationMode.NoChange => xyzw,
                Bc7RotationMode.SwapAlphaRed => new( xyzw.W, xyzw.Y, xyzw.Z, xyzw.X ),
                Bc7RotationMode.SwapAlphaGreen => new( xyzw.X, xyzw.W, xyzw.Z, xyzw.Y ),
                Bc7RotationMode.SwapAlphaBlue => new( xyzw.X, xyzw.Y, xyzw.W, xyzw.Z ),
                _ => xyzw,
            };
            xyzw.CopyTo( pixelBuffer );
            pixelBuffer = pixelBuffer[ 4.. ];
        }
    }

    private static byte Interpolate( byte e0, byte e1, int index, int indexPrecision ) => indexPrecision switch
    {
        2 => (byte) ( ( ( 64 - Bc7Constants.InterpolationWeights2[ index ] ) * e0 +
            Bc7Constants.InterpolationWeights2[ index ] * e1 + 32 ) >> 6 ),
        3 => (byte) ( ( ( 64 - Bc7Constants.InterpolationWeights3[ index ] ) * e0 +
            Bc7Constants.InterpolationWeights3[ index ] * e1 + 32 ) >> 6 ),
        4 => (byte) ( ( ( 64 - Bc7Constants.InterpolationWeights4[ index ] ) * e0 +
            Bc7Constants.InterpolationWeights4[ index ] * e1 + 32 ) >> 6 ),
        _ => e0,
    };
}