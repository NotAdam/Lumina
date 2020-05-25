using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItem", columnHash: 0x00035bbe )]
    public class LeveRewardItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort[] unknown0;

        // col: 08 offset: 0008
        public ushort unknown8;

        // col: 10 offset: 000a
        public ushort unknowna;

        // col: 12 offset: 000c
        public ushort unknownc;

        // col: 14 offset: 000e
        public ushort unknowne;

        // col: 09 offset: 0014
        public byte unknown14;

        // col: 11 offset: 0015
        public byte unknown15;

        // col: 13 offset: 0016
        public byte unknown16;

        // col: 15 offset: 0017
        public byte unknown17;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = new ushort[8];
            unknown0[0] = parser.ReadOffset< ushort >( 0x0 );
            unknown0[1] = parser.ReadOffset< ushort >( 0x10 );
            unknown0[2] = parser.ReadOffset< ushort >( 0x2 );
            unknown0[3] = parser.ReadOffset< ushort >( 0x11 );
            unknown0[4] = parser.ReadOffset< ushort >( 0x4 );
            unknown0[5] = parser.ReadOffset< ushort >( 0x12 );
            unknown0[6] = parser.ReadOffset< ushort >( 0x6 );
            unknown0[7] = parser.ReadOffset< ushort >( 0x13 );

            // col: 8 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 10 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 12 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 14 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 9 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 11 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 13 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 15 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );


        }
    }
}