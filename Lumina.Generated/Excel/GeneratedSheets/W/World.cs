using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xd4d62b80 )]
    public class World : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public byte UserType;

        // col: 02 offset: 0005
        public byte DataCenter;

        // col: 03 offset: 0006
        public bool IsPublic;
        public byte packed6;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

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

            IsPublic = ( packed6 & 0x1 ) == 0x1;


        }
    }
}