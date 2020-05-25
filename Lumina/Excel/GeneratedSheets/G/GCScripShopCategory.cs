using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCScripShopCategory", columnHash: 0x9b330d8a )]
    public class GCScripShopCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public sbyte GrandCompany;

        // col: 01 offset: 0001
        public sbyte Tier;

        // col: 02 offset: 0002
        public sbyte SubCategory;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            GrandCompany = parser.ReadOffset< sbyte >( 0x0 );

            // col: 1 offset: 0001
            Tier = parser.ReadOffset< sbyte >( 0x1 );

            // col: 2 offset: 0002
            SubCategory = parser.ReadOffset< sbyte >( 0x2 );


        }
    }
}