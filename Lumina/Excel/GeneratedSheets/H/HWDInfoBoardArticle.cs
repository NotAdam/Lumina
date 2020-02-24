namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticle", columnHash: 0x76cb5660 )]
    public class HWDInfoBoardArticle : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0006 col: 0
         *  name: Type
         *  type: 
         */

        /* offset: 0007 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 4
         *  name: Text
         *  type: 
         */



        // col: 04 offset: 0000
        public string Text;

        // col: 02 offset: 0004
        public ushort unknown4;

        // col: 00 offset: 0006
        public byte Type;

        // col: 01 offset: 0007
        public byte unknown7;

        // col: 03 offset: 0008
        private byte packed8;
        public bool packed8_1 => ( packed8 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            Type = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 3 offset: 0008
            packed8 = parser.ReadOffset< byte >( 0x8 );


        }
    }
}