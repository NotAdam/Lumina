using System;

namespace Lumina.Data.Parsing.Tex
{
    // From DotSquish
    internal class ColourSet
    {
        #region Fields

        private int _Count;
        private Vector3[] _Points = new Vector3[16];
        private float[] _Weights = new float[16];
        private int[] _Remap = new int[16];
        private bool _IsTransparent;

        #endregion

        #region Properties

        public int Count => _Count;

        public Vector3[] Points => _Points;

        public float[] Weights => _Weights;

        public bool IsTransparent => _IsTransparent;

        #endregion

        #region Constructor

        public ColourSet( byte[] rgba, int mask, SquishOptions flags )
        {
            // Check the compression mode.
            var isDxt1 = flags.HasFlag( SquishOptions.DXT1 );
            var weightByAlpha = flags.HasFlag( SquishOptions.WeightColourByAlpha );

            // Create he minimal set.
            for( int i = 0; i < 16; ++i )
            {
                // Check this pixel is enabled.
                int bit = 1 << i;
                if( ( mask & bit ) == 0 )
                {
                    _Remap[ i ] = -1;
                    continue;
                }

                // Check for transparent pixels when using DXT1.
                if( isDxt1 && rgba[ 4 * i + 3 ] < 128 )
                {
                    _Remap[ i ] = -1;
                    _IsTransparent = true;
                }

                // Loop over previous points for a match.
                for( int j = 0;; ++j )
                {
                    // Allocate a new point.
                    if( j == i )
                    {
                        // Normalise coordinates to [0,1].
                        var x = rgba[ 4 * i ] / 255f;
                        var y = rgba[ 4 * i + 1 ] / 255f;
                        var z = rgba[ 4 * i + 2 ] / 255f;

                        // Ensure there is always a non-zero weight even for zero alpha.
                        var w = ( rgba[ 4 * i + 3 ] + 1 ) / 256f;

                        // Add the point.
                        _Points[ _Count ] = new Vector3( x, y, z );
                        _Weights[ _Count ] = w;
                        _Remap[ i ] = _Count;

                        // Advance.
                        ++_Count;
                        break;
                    }

                    // Check for a match.
                    int oldBit = 1 << j;
                    var match = ( ( mask & oldBit ) != 0 )
                                && ( rgba[ 4 * i ] == rgba[ 4 * j ] )
                                && ( rgba[ 4 * i + 1 ] == rgba[ 4 * j + 1 ] )
                                && ( rgba[ 4 * i + 3 ] == rgba[ 4 * j + 2 ] )
                                && ( rgba[ 4 * j + 3 ] >= 128 || !isDxt1 );
                    if( match )
                    {
                        // Get index of the match.
                        var index = _Remap[ j ];

                        // Ensure there is always a non-zero weight even for zero alpha.
                        var w = ( rgba[ 4 * i + 3 ] + 1 ) / 256f;

                        // Map this point and increase the weight.
                        _Weights[ index ] += ( weightByAlpha ? w : 1f );
                        _Remap[ i ] = index;
                        break;
                    }
                }
            }

            // Square root the weights.
            for( int i = 0; i < _Count; ++i )
            {
                _Weights[ i ] = (float)Math.Sqrt( _Weights[ i ] );
            }
        }

        #endregion

        #region Methods

        public void RemapIndices( byte[] source, byte[] target, int targetOffset )
        {
            for( int i = 0; i < 16; ++i )
            {
                var j = _Remap[ i ];
                if( j == -1 )
                    target[ i + targetOffset ] = 3;
                else
                    target[ i + targetOffset ] = source[ j ];
            }
        }

        #endregion
    }
}