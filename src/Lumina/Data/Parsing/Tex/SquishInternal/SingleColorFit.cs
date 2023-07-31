using System;
using System.Numerics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal partial class SingleColorFit : ColorFit
{
    private Vector4< byte > _color; // XYZ for color; W for index 
    private Vector3 _start;
    private Vector3 _end;
    private int _besterror;

    public SingleColorFit( ColorSet colors, SquishOptions2 options ) : base( colors, options )
    { }

    protected override void Reset()
    {
        _color.X = (byte) SquishMathExtensions.FloatToInt( 255f * Colors.Points[ 0 ].X, 255 );
        _color.Y = (byte) SquishMathExtensions.FloatToInt( 255f * Colors.Points[ 0 ].Y, 255 );
        _color.Z = (byte) SquishMathExtensions.FloatToInt( 255f * Colors.Points[ 0 ].Z, 255 );
        _besterror = int.MaxValue;
    }

    protected override void Compress3( Span< byte > block )
    {
        // find the best end-points and index
        ComputeEndPoints( 3, lookups_3, out var error );

        // build the block if we win
        if( error < _besterror )
        {
            // remap the indices
            Span< byte > indices = stackalloc byte[16];
            Colors.RemapIndices( _color.W, indices );

            // save the block
            ColorBlock.WriteColorBlock3( _start, _end, indices, block );

            // save the error
            _besterror = error;
        }
    }

    protected override void Compress4( Span< byte > block )
    {
        // find the best end-points and index
        ComputeEndPoints( 4, lookups_4, out var error );

        // build the block if we win
        if( error < _besterror )
        {
            // remap the indices
            Span< byte > indices = stackalloc byte[16];
            Colors.RemapIndices( _color.W, indices );

            // save the block
            ColorBlock.WriteColorBlock4( _start, _end, indices, block );

            // save the error
            _besterror = error;
        }
    }

    private void ComputeEndPoints( int count, SourceBlock[][,] lookups, out int error )
    {
        // check each index combination (endpoint or intermediate)
        error = int.MaxValue;
        Span< SourceBlock > sources = stackalloc SourceBlock[3];
        for( var index = 0; index < count; ++index )
        {
            // check the error for this codebook index
            var currentError = 0;
            for( var channel = 0; channel < 3; ++channel )
            {
                // grab the lookup table and index for this channel
                var lookup = lookups[ channel ];
                var target = _color[ channel ];

                // store a pointer to the source for this channel
                sources[ channel ] = lookup[ target, index ];

                // accumulate the error
                var diff = sources[ channel ].Error;
                currentError += diff * diff;
            }

            // keep it if the error is lower
            if( currentError < error )
            {
                _start = new(
                    sources[ 0 ].Start / 31f,
                    sources[ 1 ].Start / 63f,
                    sources[ 2 ].Start / 31f
                );
                _end = new(
                    sources[ 0 ].End / 31f,
                    sources[ 1 ].End / 63f,
                    sources[ 2 ].End / 31f
                );
                _color.W = (byte) index;
                error = currentError;
            }
        }
    }

    private readonly struct SourceBlock
    {
        public readonly byte Start;
        public readonly byte End;
        public readonly byte Error;

        public SourceBlock( byte s, byte en, byte er )
        {
            Start = s;
            End = en;
            Error = er;
        }
    }
}