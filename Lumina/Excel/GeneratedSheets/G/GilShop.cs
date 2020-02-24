namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShop", columnHash: 0xa0969241 )]
    public class GilShop : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Icon
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Quest
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: AcceptTalk
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: FailTalk
         *  type: 
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public uint Quest;

        // col: 03 offset: 000c
        public int AcceptTalk;

        // col: 04 offset: 0010
        public int FailTalk;

        // col: 05 offset: 0014
        private byte packed14;
        public bool packed14_1 => ( packed14 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Quest = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            AcceptTalk = parser.ReadOffset< int >( 0xc );

            // col: 4 offset: 0010
            FailTalk = parser.ReadOffset< int >( 0x10 );

            // col: 5 offset: 0014
            packed14 = parser.ReadOffset< byte >( 0x14 );


        }
    }
}