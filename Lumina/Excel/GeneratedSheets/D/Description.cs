using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Description", columnHash: 0x1933868c )]
    public class Description : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT


        // col: 01 offset: 0000
        public string TextLong;

        // col: 02 offset: 0004
        public string TextShort;

        // col: 03 offset: 0008
        public string TextCommentary;

        // col: 00 offset: 000c
        public uint Quest;

        // col: 05 offset: 0010
        public uint Section;

        // col: 04 offset: 0014
        private byte packed14;
        public bool packed14_1 => ( packed14 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            TextLong = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            TextShort = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            TextCommentary = parser.ReadOffset< string >( 0x8 );

            // col: 0 offset: 000c
            Quest = parser.ReadOffset< uint >( 0xc );

            // col: 5 offset: 0010
            Section = parser.ReadOffset< uint >( 0x10 );

            // col: 4 offset: 0014
            packed14 = parser.ReadOffset< byte >( 0x14, ExcelColumnDataType.UInt8 );


        }
    }
}