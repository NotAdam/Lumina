namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Lobby", columnHash: 0x54075f2e )]
    public class Lobby : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT

        /* offset: 000c col: 0
         *  name: TYPE
         *  type: 
         */

        /* offset: 0010 col: 1
         *  name: PARAM
         *  type: 
         */

        /* offset: 0014 col: 2
         *  name: LINK
         *  type: 
         */

        /* offset: 0000 col: 3
         *  name: Text
         *  type: 
         */

        /* offset: 0004 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 5
         *  no SaintCoinach definition found
         */



        // col: 03 offset: 0000
        public string Text;

        // col: 04 offset: 0004
        public string unknown4;

        // col: 05 offset: 0008
        public string unknown8;

        // col: 00 offset: 000c
        public uint TYPE;

        // col: 01 offset: 0010
        public uint PARAM;

        // col: 02 offset: 0014
        public uint LINK;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 0 offset: 000c
            TYPE = parser.ReadOffset< uint >( 0xc );

            // col: 1 offset: 0010
            PARAM = parser.ReadOffset< uint >( 0x10 );

            // col: 2 offset: 0014
            LINK = parser.ReadOffset< uint >( 0x14 );


        }
    }
}