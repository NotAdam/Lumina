namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DescriptionPage", columnHash: 0xe7fa61e4 )]
    public class DescriptionPage : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Quest
         *  type: 
         */

        /* offset: 0030 col: 1
         *  name: Text[1]
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Image[1]
         *  type: 
         */

        /* offset: 0032 col: 3
         *  name: Text[2]
         *  type: 
         */

        /* offset: 0008 col: 4
         *  name: Image[2]
         *  type: 
         */

        /* offset: 0034 col: 5
         *  name: Text[3]
         *  type: 
         */

        /* offset: 000c col: 6
         *  name: Image[3]
         *  type: 
         */

        /* offset: 0036 col: 7
         *  name: Text[4]
         *  type: 
         */

        /* offset: 0010 col: 8
         *  name: Image[4]
         *  type: 
         */

        /* offset: 0038 col: 9
         *  name: Text[5]
         *  type: 
         */

        /* offset: 0014 col: 10
         *  name: Image[5]
         *  type: 
         */

        /* offset: 003a col: 11
         *  name: Text[6]
         *  type: 
         */

        /* offset: 0018 col: 12
         *  name: Image[6]
         *  type: 
         */

        /* offset: 003c col: 13
         *  name: Text[7]
         *  type: 
         */

        /* offset: 001c col: 14
         *  name: Image[7]
         *  type: 
         */

        /* offset: 003e col: 15
         *  name: Text[8]
         *  type: 
         */

        /* offset: 0020 col: 16
         *  name: Image[8]
         *  type: 
         */

        /* offset: 0040 col: 17
         *  name: Text[9]
         *  type: 
         */

        /* offset: 0024 col: 18
         *  name: Image[9]
         *  type: 
         */

        /* offset: 0042 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 0046 col: 23
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Quest;

        // col: 02 offset: 0004
        public uint Image1;

        // col: 04 offset: 0008
        public uint Image2;

        // col: 06 offset: 000c
        public uint Image3;

        // col: 08 offset: 0010
        public uint Image4;

        // col: 10 offset: 0014
        public uint Image5;

        // col: 12 offset: 0018
        public uint Image6;

        // col: 14 offset: 001c
        public uint Image7;

        // col: 16 offset: 0020
        public uint Image8;

        // col: 18 offset: 0024
        public uint Image9;

        // col: 20 offset: 0028
        public uint unknown28;

        // col: 22 offset: 002c
        public uint unknown2c;

        // col: 01 offset: 0030
        public ushort Text1;

        // col: 03 offset: 0032
        public ushort Text2;

        // col: 05 offset: 0034
        public ushort Text3;

        // col: 07 offset: 0036
        public ushort Text4;

        // col: 09 offset: 0038
        public ushort Text5;

        // col: 11 offset: 003a
        public ushort Text6;

        // col: 13 offset: 003c
        public ushort Text7;

        // col: 15 offset: 003e
        public ushort Text8;

        // col: 17 offset: 0040
        public ushort Text9;

        // col: 19 offset: 0042
        public ushort unknown42;

        // col: 21 offset: 0044
        public ushort unknown44;

        // col: 23 offset: 0046
        public ushort unknown46;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            Image1 = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            Image2 = parser.ReadOffset< uint >( 0x8 );

            // col: 6 offset: 000c
            Image3 = parser.ReadOffset< uint >( 0xc );

            // col: 8 offset: 0010
            Image4 = parser.ReadOffset< uint >( 0x10 );

            // col: 10 offset: 0014
            Image5 = parser.ReadOffset< uint >( 0x14 );

            // col: 12 offset: 0018
            Image6 = parser.ReadOffset< uint >( 0x18 );

            // col: 14 offset: 001c
            Image7 = parser.ReadOffset< uint >( 0x1c );

            // col: 16 offset: 0020
            Image8 = parser.ReadOffset< uint >( 0x20 );

            // col: 18 offset: 0024
            Image9 = parser.ReadOffset< uint >( 0x24 );

            // col: 20 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 22 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 1 offset: 0030
            Text1 = parser.ReadOffset< ushort >( 0x30 );

            // col: 3 offset: 0032
            Text2 = parser.ReadOffset< ushort >( 0x32 );

            // col: 5 offset: 0034
            Text3 = parser.ReadOffset< ushort >( 0x34 );

            // col: 7 offset: 0036
            Text4 = parser.ReadOffset< ushort >( 0x36 );

            // col: 9 offset: 0038
            Text5 = parser.ReadOffset< ushort >( 0x38 );

            // col: 11 offset: 003a
            Text6 = parser.ReadOffset< ushort >( 0x3a );

            // col: 13 offset: 003c
            Text7 = parser.ReadOffset< ushort >( 0x3c );

            // col: 15 offset: 003e
            Text8 = parser.ReadOffset< ushort >( 0x3e );

            // col: 17 offset: 0040
            Text9 = parser.ReadOffset< ushort >( 0x40 );

            // col: 19 offset: 0042
            unknown42 = parser.ReadOffset< ushort >( 0x42 );

            // col: 21 offset: 0044
            unknown44 = parser.ReadOffset< ushort >( 0x44 );

            // col: 23 offset: 0046
            unknown46 = parser.ReadOffset< ushort >( 0x46 );


        }
    }
}