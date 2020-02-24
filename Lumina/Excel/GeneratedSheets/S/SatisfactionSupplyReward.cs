using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionSupplyReward", columnHash: 0xc81395f9 )]
    public class SatisfactionSupplyReward : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public ushort[] unknown0;

        // col: 03 offset: 0004
        public ushort unknown4;

        // col: 04 offset: 0006
        public ushort unknown6;

        // col: 05 offset: 0008
        public ushort unknown8;

        // col: 06 offset: 000a
        public ushort unknowna;

        // col: 07 offset: 000c
        public ushort unknownc;

        // col: 08 offset: 000e
        public ushort unknowne;

        // col: 10 offset: 0010
        public ushort SatisfactionLow;

        // col: 11 offset: 0012
        public ushort SatisfactionMid;

        // col: 12 offset: 0014
        public ushort SatisfactionHigh;

        // col: 13 offset: 0016
        public ushort GilLow;

        // col: 14 offset: 0018
        public ushort GilMid;

        // col: 15 offset: 001a
        public ushort GilHigh;

        // col: 00 offset: 001c
        public byte unknown1c;

        // col: 09 offset: 001d
        public byte unknown1d;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            unknown0 = new ushort[2];
            unknown0[0] = parser.ReadOffset< ushort >( 0x0 );
            unknown0[1] = parser.ReadOffset< ushort >( 0x2 );

            // col: 3 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 4 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 7 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 8 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 10 offset: 0010
            SatisfactionLow = parser.ReadOffset< ushort >( 0x10 );

            // col: 11 offset: 0012
            SatisfactionMid = parser.ReadOffset< ushort >( 0x12 );

            // col: 12 offset: 0014
            SatisfactionHigh = parser.ReadOffset< ushort >( 0x14 );

            // col: 13 offset: 0016
            GilLow = parser.ReadOffset< ushort >( 0x16 );

            // col: 14 offset: 0018
            GilMid = parser.ReadOffset< ushort >( 0x18 );

            // col: 15 offset: 001a
            GilHigh = parser.ReadOffset< ushort >( 0x1a );

            // col: 0 offset: 001c
            unknown1c = parser.ReadOffset< byte >( 0x1c );

            // col: 9 offset: 001d
            unknown1d = parser.ReadOffset< byte >( 0x1d );


        }
    }
}