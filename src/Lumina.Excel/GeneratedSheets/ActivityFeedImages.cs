// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedImages", columnHash: 0x530c5199 )]
    public partial class ActivityFeedImages : ExcelRow
    {
        
        public SeString ExpansionImage { get; set; }
        public SeString ActivityFeedJA { get; set; }
        public SeString ActivityFeedEN { get; set; }
        public SeString ActivityFeedDE { get; set; }
        public SeString ActivityFeedFR { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ExpansionImage = parser.ReadColumn< SeString >( 0 );
            ActivityFeedJA = parser.ReadColumn< SeString >( 1 );
            ActivityFeedEN = parser.ReadColumn< SeString >( 2 );
            ActivityFeedDE = parser.ReadColumn< SeString >( 3 );
            ActivityFeedFR = parser.ReadColumn< SeString >( 4 );
        }
    }
}