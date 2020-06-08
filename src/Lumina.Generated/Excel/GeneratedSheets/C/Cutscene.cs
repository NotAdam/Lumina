using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Cutscene", columnHash: 0x35b9ac80 )]
    public class Cutscene : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Path;

        // col: 04 offset: 0004
        public int unknown4;

        // col: 05 offset: 0008
        public int unknown8;

        // col: 06 offset: 000c
        public int unknownc;

        // col: 07 offset: 0010
        public int unknown10;

        // col: 01 offset: 0014
        public byte unknown14;

        // col: 02 offset: 0015
        public byte unknown15;

        // col: 03 offset: 0016
        public bool packed16_1;
        public byte packed16;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Path = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< int >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< int >( 0x8 );

            // col: 6 offset: 000c
            unknownc = parser.ReadOffset< int >( 0xc );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 1 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 2 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 3 offset: 0016
            packed16 = parser.ReadOffset< byte >( 0x16, ExcelColumnDataType.UInt8 );

            packed16_1 = ( packed16 & 0x1 ) == 0x1;


        }
    }
}