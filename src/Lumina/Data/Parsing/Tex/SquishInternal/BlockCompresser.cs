using System;
using System.Diagnostics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal unsafe struct BlockCompresser
{
    private readonly SquishOptions2 _options;
    private readonly ColorSet _colors = new();
    private readonly SingleColorFit _singleColorFit;
    private readonly RangeFit _rangeFit;
    private readonly ClusterFit _clusterFit;
#pragma warning disable CS0649
    private fixed byte _rgba[64];
#pragma warning restore CS0649
    private int _mask;

    public BlockCompresser( SquishOptions2 options )
    {
        _options = options;
        _singleColorFit = new( _colors, options );
        _rangeFit = new( _colors, options );
        _clusterFit = new( _colors, options );

        // Initialize rgba view with opaque pixels
        for( var i = 3; i < 64; i += 4 )
            _rgba[ i ] = 255;
    }

    public void RemapChannelsFromMasked( ReadOnlySpan< byte > pixelBuffer, int mask )
    {
        var p = _options.NumBytesPerPixel;
        var (r, g, b, a) = _options.ChannelOffsets;
        if( r < p )
            for( int i = 0, j = r; i < 64; i += 4, j += p )
                _rgba[ i ] = pixelBuffer[ j ];
        if( g < p )
            for( int i = 1, j = g; i < 64; i += 4, j += p )
                _rgba[ i ] = pixelBuffer[ j ];
        if( b < p )
            for( int i = 2, j = b; i < 64; i += 4, j += p )
                _rgba[ i ] = pixelBuffer[ j ];
        if( a < p )
            for( int i = 3, j = a; i < 64; i += 4, j += p )
                _rgba[ i ] = pixelBuffer[ j ];
        _mask = mask;
    }

    public void RemapChannelsFrom( ReadOnlySpan< byte > pixelBuffer ) => RemapChannelsFromMasked( pixelBuffer, 0xffff );

    public void RemapChannelsFrom( ReadOnlySpan< byte > pixels, int x0, int y0, int stride, int width, int height )
    {
        var p = _options.NumBytesPerPixel;

        var (r, g, b, a) = _options.ChannelOffsets;

        var availHorzPixels = Math.Min( 4, width - x0 );
        var availVertPixels = Math.Min( 4, height - y0 );

        _mask = 0;
        for( int by = 0, y = y0; by < availVertPixels; by++, y++ )
        {
            var pixelsRow = pixels[ ( stride * y + p * x0 ).. ];
            for( var bx = 0; bx < availHorzPixels; bx++ )
            {
                var off = 16 * by + 4 * bx;
                _rgba[ off + 0 ] = r < p ? pixelsRow[ p * bx + r ] : (byte) 0;
                _rgba[ off + 1 ] = g < p ? pixelsRow[ p * bx + g ] : (byte) 0;
                _rgba[ off + 2 ] = b < p ? pixelsRow[ p * bx + b ] : (byte) 0;
                _rgba[ off + 3 ] = a < p ? pixelsRow[ p * bx + a ] : (byte) 255;
                _mask |= 1 << ( 4 * by + bx );
            }
        }
    }

    public void CompressMaskedInto( Span< byte > block )
    {
        fixed( byte* pRgba = _rgba )
        {
            Span< byte > rgba = new( pRgba, 64 );
            switch( _options.Method )
            {
                case SquishMethod.Bc1:
                    Debug.Assert( block.Length >= 8 );
                    CompressColors( rgba, _mask, block );
                    break;
                case SquishMethod.Bc2:
                    Debug.Assert( block.Length >= 16 );
                    CompressColors( rgba, _mask, block[ 8.. ] );
                    AlphaBc2.Compress( rgba, 3, _mask, block );
                    break;
                case SquishMethod.Bc3:
                    Debug.Assert( block.Length >= 16 );
                    CompressColors( rgba, _mask, block[ 8.. ] );
                    AlphaBc3U.Compress( rgba, 3, _mask, block );
                    break;
                case SquishMethod.Bc4U:
                    Debug.Assert( block.Length >= 8 );
                    AlphaBc3U.Compress( rgba, 0, _mask, block );
                    break;
                case SquishMethod.Bc4S:
                    Debug.Assert( block.Length >= 8 );
                    AlphaBc3S.Compress( rgba, 0, _mask, block );
                    break;
                case SquishMethod.Bc5U:
                    Debug.Assert( block.Length >= 16 );
                    AlphaBc3U.Compress( rgba, 0, _mask, block );
                    AlphaBc3U.Compress( rgba, 1, _mask, block[ 8.. ] );
                    break;
                case SquishMethod.Bc5S:
                    Debug.Assert( block.Length >= 16 );
                    AlphaBc3S.Compress( rgba, 0, _mask, block );
                    AlphaBc3S.Compress( rgba, 1, _mask, block[ 8.. ] );
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }

    private void CompressColors( Span< byte > rgba, int mask, Span< byte > block )
    {
        // create the minimal point set
        _colors.Reset( rgba, mask, _options );

        // check the compression type and compress colour
        if( _colors.Count == 1 )
        {
            // always do a single colour fit
            _singleColorFit.Compress( block );
        }
        else if( _options.Fit == SquishFit.ColorRangeFit || _colors.Count == 0 )
        {
            _rangeFit.Compress( block );
        }
        else
        {
            // default to a cluster fit (could be iterative or not)
            _clusterFit.Compress( block );
        }
    }
}