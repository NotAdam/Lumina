using System;
using System.Numerics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal class RangeFit : ColorFit
{
    private static readonly Vector3 Half = new( 0.5f );
    private static readonly Vector3 Grid = new( 31f, 63f, 31f );
    private static readonly Vector3 GridRcp = new( 1f / 31f, 1f / 63f, 1f / 31f );

    private readonly Vector3 _metric;
    private Vector3 _start;
    private Vector3 _end;
    private float _besterror;

    public RangeFit( ColorSet colors, SquishOptions2 options ) : base( colors, options )
    {
        _metric = options.Weights;
    }

    protected override void Reset()
    {
        // initialise the best error
        _besterror = float.MaxValue;

        // get the covariance matrix
        var covariance = Sym3x3.ComputeWeightedCovariance( Colors.Count, Colors.Points, Colors.Weights );

        // compute the principle component
        var principle = Sym3x3.ComputePrincipleComponent( covariance );

        // get the min and max range as the codebook endpoints
        var start = Vector3.Zero;
        var end = Vector3.Zero;
        if( Colors.Count > 0 )
        {
            // compute the range
            start = end = Colors.Points[ 0 ];
            var max = Vector3.Dot( Colors.Points[ 0 ], principle );
            var min = max;
            for( var i = 1; i < Colors.Count; ++i )
            {
                var val = Vector3.Dot( Colors.Points[ i ], principle );
                if( val < min )
                {
                    start = Colors.Points[ i ];
                    min = val;
                }
                else if( val > max )
                {
                    end = Colors.Points[ i ];
                    max = val;
                }
            }
        }

        // clamp the output to [0, 1], clamp to the grid, and save
        _start = ( Grid * start.ClampElements( Vector3.Zero, Vector3.One ) + Half ).TruncateElements() * GridRcp;
        _end = ( Grid * end.ClampElements( Vector3.Zero, Vector3.One ) + Half ).TruncateElements() * GridRcp;
    }

    protected override void Compress3( Span< byte > block )
    {
        // create a codebook
        Span< Vector3 > codes = stackalloc Vector3[3];
        codes[ 0 ] = _start;
        codes[ 1 ] = _end;
        codes[ 2 ] = 0.5f * _start + 0.5f * _end;

        // match each point to the closest code
        Span< byte > closest = stackalloc byte[16];
        var error = 0f;
        for( var i = 0; i < Colors.Count; ++i )
        {
            // find the closest code
            var dist = float.MaxValue;
            var idx = 0;
            for( var j = 0; j < 3; ++j )
            {
                var d = ( _metric * ( Colors.Points[ i ] - codes[ j ] ) ).LengthSquared();
                if( d < dist )
                {
                    dist = d;
                    idx = j;
                }
            }

            // save the index
            closest[ i ] = (byte) idx;

            // accumulate the error
            error += dist;
        }

        // save this scheme if it wins
        if( error < _besterror )
        {
            // remap the indices
            Span< byte > indices = stackalloc byte[16];
            Colors.RemapIndices( closest, indices );

            // save the block
            ColorBlock.WriteColorBlock3( _start, _end, indices, block );

            // save the error
            _besterror = error;
        }
    }

    protected override void Compress4( Span< byte > block )
    {
        // create a codebook
        Span< Vector3 > codes = stackalloc Vector3[4];
        codes[ 0 ] = _start;
        codes[ 1 ] = _end;
        codes[ 2 ] = 2f / 3f * _start + 1f / 3f * _end;
        codes[ 3 ] = 1f / 3f * _start + 2f / 3f * _end;

        // match each point to the closest code
        Span< byte > closest = stackalloc byte[16];
        var error = 0f;
        for( var i = 0; i < Colors.Count; ++i )
        {
            // find the closest code
            var dist = float.MaxValue;
            var idx = 0;
            for( var j = 0; j < 4; ++j )
            {
                var d = ( _metric * ( Colors.Points[ i ] - codes[ j ] ) ).LengthSquared();
                if( d < dist )
                {
                    dist = d;
                    idx = j;
                }
            }

            // save the index
            closest[ i ] = (byte) idx;

            // accumulate the error
            error += dist;
        }

        // save this scheme if it wins
        if( error < _besterror )
        {
            // remap the indices
            Span< byte > indices = stackalloc byte[16];
            Colors.RemapIndices( closest, indices );

            // save the block
            ColorBlock.WriteColorBlock4( _start, _end, indices, block );

            // save the error
            _besterror = error;
        }
    }
}