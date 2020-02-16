namespace Lumina.Excel.GeneratedSheets
{
    [SheetName( "AchievementCategory" )]
    public class AchievementCategory : IExcelRow
    {
        // col: 0 offset: 0000
        public string Name;

        // col: 1 offset: 0004
        public byte AchievementKind;

        // col: 4 offset: 0005
        public byte unknown5;

        // col: 2 offset: 0006
        private byte packed6;
        public bool ShowComplete => ( packed6 & 0x1 ) == 0x1;
        public bool HideCategory => ( packed6 & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            AchievementKind = parser.ReadOffset< byte >( 0x4 );

            // col: 4 offset: 0005
            unknown5 = parser.ReadOffset< byte >( 0x5 );

            // col: 2 offset: 0006
            packed6 = parser.ReadOffset< byte >( 0x6 );


        }
    }
}