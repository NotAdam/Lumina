using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowToPage", columnHash: 0x006e1eac )]
    public class HowToPage : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public string unknown0;

        // col: 05 offset: 0004
        public string unknown4;

        // col: 06 offset: 0008
        public string unknown8;

        // col: 02 offset: 000c
        public int Image;

        // col: 00 offset: 0010
        public byte unknown10;

        // col: 01 offset: 0011
        public byte unknown11;

        // col: 03 offset: 0012
        public byte unknown12;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 5 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 6 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 2 offset: 000c
            Image = parser.ReadOffset< int >( 0xc );

            // col: 0 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 1 offset: 0011
            unknown11 = parser.ReadOffset< byte >( 0x11 );

            // col: 3 offset: 0012
            unknown12 = parser.ReadOffset< byte >( 0x12 );


        }
    }
}