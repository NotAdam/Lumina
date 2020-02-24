namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGM", columnHash: 0xc9fc6953 )]
    public class BGM : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: File
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Priority
         *  type: 
         */

        /* offset: 000a col: 2
         *  name: DisableRestartTimeOut
         *  type: 
         */

        /* offset: 000a col: 3
         *  name: DisableRestart
         *  type: 
         */

        /* offset: 000a col: 4
         *  name: PassEnd
         *  type: 
         */

        /* offset: 0004 col: 5
         *  name: DisableRestartResetTime
         *  type: 
         */

        /* offset: 0009 col: 6
         *  name: SpecialMode
         *  type: 
         */



        // col: 00 offset: 0000
        public string File;

        // col: 05 offset: 0004
        public float DisableRestartResetTime;

        // col: 01 offset: 0008
        public byte Priority;

        // col: 06 offset: 0009
        public byte SpecialMode;

        // col: 02 offset: 000a
        private byte packeda;
        public bool DisableRestartTimeOut => ( packeda & 0x1 ) == 0x1;
        public bool DisableRestart => ( packeda & 0x2 ) == 0x2;
        public bool PassEnd => ( packeda & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            File = parser.ReadOffset< string >( 0x0 );

            // col: 5 offset: 0004
            DisableRestartResetTime = parser.ReadOffset< float >( 0x4 );

            // col: 1 offset: 0008
            Priority = parser.ReadOffset< byte >( 0x8 );

            // col: 6 offset: 0009
            SpecialMode = parser.ReadOffset< byte >( 0x9 );

            // col: 2 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa );


        }
    }
}