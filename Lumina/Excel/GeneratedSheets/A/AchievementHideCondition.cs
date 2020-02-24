namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementHideCondition", columnHash: 0x824c4ccf )]
    public class AchievementHideCondition : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT

        /* offset: 0000 col: 0
         *  name: HideAchievement
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: HideName
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: HideConditions
         *  type: 
         */



        // col: 00 offset: 0000
        private byte packed0;
        public bool HideAchievement => ( packed0 & 0x1 ) == 0x1;
        public bool HideName => ( packed0 & 0x2 ) == 0x2;
        public bool HideConditions => ( packed0 & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            packed0 = parser.ReadOffset< byte >( 0x0 );


        }
    }
}