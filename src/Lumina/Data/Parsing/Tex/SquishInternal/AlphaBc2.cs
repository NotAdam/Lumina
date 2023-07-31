using System;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal static class AlphaBc2
{
    public static void Compress( ReadOnlySpan< byte > pixelBuffer, int alphaOffset, int mask, Span< byte > block )
    {
        // Quantise and pack alpha values pairwise.
        for( var i = 0; i < 8; ++i )
        {
            // Qnatise down to 4 bits.
            var alpha1 = pixelBuffer[ 8 * i + alphaOffset + 0 ] * ( 15f / 255f );
            var alpha2 = pixelBuffer[ 8 * i + alphaOffset + 4 ] * ( 15f / 255f );
            var quant1 = SquishMathExtensions.FloatToInt( alpha1, 15 );
            var quant2 = SquishMathExtensions.FloatToInt( alpha2, 15 );

            // Set alpha to zero where masked.
            var bit1 = 1 << ( 2 * i );
            var bit2 = 1 << ( 2 * i + 1 );
            if( ( mask & bit1 ) == 0 )
                quant1 = 0;
            if( ( mask & bit2 ) == 0 )
                quant2 = 0;

            // Pack into the byte.
            block[ i ] = (byte) ( quant1 | ( quant2 << 4 ) );
        }
    }

    public static void Decompress( ReadOnlySpan< byte > block, Span< byte > pixelBuffer, int alphaOffset )
    {
        // Unpack the alpha values pairwise.
        for( var i = 0; i < 8; ++i )
        {
            // Quantise down to 4 bits.
            var quant = block[ i ];

            // Unpack the values.
            var lo = quant & 0x0f;
            var hi = quant & 0xf0;

            // Convert back up to bytes.
            pixelBuffer[ 8 * i + alphaOffset + 0 ] = (byte) ( lo | ( lo << 4 ) );
            pixelBuffer[ 8 * i + alphaOffset + 4 ] = (byte) ( hi | ( hi << 4 ) );
        }
    }
}