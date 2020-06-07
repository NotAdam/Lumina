using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickAccessor", columnHash: 0xc4f527f3 )]
    public class GimmickAccessor : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint Param1;

        // col: 02 offset: 0004
        public uint Param2;

        // col: 03 offset: 0008
        public uint Type;

        // col: 04 offset: 000c
        public uint unknownc;

        // col: 05 offset: 0010
        public uint unknown10;

        // col: 06 offset: 0014
        public uint unknown14;

        // col: 00 offset: 0018
        public int Param0;

        // col: 07 offset: 001c
        public bool packed1c_1;
        public byte packed1c;
        public bool packed1c_2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Param1 = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            Param2 = parser.ReadOffset< uint >( 0x4 );

            // col: 3 offset: 0008
            Type = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 5 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 6 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 0 offset: 0018
            Param0 = parser.ReadOffset< int >( 0x18 );

            // col: 7 offset: 001c
            packed1c = parser.ReadOffset< byte >( 0x1c, ExcelColumnDataType.UInt8 );

            packed1c_1 = ( packed1c & 0x1 ) == 0x1;
            packed1c_2 = ( packed1c & 0x2 ) == 0x2;


        }
    }
}