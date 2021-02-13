// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementKind", columnHash: 0x9ff65ad6 )]
    public class AchievementKind : ExcelRow
    {
        
        public SeString Name;
        public byte Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Order = parser.ReadColumn< byte >( 1 );
        }
    }
}