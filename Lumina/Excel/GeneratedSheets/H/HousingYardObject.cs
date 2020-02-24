namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingYardObject", columnHash: 0xe15fd4d0 )]
    public class HousingYardObject : IExcelRow
    {
        // column defs from Fri, 28 Jun 2019 17:13:11 GMT

        /* offset: 000c col: 0
         *  name: ModelKey
         *  type: 
         */

        /* offset: 000d col: 1
         *  name: HousingItemCategory
         *  type: 
         */

        /* offset: 000e col: 2
         *  name: UsageType
         *  type: 
         */

        /* offset: 0000 col: 3
         *  name: UsageParameter
         *  type: 
         */

        /* offset: 000f col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 5
         *  name: CustomTalk
         *  type: 
         */

        /* offset: 0008 col: 6
         *  name: Item
         *  type: 
         */

        /* offset: 0013 col: 7
         *  name: DestroyOnRemoval
         *  type: 
         */

        /* offset: 0013 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0013 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0011 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 0013 col: 13
         *  no SaintCoinach definition found
         */



        // col: 03 offset: 0000
        public uint UsageParameter;

        // col: 05 offset: 0004
        public uint CustomTalk;

        // col: 06 offset: 0008
        public uint Item;

        // col: 00 offset: 000c
        public byte ModelKey;

        // col: 01 offset: 000d
        public byte HousingItemCategory;

        // col: 02 offset: 000e
        public byte UsageType;

        // col: 04 offset: 000f
        public byte unknownf;

        // col: 10 offset: 0010
        public byte unknown10;

        // col: 11 offset: 0011
        public byte unknown11;

        // col: 12 offset: 0012
        public byte unknown12;

        // col: 07 offset: 0013
        private byte packed13;
        public bool DestroyOnRemoval => ( packed13 & 0x1 ) == 0x1;
        public bool packed13_2 => ( packed13 & 0x2 ) == 0x2;
        public bool packed13_4 => ( packed13 & 0x4 ) == 0x4;
        public bool packed13_8 => ( packed13 & 0x8 ) == 0x8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            UsageParameter = parser.ReadOffset< uint >( 0x0 );

            // col: 5 offset: 0004
            CustomTalk = parser.ReadOffset< uint >( 0x4 );

            // col: 6 offset: 0008
            Item = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            ModelKey = parser.ReadOffset< byte >( 0xc );

            // col: 1 offset: 000d
            HousingItemCategory = parser.ReadOffset< byte >( 0xd );

            // col: 2 offset: 000e
            UsageType = parser.ReadOffset< byte >( 0xe );

            // col: 4 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 10 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 11 offset: 0011
            unknown11 = parser.ReadOffset< byte >( 0x11 );

            // col: 12 offset: 0012
            unknown12 = parser.ReadOffset< byte >( 0x12 );

            // col: 7 offset: 0013
            packed13 = parser.ReadOffset< byte >( 0x13 );


        }
    }
}