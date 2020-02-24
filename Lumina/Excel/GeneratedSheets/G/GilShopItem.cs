using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShopItem", columnHash: 0x2f7317fe )]
    public class GilShopItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public int Item;

        // col: 02 offset: 0004
        public int unknown4;

        // col: 03 offset: 0008
        public int[] RowRequired;

        // col: 07 offset: 0014
        public ushort StateRequired;

        // col: 08 offset: 0016
        public ushort Patch;

        // col: 06 offset: 0018
        public byte unknown18;

        // col: 01 offset: 0019
        private byte packed19;
        public bool packed19_1 => ( packed19 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< int >( 0x4 );

            // col: 3 offset: 0008
            RowRequired = new int[3];
            RowRequired[0] = parser.ReadOffset< int >( 0x8 );
            RowRequired[1] = parser.ReadOffset< int >( 0xc );
            RowRequired[2] = parser.ReadOffset< int >( 0x10 );

            // col: 7 offset: 0014
            StateRequired = parser.ReadOffset< ushort >( 0x14 );

            // col: 8 offset: 0016
            Patch = parser.ReadOffset< ushort >( 0x16 );

            // col: 6 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 1 offset: 0019
            packed19 = parser.ReadOffset< byte >( 0x19, ExcelColumnDataType.UInt8 );


        }
    }
}