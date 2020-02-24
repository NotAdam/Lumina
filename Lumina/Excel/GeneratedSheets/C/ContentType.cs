namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentType", columnHash: 0xf75a9d4b )]
    public class ContentType : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Icon
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Icon{DutyFinder}
         *  type: 
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 000d col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000e col: 5
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public uint IconDutyFinder;

        // col: 03 offset: 000c
        public byte unknownc;

        // col: 04 offset: 000d
        public byte unknownd;

        // col: 05 offset: 000e
        public byte unknowne;


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
            IconDutyFinder = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 4 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 5 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );


        }
    }
}