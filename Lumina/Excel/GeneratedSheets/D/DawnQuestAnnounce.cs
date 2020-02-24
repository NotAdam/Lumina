namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestAnnounce", columnHash: 0xf8bddb48 )]
    public class DawnQuestAnnounce : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Quest
         *  type: 
         */

        /* offset: 001c col: 1
         *  name: Content
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: ENPC
         *  repeat count: 6
         */

        /* offset: 0008 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 7
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Quest;

        // col: 02 offset: 0004
        public uint[] ENPC;

        // col: 01 offset: 001c
        public byte Content;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            ENPC = new uint[6];
            ENPC[0] = parser.ReadOffset< uint >( 0x4 );
            ENPC[1] = parser.ReadOffset< uint >( 0x8 );
            ENPC[2] = parser.ReadOffset< uint >( 0xc );
            ENPC[3] = parser.ReadOffset< uint >( 0x10 );
            ENPC[4] = parser.ReadOffset< uint >( 0x14 );
            ENPC[5] = parser.ReadOffset< uint >( 0x18 );

            // col: 1 offset: 001c
            Content = parser.ReadOffset< byte >( 0x1c );


        }
    }
}