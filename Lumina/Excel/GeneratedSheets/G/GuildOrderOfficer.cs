namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildOrderOfficer", columnHash: 0xa76e50e1 )]
    public class GuildOrderOfficer : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint unknown0;

        // col: 01 offset: 0004
        public uint unknown4;

        // col: 02 offset: 0008
        public uint unknown8;

        // col: 03 offset: 000c
        public uint unknownc;

        // col: 04 offset: 0010
        public uint unknown10;

        // col: 05 offset: 0014
        public uint unknown14;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 5 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );


        }
    }
}