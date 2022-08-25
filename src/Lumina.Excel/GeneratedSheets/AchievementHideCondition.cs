// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementHideCondition", columnHash: 0x0e90be06 )]
    public partial class AchievementHideCondition : ExcelRow
    {
        
        public bool HideAchievement { get; set; }
        public bool HideName { get; set; }
        public bool HideConditions { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            HideAchievement = parser.ReadColumn< bool >( 0 );
            HideName = parser.ReadColumn< bool >( 1 );
            HideConditions = parser.ReadColumn< bool >( 2 );
        }
    }
}