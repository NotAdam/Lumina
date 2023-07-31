using System;
using System.Diagnostics;
using Lumina.Data.Parsing.Tex.SquishInternal.Bc7;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal unsafe struct BlockDecompresser
{
    private readonly SquishOptions2 _options;
#pragma warning disable CS0649
    private fixed byte _rgba[64];
#pragma warning restore CS0649

    public BlockDecompresser( SquishOptions2 options )
    {
        _options = options;
    }

    public Vector4< byte > this[ int y, int x ] => new(
        _rgba[ y * 16 + x * 4 + 0 ],
        _rgba[ y * 16 + x * 4 + 1 ],
        _rgba[ y * 16 + x * 4 + 2 ],
        _rgba[ y * 16 + x * 4 + 3 ] );

    public void DecompressFrom( ReadOnlySpan< byte > block )
    {
        fixed( byte* pRgba = _rgba )
        {
            Span< byte > rgba = new( pRgba, 64 );
            switch( _options.Method )
            {
                case SquishMethod.Bc1:
                    Debug.Assert( block.Length >= 8 );
                    ColorBlock.DecompressColor( rgba, block, _options );
                    break;
                case SquishMethod.Bc2:
                    Debug.Assert( block.Length >= 16 );
                    ColorBlock.DecompressColor( rgba, block[ 8.. ], _options );
                    AlphaBc2.Decompress( block, rgba, 3 );
                    break;
                case SquishMethod.Bc3:
                    Debug.Assert( block.Length >= 16 );
                    ColorBlock.DecompressColor( rgba, block[ 8.. ], _options );
                    AlphaBc3U.Decompress( block, rgba, 3 );
                    break;
                case SquishMethod.Bc4U:
                    Debug.Assert( block.Length >= 8 );
                    AlphaBc3U.Decompress( block, rgba, 0 );
                    break;
                case SquishMethod.Bc4S:
                    Debug.Assert( block.Length >= 8 );
                    AlphaBc3S.Decompress( block, rgba, 0 );
                    break;
                case SquishMethod.Bc5U:
                    Debug.Assert( block.Length >= 16 );
                    AlphaBc3U.Decompress( block, rgba, 0 );
                    AlphaBc3U.Decompress( block[ 8.. ], rgba, 1 );
                    break;
                case SquishMethod.Bc5S:
                    Debug.Assert( block.Length >= 16 );
                    AlphaBc3S.Decompress( block, rgba, 0 );
                    AlphaBc3S.Decompress( block[ 8.. ], rgba, 1 );
                    break;
                case SquishMethod.Bc7:
                    Debug.Assert( block.Length >= 16 );
                    Bc7Codec.Decompress( block, rgba );
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }

    public void RemapChannelsInto( Span< byte > pixels )
    {
        fixed( byte* pRgba = _rgba )
        {
            Span< byte > rgba = new( pRgba, 64 );
            Debug.Assert( pixels.Length == 16 * _options.NumBytesPerPixel );

            var p = _options.NumBytesPerPixel;
            var (r, g, b, a) = _options.ChannelOffsets;
            if( r < p )
                for( int i = 0, j = r; i < 64; i += 4, j += p )
                    pixels[ j ] = rgba[ i ];
            if( g < p )
                for( int i = 1, j = g; i < 64; i += 4, j += p )
                    pixels[ j ] = rgba[ i ];
            if( b < p )
                for( int i = 2, j = b; i < 64; i += 4, j += p )
                    pixels[ j ] = rgba[ i ];
            if( a < p )
                for( int i = 3, j = a; i < 64; i += 4, j += p )
                    pixels[ j ] = rgba[ i ];
        }
    }

    public void RemapChannelsInto( Span< byte > pixels, int x0, int y0, int stride, int width, int height )
    {
        fixed( byte* pRgba = _rgba )
        {
            Span< byte > rgba = new( pRgba, 64 );
            var p = _options.NumBytesPerPixel;

            var (r, g, b, a) = _options.ChannelOffsets;

            var availHorzBytes = Math.Min( 4, width - x0 ) * 4;
            var availVertPixels = Math.Min( 4, height - y0 );

            for( int by = 0, y = y0; by < availVertPixels; by++, y++ )
            {
                var rgbaRow = rgba[ ( by * 16 ).. ];
                var pixelsRow = pixels[ ( stride * y + p * x0 ).. ];
                if( r < p )
                    for( int rgbaOffset = 0, pixelOffset = r;
                        rgbaOffset < availHorzBytes;
                        rgbaOffset += 4, pixelOffset += p )
                        pixelsRow[ pixelOffset ] = rgbaRow[ rgbaOffset ];
                if( g < p )
                    for( int rgbaOffset = 1, pixelOffset = g;
                        rgbaOffset < availHorzBytes;
                        rgbaOffset += 4, pixelOffset += p )
                        pixelsRow[ pixelOffset ] = rgbaRow[ rgbaOffset ];
                if( b < p )
                    for( int rgbaOffset = 2, pixelOffset = b;
                        rgbaOffset < availHorzBytes;
                        rgbaOffset += 4, pixelOffset += p )
                        pixelsRow[ pixelOffset ] = rgbaRow[ rgbaOffset ];
                if( a < p )
                    for( int rgbaOffset = 3, pixelOffset = a;
                        rgbaOffset < availHorzBytes;
                        rgbaOffset += 4, pixelOffset += p )
                        pixelsRow[ pixelOffset ] = rgbaRow[ rgbaOffset ];
            }
        }
    }
}