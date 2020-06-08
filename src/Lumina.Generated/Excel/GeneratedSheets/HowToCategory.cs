using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowToCategory", columnHash: 0xdebb20e3 )]
    public class HowToCategory : IExcelRow
    {
        
        public string Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = parser.ReadColumn< string >( 0 );
        }
    }
}