namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMScene", columnHash: 0x2711a5ea )]
    public class BGMScene : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: EnableDisableRestart
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Resume
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: EnablePassEnd
         *  type: 
         */

        /* offset: 0000 col: 3
         *  name: ForceAutoReset
         *  type: 
         */

        /* offset: 0000 col: 4
         *  name: IgnoreBattle
         *  type: 
         */



        // col: 00 offset: 0000
        private byte packed0;
        public bool EnableDisableRestart => ( packed0 & 0x1 ) == 0x1;
        public bool Resume => ( packed0 & 0x2 ) == 0x2;
        public bool EnablePassEnd => ( packed0 & 0x4 ) == 0x4;
        public bool ForceAutoReset => ( packed0 & 0x8 ) == 0x8;
        public bool IgnoreBattle => ( packed0 & 0x10 ) == 0x10;


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