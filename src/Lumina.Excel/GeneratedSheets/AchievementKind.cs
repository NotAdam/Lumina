// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementKind", columnHash: 0x9ff65ad6 )]
    public partial class AchievementKind : ExcelRow
    {
        
        public SeString Name { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Order = parser.ReadColumn< byte >( 1 );
        }
    }
}