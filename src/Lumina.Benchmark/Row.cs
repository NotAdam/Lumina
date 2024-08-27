using BenchmarkDotNet.Attributes;
using Lumina.Excel;

namespace Lumina.Benchmark;

[DisassemblyDiagnoser( maxDepth: 500, exportGithubMarkdown: false, exportHtml: true )]
public class RowBench
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
    public ulong AddonRowAccessor()
    {
        ulong ret = 0;
        foreach( var x in addonRows )
            ret += addonSheet[x].Data;
        return ret;
    }

    [Benchmark]
    public ulong AddonRowEnumerator()
    {
        ulong ret = 0;
        foreach( var x in addonSheet )
            ret += x.Data;
        return ret;
    }

    [Benchmark]
    public ulong ItemRowAccessor()
    {
        ulong ret = 0;
        foreach( var x in itemRows )
            ret += itemSheet[x].Data;
        return ret;
    }

    [Benchmark]
    public ulong ItemRowEnumerator()
    {
        ulong ret = 0;
        foreach( var x in itemSheet )
            ret += x.Data;
        return ret;
    }

    [Benchmark]
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
    public ulong SubrowEnumerator()
    {
        ulong ret = 0;
        foreach( var x in subrowSheet.Flatten() )
            ret += x.RowId;
        return ret;
    }
}
