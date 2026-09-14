using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Misc;
using Xunit;

namespace Lumina.Tests;

public class HashLookupTests
{
    [Fact]
    public void EveryKeyResolvesToItsOwnValue()
    {
        var random = new Random( 1234 );
        var expected = new Dictionary< uint, int >();
        while( expected.Count < 50_000 )
            expected[ (uint)random.Next( int.MinValue, int.MaxValue ) ] = expected.Count;

        var lookup = new HashLookup< int >( expected.Keys.ToArray(), expected.Values.ToArray() );

        Assert.Equal( expected.Count, lookup.Count );
        foreach( var (key, value) in expected )
        {
            Assert.True( lookup.TryGetValue( key, out var actual ) );
            Assert.Equal( value, actual );
        }
    }

    [Fact]
    public void AbsentKeysAreNotFound()
    {
        var present = Enumerable.Range( 1, 1000 ).Select( i => (uint)( i * 2 ) ).ToArray();
        var lookup = new HashLookup< int >( present, present.Select( p => (int)p ).ToArray() );

        foreach( var odd in Enumerable.Range( 1, 1000 ).Select( i => (uint)( i * 2 - 1 ) ) )
            Assert.False( lookup.TryGetValue( odd, out _ ) );
    }

    [Fact]
    public void ZeroIsAValidKey()
    {
        var keys = new List< uint > { 0u };
        for( var i = 1u; keys.Count < 200; i++ )
            keys.Add( i );

        var lookup = new HashLookup< int >( keys.ToArray(), keys.Select( k => (int)k + 10 ).ToArray() );

        foreach( var key in keys )
        {
            Assert.True( lookup.TryGetValue( key, out var value ) );
            Assert.Equal( (int)key + 10, value );
        }

        Assert.False( lookup.TryGetValue( 9999u, out _ ) );
    }

    [Fact]
    public void EmptyLookupFindsNothing()
    {
        var lookup = new HashLookup< int >( [], [] );

        Assert.Equal( 0, lookup.Count );
        Assert.False( lookup.TryGetValue( 0u, out _ ) );
        Assert.False( lookup.TryGetValue( 12345u, out _ ) );
    }

    [Fact]
    public void DuplicateKeysKeepTheFirstValue()
    {
        var lookup = new HashLookup< int >( [7u, 7u], [1, 2] );

        Assert.Equal( 1, lookup.Count );
        Assert.True( lookup.TryGetValue( 7u, out var value ) );
        Assert.Equal( 1, value );
    }
}
