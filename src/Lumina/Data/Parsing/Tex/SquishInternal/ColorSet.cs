using System;
using System.Diagnostics;
using System.Numerics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal class ColorSet
{
    public bool IsTransparent;
    public int Count;
    public readonly Vector3[] Points = new Vector3[16];
    public readonly float[] Weights = new float[16];
    private readonly int[] _remap = new int[16];

    public void Reset( ReadOnlySpan< byte > pixelBuffer, int mask, SquishOptions2 options )
    {
        IsTransparent = false;
        Count = 0;
        Points.AsSpan().Clear();
        Weights.AsSpan().Clear();
        _remap.AsSpan().Clear();

        // Check the compression mode.
        var isDxt1 = options.Method == SquishMethod.Dxt1;

        // Create he minimal set.
        for( var i = 0; i < 16; ++i )
        {
            // Check this pixel is enabled.
            var bit = 1 << i;
            if( ( mask & bit ) == 0 )
            {
                _remap[ i ] = -1;
                continue;
            }

            // Check for transparent pixels when using DXT1.
            if( isDxt1 && pixelBuffer[ 4 * i + 3 ] == 0 )
            {
                _remap[ i ] = -1;
                IsTransparent = true;
                continue;
            }

            // Loop over previous points for a match.
            for( var j = 0;; ++j )
            {
                // Allocate a new point.
                if( j == i )
                {
                    // Ensure there is always a non-zero weight even for zero alpha.
                    var w = ( pixelBuffer[ 4 * i + 3 ] + 1 ) / 256f;

                    // Add the point.
                    Points[ Count ] = new Vector3(
                        pixelBuffer[ 4 * i + 0 ],
                        pixelBuffer[ 4 * i + 1 ],
                        pixelBuffer[ 4 * i + 2 ] ) / 255f;
                    Weights[ Count ] = options.WeightColorByAlpha ? w : 1f;
                    _remap[ i ] = Count;

                    // Advance.
                    ++Count;
                    break;
                }

                // Check for a match.
                var oldBit = 1 << j;
                var match = ( mask & oldBit ) != 0
                    && pixelBuffer[ 4 * i + 0 ] == pixelBuffer[ 4 * j + 0 ]
                    && pixelBuffer[ 4 * i + 1 ] == pixelBuffer[ 4 * j + 1 ]
                    && pixelBuffer[ 4 * i + 2 ] == pixelBuffer[ 4 * j + 2 ]
                    && ( !isDxt1 || pixelBuffer[ 4 * j + 3 ] != 0 );
                if( match )
                {
                    // Get index of the match.
                    var index = _remap[ j ];

                    // Ensure there is always a non-zero weight even for zero alpha.
                    var w = ( pixelBuffer[ 4 * i + 3 ] + 1 ) / 256f;

                    // Map this point and increase the weight.
                    Weights[ index ] += options.WeightColorByAlpha ? w : 1f;
                    _remap[ i ] = index;
                    break;
                }
            }
        }

        // Square root the weights.
        for( var i = 0; i < Count; ++i )
            Weights[ i ] = MathF.Sqrt( Weights[ i ] );
    }

    public void RemapIndices( Span< byte > source, Span< byte > target )
    {
        Debug.Assert( source.Length == 16 );
        Debug.Assert( target.Length == 16 );
        for( var i = 0; i < 16; ++i )
        {
            var j = _remap[ i ];
            target[ i ] = j == -1 ? (byte) 3 : source[ j ];
        }
    }

    public void RemapIndices( byte source, Span< byte > target )
    {
        Debug.Assert( target.Length == 16 );
        for( var i = 0; i < 16; ++i )
        {
            var j = _remap[ i ];
            target[ i ] = j == -1 ? (byte) 3 : source;
        }
    }
}