using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriad", columnHash: 0x2f29903e )]
    public class TripleTriad : IExcelRow
    {
        
        public LazyRow< TripleTriadCard >[] TripleTriadCardFixed;
        public LazyRow< TripleTriadCard >[] TripleTriadCardVariable;
        public LazyRow< TripleTriadRule >[] TripleTriadRule;
        public bool UsesRegionalRules;
        public ushort Fee;
        public byte PreviousQuestJoin;
        public LazyRow< Quest >[] PreviousQuest;
        public ushort StartTime;
        public ushort EndTime;
        public LazyRow< DefaultTalk > DefaultTalkChallenge;
        public LazyRow< DefaultTalk > DefaultTalkUnavailable;
        public LazyRow< DefaultTalk > DefaultTalkNPCWin;
        public LazyRow< DefaultTalk > DefaultTalkDraw;
        public LazyRow< DefaultTalk > DefaultTalkPCWin;
        public bool Unknown25;
        public LazyRow< Item >[] ItemPossibleReward;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 5; i++ )
                TripleTriadCardFixed[ i ] = new LazyRow< TripleTriadCard >( lumina, parser.ReadColumn< ushort >( 0 + i ) );
            for( var i = 0; i < 5; i++ )
                TripleTriadCardVariable[ i ] = new LazyRow< TripleTriadCard >( lumina, parser.ReadColumn< ushort >( 5 + i ) );
            for( var i = 0; i < 2; i++ )
                TripleTriadRule[ i ] = new LazyRow< TripleTriadRule >( lumina, parser.ReadColumn< byte >( 10 + i ) );
            UsesRegionalRules = parser.ReadColumn< bool >( 12 );
            Fee = parser.ReadColumn< ushort >( 13 );
            PreviousQuestJoin = parser.ReadColumn< byte >( 14 );
            for( var i = 0; i < 3; i++ )
                PreviousQuest[ i ] = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 15 + i ) );
            StartTime = parser.ReadColumn< ushort >( 18 );
            EndTime = parser.ReadColumn< ushort >( 19 );
            DefaultTalkChallenge = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 20 ) );
            DefaultTalkUnavailable = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 21 ) );
            DefaultTalkNPCWin = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 22 ) );
            DefaultTalkDraw = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 23 ) );
            DefaultTalkPCWin = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 24 ) );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            for( var i = 0; i < 4; i++ )
                ItemPossibleReward[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 26 + i ) );
        }
    }
}