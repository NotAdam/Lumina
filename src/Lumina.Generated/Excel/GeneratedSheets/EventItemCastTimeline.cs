using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItemCastTimeline", columnHash: 0xdbf43666 )]
    public class EventItemCastTimeline : IExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< uint >( 0 ) );
        }
    }
}