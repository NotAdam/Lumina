using System;
using System.Runtime.CompilerServices;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal static class AlphaBc3U
{
    private const byte TypeMin = byte.MinValue;
    private const byte TypeMax = byte.MaxValue;

    [MethodImpl( MethodImplOptions.AggressiveInlining )]
    private static void FixRange( ref byte min, ref byte max, int steps )
    {
        if( max - min < steps )
            max = (byte) Math.Min( min + steps, TypeMax );
        if( max - min < steps )
            min = (byte) Math.Max( TypeMin, max - steps );
    }

    private static int FitCodes(
        ReadOnlySpan< byte > pixelBuffer,
        int channelIndex,
        int mask,
        ReadOnlySpan< byte > codes,
        Span< byte > indices )
    {
        // Fit each alpha value to the codebook.
        var err = 0;
        for( var i = 0; i < 16; ++i )
        {
            // Check this pixel is valid.
            var bit = 1 << i;
            if( ( mask & bit ) == 0 )
            {
                // Use the first code.
                indices[ i ] = 0;
                continue;
            }

            // Find the least error and corresponding index.
            var value = pixelBuffer[ 4 * i + channelIndex ];
            var least = int.MaxValue;
            var index = 0;
            for( var j = 0; j < 8; ++j )
            {
                // Get the squared error from this code.
                var dist = value - codes[ j ];
                dist *= dist;

                // Compare with the best so far.
                if( dist < least )
                {
                    least = dist;
                    index = j;
                }
            }

            // Save this index and accumulate the error.
            indices[ i ] = (byte) index;
            err += least;
        }

        // Return the total error.
        return err;
    }

    private static void WriteBlock( byte alpha0, byte alpha1, ReadOnlySpan< byte > indices, Span< byte > target )
    {
        // Write the first two bytes.
        target[ 0 ] = alpha0;
        target[ 1 ] = alpha1;

        var indOff = 0;
        var retOff = 2;
        for( var i = 0; i < 2; ++i )
        {
            // Pack 8 3-bit values.
            var value = 0;
            for( var j = 0; j < 8; ++j )
            {
                var index = indices[ indOff++ ];
                value |= index << 3 * j;
            }

            // Store in 3 bytes
            for( var j = 0; j < 3; ++j )
            {
                var b = ( value >> ( 8 * j ) ) & 0xFF;
                target[ retOff++ ] = (byte) b;
            }
        }
    }

    private static void WriteBlock5( byte alpha0, byte alpha1, ReadOnlySpan< byte > indices, Span< byte > block )
    {
        // Check the relative values of the endpoints.
        if( alpha0 > alpha1 )
        {
            Span< byte > swapped = stackalloc byte[16];
            for( var i = 0; i < 16; ++i )
            {
                var index = indices[ i ];
                swapped[ i ] = index switch
                {
                    0 => 1,
                    1 => 0,
                    <= 5 => (byte) ( 7 - index ),
                    _ => index,
                };
            }

            // Write the block.
            WriteBlock( alpha1, alpha0, swapped, block );
        }
        else
        {
            // Write the block.
            WriteBlock( alpha0, alpha1, indices, block );
        }
    }

    private static void WriteBlock7( byte alpha0, byte alpha1, ReadOnlySpan< byte > indices, Span< byte > block )
    {
        // Check the relative values of the endpoints.
        if( alpha0 < alpha1 )
        {
            Span< byte > swapped = stackalloc byte[16];
            for( var i = 0; i < 16; ++i )
            {
                var index = indices[ i ];
                swapped[ i ] = index switch
                {
                    0 => 1,
                    1 => 0,
                    _ => (byte) ( 9 - index )
                };
            }

            // Write the block.
            WriteBlock( alpha1, alpha0, swapped, block );
        }
        else
        {
            // Write the block.
            WriteBlock( alpha0, alpha1, indices, block );
        }
    }

    public static void Compress( ReadOnlySpan< byte > pixelBuffer, int channelIndex, int mask, Span< byte > block )
    {
        // Get the range for 5-alpha and 7-alpha interpolation.
        byte min5 = TypeMax, max5 = TypeMin;
        byte min7 = TypeMax, max7 = TypeMin;
        for( var i = 0; i < 16; ++i )
        {
            // Check this pixel is valid.
            var bit = 1 << i;
            if( ( mask & bit ) == 0 )
                continue;

            // Incorporate into the min/max.
            var value = pixelBuffer[ 4 * i + channelIndex ];
            if( value < min7 )
                min7 = value;
            if( value > max7 )
                max7 = value;
            if( value != TypeMin && value < min5 )
                min5 = value;
            if( value != TypeMax && value > max5 )
                max5 = value;
        }

        // Handle the case that no valid range was found.
        if( min5 > max5 )
            min5 = max5;
        if( min7 > max7 )
            min7 = max7;

        // Fix the range to be the minimum in each case.
        FixRange( ref min5, ref max5, 5 );
        FixRange( ref min7, ref max7, 7 );

        // Set up the 5-alpha code book.
        Span< byte > codes5 = stackalloc byte[8];
        codes5[ 0 ] = min5;
        codes5[ 1 ] = max5;
        for( var i = 1; i < 5; ++i )
            codes5[ i + 1 ] = (byte) ( ( ( 5 - i ) * min5 + i * max5 ) / 5 );
        codes5[ 6 ] = TypeMin;
        codes5[ 7 ] = TypeMax;

        // Set up the 7-alpha code book.
        Span< byte > codes7 = stackalloc byte[8];
        codes7[ 0 ] = min7;
        codes7[ 1 ] = max7;
        for( var i = 1; i < 7; ++i )
            codes7[ i + 1 ] = (byte) ( ( ( 7 - i ) * min7 + i * max7 ) / 7 );

        // Fit the data to both code books.
        Span< byte > indices5 = stackalloc byte[16];
        Span< byte > indices7 = stackalloc byte[16];
        var err5 = FitCodes( pixelBuffer, channelIndex, mask, codes5, indices5 );
        var err7 = FitCodes( pixelBuffer, channelIndex, mask, codes7, indices7 );

        // Save the block with least error.
        if( err5 <= err7 )
            WriteBlock5( min5, max5, indices5, block );
        else
            WriteBlock7( min7, max7, indices7, block );
    }

    public static void Decompress( ReadOnlySpan< byte > block, Span< byte > pixelBuffer, int channelIndex )
    {
        if( channelIndex < 0 || channelIndex >= 4 )
            return;

        // Get the two alpha values.
        var alpha0 = block[ 0 ];
        var alpha1 = block[ 1 ];

        // Compare the values to build the codebook.
        Span< byte > codes = stackalloc byte[8];
        codes[ 0 ] = alpha0;
        codes[ 1 ] = alpha1;
        if( alpha0 <= alpha1 )
        {
            // Use the 5-alpha codebook.
            for( var i = 1; i < 5; ++i )
                codes[ 1 + i ] = (byte) ( ( ( 5 - i ) * alpha0 + i * alpha1 ) / 5 );
            codes[ 6 ] = TypeMin;
            codes[ 7 ] = TypeMax;
        }
        else
        {
            // Use the 7-alpha codebook.
            for( var i = 1; i < 7; ++i )
                codes[ 1 + i ] = (byte) ( ( ( 7 - i ) * alpha0 + i * alpha1 ) / 7 );
        }

        // Decode the incdices
        Span< byte > indices = stackalloc byte[16];
        var blOff = 2;
        var indOff = 0;
        for( var i = 0; i < 2; ++i )
        {
            // Grab 3 bytes
            var value = 0;
            for( var j = 0; j < 3; ++j )
            {
                var b = block[ blOff++ ];
                value |= b << 8 * j;
            }

            // Unpack 8 3-bit values from it
            for( var j = 0; j < 8; ++j )
            {
                var index = ( value >> 3 * j ) & 0x7;
                indices[ indOff++ ] = (byte) index;
            }
        }

        // Write out the index codebook values.
        for( var i = 0; i < 16; ++i )
            pixelBuffer[ 4 * i + channelIndex ] = codes[ indices[ i ] ];
    }
}