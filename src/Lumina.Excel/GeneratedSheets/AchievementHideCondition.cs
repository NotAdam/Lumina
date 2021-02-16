// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementHideCondition", columnHash: 0x824c4ccf )]
    public class AchievementHideCondition : ExcelRow
    {
        
        public bool HideAchievement;
        public bool HideName;
        public bool HideConditions;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            HideAchievement = parser.ReadColumn< bool >( 0 );
            HideName = parser.ReadColumn< bool >( 1 );
            HideConditions = parser.ReadColumn< bool >( 2 );
        }
    }
}