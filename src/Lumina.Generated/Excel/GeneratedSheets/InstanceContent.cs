using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContent", columnHash: 0xe8f48f92 )]
    public class InstanceContent : IExcelRow
    {
        public struct UnkStruct25Struct
        {
            public uint BossExp;
        }
        public struct UnkStruct30Struct
        {
            public ushort BossCurrencyA;
        }
        public struct UnkStruct35Struct
        {
            public ushort BossCurrencyB;
        }
        public struct UnkStruct40Struct
        {
            public ushort BossCurrencyC;
        }
        
        public byte InstanceContentType;
        public byte WeekRestriction;
        public ushort TimeLimitmin;
        public bool Unknown3;
        public LazyRow< BGM > BGM;
        public LazyRow< BGM > WinBGM;
        public LazyRow< Cutscene > Cutscene;
        public uint Unknown7;
        public ushort Order;
        public byte Colosseum;
        public bool Unknown10;
        public LazyRow< InstanceContentTextData > InstanceContentTextDataBossStart;
        public LazyRow< InstanceContentTextData > InstanceContentTextDataBossEnd;
        public LazyRow< BNpcBase > BNpcBaseBoss;
        public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveStart;
        public LazyRow< InstanceContentTextData > InstanceContentTextDataObjectiveEnd;
        public ushort SortKey;
        public uint InstanceClearExp;
        public uint Unknown18;
        public ushort NewPlayerBonusA;
        public ushort FinalBossCurrencyC;
        public uint Unknown21;
        public ushort FinalBossCurrencyA;
        public ushort FinalBossCurrencyB;
        public ushort NewPlayerBonusB;
        public UnkStruct25Struct[] UnkStruct25;
        public UnkStruct30Struct[] UnkStruct30;
        public UnkStruct35Struct[] UnkStruct35;
        public UnkStruct40Struct[] UnkStruct40;
        public uint Unknown45;
        public uint InstanceClearGil;
        public uint InstanceContentRewardItem;
        public byte Unknown48;
        public uint FinalBossExp;
        public LazyRow< InstanceContentBuff > InstanceContentBuff;
        public LazyRow< InstanceContent > ReqInstance;
        public short Unknown52;
        public byte PartyCondition;
        public byte Unknown54;
        public byte Unknown55;
        public byte Unknown56;
        public bool Unknown57;
        public ushort Unknown58;
        public ushort Unknown59;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            InstanceContentType = parser.ReadColumn< byte >( 0 );
            WeekRestriction = parser.ReadColumn< byte >( 1 );
            TimeLimitmin = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 4 ) );
            WinBGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 5 ) );
            Cutscene = new LazyRow< Cutscene >( lumina, parser.ReadColumn< uint >( 6 ) );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Order = parser.ReadColumn< ushort >( 8 );
            Colosseum = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            InstanceContentTextDataBossStart = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 11 ) );
            InstanceContentTextDataBossEnd = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 12 ) );
            BNpcBaseBoss = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< uint >( 13 ) );
            InstanceContentTextDataObjectiveStart = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 14 ) );
            InstanceContentTextDataObjectiveEnd = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 15 ) );
            SortKey = parser.ReadColumn< ushort >( 16 );
            InstanceClearExp = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            NewPlayerBonusA = parser.ReadColumn< ushort >( 19 );
            FinalBossCurrencyC = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            FinalBossCurrencyA = parser.ReadColumn< ushort >( 22 );
            FinalBossCurrencyB = parser.ReadColumn< ushort >( 23 );
            NewPlayerBonusB = parser.ReadColumn< ushort >( 24 );
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct25[ i ] = new UnkStruct25Struct();
                UnkStruct25[ i ].BossExp = parser.ReadColumn< uint >( 25 + ( i * 5 + 0 ) );
            }
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct30[ i ] = new UnkStruct30Struct();
                UnkStruct30[ i ].BossCurrencyA = parser.ReadColumn< ushort >( 30 + ( i * 5 + 0 ) );
            }
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct35[ i ] = new UnkStruct35Struct();
                UnkStruct35[ i ].BossCurrencyB = parser.ReadColumn< ushort >( 35 + ( i * 5 + 0 ) );
            }
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct40[ i ] = new UnkStruct40Struct();
                UnkStruct40[ i ].BossCurrencyC = parser.ReadColumn< ushort >( 40 + ( i * 5 + 0 ) );
            }
            Unknown45 = parser.ReadColumn< uint >( 45 );
            InstanceClearGil = parser.ReadColumn< uint >( 46 );
            InstanceContentRewardItem = parser.ReadColumn< uint >( 47 );
            Unknown48 = parser.ReadColumn< byte >( 48 );
            FinalBossExp = parser.ReadColumn< uint >( 49 );
            InstanceContentBuff = new LazyRow< InstanceContentBuff >( lumina, parser.ReadColumn< int >( 50 ) );
            ReqInstance = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< uint >( 51 ) );
            Unknown52 = parser.ReadColumn< short >( 52 );
            PartyCondition = parser.ReadColumn< byte >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< ushort >( 58 );
            Unknown59 = parser.ReadColumn< ushort >( 59 );
        }
    }
}