using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastRankBonus", columnHash: 0x4d6cbdc3 )]
    public class BeastRankBonus : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 08 offset: 0000
        public uint Item;

        // col: 00 offset: 0004
        public ushort unknown4;

        // col: 01 offset: 0006
        public ushort unknown6;

        // col: 02 offset: 0008
        public ushort unknown8;

        // col: 03 offset: 000a
        public ushort unknowna;

        // col: 04 offset: 000c
        public ushort unknownc;

        // col: 05 offset: 000e
        public ushort unknowne;

        // col: 06 offset: 0010
        public ushort unknown10;

        // col: 07 offset: 0012
        public ushort unknown12;

        // col: 09 offset: 0014
        public byte[] ItemQuantity;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 8 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 5 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 6 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 7 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 9 offset: 0014
            ItemQuantity = new byte[8];
            ItemQuantity[0] = parser.ReadOffset< byte >( 0x14 );
            ItemQuantity[1] = parser.ReadOffset< byte >( 0x15 );
            ItemQuantity[2] = parser.ReadOffset< byte >( 0x16 );
            ItemQuantity[3] = parser.ReadOffset< byte >( 0x17 );
            ItemQuantity[4] = parser.ReadOffset< byte >( 0x18 );
            ItemQuantity[5] = parser.ReadOffset< byte >( 0x19 );
            ItemQuantity[6] = parser.ReadOffset< byte >( 0x1a );
            ItemQuantity[7] = parser.ReadOffset< byte >( 0x1b );


        }
    }
}