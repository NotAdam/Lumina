using System;
using System.Collections.Generic;
using System.Text;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;
using Lumina.Text;
using Lumina.Text.Expressions;
using Lumina.Text.Parse;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;
using Xunit;
using Xunit.Abstractions;

namespace Lumina.Tests;

public class SeStringBuilderTests
{
    private readonly ITestOutputHelper _outputHelper;

    public SeStringBuilderTests( ITestOutputHelper outputHelper )
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void InvalidCharacterTest()
    {
        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( "NUL: \0" ) );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( "STX: \x02" ) );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( "NUL: \0"u8 ) );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( "STX: \x02"u8 ) );

        var nulsb = new StringBuilder()
            .Append( "NUL: " )
            .Append( '\0' );
        var stxsb = new StringBuilder()
            .Append( "STX: " )
            .Append( '\x02' );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( nulsb ) );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( stxsb ) );

        Assert.True(
            new SeStringBuilder()
                .Append( nulsb, 0, 4 )
                .ToArray()
                .AsSpan()
                .SequenceEqual( "NUL:"u8 ) );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( nulsb, 5, 1 ) );

        new SeStringBuilder()
            .Append( stxsb, 0, 4 );

        Assert.Throws< ArgumentException >(
            () =>
                new SeStringBuilder()
                    .Append( stxsb, 5, 1 ) );
    }

    [Fact]
    public void PayloadStateTest()
    {
        new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .EndMacro()
            .ToReadOnlySeString();

        new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .BeginStringExpression()
            .BeginMacro( MacroCode.Italic )
            .EndMacro()
            .EndExpression()
            .EndMacro()
            .ToReadOnlySeString();

        Assert.Throws< ArgumentOutOfRangeException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( 0 ) );

        Assert.Throws< InvalidOperationException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( MacroCode.Bold )
                    .ToReadOnlySeString() );

        Assert.Throws< InvalidOperationException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( MacroCode.Bold )
                    .BeginMacro( MacroCode.Bold ) );

        Assert.Throws< InvalidOperationException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( MacroCode.Bold )
                    .EndMacro()
                    .EndMacro() );
    }

    [Fact]
    public void ExpressionStateTest()
    {
        new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .AppendUIntExpression( 0 )
            .BeginUnaryExpression( ExpressionType.LocalNumber )
            .AppendUIntExpression( 0 )
            .EndExpression()
            .BeginBinaryExpression( ExpressionType.GreaterThan )
            .AppendUIntExpression( 0 )
            .AppendUIntExpression( 1 )
            .EndExpression()
            .BeginBinaryExpression( ExpressionType.GreaterThan )
            .BeginUnaryExpression( ExpressionType.LocalNumber )
            .AppendUIntExpression( 0 )
            .EndExpression()
            .AppendNullaryExpression( ExpressionType.Day )
            .EndExpression()
            .EndMacro();

        Assert.Throws< ArgumentOutOfRangeException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( MacroCode.Bold )
                    .AppendNullaryExpression( 0 ) );

        Assert.Throws< ArgumentOutOfRangeException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( MacroCode.Bold )
                    .BeginUnaryExpression( 0 ) );

        Assert.Throws< ArgumentOutOfRangeException >(
            () =>
                new SeStringBuilder()
                    .BeginMacro( MacroCode.Bold )
                    .BeginBinaryExpression( 0 ) );

        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginUnaryExpression( ExpressionType.GlobalString )
                .AppendUIntExpression( 0 ) );

        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginBinaryExpression( ExpressionType.NotEqual )
                .AppendUIntExpression( 0 ) );

        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginMacro( MacroCode.Bold )
                .BeginBinaryExpression( ExpressionType.LessThan )
                .AppendUIntExpression( 0 )
                .AppendUIntExpression( 0 )
                .AppendUIntExpression( 0 ) );

        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginMacro( MacroCode.Bold )
                .EndExpression() );
    }

    [Fact]
    public void ExpressionArityTestUnaryInsufficient() =>
        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginMacro( MacroCode.Bold )
                .BeginUnaryExpression( ExpressionType.LocalNumber )
                .EndExpression()
                .ToReadOnlySeString() );

    [Fact]
    public void ExpressionArityTestUnaryCorrect() =>
        new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .BeginUnaryExpression( ExpressionType.LocalNumber )
            .AppendIntExpression( 0 )
            .EndExpression()
            .EndMacro()
            .ToReadOnlySeString();

    [Fact]
    public void ExpressionArityTestUnaryOverfed() =>
        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginMacro( MacroCode.Bold )
                .BeginUnaryExpression( ExpressionType.LocalNumber )
                .AppendIntExpression( 0 )
                .AppendIntExpression( 1 )
                .EndExpression()
                .EndMacro()
                .ToReadOnlySeString() );

    [Fact]
    public void ExpressionArityTestBinaryInsufficient()
    {
        Assert.Throws< InvalidOperationException >( () => new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .BeginBinaryExpression( ExpressionType.Equal )
            .EndExpression()
            .EndMacro()
            .ToReadOnlySeString() );
        Assert.Throws< InvalidOperationException >( () => new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .BeginBinaryExpression( ExpressionType.Equal )
            .AppendIntExpression( 0 )
            .EndExpression()
            .EndMacro()
            .ToReadOnlySeString() );
    }

    [Fact]
    public void ExpressionArityTestBinaryCorrect() =>
        new SeStringBuilder()
            .BeginMacro( MacroCode.Bold )
            .BeginBinaryExpression( ExpressionType.Equal )
            .AppendIntExpression( 0 )
            .AppendIntExpression( 1 )
            .EndExpression()
            .EndMacro()
            .ToReadOnlySeString();

    [Fact]
    public void ExpressionArityTestBinaryOverfed() =>
        Assert.Throws< InvalidOperationException >(
            () => new SeStringBuilder()
                .BeginMacro( MacroCode.Bold )
                .BeginBinaryExpression( ExpressionType.Equal )
                .AppendIntExpression( 0 )
                .AppendIntExpression( 1 )
                .AppendIntExpression( 2 )
                .EndExpression()
                .EndMacro()
                .ToReadOnlySeString() );

    [Fact]
    public void ComplicatedTest()
    {
        var test =
            ""
            + ReadOnlySePayloadSpan.FromText( "Testing" )
            + "_"
            + new SeStringBuilder()
                .Append( "asdf: " )
                .Append( 12345 )
                .BeginMacro( MacroCode.If )
                .BeginBinaryExpression( ExpressionType.Equal )
                .AppendIntExpression( 0x55 )
                .AppendNullaryExpression( ExpressionType.Day )
                .EndExpression()
                .BeginStringExpression()
                .AppendItalicized( "TRUE" )
                .EndExpression()
                .BeginStringExpression()
                .AppendBold( "false"u8 )
                .EndExpression()
                .EndMacro()
                .Append( " "u8 )
                .PushColorType( 510 )
                .PushEdgeColorType( 510 )
                .Append( "Colored text" )
                .PopColorType()
                .PopEdgeColorType()
                .ToReadOnlySeString();
        _outputHelper.WriteLine( test.ToString() );
    }

    [RequiresGameInstallationFact]
    public void AddonIsParsedCorrectly()
    {
        var gameData = new GameData( @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\game\sqpack" );
        var addon = gameData.Excel.GetSheetRaw( "Addon" )!;
        var ssb = new SeStringBuilder();
        var expected = new Dictionary< uint, ReadOnlySeString >
        {
            [ 6 ] = ssb
                .Clear()
                .BeginMacro( MacroCode.Switch )
                .AppendLocalNumberExpression( 1 )
                .BeginStringExpression().PushColorType( 549 ).PushEdgeColorType( 550 ).EndExpression()
                .BeginStringExpression().PushColorType( 551 ).PushEdgeColorType( 552 ).EndExpression()
                .BeginStringExpression().PushColorType( 553 ).PushEdgeColorType( 554 ).EndExpression()
                .BeginStringExpression().PushColorType( 555 ).PushEdgeColorType( 556 ).EndExpression()
                .BeginStringExpression().PushColorType( 557 ).PushEdgeColorType( 558 ).EndExpression()
                .BeginStringExpression().PushColorType( 559 ).PushEdgeColorType( 560 ).EndExpression()
                .BeginStringExpression().PushColorType( 561 ).PushEdgeColorType( 562 ).EndExpression()
                .BeginStringExpression().PushColorType( 563 ).PushEdgeColorType( 564 ).EndExpression()
                .EndMacro()
                .ToReadOnlySeString(),
            [ 15 ] = ssb
                .Clear()
                .BeginMacro( MacroCode.If )
                .BeginBinaryExpression( ExpressionType.Equal )
                .AppendGlobalNumberExpression( 78 )
                .AppendIntExpression( 99 )
                .EndExpression()
                .AppendStringExpression( "Online ID" )
                .AppendStringExpression( "Gamertag" )
                .EndMacro()
                .Append( ": "u8 )
                .BeginMacro( MacroCode.String )
                .AppendLocalStringExpression( 1 )
                .EndMacro()
                .ToReadOnlySeString(),
            [ 28 ] = ssb
                .Clear()
                .BeginMacro( MacroCode.SetTime )
                .AppendLocalNumberExpression( 1 )
                .EndMacro()
                .BeginMacro( MacroCode.If )
                .AppendNullaryExpression( ExpressionType.Hour )
                .BeginStringExpression()
                .BeginMacro( MacroCode.Switch )
                .AppendNullaryExpression( ExpressionType.Hour )
                .AppendIntExpression( 1 )
                .AppendIntExpression( 2 )
                .AppendIntExpression( 3 )
                .AppendIntExpression( 4 )
                .AppendIntExpression( 5 )
                .AppendIntExpression( 6 )
                .AppendIntExpression( 7 )
                .AppendIntExpression( 8 )
                .AppendIntExpression( 9 )
                .AppendIntExpression( 10 )
                .AppendIntExpression( 11 )
                .AppendIntExpression( 12 )
                .AppendIntExpression( 1 )
                .AppendIntExpression( 2 )
                .AppendIntExpression( 3 )
                .AppendIntExpression( 4 )
                .AppendIntExpression( 5 )
                .AppendIntExpression( 6 )
                .AppendIntExpression( 7 )
                .AppendIntExpression( 8 )
                .AppendIntExpression( 9 )
                .AppendIntExpression( 10 )
                .AppendIntExpression( 11 )
                .EndMacro()
                .EndExpression()
                .AppendIntExpression( 12 )
                .EndMacro()
                .Append( ":" )
                .BeginMacro( MacroCode.Sec )
                .AppendNullaryExpression( ExpressionType.Minute )
                .EndMacro()
                .Append( " " )
                .BeginMacro( MacroCode.If )
                .BeginBinaryExpression( ExpressionType.GreaterThanOrEqualTo )
                .AppendNullaryExpression( ExpressionType.Hour )
                .AppendIntExpression( 12 )
                .EndExpression()
                .AppendStringExpression( "p.m." )
                .AppendStringExpression( "a.m." )
                .EndMacro()
                .ToReadOnlySeString(),
            [ 110 ] = ssb
                .Clear()
                .PushColorType( 508 )
                .PushEdgeColorType( 509 )
                .Append( "Discard "u8 )
                .BeginMacro( MacroCode.If )
                .BeginBinaryExpression( ExpressionType.Equal )
                .AppendLocalNumberExpression( 2 )
                .AppendIntExpression( 1 )
                .EndExpression()
                .BeginStringExpression()
                .BeginMacro( MacroCode.EnNoun )
                .AppendStringExpression( "Item" )
                .AppendIntExpression( 2 )
                .AppendLocalNumberExpression( 1 )
                .AppendIntExpression( 1 )
                .AppendIntExpression( 1 )
                .EndMacro()
                .EndExpression()
                .BeginStringExpression()
                .BeginMacro( MacroCode.Num )
                .AppendLocalNumberExpression( 2 )
                .EndMacro()
                .Append( " " )
                .BeginMacro( MacroCode.EnNoun )
                .AppendStringExpression( "Item" )
                .AppendIntExpression( 3 )
                .AppendLocalNumberExpression( 1 )
                .AppendLocalNumberExpression( 2 )
                .AppendIntExpression( 1 )
                .EndMacro()
                .EndExpression()
                .EndMacro()
                .Append( "?" )
                .PopEdgeColorType()
                .PopColorType()
                .ToReadOnlySeString(),
        };
        foreach( var row in addon )
        {
            var r = row.ReadColumn< SeString >( 0 ).AsReadOnly();
            _outputHelper.WriteLine( $"{row.RowId}\t{r.ExtractText()}\t{r}" );
            if( expected.TryGetValue( row.RowId, out var expectedSeString ) )
                Assert.StrictEqual( expectedSeString, r );
        }
    }

    [Fact]
    public unsafe void InterpolationHandlerTest1()
    {
        const string test = "asdf";
        Assert.Equal(
            "Left:1234    \nRight:    1234\nasdf\nint*: 0x0000000012345678",
            new SeStringBuilder()
                .Append( $"Left:{0x1234,-8:X}\nRight:{0x1234,8:X}\n{test}\nint*: 0x{(void*) 0x12345678:X16}" )
                .ToReadOnlySeString()
                .ToString() );
    }

    [Fact]
    public void InterpolationHandlerTest2()
    {
        var boldHello = new SeStringBuilder().AppendBold( "Hello" ).ToReadOnlySeString();
        Assert.Equal(
            "|Left    |\n|   Right|\n<bold(1)>Hello<bold(0)>\nnull",
            new SeStringBuilder()
                .Append( $"|{"Left",-8}|\n|{"Right"u8,8}|\n{boldHello}\n{(object) null}" )
                .ToReadOnlySeString()
                .ToString() );
    }

    [Fact]
    public void InterpolationHandlerTest3() =>
        Assert.Equal(
            "<italic(1)>test<italic(0)>",
            new SeStringBuilder()
                .Append( $"{"<italic(1)>test<italic(0)>":m}" )
                .ToReadOnlySeString()
                .ToString() );

    [Fact]
    public void ThrowsOnInvalidMacroStrings1() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "<bad_payload>"u8 ) );

    [Fact]
    public void ThrowsOnInvalidMacroStrings2() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "<if([a=b])>"u8 ) );

    [Fact]
    public void ThrowsOnInvalidMacroStrings3() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "<if(1,2,3>"u8 ) );

    [Fact]
    public void ThrowsOnInvalidMacroStrings4() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "<if,2,3>"u8 ) );

    [Fact]
    public void ThrowsOnInvalidMacroStrings5() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "<if(1,2,3)"u8 ) );

    [Fact]
    public void ThrowsOnInvalidMacroStrings6() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "<if(1,2,3"u8 ) );

    [Fact]
    public void ThrowsOnInvalidMacroStrings7() =>
        Assert.Throws< MacroStringParseException >( () => new SeStringBuilder().AppendMacroString( "< asdf >"u8 ) );

    [Fact]
    public void PooledObjectsStateTest()
    {
        for( var i = 0; i < 64; i++ )
        {
            Assert.Equal(
                $"{i}<string({i})>{i}<string(<string({i})>)>{i}",
                ReadOnlySeString.FromMacroString( $"{i}<string({i})>{i}<string(<string({i})>)>{i}" ).ToString() );
        }
    }
    
    [RequiresGameInstallationFact]
    public void AllSheetsTextColumnCodec()
    {
        var gameData = new GameData( @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\game\sqpack" );
        var ssb = new SeStringBuilder();
        foreach( var sheetName in gameData.Excel.GetSheetNames() )
        {
            var languages = gameData.GetFile< ExcelHeaderFile >( ExcelModule.BuildExcelHeaderPath( sheetName ) )?.Languages ?? [Language.None];
            foreach( var language in languages )
            {
                if( gameData.Excel.GetSheetRaw( sheetName, language ) is not { } sheet )
                    continue;

                // CustomTalkDefineClient: it currently fails at reading string columns in sheets of subrow variant. 
                if( sheet.Variant != ExcelVariant.Default )
                    continue;

                foreach( var row in sheet )
                {
                    for( var i = 0; i < sheet.Columns.Length; i++ )
                    {
                        if( sheet.Columns[ i ].Type != ExcelColumnDataType.String )
                            continue;

                        var test1 = row.ReadColumn< SeString >( i ).AsReadOnly();
                        if( test1.Data.Span.IndexOf( "payload:"u8 ) != -1 )
                            throw new( $"Unsupported payload at {sheetName}#{row.RowId}; {test1}" );

                        ReadOnlySeString test2;
                        try
                        {
                            test2 = ssb.Clear().AppendMacroString( test1.ToString() ).ToReadOnlySeString();
                        }
                        catch( Exception e )
                        {
                            throw new( $"Error at {sheetName}#{row.RowId}({language})", e );
                        }

                        Assert.True( test1.AsSpan().Data.SequenceEqual( test2.AsSpan().Data ), $"Parse-encode failure at {sheetName}#{row.RowId}({language})" );
                    }
                }
            }
        }
    }
}