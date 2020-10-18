// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedImages", columnHash: 0x530c5199 )]
    public class ActivityFeedImages : IExcelRow
    {
        
        public SeString ExpansionImage;
        public SeString ActivityFeedJA;
        public SeString ActivityFeedEN;
        public SeString ActivityFeedDE;
        public SeString ActivityFeedFR;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpansionImage = parser.ReadColumn< SeString >( 0 );
            ActivityFeedJA = parser.ReadColumn< SeString >( 1 );
            ActivityFeedEN = parser.ReadColumn< SeString >( 2 );
            ActivityFeedDE = parser.ReadColumn< SeString >( 3 );
            ActivityFeedFR = parser.ReadColumn< SeString >( 4 );
        }
    }
}