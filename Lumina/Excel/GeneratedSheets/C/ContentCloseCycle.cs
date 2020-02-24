namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentCloseCycle", columnHash: 0xd3032cdb )]
    public class ContentCloseCycle : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Unixtime
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Time{Seconds}
         *  type: 
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
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

        /* offset: 000f col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0011 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0013 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0015 col: 12
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Unixtime;

        // col: 01 offset: 0004
        public uint TimeSeconds;

        // col: 02 offset: 0008
        public uint unknown8;

        // col: 03 offset: 000c
        public bool unknownc;

        // col: 04 offset: 000d
        public bool unknownd;

        // col: 05 offset: 000e
        public bool unknowne;

        // col: 06 offset: 000f
        public bool unknownf;

        // col: 07 offset: 0010
        public bool unknown10;

        // col: 08 offset: 0011
        public bool unknown11;

        // col: 09 offset: 0012
        public bool unknown12;

        // col: 10 offset: 0013
        public bool unknown13;

        // col: 11 offset: 0014
        public bool unknown14;

        // col: 12 offset: 0015
        public bool unknown15;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Unixtime = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            TimeSeconds = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< bool >( 0xc );

            // col: 4 offset: 000d
            unknownd = parser.ReadOffset< bool >( 0xd );

            // col: 5 offset: 000e
            unknowne = parser.ReadOffset< bool >( 0xe );

            // col: 6 offset: 000f
            unknownf = parser.ReadOffset< bool >( 0xf );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< bool >( 0x10 );

            // col: 8 offset: 0011
            unknown11 = parser.ReadOffset< bool >( 0x11 );

            // col: 9 offset: 0012
            unknown12 = parser.ReadOffset< bool >( 0x12 );

            // col: 10 offset: 0013
            unknown13 = parser.ReadOffset< bool >( 0x13 );

            // col: 11 offset: 0014
            unknown14 = parser.ReadOffset< bool >( 0x14 );

            // col: 12 offset: 0015
            unknown15 = parser.ReadOffset< bool >( 0x15 );


        }
    }
}