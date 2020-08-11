// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementHideCondition", columnHash: 0x824c4ccf )]
    public class AchievementHideCondition : IExcelRow
    {
        
        public bool HideAchievement;
        public bool HideName;
        public bool HideConditions;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            HideAchievement = parser.ReadColumn< bool >( 0 );
            HideName = parser.ReadColumn< bool >( 1 );
            HideConditions = parser.ReadColumn< bool >( 2 );
        }
    }
}