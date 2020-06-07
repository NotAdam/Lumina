using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "YardCatalogCategory", columnHash: 0xc8b7ab9b )]
    public class YardCatalogCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Category;

        // col: 01 offset: 0004
        public ushort unknown4;

        // col: 02 offset: 0006
        public byte unknown6;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Category = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );


        }
    }
}