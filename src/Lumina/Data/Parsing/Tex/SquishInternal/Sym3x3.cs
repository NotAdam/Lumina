using System;
using System.Numerics;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

// ReSharper disable once InconsistentNaming
internal unsafe struct Sym3x3
{
#pragma warning disable CS0649
    private fixed float _values[6];
#pragma warning restore CS0649

    public float this[ int index ] {
        get => _values[ index ];
        set => _values[ index ] = value;
    }

    public Sym3x3() : this( 0f )
    { }

    public Sym3x3( float s )
    {
        for( var i = 0; i < 6; ++i )
            _values[ i ] = s;
    }

    public static Sym3x3 ComputeWeightedCovariance( int n, Vector3[] points, float[] weights )
    {
        // Compute the centroid.
        var total = 0f;
        var centroid = new Vector3( 0f );
        for( var i = 0; i < n; ++i )
        {
            total += weights[ i ];
            centroid += weights[ i ] * points[ i ];
        }

        centroid /= total;

        // Accumulate the covariance matrix.
        var covariance = new Sym3x3( 0f );
        for( var i = 0; i < n; ++i )
        {
            var a = points[ i ] - centroid;
            var b = weights[ i ] * a;

            covariance[ 0 ] += a.X * b.X;
            covariance[ 1 ] += a.X * b.Y;
            covariance[ 2 ] += a.X * b.Z;
            covariance[ 3 ] += a.Y * b.Y;
            covariance[ 4 ] += a.Y * b.Z;
            covariance[ 5 ] += a.Z * b.Z;
        }

        return covariance;
    }

    private static Vector3 GetMultiplicity1Evector( in Sym3x3 matrix, float evalue )
    {
        // Compute M
        var m = new Sym3x3();
        m[ 0 ] = matrix[ 0 ] - evalue;
        m[ 1 ] = matrix[ 1 ];
        m[ 2 ] = matrix[ 2 ];
        m[ 3 ] = matrix[ 3 ] - evalue;
        m[ 4 ] = matrix[ 4 ];
        m[ 5 ] = matrix[ 5 ] - evalue;

        // Compute U
        var u = new Sym3x3();
        u[ 0 ] = m[ 3 ] * m[ 5 ] - m[ 4 ] * m[ 4 ];
        u[ 1 ] = m[ 2 ] * m[ 4 ] - m[ 1 ] * m[ 5 ];
        u[ 2 ] = m[ 1 ] * m[ 4 ] - m[ 2 ] * m[ 3 ];
        u[ 3 ] = m[ 0 ] * m[ 5 ] - m[ 2 ] * m[ 2 ];
        u[ 4 ] = m[ 1 ] * m[ 2 ] - m[ 4 ] * m[ 0 ];
        u[ 5 ] = m[ 0 ] * m[ 3 ] - m[ 1 ] * m[ 1 ];

        // Find the largest component.
        var mc = Math.Abs( u[ 0 ] );
        var mi = 0;
        for( var i = 1; i < 6; ++i )
        {
            var c = Math.Abs( u[ i ] );
            if( c > mc )
            {
                mc = c;
                mi = i;
            }
        }

        // Pick the column with this component.
        switch( mi )
        {
            case 0:
                return new( u[ 0 ], u[ 1 ], u[ 2 ] );
            case 1:
            case 3:
                return new( u[ 1 ], u[ 3 ], u[ 4 ] );
            default:
                return new( u[ 2 ], u[ 4 ], u[ 5 ] );
        }
    }

    private static Vector3 GetMultiplicity2Evector( in Sym3x3 matrix, float evalue )
    {
        // Compute M
        var m = new Sym3x3();
        m[ 0 ] = matrix[ 0 ] - evalue;
        m[ 1 ] = matrix[ 1 ];
        m[ 2 ] = matrix[ 2 ];
        m[ 3 ] = matrix[ 3 ] - evalue;
        m[ 4 ] = matrix[ 4 ];
        m[ 5 ] = matrix[ 5 ] - evalue;

        // Find the largest component.
        var mc = Math.Abs( m[ 0 ] );
        var mi = 0;
        for( var i = 1; i < 6; ++i )
        {
            var c = Math.Abs( m[ i ] );
            if( c > mc )
            {
                mc = c;
                mi = i;
            }
        }

        // pick the first eigenvector based on this index
        switch( mi )
        {
            case 0:
            case 1:
                return new( -m[ 1 ], m[ 0 ], 0f );

            case 2:
                return new( m[ 2 ], 0f, -m[ 0 ] );

            case 3:
            case 4:
                return new( 0f, -m[ 4 ], m[ 3 ] );

            default:
                return new( 0f, -m[ 5 ], m[ 4 ] );
        }
    }

    public static Vector3 ComputePrincipleComponent( in Sym3x3 matrix )
    {
        // Compute the cubic coefficients
        var c0 =
            matrix[ 0 ] * matrix[ 3 ] * matrix[ 5 ]
            + matrix[ 1 ] * matrix[ 2 ] * matrix[ 4 ] * 2f
            - matrix[ 0 ] * matrix[ 4 ] * matrix[ 4 ]
            - matrix[ 3 ] * matrix[ 2 ] * matrix[ 2 ]
            - matrix[ 5 ] * matrix[ 1 ] * matrix[ 1 ];
        var c1 =
            matrix[ 0 ] * matrix[ 3 ]
            + matrix[ 0 ] * matrix[ 5 ]
            + matrix[ 3 ] * matrix[ 5 ]
            - matrix[ 1 ] * matrix[ 1 ]
            - matrix[ 2 ] * matrix[ 2 ]
            - matrix[ 4 ] * matrix[ 4 ];
        var c2 = matrix[ 0 ] + matrix[ 3 ] + matrix[ 5 ];

        // Compute the quadratic coefficients
        var a = c1 - 1f / 3f * c2 * c2;
        var b = -2f / 27f * c2 * c2 * c2 + 1f / 3f * c1 * c2 - c0;

        // Compute the root count check;
        var q = .25f * b * b + 1f / 27f * a * a * a;

        // Test the multiplicity.
        if( float.Epsilon < q )
            return new( 1f ); // Only one root, which implies we have a multiple of the identity.
        else if( q < -float.Epsilon )
        {
            // Three distinct roots
            var theta = Math.Atan2( Math.Sqrt( q ), -.5f * b );
            var rho = Math.Sqrt( .25f * b * b - q );

            var rt = Math.Pow( rho, 1f / 3f );
            var ct = Math.Cos( theta / 3f );
            var st = Math.Sin( theta / 3f );

            var l1 = 1f / 3f * c2 + 2f * rt * ct;
            var l2 = 1f / 3f * c2 - rt * ( ct + Math.Sqrt( 3f ) * st );
            var l3 = 1f / 3f * c2 - rt * ( ct - Math.Sqrt( 3f ) * st );

            // Pick the larger.
            if( Math.Abs( l2 ) > Math.Abs( l1 ) )
                l1 = l2;
            if( Math.Abs( l3 ) > Math.Abs( l1 ) )
                l1 = l3;

            // Get the eigenvector
            return GetMultiplicity1Evector( matrix, (float) l1 );
        }
        else
        {
            // Q very close to 0
            // Two roots
            double rt;
            if( b < 0f )
                rt = -Math.Pow( -.5f * b, 1f / 3f );
            else
                rt = Math.Pow( .5f * b, 1f / 3f );

            var l1 = 1f / 3f * c2 + rt;
            var l2 = 1f / 3f * c2 - 2f * rt;

            // Get the eigenvector
            if( Math.Abs( l1 ) > Math.Abs( l2 ) )
                return GetMultiplicity2Evector( matrix, (float) l1 );
            else
                return GetMultiplicity1Evector( matrix, (float) l2 );
        }
    }
}