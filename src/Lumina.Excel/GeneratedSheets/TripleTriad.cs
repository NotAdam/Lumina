// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriad", columnHash: 0x646dde20 )]
    public partial class TripleTriad : ExcelRow
    {
        
        public LazyRow< TripleTriadCard >[] TripleTriadCardFixed { get; set; }
        public LazyRow< TripleTriadCard >[] TripleTriadCardVariable { get; set; }
        public LazyRow< TripleTriadRule >[] TripleTriadRule { get; set; }
        public bool UsesRegionalRules { get; set; }
        public ushort Fee { get; set; }
        public byte PreviousQuestJoin { get; set; }
        public LazyRow< Quest >[] PreviousQuest { get; set; }
        public ushort StartTime { get; set; }
        public ushort EndTime { get; set; }
        public LazyRow< DefaultTalk > DefaultTalkChallenge { get; set; }
        public LazyRow< DefaultTalk > DefaultTalkUnavailable { get; set; }
        public LazyRow< DefaultTalk > DefaultTalkNPCWin { get; set; }
        public LazyRow< DefaultTalk > DefaultTalkDraw { get; set; }
        public LazyRow< DefaultTalk > DefaultTalkPCWin { get; set; }
        public bool Unknown25 { get; set; }
        public LazyRow< Item >[] ItemPossibleReward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TripleTriadCardFixed = new LazyRow< TripleTriadCard >[ 5 ];
            for( var i = 0; i < 5; i++ )
                TripleTriadCardFixed[ i ] = new LazyRow< TripleTriadCard >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            TripleTriadCardVariable = new LazyRow< TripleTriadCard >[ 5 ];
            for( var i = 0; i < 5; i++ )
                TripleTriadCardVariable[ i ] = new LazyRow< TripleTriadCard >( gameData, parser.ReadColumn< ushort >( 5 + i ), language );
            TripleTriadRule = new LazyRow< TripleTriadRule >[ 2 ];
            for( var i = 0; i < 2; i++ )
                TripleTriadRule[ i ] = new LazyRow< TripleTriadRule >( gameData, parser.ReadColumn< byte >( 10 + i ), language );
            UsesRegionalRules = parser.ReadColumn< bool >( 12 );
            Fee = parser.ReadColumn< ushort >( 13 );
            PreviousQuestJoin = parser.ReadColumn< byte >( 14 );
            PreviousQuest = new LazyRow< Quest >[ 3 ];
            for( var i = 0; i < 3; i++ )
                PreviousQuest[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 15 + i ), language );
            StartTime = parser.ReadColumn< ushort >( 18 );
            EndTime = parser.ReadColumn< ushort >( 19 );
            DefaultTalkChallenge = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 20 ), language );
            DefaultTalkUnavailable = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 21 ), language );
            DefaultTalkNPCWin = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 22 ), language );
            DefaultTalkDraw = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 23 ), language );
            DefaultTalkPCWin = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 24 ), language );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            ItemPossibleReward = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemPossibleReward[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 26 + i ), language );
        }
    }
}