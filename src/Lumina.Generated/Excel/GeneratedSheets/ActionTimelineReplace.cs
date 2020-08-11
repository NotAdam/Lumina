// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimelineReplace", columnHash: 0x2020acf6 )]
    public class ActionTimelineReplace : IExcelRow
    {
        
        public LazyRow< ActionTimeline > Old;
        public LazyRow< ActionTimeline > New;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Old = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            New = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}