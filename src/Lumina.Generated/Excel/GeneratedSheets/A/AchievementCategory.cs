using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementCategory", columnHash: 0xb98d9baf )]
    public class AchievementCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public byte AchievementKind;

        // col: 04 offset: 0005
        public byte Order;

        // col: 02 offset: 0006
        public bool ShowComplete;
        public byte packed6;
        public bool HideCategory;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            AchievementKind = parser.ReadOffset< byte >( 0x4 );

            // col: 4 offset: 0005
            Order = parser.ReadOffset< byte >( 0x5 );

            // col: 2 offset: 0006
            packed6 = parser.ReadOffset< byte >( 0x6, ExcelColumnDataType.UInt8 );

            ShowComplete = ( packed6 & 0x1 ) == 0x1;
            HideCategory = ( packed6 & 0x2 ) == 0x2;


        }
    }
}