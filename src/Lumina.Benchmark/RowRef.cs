using BenchmarkDotNet.Attributes;
using Lumina.Excel;

namespace Lumina.Benchmark;

[DisassemblyDiagnoser( maxDepth: 500, exportGithubMarkdown: false, exportHtml: true )]
public class RowRefBench
{
    private GameData gameData;
    private ExcelSheet< GatheringItem > rowRefSheet;
    private RowRef< GatheringItemLevelConvertTable > rowRef;

    [GlobalSetup]
    public void Setup()
    {
        gameData = Program.CreateGameData();

        rowRefSheet = gameData.GetExcelSheet< GatheringItem >()!;
        rowRef = rowRefSheet.First().GatheringItemLevel;
    }

    [Benchmark]
    public ulong RowRefEnumerator()
    {
        ulong ret = 0;
        foreach( var x in rowRefSheet )
        {
            if( x.RowId == 0 || x.GatheringItemLevel.RowId == 0 )
                continue;

            ret += x.GatheringItemLevel.RowId;
        }
        return ret;
    }

    [Benchmark]
    public ulong RowRefResolver()
    {
        ulong ret = 0;
        foreach( var x in rowRefSheet )
        {
            if( x.RowId == 0 || x.GatheringItemLevel.RowId == 0 )
                continue;

            ret += x.GatheringItemLevel.Value.GatheringItemLevel;
        }
        return ret;
    }

    [Benchmark]
    public ulong RowMultiRefEnumerator()
    {
        ulong ret = 0;
        foreach( var x in rowRefSheet )
        {
            var item = x.Item;
            if( x.RowId == 0 || item.RowId == 0 )
                continue;

            ret += item.RowId;
        }
        return ret;
    }

    [Benchmark]
    public ulong RowMultiRefResolver()
    {
        ulong ret = 0;
        foreach( var x in rowRefSheet )
        {
            var item = x.Item;
            if( x.RowId == 0 || item.RowId == 0 )
                continue;

            if( item.GetValueOrDefault<Item>() is { } itemVal )
                ret += itemVal.Icon;
            else if( item.GetValueOrDefault<EventItem>() is { } itemVal2 )
                ret += itemVal2.Icon;
        }
        return ret;
    }

    [Benchmark]
    public byte RowRefOne() =>
        rowRef.Value.GatheringItemLevel;
}
