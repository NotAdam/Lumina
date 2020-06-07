using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Picture", columnHash: 0xfaedad07 )]
    public class Picture : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Item;

        // col: 01 offset: 0004
        public int Image;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            Image = parser.ReadOffset< int >( 0x4 );


        }
    }
}