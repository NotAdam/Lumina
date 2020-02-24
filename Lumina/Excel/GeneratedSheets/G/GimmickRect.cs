namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickRect", columnHash: 0x9be6d434 )]
    public class GimmickRect : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: LayoutID
         *  type: 
         */

        /* offset: 0024 col: 1
         *  name: TriggerIn
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Param0
         *  type: 
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

        /* offset: 0025 col: 6
         *  name: TriggerOut
         *  type: 
         */

        /* offset: 0014 col: 7
         *  name: Param1
         *  type: 
         */

        /* offset: 0018 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 10
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint LayoutID;

        // col: 02 offset: 0004
        public uint Param0;

        // col: 03 offset: 0008
        public uint unknown8;

        // col: 04 offset: 000c
        public uint unknownc;

        // col: 05 offset: 0010
        public uint unknown10;

        // col: 07 offset: 0014
        public uint Param1;

        // col: 08 offset: 0018
        public uint unknown18;

        // col: 09 offset: 001c
        public uint unknown1c;

        // col: 10 offset: 0020
        public uint unknown20;

        // col: 01 offset: 0024
        public byte TriggerIn;

        // col: 06 offset: 0025
        public byte TriggerOut;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            LayoutID = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            Param0 = parser.ReadOffset< uint >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 5 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 7 offset: 0014
            Param1 = parser.ReadOffset< uint >( 0x14 );

            // col: 8 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 9 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 10 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 1 offset: 0024
            TriggerIn = parser.ReadOffset< byte >( 0x24 );

            // col: 6 offset: 0025
            TriggerOut = parser.ReadOffset< byte >( 0x25 );


        }
    }
}