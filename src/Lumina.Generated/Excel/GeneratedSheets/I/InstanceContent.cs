using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContent", columnHash: 0xe8f48f92 )]
    public class InstanceContent : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 17 offset: 0000
        public uint InstanceClearExp;

        // col: 18 offset: 0004
        public uint unknown4;

        // col: 21 offset: 0008
        public uint unknown8;

        // col: 25 offset: 000c
        public uint[] unknownc;

        // col: 45 offset: 0020
        public uint unknown20;

        // col: 46 offset: 0024
        public uint InstanceClearGil;

        // col: 47 offset: 0028
        public uint InstanceContentRewardItem;

        // col: 19 offset: 002c
        public ushort NewPlayerBonusA;

        // col: 20 offset: 002e
        public ushort FinalBossCurrencyC;

        // col: 22 offset: 0030
        public ushort FinalBossCurrencyA;

        // col: 23 offset: 0032
        public ushort FinalBossCurrencyB;

        // col: 24 offset: 0034
        public ushort NewPlayerBonusB;

        // col: 30 offset: 0036
        public ushort[] unknown36;

        // col: 35 offset: 0040
        public ushort[] unknown40;

        // col: 40 offset: 004a
        public ushort[] unknown4a;

        // col: 48 offset: 0054
        public byte unknown54;

        // col: 06 offset: 0058
        public uint Cutscene;

        // col: 07 offset: 005c
        public uint unknown5c;

        // col: 11 offset: 0060
        public uint InstanceContentTextDataBossStart;

        // col: 12 offset: 0064
        public uint InstanceContentTextDataBossEnd;

        // col: 13 offset: 0068
        public uint BNpcBaseBoss;

        // col: 14 offset: 006c
        public uint InstanceContentTextDataObjectiveStart;

        // col: 15 offset: 0070
        public uint InstanceContentTextDataObjectiveEnd;

        // col: 49 offset: 0074
        public uint FinalBossExp;

        // col: 51 offset: 0078
        public uint ReqInstance;

        // col: 50 offset: 007c
        public int InstanceContentBuff;

        // col: 02 offset: 0080
        public ushort TimeLimitmin;

        // col: 04 offset: 0082
        public ushort BGM;

        // col: 05 offset: 0084
        public ushort WinBGM;

        // col: 08 offset: 0086
        public ushort Order;

        // col: 16 offset: 0088
        public ushort SortKey;

        // col: 58 offset: 008a
        public ushort unknown8a;

        // col: 59 offset: 008c
        public ushort unknown8c;

        // col: 52 offset: 008e
        public short unknown8e;

        // col: 00 offset: 0090
        public byte InstanceContentType;

        // col: 01 offset: 0091
        public byte WeekRestriction;

        // col: 09 offset: 0092
        public byte Colosseum;

        // col: 53 offset: 0093
        public byte PartyCondition;

        // col: 54 offset: 0094
        public byte unknown94;

        // col: 55 offset: 0095
        public byte unknown95;

        // col: 56 offset: 0096
        public byte unknown96;

        // col: 03 offset: 0097
        public bool packed97_1;
        public byte packed97;
        public bool packed97_2;
        public bool packed97_4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 17 offset: 0000
            InstanceClearExp = parser.ReadOffset< uint >( 0x0 );

            // col: 18 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 21 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 25 offset: 000c
            unknownc = new uint[5];
            unknownc[0] = parser.ReadOffset< uint >( 0xc );
            unknownc[1] = parser.ReadOffset< uint >( 0x10 );
            unknownc[2] = parser.ReadOffset< uint >( 0x14 );
            unknownc[3] = parser.ReadOffset< uint >( 0x18 );
            unknownc[4] = parser.ReadOffset< uint >( 0x1c );

            // col: 45 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 46 offset: 0024
            InstanceClearGil = parser.ReadOffset< uint >( 0x24 );

            // col: 47 offset: 0028
            InstanceContentRewardItem = parser.ReadOffset< uint >( 0x28 );

            // col: 19 offset: 002c
            NewPlayerBonusA = parser.ReadOffset< ushort >( 0x2c );

            // col: 20 offset: 002e
            FinalBossCurrencyC = parser.ReadOffset< ushort >( 0x2e );

            // col: 22 offset: 0030
            FinalBossCurrencyA = parser.ReadOffset< ushort >( 0x30 );

            // col: 23 offset: 0032
            FinalBossCurrencyB = parser.ReadOffset< ushort >( 0x32 );

            // col: 24 offset: 0034
            NewPlayerBonusB = parser.ReadOffset< ushort >( 0x34 );

            // col: 30 offset: 0036
            unknown36 = new ushort[5];
            unknown36[0] = parser.ReadOffset< ushort >( 0x36 );
            unknown36[1] = parser.ReadOffset< ushort >( 0x38 );
            unknown36[2] = parser.ReadOffset< ushort >( 0x3a );
            unknown36[3] = parser.ReadOffset< ushort >( 0x3c );
            unknown36[4] = parser.ReadOffset< ushort >( 0x3e );

            // col: 35 offset: 0040
            unknown40 = new ushort[5];
            unknown40[0] = parser.ReadOffset< ushort >( 0x40 );
            unknown40[1] = parser.ReadOffset< ushort >( 0x42 );
            unknown40[2] = parser.ReadOffset< ushort >( 0x44 );
            unknown40[3] = parser.ReadOffset< ushort >( 0x46 );
            unknown40[4] = parser.ReadOffset< ushort >( 0x48 );

            // col: 40 offset: 004a
            unknown4a = new ushort[5];
            unknown4a[0] = parser.ReadOffset< ushort >( 0x4a );
            unknown4a[1] = parser.ReadOffset< ushort >( 0x4c );
            unknown4a[2] = parser.ReadOffset< ushort >( 0x4e );
            unknown4a[3] = parser.ReadOffset< ushort >( 0x50 );
            unknown4a[4] = parser.ReadOffset< ushort >( 0x52 );

            // col: 48 offset: 0054
            unknown54 = parser.ReadOffset< byte >( 0x54 );

            // col: 6 offset: 0058
            Cutscene = parser.ReadOffset< uint >( 0x58 );

            // col: 7 offset: 005c
            unknown5c = parser.ReadOffset< uint >( 0x5c );

            // col: 11 offset: 0060
            InstanceContentTextDataBossStart = parser.ReadOffset< uint >( 0x60 );

            // col: 12 offset: 0064
            InstanceContentTextDataBossEnd = parser.ReadOffset< uint >( 0x64 );

            // col: 13 offset: 0068
            BNpcBaseBoss = parser.ReadOffset< uint >( 0x68 );

            // col: 14 offset: 006c
            InstanceContentTextDataObjectiveStart = parser.ReadOffset< uint >( 0x6c );

            // col: 15 offset: 0070
            InstanceContentTextDataObjectiveEnd = parser.ReadOffset< uint >( 0x70 );

            // col: 49 offset: 0074
            FinalBossExp = parser.ReadOffset< uint >( 0x74 );

            // col: 51 offset: 0078
            ReqInstance = parser.ReadOffset< uint >( 0x78 );

            // col: 50 offset: 007c
            InstanceContentBuff = parser.ReadOffset< int >( 0x7c );

            // col: 2 offset: 0080
            TimeLimitmin = parser.ReadOffset< ushort >( 0x80 );

            // col: 4 offset: 0082
            BGM = parser.ReadOffset< ushort >( 0x82 );

            // col: 5 offset: 0084
            WinBGM = parser.ReadOffset< ushort >( 0x84 );

            // col: 8 offset: 0086
            Order = parser.ReadOffset< ushort >( 0x86 );

            // col: 16 offset: 0088
            SortKey = parser.ReadOffset< ushort >( 0x88 );

            // col: 58 offset: 008a
            unknown8a = parser.ReadOffset< ushort >( 0x8a );

            // col: 59 offset: 008c
            unknown8c = parser.ReadOffset< ushort >( 0x8c );

            // col: 52 offset: 008e
            unknown8e = parser.ReadOffset< short >( 0x8e );

            // col: 0 offset: 0090
            InstanceContentType = parser.ReadOffset< byte >( 0x90 );

            // col: 1 offset: 0091
            WeekRestriction = parser.ReadOffset< byte >( 0x91 );

            // col: 9 offset: 0092
            Colosseum = parser.ReadOffset< byte >( 0x92 );

            // col: 53 offset: 0093
            PartyCondition = parser.ReadOffset< byte >( 0x93 );

            // col: 54 offset: 0094
            unknown94 = parser.ReadOffset< byte >( 0x94 );

            // col: 55 offset: 0095
            unknown95 = parser.ReadOffset< byte >( 0x95 );

            // col: 56 offset: 0096
            unknown96 = parser.ReadOffset< byte >( 0x96 );

            // col: 3 offset: 0097
            packed97 = parser.ReadOffset< byte >( 0x97, ExcelColumnDataType.UInt8 );

            packed97_1 = ( packed97 & 0x1 ) == 0x1;
            packed97_2 = ( packed97 & 0x2 ) == 0x2;
            packed97_4 = ( packed97 & 0x4 ) == 0x4;


        }
    }
}