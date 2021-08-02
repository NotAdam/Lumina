// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedCaptions", columnHash: 0x776ee24c )]
    public partial class ActivityFeedCaptions : ExcelRow
    {
        
        public SeString JA { get; set; }
        public SeString EN { get; set; }
        public SeString DE { get; set; }
        public SeString FR { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            JA = parser.ReadColumn< SeString >( 0 );
            EN = parser.ReadColumn< SeString >( 1 );
            DE = parser.ReadColumn< SeString >( 2 );
            FR = parser.ReadColumn< SeString >( 3 );
        }
    }
}