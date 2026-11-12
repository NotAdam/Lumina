using System;
using System.Runtime.InteropServices;
using Lumina.Text.ReadOnly;
using Xunit;
using Xunit.Abstractions;

namespace Lumina.Tests;

public class ReadOnlySeStringTests
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly ReadOnlySeString _test = ReadOnlySeString.FromMacroString( "Test" );
    private readonly ReadOnlySeString _ita0 = ReadOnlySeString.FromMacroString( "<italic(0)>" );
    private readonly ReadOnlySeString _ita1 = ReadOnlySeString.FromMacroString( "<italic(1)>" );
    private readonly ReadOnlySeString _shy = ReadOnlySeString.FromMacroString( "<->" );
    private readonly ReadOnlySeString _hy = ReadOnlySeString.FromMacroString( "<-->" );

    public ReadOnlySeStringTests( ITestOutputHelper outputHelper )
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void FormatTest()
    {
        var ss = ReadOnlySeString.Format( $"{_test}{_shy}{_ita1}{_test}{_hy}{_ita0}{_test}" );
        Assert.Equal( "Test<-><italic(1)>Test<--><italic(0)>Test", ss.ToMacroString() );
        Assert.Equal( ss, ReadOnlySeString.Format( $"{ss}" ) );
        Assert.Equal( ss, ReadOnlySeString.Format( $"{ss:r}" ) );
        Assert.True( "TestTest-Test"u8.SequenceEqual( ReadOnlySeString.Format( $"{ss:t}" ) ) );
        Assert.True( "Test\u00adTest-Test"u8.SequenceEqual( ReadOnlySeString.Format( $"{ss:y}" ) ) );
        Assert.True( "Test<-><italic(1)>Test<--><italic(0)>Test"u8.SequenceEqual( ReadOnlySeString.Format( $"{ss:m}" ) ) );
    }

    [Fact]
    public void ExtractTextTest()
    {
        var ss = ReadOnlySeString.Format( $"{_test}{_shy}{_ita1}{_test}{_hy}{_ita0}{_test}" );
        Assert.Equal( "TestTest-Test", ss.ExtractText() );
        Assert.Equal( "Test\u00adTest-Test", ss.ExtractText( true ) );
        Assert.Equal( "Test**Test-*Test", ss.ExtractText( false, "*" ) );
    }

    [Fact]
    public void ToStringTest()
    {
        var ss = ReadOnlySeString.Format( $"{_test}{_shy}{_ita1}{_test}{_hy}{_ita0}{_test}" );
        Assert.Equal( "TestTest-Test", ss.ToString() );
        Assert.Equal( "TestTest-Test", ss.ToString( "t" ) );
        Assert.Equal( "Test\u00adTest-Test", ss.ToString( "y" ) );
        Assert.Equal( "Test<-><italic(1)>Test<--><italic(0)>Test", ss.ToString( "m" ) );
        Assert.Equal( "__TestTest-Test^^", $"__{ss}^^" );
        Assert.Equal( "__TestTest-Test^^", $"__{ss:t}^^" );
        Assert.Equal( "__Test\u00adTest-Test^^", $"__{ss:y}^^" );
        Assert.Equal( "__Test<-><italic(1)>Test<--><italic(0)>Test^^", $"__{ss:m}^^" );
    }

    [Fact]
    public unsafe void NullTerminationTest()
    {
        var bytes = "abc"u8.ToArray();
        var memory = new byte[] { (byte) 'x', (byte) 'y', (byte) 'z', (byte) 'w' }.AsMemory( 0, 3 );
        ReadOnlySeString[] cases =
        [
            new( "abc"u8 ),
            new( bytes ),
            new( memory ),
            new( "abc" ),
            ReadOnlySeString.FromMacroString( "<italic(1)>abc" ),
            _test + _ita1,
            _test + "abc",
            "abc" + _test,
            _test + _ita1.AsSpan(),
            _test.AsSpan() + _ita1.AsSpan(),
        ];

        foreach( var s in cases )
        {
            fixed( byte* p = s )
            {
                Assert.Equal( 0, p[ s.ByteLength ] );
            }

            fixed( byte* p = (ReadOnlySpan< byte >) s )
            {
                Assert.Equal( 0, p[ s.ByteLength ] );
            }
        }

        // Mutate backing memory shouldn't apply to string
        bytes[ 0 ] = (byte) 'X';
        Assert.True( "abc"u8.SequenceEqual( cases[ 1 ] ) );
        Assert.True( "xyz"u8.SequenceEqual( cases[ 2 ] ) );
    }

    [Fact]
    public void WrapTest()
    {
        var buffer = "xabc\0"u8.ToArray();
        foreach( var s in new[] { ReadOnlySeString.FromTerminatedBuffer( buffer, 1, 3 ), ReadOnlySeString.FromTerminatedBufferUnchecked( buffer, 1, 3 ) } )
        {
            Assert.True( "abc"u8.SequenceEqual( s ) );
            Assert.True( MemoryMarshal.TryGetArray( s.Data, out var segment ) && segment.Array == buffer );
        }

        Assert.Throws< ArgumentException >( () => ReadOnlySeString.FromTerminatedBuffer( buffer, 0, 3 ) );
        Assert.Throws< ArgumentException >( () => ReadOnlySeString.FromTerminatedBuffer( "abc"u8.ToArray(), 0, 3 ) );
        Assert.Throws< ArgumentOutOfRangeException >( () => ReadOnlySeString.FromTerminatedBuffer( buffer, 2, 9 ) );
    }

    [Fact]
    public void TextNulTest()
    {
        Assert.Throws< ArgumentException >( () => new ReadOnlySeString( "a\0b" ) );
        Assert.Throws< ArgumentException >( () => ReadOnlySeString.FromText( "a\0b" ) );
        Assert.Throws< ArgumentException >( () => ReadOnlySeString.FromText( "a\0b"u8 ) );

        // Raw bytes are accepted but validate fails
        var raw = new ReadOnlySeString( "a\0b"u8 );
        Assert.Equal( 3, raw.ByteLength );
        Assert.False( raw.Validate() );
    }

    [Fact]
    public unsafe void EmptyPinTest()
    {
        ReadOnlySeString[] cases = [ default, new( ""u8 ), new( "" ), new( Array.Empty< byte >() ) ];
        foreach( var s in cases )
        {
            fixed( byte* p = s )
            {
                Assert.True( p != null );
                Assert.Equal( 0, *p );
            }
        }
    }
}