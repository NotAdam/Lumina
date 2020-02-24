using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedo", columnHash: 0x35f497dd )]
    public class QuestRedo : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 18:15:43 GMT


        // col: 03 offset: 0000
        public uint[] Quest;

        // col: 35 offset: 0004
        public byte unknown4;

        // col: 36 offset: 000c
        public byte unknownc;

        // col: 37 offset: 0014
        public byte unknown14;

        // col: 38 offset: 001c
        public byte unknown1c;

        // col: 39 offset: 0024
        public byte unknown24;

        // col: 40 offset: 002c
        public byte unknown2c;

        // col: 41 offset: 0034
        public byte unknown34;

        // col: 42 offset: 003c
        public byte unknown3c;

        // col: 43 offset: 0044
        public byte unknown44;

        // col: 44 offset: 004c
        public byte unknown4c;

        // col: 45 offset: 0054
        public byte unknown54;

        // col: 46 offset: 005c
        public byte unknown5c;

        // col: 47 offset: 0064
        public byte unknown64;

        // col: 48 offset: 006c
        public byte unknown6c;

        // col: 49 offset: 0074
        public byte unknown74;

        // col: 50 offset: 007c
        public byte unknown7c;

        // col: 51 offset: 0084
        public byte unknown84;

        // col: 52 offset: 008c
        public byte unknown8c;

        // col: 53 offset: 0094
        public byte unknown94;

        // col: 54 offset: 009c
        public byte unknown9c;

        // col: 55 offset: 00a4
        public byte unknowna4;

        // col: 56 offset: 00ac
        public byte unknownac;

        // col: 57 offset: 00b4
        public byte unknownb4;

        // col: 58 offset: 00bc
        public byte unknownbc;

        // col: 59 offset: 00c4
        public byte unknownc4;

        // col: 60 offset: 00cc
        public byte unknowncc;

        // col: 61 offset: 00d4
        public byte unknownd4;

        // col: 62 offset: 00dc
        public byte unknowndc;

        // col: 63 offset: 00e4
        public byte unknowne4;

        // col: 64 offset: 00ec
        public byte unknownec;

        // col: 65 offset: 00f4
        public byte unknownf4;

        // col: 66 offset: 00fc
        public byte unknownfc;

        // col: 00 offset: 0100
        public uint FinalQuest;

        // col: 02 offset: 0104
        public ushort Chapter;

        // col: 01 offset: 0106
        public byte unknown106;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Quest = new uint[32];
            Quest[0] = parser.ReadOffset< uint >( 0x0 );
            Quest[1] = parser.ReadOffset< uint >( 0x8 );
            Quest[2] = parser.ReadOffset< uint >( 0x10 );
            Quest[3] = parser.ReadOffset< uint >( 0x18 );
            Quest[4] = parser.ReadOffset< uint >( 0x20 );
            Quest[5] = parser.ReadOffset< uint >( 0x28 );
            Quest[6] = parser.ReadOffset< uint >( 0x30 );
            Quest[7] = parser.ReadOffset< uint >( 0x38 );
            Quest[8] = parser.ReadOffset< uint >( 0x40 );
            Quest[9] = parser.ReadOffset< uint >( 0x48 );
            Quest[10] = parser.ReadOffset< uint >( 0x50 );
            Quest[11] = parser.ReadOffset< uint >( 0x58 );
            Quest[12] = parser.ReadOffset< uint >( 0x60 );
            Quest[13] = parser.ReadOffset< uint >( 0x68 );
            Quest[14] = parser.ReadOffset< uint >( 0x70 );
            Quest[15] = parser.ReadOffset< uint >( 0x78 );
            Quest[16] = parser.ReadOffset< uint >( 0x80 );
            Quest[17] = parser.ReadOffset< uint >( 0x88 );
            Quest[18] = parser.ReadOffset< uint >( 0x90 );
            Quest[19] = parser.ReadOffset< uint >( 0x98 );
            Quest[20] = parser.ReadOffset< uint >( 0xa0 );
            Quest[21] = parser.ReadOffset< uint >( 0xa8 );
            Quest[22] = parser.ReadOffset< uint >( 0xb0 );
            Quest[23] = parser.ReadOffset< uint >( 0xb8 );
            Quest[24] = parser.ReadOffset< uint >( 0xc0 );
            Quest[25] = parser.ReadOffset< uint >( 0xc8 );
            Quest[26] = parser.ReadOffset< uint >( 0xd0 );
            Quest[27] = parser.ReadOffset< uint >( 0xd8 );
            Quest[28] = parser.ReadOffset< uint >( 0xe0 );
            Quest[29] = parser.ReadOffset< uint >( 0xe8 );
            Quest[30] = parser.ReadOffset< uint >( 0xf0 );
            Quest[31] = parser.ReadOffset< uint >( 0xf8 );

            // col: 35 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );

            // col: 36 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 37 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 38 offset: 001c
            unknown1c = parser.ReadOffset< byte >( 0x1c );

            // col: 39 offset: 0024
            unknown24 = parser.ReadOffset< byte >( 0x24 );

            // col: 40 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 41 offset: 0034
            unknown34 = parser.ReadOffset< byte >( 0x34 );

            // col: 42 offset: 003c
            unknown3c = parser.ReadOffset< byte >( 0x3c );

            // col: 43 offset: 0044
            unknown44 = parser.ReadOffset< byte >( 0x44 );

            // col: 44 offset: 004c
            unknown4c = parser.ReadOffset< byte >( 0x4c );

            // col: 45 offset: 0054
            unknown54 = parser.ReadOffset< byte >( 0x54 );

            // col: 46 offset: 005c
            unknown5c = parser.ReadOffset< byte >( 0x5c );

            // col: 47 offset: 0064
            unknown64 = parser.ReadOffset< byte >( 0x64 );

            // col: 48 offset: 006c
            unknown6c = parser.ReadOffset< byte >( 0x6c );

            // col: 49 offset: 0074
            unknown74 = parser.ReadOffset< byte >( 0x74 );

            // col: 50 offset: 007c
            unknown7c = parser.ReadOffset< byte >( 0x7c );

            // col: 51 offset: 0084
            unknown84 = parser.ReadOffset< byte >( 0x84 );

            // col: 52 offset: 008c
            unknown8c = parser.ReadOffset< byte >( 0x8c );

            // col: 53 offset: 0094
            unknown94 = parser.ReadOffset< byte >( 0x94 );

            // col: 54 offset: 009c
            unknown9c = parser.ReadOffset< byte >( 0x9c );

            // col: 55 offset: 00a4
            unknowna4 = parser.ReadOffset< byte >( 0xa4 );

            // col: 56 offset: 00ac
            unknownac = parser.ReadOffset< byte >( 0xac );

            // col: 57 offset: 00b4
            unknownb4 = parser.ReadOffset< byte >( 0xb4 );

            // col: 58 offset: 00bc
            unknownbc = parser.ReadOffset< byte >( 0xbc );

            // col: 59 offset: 00c4
            unknownc4 = parser.ReadOffset< byte >( 0xc4 );

            // col: 60 offset: 00cc
            unknowncc = parser.ReadOffset< byte >( 0xcc );

            // col: 61 offset: 00d4
            unknownd4 = parser.ReadOffset< byte >( 0xd4 );

            // col: 62 offset: 00dc
            unknowndc = parser.ReadOffset< byte >( 0xdc );

            // col: 63 offset: 00e4
            unknowne4 = parser.ReadOffset< byte >( 0xe4 );

            // col: 64 offset: 00ec
            unknownec = parser.ReadOffset< byte >( 0xec );

            // col: 65 offset: 00f4
            unknownf4 = parser.ReadOffset< byte >( 0xf4 );

            // col: 66 offset: 00fc
            unknownfc = parser.ReadOffset< byte >( 0xfc );

            // col: 0 offset: 0100
            FinalQuest = parser.ReadOffset< uint >( 0x100 );

            // col: 2 offset: 0104
            Chapter = parser.ReadOffset< ushort >( 0x104 );

            // col: 1 offset: 0106
            unknown106 = parser.ReadOffset< byte >( 0x106 );


        }
    }
}