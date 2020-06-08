using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderConditionTransient", columnHash: 0xdebb20e3 )]
    public class ContentFinderConditionTransient : IExcelRow
    {
        
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< string >( 0 );
        }
    }
}