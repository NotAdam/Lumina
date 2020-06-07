using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Calendar", columnHash: 0x005cfabb )]
    public class Calendar : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public byte[] Month;

        // col: 32 offset: 0001
        public byte[] Day;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Month = new byte[32];
            Month[0] = parser.ReadOffset< byte >( 0x0 );
            Month[1] = parser.ReadOffset< byte >( 0x2 );
            Month[2] = parser.ReadOffset< byte >( 0x4 );
            Month[3] = parser.ReadOffset< byte >( 0x6 );
            Month[4] = parser.ReadOffset< byte >( 0x8 );
            Month[5] = parser.ReadOffset< byte >( 0xa );
            Month[6] = parser.ReadOffset< byte >( 0xc );
            Month[7] = parser.ReadOffset< byte >( 0xe );
            Month[8] = parser.ReadOffset< byte >( 0x10 );
            Month[9] = parser.ReadOffset< byte >( 0x12 );
            Month[10] = parser.ReadOffset< byte >( 0x14 );
            Month[11] = parser.ReadOffset< byte >( 0x16 );
            Month[12] = parser.ReadOffset< byte >( 0x18 );
            Month[13] = parser.ReadOffset< byte >( 0x1a );
            Month[14] = parser.ReadOffset< byte >( 0x1c );
            Month[15] = parser.ReadOffset< byte >( 0x1e );
            Month[16] = parser.ReadOffset< byte >( 0x20 );
            Month[17] = parser.ReadOffset< byte >( 0x22 );
            Month[18] = parser.ReadOffset< byte >( 0x24 );
            Month[19] = parser.ReadOffset< byte >( 0x26 );
            Month[20] = parser.ReadOffset< byte >( 0x28 );
            Month[21] = parser.ReadOffset< byte >( 0x2a );
            Month[22] = parser.ReadOffset< byte >( 0x2c );
            Month[23] = parser.ReadOffset< byte >( 0x2e );
            Month[24] = parser.ReadOffset< byte >( 0x30 );
            Month[25] = parser.ReadOffset< byte >( 0x32 );
            Month[26] = parser.ReadOffset< byte >( 0x34 );
            Month[27] = parser.ReadOffset< byte >( 0x36 );
            Month[28] = parser.ReadOffset< byte >( 0x38 );
            Month[29] = parser.ReadOffset< byte >( 0x3a );
            Month[30] = parser.ReadOffset< byte >( 0x3c );
            Month[31] = parser.ReadOffset< byte >( 0x3e );

            // col: 32 offset: 0001
            Day = new byte[32];
            Day[0] = parser.ReadOffset< byte >( 0x1 );
            Day[1] = parser.ReadOffset< byte >( 0x3 );
            Day[2] = parser.ReadOffset< byte >( 0x5 );
            Day[3] = parser.ReadOffset< byte >( 0x7 );
            Day[4] = parser.ReadOffset< byte >( 0x9 );
            Day[5] = parser.ReadOffset< byte >( 0xb );
            Day[6] = parser.ReadOffset< byte >( 0xd );
            Day[7] = parser.ReadOffset< byte >( 0xf );
            Day[8] = parser.ReadOffset< byte >( 0x11 );
            Day[9] = parser.ReadOffset< byte >( 0x13 );
            Day[10] = parser.ReadOffset< byte >( 0x15 );
            Day[11] = parser.ReadOffset< byte >( 0x17 );
            Day[12] = parser.ReadOffset< byte >( 0x19 );
            Day[13] = parser.ReadOffset< byte >( 0x1b );
            Day[14] = parser.ReadOffset< byte >( 0x1d );
            Day[15] = parser.ReadOffset< byte >( 0x1f );
            Day[16] = parser.ReadOffset< byte >( 0x21 );
            Day[17] = parser.ReadOffset< byte >( 0x23 );
            Day[18] = parser.ReadOffset< byte >( 0x25 );
            Day[19] = parser.ReadOffset< byte >( 0x27 );
            Day[20] = parser.ReadOffset< byte >( 0x29 );
            Day[21] = parser.ReadOffset< byte >( 0x2b );
            Day[22] = parser.ReadOffset< byte >( 0x2d );
            Day[23] = parser.ReadOffset< byte >( 0x2f );
            Day[24] = parser.ReadOffset< byte >( 0x31 );
            Day[25] = parser.ReadOffset< byte >( 0x33 );
            Day[26] = parser.ReadOffset< byte >( 0x35 );
            Day[27] = parser.ReadOffset< byte >( 0x37 );
            Day[28] = parser.ReadOffset< byte >( 0x39 );
            Day[29] = parser.ReadOffset< byte >( 0x3b );
            Day[30] = parser.ReadOffset< byte >( 0x3d );
            Day[31] = parser.ReadOffset< byte >( 0x3f );


        }
    }
}