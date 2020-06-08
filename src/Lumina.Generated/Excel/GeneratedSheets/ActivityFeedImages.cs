using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedImages", columnHash: 0x530c5199 )]
    public class ActivityFeedImages : IExcelRow
    {
        
        public string ExpansionImage;
        public string ActivityFeedJA;
        public string ActivityFeedEN;
        public string ActivityFeedDE;
        public string ActivityFeedFR;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpansionImage = parser.ReadColumn< string >( 0 );
            ActivityFeedJA = parser.ReadColumn< string >( 1 );
            ActivityFeedEN = parser.ReadColumn< string >( 2 );
            ActivityFeedDE = parser.ReadColumn< string >( 3 );
            ActivityFeedFR = parser.ReadColumn< string >( 4 );
        }
    }
}