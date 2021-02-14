// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContent", columnHash: 0xa4243e29 )]
    public class InstanceContent : ExcelRow
    {
        public struct UnkStruct25Struct
        {
            public ushort BossExp;
        }
        public struct UnkStruct30Struct
        {
            public uint BossCurrencyA;
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
        public uint FinalBossCurrencyA;
        public ushort FinalBossCurrencyB;
        public ushort NewPlayerBonusB;
        public UnkStruct25Struct[] UnkStruct25;
        public UnkStruct30Struct[] UnkStruct30;
        public UnkStruct35Struct[] UnkStruct35;
        public UnkStruct40Struct[] UnkStruct40;
        public ushort Unknown45;
        public uint InstanceClearGil;
        public uint InstanceContentRewardItem;
        public uint Unknown48;
        public byte FinalBossExp;
        public LazyRow< InstanceContentBuff > InstanceContentBuff;
        public LazyRow< InstanceContent > ReqInstance;
        public uint Unknown52;
        public short PartyCondition;
        public byte Unknown54;
        public byte Unknown55;
        public byte Unknown56;
        public byte Unknown57;
        public bool Unknown58;
        public ushort Unknown59;
        public ushort Unknown60;
        public ushort Unknown540;
        public ushort Unknown541;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            InstanceContentType = parser.ReadColumn< byte >( 0 );
            WeekRestriction = parser.ReadColumn< byte >( 1 );
            TimeLimitmin = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            WinBGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            Cutscene = new LazyRow< Cutscene >( lumina, parser.ReadColumn< uint >( 6 ), language );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Order = parser.ReadColumn< ushort >( 8 );
            Colosseum = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            InstanceContentTextDataBossStart = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 11 ), language );
            InstanceContentTextDataBossEnd = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 12 ), language );
            BNpcBaseBoss = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< uint >( 13 ), language );
            InstanceContentTextDataObjectiveStart = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 14 ), language );
            InstanceContentTextDataObjectiveEnd = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 15 ), language );
            SortKey = parser.ReadColumn< ushort >( 16 );
            InstanceClearExp = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            NewPlayerBonusA = parser.ReadColumn< ushort >( 19 );
            FinalBossCurrencyC = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            FinalBossCurrencyA = parser.ReadColumn< uint >( 22 );
            FinalBossCurrencyB = parser.ReadColumn< ushort >( 23 );
            NewPlayerBonusB = parser.ReadColumn< ushort >( 24 );
            UnkStruct25 = new UnkStruct25Struct[ 5 ];
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct25[ i ] = new UnkStruct25Struct();
                UnkStruct25[ i ].BossExp = parser.ReadColumn< ushort >( 25 + ( i * 1 + 0 ) );
            }
            UnkStruct30 = new UnkStruct30Struct[ 5 ];
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct30[ i ] = new UnkStruct30Struct();
                UnkStruct30[ i ].BossCurrencyA = parser.ReadColumn< uint >( 30 + ( i * 1 + 0 ) );
            }
            UnkStruct35 = new UnkStruct35Struct[ 5 ];
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct35[ i ] = new UnkStruct35Struct();
                UnkStruct35[ i ].BossCurrencyB = parser.ReadColumn< ushort >( 35 + ( i * 1 + 0 ) );
            }
            UnkStruct40 = new UnkStruct40Struct[ 5 ];
            for( var i = 0; i < 5; i++ )
            {
                UnkStruct40[ i ] = new UnkStruct40Struct();
                UnkStruct40[ i ].BossCurrencyC = parser.ReadColumn< ushort >( 40 + ( i * 1 + 0 ) );
            }
            Unknown45 = parser.ReadColumn< ushort >( 45 );
            InstanceClearGil = parser.ReadColumn< uint >( 46 );
            InstanceContentRewardItem = parser.ReadColumn< uint >( 47 );
            Unknown48 = parser.ReadColumn< uint >( 48 );
            FinalBossExp = parser.ReadColumn< byte >( 49 );
            InstanceContentBuff = new LazyRow< InstanceContentBuff >( lumina, parser.ReadColumn< uint >( 50 ), language );
            ReqInstance = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< int >( 51 ), language );
            Unknown52 = parser.ReadColumn< uint >( 52 );
            PartyCondition = parser.ReadColumn< short >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< byte >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< ushort >( 59 );
            Unknown60 = parser.ReadColumn< ushort >( 60 );
            Unknown540 = parser.ReadColumn< ushort >( 61 );
            Unknown541 = parser.ReadColumn< ushort >( 62 );
        }
    }
}