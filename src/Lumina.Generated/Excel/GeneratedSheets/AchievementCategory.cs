using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementCategory", columnHash: 0xb98d9baf )]
    public class AchievementCategory : IExcelRow
    {
        
        public string Name;
        public LazyRow< AchievementKind > AchievementKind;
        public bool ShowComplete;
        public bool HideCategory;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            AchievementKind = new LazyRow< AchievementKind >( lumina, parser.ReadColumn< byte >( 1 ) );
            ShowComplete = parser.ReadColumn< bool >( 2 );
            HideCategory = parser.ReadColumn< bool >( 3 );
            Order = parser.ReadColumn< byte >( 4 );
        }
    }
}