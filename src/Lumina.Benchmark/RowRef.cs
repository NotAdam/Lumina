using BenchmarkDotNet.Attributes;
using Lumina.Excel;

namespace Lumina.Benchmark;

[DisassemblyDiagnoser( maxDepth: 500, exportGithubMarkdown: false, exportHtml: true )]
public class RowRefBench
{
    private GameData gameData;
    private ExcelSheet<GatheringItem> rowRefSheet;
    private RowRef<GatheringItemLevelConvertTable> rowRef;

    [GlobalSetup]
    public void Setup()
    {
        gameData = new GameData( @"J:\Programs\Steam\steamapps\common\FINAL FANTASY XIV Online\game\sqpack", new()
        {
            PanicOnSheetChecksumMismatch = false,
        } );

        rowRefSheet = gameData.GetExcelSheet<GatheringItem>()!;
        rowRef = rowRefSheet.First().GatheringItemLevel;
    }

    [Benchmark]
    public ulong RowRefEnumerator()
    {
        ulong ret = 0;
        foreach( var x in rowRefSheet )
        {
            if( x.RowId == 0 || x.Item.RowId == 0 )
                continue;

            ret += x.GatheringItemLevel.RowId;
        }
        return ret;
    }

    [Benchmark]
    public byte RowRefOne() =>
        rowRef.Value.GatheringItemLevel;

    [Benchmark]
    public ulong RowRefSheet()
    {
        ulong ret = 0;
        foreach( var x in rowRefSheet )
        {
            if( x.RowId == 0 || x.Item.RowId == 0 )
                continue;

            ret += x.GatheringItemLevel.Value.GatheringItemLevel;
        }
        return ret;
    }
}
