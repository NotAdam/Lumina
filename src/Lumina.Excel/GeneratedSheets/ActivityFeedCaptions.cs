// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedCaptions", columnHash: 0x776ee24c )]
    public class ActivityFeedCaptions : ExcelRow
    {
        
        public SeString JA;
        public SeString EN;
        public SeString DE;
        public SeString FR;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            JA = parser.ReadColumn< SeString >( 0 );
            EN = parser.ReadColumn< SeString >( 1 );
            DE = parser.ReadColumn< SeString >( 2 );
            FR = parser.ReadColumn< SeString >( 3 );
        }
    }
}