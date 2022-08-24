// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementCategory", columnHash: 0xb98d9baf )]
    public partial class AchievementCategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< AchievementKind > AchievementKind { get; set; }
        public bool ShowComplete { get; set; }
        public bool HideCategory { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            AchievementKind = new LazyRow< AchievementKind >( gameData, parser.ReadColumn< byte >( 1 ), language );
            ShowComplete = parser.ReadColumn< bool >( 2 );
            HideCategory = parser.ReadColumn< bool >( 3 );
            Order = parser.ReadColumn< byte >( 4 );
        }
    }
}