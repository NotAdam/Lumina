using System;
using System.Numerics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal class ClusterFit : ColorFit
{
    private const int MaxIterations = 8;

    private static readonly Vector4 Two = new( 2f );
    private static readonly Vector4 OneThirdOneThird2 = new( 1f / 3f, 1f / 3f, 1f / 3f, 1f / 9f );
    private static readonly Vector4 TwoThirdsTwoThirds2 = new( 2f / 3f, 2f / 3f, 2f / 3f, 4f / 9f );
    private static readonly Vector4 TwoNineths = new( 2f / 9f );
    private static readonly Vector4 HalfHalf2 = new( 0.5f, 0.5f, 0.5f, 0.25f );
    private static readonly Vector4 Half = new( 0.5f );
    private static readonly Vector4 Grid = new( 31f, 63f, 31f, 0f );
    private static readonly Vector4 GridRcp = new( 1f / 31f, 1f / 63f, 1f / 31f, 0f );

    private readonly int _iterationCount;
    private readonly byte[] _order = new byte[16 * MaxIterations];
    private readonly Vector4[] _pointsWeights = new Vector4[16];
    private readonly Vector4 _metric;
    private Vector3 _principle;
    private Vector4 _xsumWsum;
    private Vector4 _besterror;

    public ClusterFit( ColorSet colors, SquishOptions2 options ) : base( colors, options )
    {
        _iterationCount = options.Fit == SquishFit.ColorIterativeClusterFit ? MaxIterations : 1;
        _metric = new( options.Weights, 1 );
    }

    protected override void Reset()
    {
        // Initialise the best error.
        _besterror = new( float.MaxValue );

        // get the covariance matrix
        var covariance = Sym3x3.ComputeWeightedCovariance( Colors.Count, Colors.Points, Colors.Weights );

        // compute the principle component
        _principle = Sym3x3.ComputePrincipleComponent( covariance );
    }

    private bool ConstructOrdering( in Vector3 axis, int iteration )
    {
        // build the list of dot products
        Span< float > dps = stackalloc float[16];
        var order = _order.AsSpan( 16 * iteration );
        for( var i = 0; i < Colors.Count; ++i )
        {
            dps[ i ] = Vector3.Dot( Colors.Points[ i ], axis );
            order[ i ] = (byte) i;
        }

        // stable sort using them
        for( var i = 0; i < Colors.Count; ++i )
        {
            for( var j = i; j > 0 && dps[ j ] < dps[ j - 1 ]; --j )
            {
                ( dps[ j ], dps[ j - 1 ] ) = ( dps[ j - 1 ], dps[ j ] );
                ( order[ j ], order[ j - 1 ] ) = ( order[ j - 1 ], order[ j ] );
            }
        }

        // check this ordering is unique
        for( var it = 0; it < iteration; ++it )
        {
            var prev = _order.AsSpan( 16 * it );
            var same = true;
            for( var i = 0; i < Colors.Count; ++i )
            {
                if( order[ i ] != prev[ i ] )
                {
                    same = false;
                    break;
                }
            }

            if( same )
                return false;
        }

        // copy the ordering and weight all the points
        _xsumWsum = new();
        for( var i = 0; i < Colors.Count; ++i )
        {
            var j = order[ i ];
            var p = new Vector4( Colors.Points[ j ], 1f );
            var w = Colors.Weights[ j ];
            var x = p * w;
            _pointsWeights[ i ] = x;
            _xsumWsum += x;
        }

        return true;
    }

    protected override void Compress3( Span< byte > block )
    {
        // prepare an ordering using the principle axis
        ConstructOrdering( _principle, 0 );

        // check all possible clusters and iterate on the total order
        var beststart = Vector4.Zero;
        var bestend = Vector4.Zero;
        var besterror = _besterror;
        Span< byte > bestindices = stackalloc byte[16];
        var bestiteration = 0;
        var besti = 0;
        var bestj = 0;

        // loop over iterations (we avoid the case that all points in first or last cluster)
        for( var iterationIndex = 0;; )
        {
            // first cluster [0,i) is at the start
            var part0 = Vector4.Zero;
            for( var i = 0; i < Colors.Count; ++i )
            {
                // second cluster [i,j) is half along
                var part1 = i == 0 ? _pointsWeights[ 0 ] : Vector4.Zero;
                var jmin = i == 0 ? 1 : i;
                for( var j = jmin;; )
                {
                    // last cluster [j,Colors.Count) is at the end
                    var part2 = _xsumWsum - part1 - part0;

                    // compute least squares terms directly
                    var alphaxSum = part1 * HalfHalf2 + part0;
                    var alpha2Sum = new Vector4( alphaxSum.W );

                    var betaxSum = part1 * HalfHalf2 + part2;
                    var beta2Sum = new Vector4( betaxSum.W );

                    var alphabetaSum = new Vector4( ( part1 * HalfHalf2 ).W );

                    // compute the least-squares optimal points
                    var factor = Vector4.One / ( alpha2Sum * beta2Sum - alphabetaSum * alphabetaSum );
                    var a = ( alphaxSum * beta2Sum - betaxSum * alphabetaSum ) * factor;
                    var b = ( betaxSum * alpha2Sum - alphaxSum * alphabetaSum ) * factor;

                    // clamp to the grid
                    a = ( Grid * a.ClampElements( Vector4.Zero, Vector4.One ) + Half ).TruncateElements() * GridRcp;
                    b = ( Grid * b.ClampElements( Vector4.Zero, Vector4.One ) + Half ).TruncateElements() * GridRcp;

                    // compute the error (we skip the constant xxsum)
                    var e1 = a * a * alpha2Sum + b * b * beta2Sum;
                    var e2 = a * b * alphabetaSum - a * alphaxSum;
                    var e3 = e2 - b * betaxSum;
                    var e4 = Two * e3 + e1;

                    // apply the metric to the error term
                    var e5 = e4 * _metric;
                    var error = new Vector4( e5.X + e5.Y + e5.Z );

                    // keep the solution if it wins
                    if( error.AnyLessThan( besterror ) )
                    {
                        beststart = a;
                        bestend = b;
                        besti = i;
                        bestj = j;
                        besterror = error;
                        bestiteration = iterationIndex;
                    }

                    // advance
                    if( j == Colors.Count )
                        break;
                    part1 += _pointsWeights[ j ];
                    ++j;
                }

                // advance
                part0 += _pointsWeights[ i ];
            }

            // stop if we didn't improve in this iteration
            if( bestiteration != iterationIndex )
                break;

            // advance if possible
            ++iterationIndex;
            if( iterationIndex == _iterationCount )
                break;

            // stop if a new iteration is an ordering that has already been tried
            var axis = ( bestend - beststart ).DropW();
            if( !ConstructOrdering( axis, iterationIndex ) )
                break;
        }

        // save the block if necessary
        if( besterror.AnyLessThan( _besterror ) )
        {
            // remap the indices
            var order = _order.AsSpan( 16 * bestiteration );

            Span< byte > unordered = stackalloc byte[16];
            for( var m = 0; m < besti; ++m )
                unordered[ order[ m ] ] = 0;
            for( var m = besti; m < bestj; ++m )
                unordered[ order[ m ] ] = 2;
            for( var m = bestj; m < Colors.Count; ++m )
                unordered[ order[ m ] ] = 1;

            Colors.RemapIndices( unordered, bestindices );

            // save the block
            ColorBlock.WriteColorBlock3( beststart.DropW(), bestend.DropW(), bestindices, block );

            // save the error
            _besterror = besterror;
        }
    }

    protected override void Compress4( Span< byte > block )
    {
        // prepare an ordering using the principle axis
        ConstructOrdering( _principle, 0 );

        // check all possible clusters and iterate on the total order
        var beststart = Vector4.Zero;
        var bestend = Vector4.Zero;
        var besterror = _besterror;
        Span< byte > bestindices = stackalloc byte[16];
        var bestiteration = 0;
        var besti = 0;
        var bestj = 0;
        var bestk = 0;

        // loop over iterations (we avoid the case that all points in first or last cluster)
        for( var iterationIndex = 0;; )
        {
            // first cluster [0,i) is at the start
            var part0 = Vector4.Zero;
            for( var i = 0; i < Colors.Count; ++i )
            {
                // second cluster [i,j) is one third along
                var part1 = Vector4.Zero;
                for( var j = i;; )
                {
                    // third cluster [j,k) is two thirds along
                    var part2 = j == 0 ? _pointsWeights[ 0 ] : Vector4.Zero;
                    var kmin = j == 0 ? 1 : j;
                    for( var k = kmin;; )
                    {
                        // last cluster [k,Colors.Count) is at the end
                        var part3 = _xsumWsum - part2 - part1 - part0;

                        // compute least squares terms directly
                        var alphaxSum = part2 * OneThirdOneThird2 + part1 * TwoThirdsTwoThirds2 + part0;
                        var alpha2Sum = new Vector4( alphaxSum.W );

                        var betaxSum = part1 * OneThirdOneThird2 + part2 * TwoThirdsTwoThirds2 + part3;
                        var beta2Sum = new Vector4( betaxSum.W );

                        var alphabetaSum = TwoNineths * new Vector4( part1.W + part2.W );

                        // compute the least-squares optimal points
                        var factor = Vector4.One / ( alpha2Sum * beta2Sum - alphabetaSum * alphabetaSum );
                        var a = ( alphaxSum * beta2Sum - betaxSum * alphabetaSum ) * factor;
                        var b = ( betaxSum * alpha2Sum - alphaxSum * alphabetaSum ) * factor;

                        // clamp to the grid
                        a = ( Grid * a.ClampElements( Vector4.Zero, Vector4.One ) + Half ).TruncateElements() * GridRcp;
                        b = ( Grid * b.ClampElements( Vector4.Zero, Vector4.One ) + Half ).TruncateElements() * GridRcp;

                        // compute the error (we skip the constant xxsum)
                        var e1 = ( a * a * alpha2Sum + b * b * beta2Sum );
                        var e2 = a * b * alphabetaSum - a * alphaxSum;
                        var e3 = e2 - b * betaxSum;
                        var e4 = ( Two * e3 + e1 );

                        // apply the metric to the error term
                        var e5 = e4 * _metric;
                        var error = new Vector4( e5.X + e5.Y + e5.Z );

                        // keep the solution if it wins
                        if( error.AnyLessThan( besterror ) )
                        {
                            beststart = a;
                            bestend = b;
                            besterror = error;
                            besti = i;
                            bestj = j;
                            bestk = k;
                            bestiteration = iterationIndex;
                        }

                        // advance
                        if( k == Colors.Count )
                            break;
                        part2 += _pointsWeights[ k ];
                        ++k;
                    }

                    // advance
                    if( j == Colors.Count )
                        break;
                    part1 += _pointsWeights[ j ];
                    ++j;
                }

                // advance
                part0 += _pointsWeights[ i ];
            }

            // stop if we didn't improve in this iteration
            if( bestiteration != iterationIndex )
                break;

            // advance if possible
            ++iterationIndex;
            if( iterationIndex == _iterationCount )
                break;

            // stop if a new iteration is an ordering that has already been tried
            var axis = ( bestend - beststart ).DropW();
            if( !ConstructOrdering( axis, iterationIndex ) )
                break;
        }

        // save the block if necessary
        if( besterror.AnyLessThan( _besterror ) )
        {
            // remap the indices
            var order = _order.AsSpan( 16 * bestiteration );

            Span< byte > unordered = stackalloc byte[16];
            for( var m = 0; m < besti; ++m )
                unordered[ order[ m ] ] = 0;
            for( var m = besti; m < bestj; ++m )
                unordered[ order[ m ] ] = 2;
            for( var m = bestj; m < bestk; ++m )
                unordered[ order[ m ] ] = 3;
            for( var m = bestk; m < Colors.Count; ++m )
                unordered[ order[ m ] ] = 1;

            Colors.RemapIndices( unordered, bestindices );

            // save the block
            ColorBlock.WriteColorBlock4( beststart.DropW(), bestend.DropW(), bestindices, block );

            // save the error
            _besterror = besterror;
        }
    }
}