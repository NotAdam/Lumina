// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContent", columnHash: 0xa4243e29 )]
    public class InstanceContent : ExcelRow
    {
        
        public byte InstanceContentType { get; set; }
        public byte WeekRestriction { get; set; }
        public ushort TimeLimitmin { get; set; }
        public bool Unknown3 { get; set; }
        public LazyRow< BGM > BGM { get; set; }
        public LazyRow< BGM > WinBGM { get; set; }
        public LazyRow< Cutscene > Cutscene { get; set; }
        public uint LGBEventRange { get; set; }
        public ushort Order { get; set; }
        public byte Colosseum { get; set; }
        public bool Unknown10 { get; set; }
        public LazyRow< InstanceContentTextData > InstanceContentTextDataBossStart { get; set; }
        public LazyRow< InstanceContentTextData > InstanceContentTextDataBossEnd { get; set; }
        public LazyRow< BNpcBase > BNpcBaseBoss { get; set; }
        public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveStart { get; set; }
        public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveEnd { get; set; }
        public ushort SortKey { get; set; }
        public uint InstanceClearExp { get; set; }
        public uint Unknown18 { get; set; }
        public ushort NewPlayerBonusA { get; set; }
        public ushort FinalBossCurrencyC { get; set; }
        public uint Unknown21 { get; set; }
        public uint FinalBossCurrencyA { get; set; }
        public ushort FinalBossCurrencyB { get; set; }
        public ushort NewPlayerBonusB { get; set; }
        public ushort[] BossExp { get; set; }
        public uint[] BossCurrencyA { get; set; }
        public ushort[] BossCurrencyB { get; set; }
        public ushort[] BossCurrencyC { get; set; }
        public ushort Unknown45 { get; set; }
        public uint InstanceClearGil { get; set; }
        public uint InstanceContentRewardItem { get; set; }
        public uint Unknown48 { get; set; }
        public byte FinalBossExp { get; set; }
        public LazyRow< InstanceContentBuff > InstanceContentBuff { get; set; }
        public LazyRow< InstanceContent > ReqInstance { get; set; }
        public uint Unknown52 { get; set; }
        public short PartyCondition { get; set; }
        public byte Unknown54 { get; set; }
        public byte Unknown55 { get; set; }
        public byte Unknown56 { get; set; }
        public byte Unknown57 { get; set; }
        public bool Unknown58 { get; set; }
        public ushort Unknown59 { get; set; }
        public ushort Unknown60 { get; set; }
        public ushort Unknown61 { get; set; }
        public ushort Unknown62 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            InstanceContentType = parser.ReadColumn< byte >( 0 );
            WeekRestriction = parser.ReadColumn< byte >( 1 );
            TimeLimitmin = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            BGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            WinBGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Cutscene = new LazyRow< Cutscene >( gameData, parser.ReadColumn< uint >( 6 ), language );
            LGBEventRange = parser.ReadColumn< uint >( 7 );
            Order = parser.ReadColumn< ushort >( 8 );
            Colosseum = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            InstanceContentTextDataBossStart = new LazyRow< InstanceContentTextData >( gameData, parser.ReadColumn< uint >( 11 ), language );
            InstanceContentTextDataBossEnd = new LazyRow< InstanceContentTextData >( gameData, parser.ReadColumn< uint >( 12 ), language );
            BNpcBaseBoss = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< uint >( 13 ), language );
            InstanceContentTextDataObjectiveStart = new LazyRow< InstanceContentTextData >( gameData, parser.ReadColumn< uint >( 14 ), language );
            InstanceContentTextDataObjectiveEnd = new LazyRow< InstanceContentTextData >( gameData, parser.ReadColumn< uint >( 15 ), language );
            SortKey = parser.ReadColumn< ushort >( 16 );
            InstanceClearExp = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            NewPlayerBonusA = parser.ReadColumn< ushort >( 19 );
            FinalBossCurrencyC = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            FinalBossCurrencyA = parser.ReadColumn< uint >( 22 );
            FinalBossCurrencyB = parser.ReadColumn< ushort >( 23 );
            NewPlayerBonusB = parser.ReadColumn< ushort >( 24 );
            BossExp = new ushort[ 5 ];
            for( var i = 0; i < 5; i++ )
                BossExp[ i ] = parser.ReadColumn< ushort >( 25 + i );
            BossCurrencyA = new uint[ 5 ];
            for( var i = 0; i < 5; i++ )
                BossCurrencyA[ i ] = parser.ReadColumn< uint >( 30 + i );
            BossCurrencyB = new ushort[ 5 ];
            for( var i = 0; i < 5; i++ )
                BossCurrencyB[ i ] = parser.ReadColumn< ushort >( 35 + i );
            BossCurrencyC = new ushort[ 5 ];
            for( var i = 0; i < 5; i++ )
                BossCurrencyC[ i ] = parser.ReadColumn< ushort >( 40 + i );
            Unknown45 = parser.ReadColumn< ushort >( 45 );
            InstanceClearGil = parser.ReadColumn< uint >( 46 );
            InstanceContentRewardItem = parser.ReadColumn< uint >( 47 );
            Unknown48 = parser.ReadColumn< uint >( 48 );
            FinalBossExp = parser.ReadColumn< byte >( 49 );
            InstanceContentBuff = new LazyRow< InstanceContentBuff >( gameData, parser.ReadColumn< uint >( 50 ), language );
            ReqInstance = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< int >( 51 ), language );
            Unknown52 = parser.ReadColumn< uint >( 52 );
            PartyCondition = parser.ReadColumn< short >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< byte >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< ushort >( 59 );
            Unknown60 = parser.ReadColumn< ushort >( 60 );
            Unknown61 = parser.ReadColumn< ushort >( 61 );
            Unknown62 = parser.ReadColumn< ushort >( 62 );
        }
    }
}