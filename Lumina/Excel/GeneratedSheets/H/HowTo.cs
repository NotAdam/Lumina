using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowTo", columnHash: 0xe4488448 )]
    public class HowTo : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string unknown0;

        // col: 02 offset: 0004
        public short[] Images;

        // col: 13 offset: 0018
        public byte unknown18;

        // col: 12 offset: 0019
        public sbyte Category;

        // col: 01 offset: 001a
        public bool packed1a_1;
        public byte packed1a;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Images = new short[10];
            Images[0] = parser.ReadOffset< short >( 0x4 );
            Images[1] = parser.ReadOffset< short >( 0x6 );
            Images[2] = parser.ReadOffset< short >( 0x8 );
            Images[3] = parser.ReadOffset< short >( 0xa );
            Images[4] = parser.ReadOffset< short >( 0xc );
            Images[5] = parser.ReadOffset< short >( 0xe );
            Images[6] = parser.ReadOffset< short >( 0x10 );
            Images[7] = parser.ReadOffset< short >( 0x12 );
            Images[8] = parser.ReadOffset< short >( 0x14 );
            Images[9] = parser.ReadOffset< short >( 0x16 );

            // col: 13 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 12 offset: 0019
            Category = parser.ReadOffset< sbyte >( 0x19 );

            // col: 1 offset: 001a
            packed1a = parser.ReadOffset< byte >( 0x1a, ExcelColumnDataType.UInt8 );

            packed1a_1 = ( packed1a & 0x1 ) == 0x1;


        }
    }
}