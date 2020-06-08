using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemPoint", columnHash: 0xdbf43666 )]
    public class GatheringItemPoint : IExcelRow
    {
        
        public LazyRow< GatheringPoint > GatheringPoint;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GatheringPoint = new LazyRow< GatheringPoint >( lumina, parser.ReadColumn< uint >( 0 ) );
        }
    }
}