using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xd4d62b80 )]
    public class World : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public byte UserType;

        // col: 02 offset: 0005
        public byte DataCenter;

        // col: 03 offset: 0006
        private byte packed6;
        public bool IsPublic => ( packed6 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            UserType = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            DataCenter = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            packed6 = parser.ReadOffset< byte >( 0x6, ExcelColumnDataType.UInt8 );


        }
    }
}