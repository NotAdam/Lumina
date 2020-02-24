using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShop", columnHash: 0xf12dc1ea )]
    public class DisposalShop : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string ShopName;

        // col: 01 offset: 0004
        public int unknown4;

        // col: 09 offset: 0008
        public ushort unknown8;

        // col: 02 offset: 000c
        public int unknownc;

        // col: 10 offset: 0010
        public ushort unknown10;

        // col: 03 offset: 0014
        public int unknown14;

        // col: 11 offset: 0018
        public ushort unknown18;

        // col: 04 offset: 001c
        public int unknown1c;

        // col: 12 offset: 0020
        public ushort unknown20;

        // col: 05 offset: 0024
        public int unknown24;

        // col: 13 offset: 0028
        public ushort unknown28;

        // col: 06 offset: 002c
        public int unknown2c;

        // col: 14 offset: 0030
        public ushort unknown30;

        // col: 07 offset: 0034
        public int unknown34;

        // col: 15 offset: 0038
        public ushort unknown38;

        // col: 08 offset: 003c
        public int unknown3c;

        // col: 16 offset: 0040
        public ushort unknown40;

        // col: 17 offset: 0044
        private byte packed44;
        public bool packed44_1 => ( packed44 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ShopName = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< int >( 0x4 );

            // col: 9 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 2 offset: 000c
            unknownc = parser.ReadOffset< int >( 0xc );

            // col: 10 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 3 offset: 0014
            unknown14 = parser.ReadOffset< int >( 0x14 );

            // col: 11 offset: 0018
            unknown18 = parser.ReadOffset< ushort >( 0x18 );

            // col: 4 offset: 001c
            unknown1c = parser.ReadOffset< int >( 0x1c );

            // col: 12 offset: 0020
            unknown20 = parser.ReadOffset< ushort >( 0x20 );

            // col: 5 offset: 0024
            unknown24 = parser.ReadOffset< int >( 0x24 );

            // col: 13 offset: 0028
            unknown28 = parser.ReadOffset< ushort >( 0x28 );

            // col: 6 offset: 002c
            unknown2c = parser.ReadOffset< int >( 0x2c );

            // col: 14 offset: 0030
            unknown30 = parser.ReadOffset< ushort >( 0x30 );

            // col: 7 offset: 0034
            unknown34 = parser.ReadOffset< int >( 0x34 );

            // col: 15 offset: 0038
            unknown38 = parser.ReadOffset< ushort >( 0x38 );

            // col: 8 offset: 003c
            unknown3c = parser.ReadOffset< int >( 0x3c );

            // col: 16 offset: 0040
            unknown40 = parser.ReadOffset< ushort >( 0x40 );

            // col: 17 offset: 0044
            packed44 = parser.ReadOffset< byte >( 0x44, ExcelColumnDataType.UInt8 );


        }
    }
}