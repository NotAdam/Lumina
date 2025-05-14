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
        Assert.Equal( "Test<-><italic(1)>Test<--><italic(0)>Test",
            ReadOnlySeString.Format( $"{_test}{_shy}{_ita1}{_test}{_hy}{_ita0}{_test}" ).ToMacroString() );
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
        Assert.Equal( "Test\u00adTest-Test", ss.ToString( "y" ) );
        Assert.Equal( "Test<-><italic(1)>Test<--><italic(0)>Test", ss.ToString( "m" ) );
    }
}