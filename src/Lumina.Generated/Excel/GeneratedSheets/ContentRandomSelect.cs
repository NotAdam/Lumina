using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRandomSelect", columnHash: 0xd870e208 )]
    public class ContentRandomSelect : IExcelRow
    {
        
        public LazyRow< ContentFinderCondition > Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 0 ) );
        }
    }
}