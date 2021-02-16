// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementCategory", columnHash: 0xb98d9baf )]
    public class AchievementCategory : ExcelRow
    {
        
        public SeString Name;
        public LazyRow< AchievementKind > AchievementKind;
        public bool ShowComplete;
        public bool HideCategory;
        public byte Order;
        

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