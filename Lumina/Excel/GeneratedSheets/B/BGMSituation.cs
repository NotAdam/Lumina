namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSituation", columnHash: 0x64a88f98 )]
    public class BGMSituation : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: DaytimeID
         *  type: 
         */

        /* offset: 0002 col: 1
         *  name: NightID
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: BattleID
         *  type: 
         */

        /* offset: 0006 col: 3
         *  name: DaybreakID
         *  type: 
         */

        /* offset: 0008 col: 4
         *  name: TwilightID
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort DaytimeID;

        // col: 01 offset: 0002
        public ushort NightID;

        // col: 02 offset: 0004
        public ushort BattleID;

        // col: 03 offset: 0006
        public ushort DaybreakID;

        // col: 04 offset: 0008
        public ushort TwilightID;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            DaytimeID = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            NightID = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            BattleID = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            DaybreakID = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            TwilightID = parser.ReadOffset< ushort >( 0x8 );


        }
    }
}