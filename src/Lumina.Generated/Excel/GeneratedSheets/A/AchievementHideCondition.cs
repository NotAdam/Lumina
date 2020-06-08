using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementHideCondition", columnHash: 0x824c4ccf )]
    public class AchievementHideCondition : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public bool HideAchievement;
        public byte packed0;
        public bool HideName;
        public bool HideConditions;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            packed0 = parser.ReadOffset< byte >( 0x0, ExcelColumnDataType.UInt8 );

            HideAchievement = ( packed0 & 0x1 ) == 0x1;
            HideName = ( packed0 & 0x2 ) == 0x2;
            HideConditions = ( packed0 & 0x4 ) == 0x4;


        }
    }
}