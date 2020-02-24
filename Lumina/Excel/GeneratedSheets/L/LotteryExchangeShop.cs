using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LotteryExchangeShop", columnHash: 0xea26200e )]
    public class LotteryExchangeShop : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string unknown0;

        // col: 17 offset: 0004
        public uint[] AmountAccepted;

        // col: 01 offset: 0008
        public int[] ItemAccepted;

        // col: 33 offset: 000c
        public byte unknownc;

        // col: 34 offset: 0018
        public byte unknown18;

        // col: 35 offset: 0024
        public byte unknown24;

        // col: 36 offset: 0030
        public byte unknown30;

        // col: 37 offset: 003c
        public byte unknown3c;

        // col: 38 offset: 0048
        public byte unknown48;

        // col: 39 offset: 0054
        public byte unknown54;

        // col: 40 offset: 0060
        public byte unknown60;

        // col: 41 offset: 006c
        public byte unknown6c;

        // col: 42 offset: 0078
        public byte unknown78;

        // col: 43 offset: 0084
        public byte unknown84;

        // col: 44 offset: 0090
        public byte unknown90;

        // col: 45 offset: 009c
        public byte unknown9c;

        // col: 46 offset: 00a8
        public byte unknowna8;

        // col: 47 offset: 00b4
        public byte unknownb4;

        // col: 48 offset: 00c0
        public byte unknownc0;

        // col: 49 offset: 00c4
        public string unknownc4;

        // col: 50 offset: 00c8
        private byte packedc8;
        public bool packedc8_1 => ( packedc8 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 17 offset: 0004
            AmountAccepted = new uint[16];
            AmountAccepted[0] = parser.ReadOffset< uint >( 0x4 );
            AmountAccepted[1] = parser.ReadOffset< uint >( 0x10 );
            AmountAccepted[2] = parser.ReadOffset< uint >( 0x1c );
            AmountAccepted[3] = parser.ReadOffset< uint >( 0x28 );
            AmountAccepted[4] = parser.ReadOffset< uint >( 0x34 );
            AmountAccepted[5] = parser.ReadOffset< uint >( 0x40 );
            AmountAccepted[6] = parser.ReadOffset< uint >( 0x4c );
            AmountAccepted[7] = parser.ReadOffset< uint >( 0x58 );
            AmountAccepted[8] = parser.ReadOffset< uint >( 0x64 );
            AmountAccepted[9] = parser.ReadOffset< uint >( 0x70 );
            AmountAccepted[10] = parser.ReadOffset< uint >( 0x7c );
            AmountAccepted[11] = parser.ReadOffset< uint >( 0x88 );
            AmountAccepted[12] = parser.ReadOffset< uint >( 0x94 );
            AmountAccepted[13] = parser.ReadOffset< uint >( 0xa0 );
            AmountAccepted[14] = parser.ReadOffset< uint >( 0xac );
            AmountAccepted[15] = parser.ReadOffset< uint >( 0xb8 );

            // col: 1 offset: 0008
            ItemAccepted = new int[16];
            ItemAccepted[0] = parser.ReadOffset< int >( 0x8 );
            ItemAccepted[1] = parser.ReadOffset< int >( 0x14 );
            ItemAccepted[2] = parser.ReadOffset< int >( 0x20 );
            ItemAccepted[3] = parser.ReadOffset< int >( 0x2c );
            ItemAccepted[4] = parser.ReadOffset< int >( 0x38 );
            ItemAccepted[5] = parser.ReadOffset< int >( 0x44 );
            ItemAccepted[6] = parser.ReadOffset< int >( 0x50 );
            ItemAccepted[7] = parser.ReadOffset< int >( 0x5c );
            ItemAccepted[8] = parser.ReadOffset< int >( 0x68 );
            ItemAccepted[9] = parser.ReadOffset< int >( 0x74 );
            ItemAccepted[10] = parser.ReadOffset< int >( 0x80 );
            ItemAccepted[11] = parser.ReadOffset< int >( 0x8c );
            ItemAccepted[12] = parser.ReadOffset< int >( 0x98 );
            ItemAccepted[13] = parser.ReadOffset< int >( 0xa4 );
            ItemAccepted[14] = parser.ReadOffset< int >( 0xb0 );
            ItemAccepted[15] = parser.ReadOffset< int >( 0xbc );

            // col: 33 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 34 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 35 offset: 0024
            unknown24 = parser.ReadOffset< byte >( 0x24 );

            // col: 36 offset: 0030
            unknown30 = parser.ReadOffset< byte >( 0x30 );

            // col: 37 offset: 003c
            unknown3c = parser.ReadOffset< byte >( 0x3c );

            // col: 38 offset: 0048
            unknown48 = parser.ReadOffset< byte >( 0x48 );

            // col: 39 offset: 0054
            unknown54 = parser.ReadOffset< byte >( 0x54 );

            // col: 40 offset: 0060
            unknown60 = parser.ReadOffset< byte >( 0x60 );

            // col: 41 offset: 006c
            unknown6c = parser.ReadOffset< byte >( 0x6c );

            // col: 42 offset: 0078
            unknown78 = parser.ReadOffset< byte >( 0x78 );

            // col: 43 offset: 0084
            unknown84 = parser.ReadOffset< byte >( 0x84 );

            // col: 44 offset: 0090
            unknown90 = parser.ReadOffset< byte >( 0x90 );

            // col: 45 offset: 009c
            unknown9c = parser.ReadOffset< byte >( 0x9c );

            // col: 46 offset: 00a8
            unknowna8 = parser.ReadOffset< byte >( 0xa8 );

            // col: 47 offset: 00b4
            unknownb4 = parser.ReadOffset< byte >( 0xb4 );

            // col: 48 offset: 00c0
            unknownc0 = parser.ReadOffset< byte >( 0xc0 );

            // col: 49 offset: 00c4
            unknownc4 = parser.ReadOffset< string >( 0xc4 );

            // col: 50 offset: 00c8
            packedc8 = parser.ReadOffset< byte >( 0xc8, ExcelColumnDataType.UInt8 );


        }
    }
}