using System;
using System.Collections.Generic;
using System.Text;
using Lumina.Excel;
using Lumina.Text;
using Lumina.Text.Expressions;
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

    [Sheet( "Addon" )]
    public readonly struct Addon( ExcelPage page, uint offset, uint row ) : IExcelRow<Addon>
    {
        public uint RowId => row;

        public readonly ReadOnlySeString Text => page.ReadString( offset, offset );

        static Addon IExcelRow<Addon>.Create( ExcelPage page, uint offset, uint row ) =>
            new( page, offset, row );

        static Addon IExcelRow<Addon>.Create( ExcelPage page, uint offset, uint row, ushort subrow ) =>
            throw new NotSupportedException();
    }

    [RequiresGameInstallationFact]
    public void AddonIsParsedCorrectly()
    {
        var gameData = new GameData( @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\game\sqpack" );
        var addon = gameData.Excel.GetSheet<Addon>( )!;
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
                .Append("Discard "u8)
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
                .Append(" "  )
                .BeginMacro( MacroCode.EnNoun )
                .AppendStringExpression( "Item" )
                .AppendIntExpression( 3 )
                .AppendLocalNumberExpression( 1 )
                .AppendLocalNumberExpression( 2 )
                .AppendIntExpression( 1 )
                .EndMacro()
                .EndExpression()
                .EndMacro()
                .Append("?"  )
                .PopEdgeColorType()
                .PopColorType()
                .ToReadOnlySeString(),
        };
        foreach( var row in addon )
        {
            _outputHelper.WriteLine( $"{row.RowId}\t{row.Text.ExtractText()}\t{row.Text}" );
            if( expected.TryGetValue( row.RowId, out var expectedSeString ) )
                Assert.True( expectedSeString == row.Text, $"{row.RowId} does not match; expected {expectedSeString}" );
        }
    }
}