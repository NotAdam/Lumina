namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OpenContent", columnHash: 0xbdff33b7 )]
    public class OpenContent : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT

        /* offset: 0004 col: 0
         *  name: Content
         *  repeat count: 16
         */

        /* offset: 000c col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 003c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 004c col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0054 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 005c col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0064 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 006c col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0074 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 007c col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 16
         *  name: CandidateName
         *  repeat count: 16
         */

        /* offset: 0008 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 0048 col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 0050 col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0058 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0060 col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 0068 col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0070 col: 30
         *  no SaintCoinach definition found
         */

        /* offset: 0078 col: 31
         *  no SaintCoinach definition found
         */



        // col: 16 offset: 0000
        public uint[] CandidateName;

        // col: 00 offset: 0004
        public ushort[] Content;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 16 offset: 0000
            CandidateName = new uint[16];
            CandidateName[0] = parser.ReadOffset< uint >( 0x0 );
            CandidateName[1] = parser.ReadOffset< uint >( 0x8 );
            CandidateName[2] = parser.ReadOffset< uint >( 0x10 );
            CandidateName[3] = parser.ReadOffset< uint >( 0x18 );
            CandidateName[4] = parser.ReadOffset< uint >( 0x20 );
            CandidateName[5] = parser.ReadOffset< uint >( 0x28 );
            CandidateName[6] = parser.ReadOffset< uint >( 0x30 );
            CandidateName[7] = parser.ReadOffset< uint >( 0x38 );
            CandidateName[8] = parser.ReadOffset< uint >( 0x40 );
            CandidateName[9] = parser.ReadOffset< uint >( 0x48 );
            CandidateName[10] = parser.ReadOffset< uint >( 0x50 );
            CandidateName[11] = parser.ReadOffset< uint >( 0x58 );
            CandidateName[12] = parser.ReadOffset< uint >( 0x60 );
            CandidateName[13] = parser.ReadOffset< uint >( 0x68 );
            CandidateName[14] = parser.ReadOffset< uint >( 0x70 );
            CandidateName[15] = parser.ReadOffset< uint >( 0x78 );

            // col: 0 offset: 0004
            Content = new ushort[16];
            Content[0] = parser.ReadOffset< ushort >( 0x4 );
            Content[1] = parser.ReadOffset< ushort >( 0xc );
            Content[2] = parser.ReadOffset< ushort >( 0x14 );
            Content[3] = parser.ReadOffset< ushort >( 0x1c );
            Content[4] = parser.ReadOffset< ushort >( 0x24 );
            Content[5] = parser.ReadOffset< ushort >( 0x2c );
            Content[6] = parser.ReadOffset< ushort >( 0x34 );
            Content[7] = parser.ReadOffset< ushort >( 0x3c );
            Content[8] = parser.ReadOffset< ushort >( 0x44 );
            Content[9] = parser.ReadOffset< ushort >( 0x4c );
            Content[10] = parser.ReadOffset< ushort >( 0x54 );
            Content[11] = parser.ReadOffset< ushort >( 0x5c );
            Content[12] = parser.ReadOffset< ushort >( 0x64 );
            Content[13] = parser.ReadOffset< ushort >( 0x6c );
            Content[14] = parser.ReadOffset< ushort >( 0x74 );
            Content[15] = parser.ReadOffset< ushort >( 0x7c );


        }
    }
}