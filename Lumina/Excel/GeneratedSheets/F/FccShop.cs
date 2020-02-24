namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FccShop", columnHash: 0x21a0d047 )]
    public class FccShop : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: 
         *  repeat count: 10
         */

        /* offset: 0010 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 004c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0058 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0064 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0070 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 11
         *  name: 
         *  repeat count: 10
         */

        /* offset: 0014 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0050 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 005c col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0068 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0074 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 21
         *  name: 
         *  repeat count: 10
         */

        /* offset: 0018 col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 003c col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 0048 col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0054 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0060 col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 006c col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0078 col: 30
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public uint[] unknown4;

        // col: 11 offset: 0008
        public uint[] unknown8;

        // col: 21 offset: 000c
        public byte[] unknownc;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = new uint[10];
            unknown4[0] = parser.ReadOffset< uint >( 0x4 );
            unknown4[1] = parser.ReadOffset< uint >( 0x10 );
            unknown4[2] = parser.ReadOffset< uint >( 0x1c );
            unknown4[3] = parser.ReadOffset< uint >( 0x28 );
            unknown4[4] = parser.ReadOffset< uint >( 0x34 );
            unknown4[5] = parser.ReadOffset< uint >( 0x40 );
            unknown4[6] = parser.ReadOffset< uint >( 0x4c );
            unknown4[7] = parser.ReadOffset< uint >( 0x58 );
            unknown4[8] = parser.ReadOffset< uint >( 0x64 );
            unknown4[9] = parser.ReadOffset< uint >( 0x70 );

            // col: 11 offset: 0008
            unknown8 = new uint[10];
            unknown8[0] = parser.ReadOffset< uint >( 0x8 );
            unknown8[1] = parser.ReadOffset< uint >( 0x14 );
            unknown8[2] = parser.ReadOffset< uint >( 0x20 );
            unknown8[3] = parser.ReadOffset< uint >( 0x2c );
            unknown8[4] = parser.ReadOffset< uint >( 0x38 );
            unknown8[5] = parser.ReadOffset< uint >( 0x44 );
            unknown8[6] = parser.ReadOffset< uint >( 0x50 );
            unknown8[7] = parser.ReadOffset< uint >( 0x5c );
            unknown8[8] = parser.ReadOffset< uint >( 0x68 );
            unknown8[9] = parser.ReadOffset< uint >( 0x74 );

            // col: 21 offset: 000c
            unknownc = new byte[10];
            unknownc[0] = parser.ReadOffset< byte >( 0xc );
            unknownc[1] = parser.ReadOffset< byte >( 0x18 );
            unknownc[2] = parser.ReadOffset< byte >( 0x24 );
            unknownc[3] = parser.ReadOffset< byte >( 0x30 );
            unknownc[4] = parser.ReadOffset< byte >( 0x3c );
            unknownc[5] = parser.ReadOffset< byte >( 0x48 );
            unknownc[6] = parser.ReadOffset< byte >( 0x54 );
            unknownc[7] = parser.ReadOffset< byte >( 0x60 );
            unknownc[8] = parser.ReadOffset< byte >( 0x6c );
            unknownc[9] = parser.ReadOffset< byte >( 0x78 );


        }
    }
}