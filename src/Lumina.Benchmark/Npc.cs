using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.dotTrace;
using Lumina.Excel;

namespace Lumina.Benchmark;

[DisassemblyDiagnoser( maxDepth: 500, exportGithubMarkdown: false, exportHtml: true )]
[DotTraceDiagnoser]
public class NpcBench
{
    private GameData gameData;
    private ExcelSheet<ENpcBase> npcSheet;

    [GlobalSetup]
    public void Setup()
    {
        gameData = Program.CreateGameData();

        npcSheet = gameData.GetExcelSheet<ENpcBase>()!;
    }

    [Benchmark]
    public Lookups BuildDataMap()
    {
        var ret = new Lookups();

        foreach( var npc in npcSheet )
        {
            foreach( var variable in npc.ENpcData )
            {
                ret.EvaluateRowRef( npc, variable );
            }
        }

        return ret;
    }

    public readonly struct Lookups()
    {
        public readonly Dictionary<uint, HashSet<uint>> npcIdToSpecialShopIdLookup = [];
        public readonly Dictionary<uint, HashSet<uint>> npcIdToFccShopIdLookup = [];
        public readonly Dictionary<uint, HashSet<uint>> npcIdToGilShopIdLookup = [];
        public readonly Dictionary<uint, HashSet<uint>> npcIdToGcShopIdLookup = [];

        public readonly Dictionary<uint, HashSet<uint>> specialShopIdToNpcIdLookup = [];
        public readonly Dictionary<uint, HashSet<uint>> fccShopIdToNpcIdLookup = [];
        public readonly Dictionary<uint, HashSet<uint>> gilShopIdToNpcIdLookup = [];
        public readonly Dictionary<uint, HashSet<uint>> gcShopIdToNpcIdLookup = [];

        public void EvaluateRowRef( ENpcBase npcBase, RowRef rowRef )
        {
            if( rowRef.Is<FccShop>() )
            {
                fccShopIdToNpcIdLookup.TryAdd( rowRef.RowId, [] );
                fccShopIdToNpcIdLookup[rowRef.RowId].Add( npcBase.RowId );

                npcIdToFccShopIdLookup.TryAdd( npcBase.RowId, [] );
                npcIdToFccShopIdLookup[npcBase.RowId].Add( rowRef.RowId );
            }
            else if( rowRef.Is<GCShop>() )
            {
                gcShopIdToNpcIdLookup.TryAdd( rowRef.RowId, [] );
                gcShopIdToNpcIdLookup[rowRef.RowId].Add( npcBase.RowId );

                npcIdToGcShopIdLookup.TryAdd( npcBase.RowId, [] );
                npcIdToGcShopIdLookup[npcBase.RowId].Add( rowRef.RowId );
            }
            else if( rowRef.Is<GilShop>() )
            {
                gilShopIdToNpcIdLookup.TryAdd( rowRef.RowId, [] );
                gilShopIdToNpcIdLookup[rowRef.RowId].Add( npcBase.RowId );

                npcIdToGilShopIdLookup.TryAdd( npcBase.RowId, [] );
                npcIdToGilShopIdLookup[npcBase.RowId].Add( rowRef.RowId );
            }
            else if( rowRef.Is<SpecialShop>() )
            {
                specialShopIdToNpcIdLookup.TryAdd( rowRef.RowId, [] );
                specialShopIdToNpcIdLookup[rowRef.RowId].Add( npcBase.RowId );

                npcIdToSpecialShopIdLookup.TryAdd( npcBase.RowId, [] );
                npcIdToSpecialShopIdLookup[npcBase.RowId].Add( rowRef.RowId );
            }
            else if( rowRef.TryGetValue<TopicSelect>(out var topicSelect) )
            {
                foreach( var topicShop in topicSelect.Shop )
                {
                    EvaluateRowRef( npcBase, topicShop );
                }
            }
            else if( rowRef.TryGetValue<PreHandler>( out var preHandler ) )
            {
                EvaluateRowRef( npcBase, preHandler.Target );
            }
        }
    }
}
