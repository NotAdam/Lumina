using BenchmarkDotNet.Attributes;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Data;
using System.Runtime.CompilerServices;
using Lumina.Excel;

namespace Lumina.Benchmark;

[DisassemblyDiagnoser( maxDepth: 500, exportGithubMarkdown: false, exportHtml: true )]
public class Bench
{
    private GameData gameData;
    private ExcelSheet<Addon> addonSheet;
    private uint[] addonRows;
    private ExcelSheet<Item> itemSheet;
    private uint[] itemRows;
    private SubrowExcelSheet<QuestLinkMarker> subrowSheet;
    private uint[] subrowRows;

    [GlobalSetup]
    public void Setup()
    {
        gameData = new GameData( @"J:\Programs\Steam\steamapps\common\FINAL FANTASY XIV Online\game\sqpack", new()
        {
            PanicOnSheetChecksumMismatch = false,
        } );

        addonSheet = gameData.GetExcelSheet<Addon>()!;
        addonRows = addonSheet.Select( x => x.RowId ).ToArray();

        itemSheet = gameData.GetExcelSheet<Item>()!;
        itemRows = itemSheet.Select( x => x.RowId ).ToArray();

        subrowSheet = gameData.GetSubrowExcelSheet<QuestLinkMarker>()!;
        subrowRows = subrowSheet.Select( x => x.RowId ).ToArray();
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public void TestAllSheets()
    {
        var gaps = new List<uint>();
        foreach( var sheetName in gameData.Excel.SheetNames )
        {
            if( gameData.GetFile<ExcelHeaderFile>( $"exd/{sheetName}.exh" ) is not { } headerFile )
                continue;
            var lang = headerFile.Languages.Contains( Language.English ) ? Language.English : Language.None;
            switch( headerFile.Header.Variant )
            {
                case ExcelVariant.Default:
                    {
                        var sheet = gameData.Excel.GetSheet<Addon>( lang, sheetName );
                        gaps.Add(
                            sheet.Count == 0 ? 0 : sheet.GetRowAt( sheet.Count - 1 ).RowId - sheet.GetRowAt( 0 ).RowId + 1 - (uint)sheet.Count );
                        break;
                    }
                case ExcelVariant.Subrows:
                    {
                        var sheet = gameData.Excel.GetSubrowSheet<QuestLinkMarker>( lang, sheetName );
                        gaps.Add( sheet.Count == 0 ? 0 : sheet.GetRowAt( sheet.Count - 1 ).RowId - sheet.GetRowAt( 0 ).RowId + 1 - (uint)sheet.Count );
                        break;
                    }
            }
        }

        gaps.Sort();
        var countAcc = 0;
        var wasteAcc = 0;
        var test = string.Join(
            "\n",
            gaps
                .GroupBy( x => x / 1024, x => x )
                .Select( x =>
                    $"{( x.Key + 1 ) * 1024,8}, {( countAcc += x.Count() ) * 100f / gaps.Count,6:00.00}%, {( wasteAcc += x.Sum( y => (int)y ) * 4 ) / 1024,5}KB" ) );
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public ulong AddonRowAccessor()
    {
        ulong ret = 0;
        foreach( var x in addonRows )
            ret += addonSheet[x].Data;
        return ret;
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public ulong AddonRowEnumerator()
    {
        ulong ret = 0;
        foreach( var x in addonSheet )
            ret += x.Data;
        return ret;
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public ulong ItemRowAccessor()
    {
        ulong ret = 0;
        foreach( var x in itemRows )
            ret += itemSheet[x].Data;
        return ret;
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public ulong ItemRowEnumerator()
    {
        ulong ret = 0;
        foreach( var x in itemSheet )
            ret += x.Data;
        return ret;
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public ulong SubrowAccessor()
    {
        ulong ret = 0;
        foreach( var x in subrowRows )
        {
            var sc = subrowSheet.GetSubrowCount( x );
            for( ushort j = 0; j < sc; j++ )
                ret += subrowSheet[x, j].Data;
        }
        return ret;
    }

    [Benchmark]
    [MethodImpl( MethodImplOptions.NoInlining )]
    public ulong SubrowEnumerator()
    {
        ulong ret = 0;
        foreach( var x in subrowSheet.Flatten() )
            ret += x.RowId;
        return ret;
    }

    [Sheet( "Addon" )]
    public readonly struct Addon( ExcelPage page, uint offset, uint row ) : IExcelRow<Addon>
    {
        public uint RowId => row;

        public uint Data => row & offset;

        static Addon IExcelRow<Addon>.Create( ExcelPage page, uint offset, uint row ) => new( page, offset, row );
    }

    [Sheet( "Item" )]
    public readonly struct Item( ExcelPage page, uint offset, uint row ) : IExcelRow<Item>
    {
        public uint RowId => row;

        public uint Data => row & offset;

        static Item IExcelRow<Item>.Create( ExcelPage page, uint offset, uint row ) => new( page, offset, row );
    }

    [Sheet( "QuestLinkMarker" )]
    public readonly struct QuestLinkMarker( ExcelPage page, uint offset, uint row, ushort subrow ) : IExcelSubrow<QuestLinkMarker>
    {
        public uint RowId => row;
        public ushort SubrowId => subrow;
        
        public uint Data => row & offset;

        static QuestLinkMarker IExcelSubrow<QuestLinkMarker>.Create( ExcelPage page, uint offset, uint row, ushort subrow ) => new( page, offset, row, subrow );
    }
}
