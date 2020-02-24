namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishParameter", columnHash: 0x019385c9 )]
    public class FishParameter : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT

        /* offset: 0000 col: 0
         *  name: Text
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Item
         *  type: 
         */

        /* offset: 000c col: 2
         *  name: GatheringItemLevel
         *  type: 
         */

        /* offset: 0010 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0012 col: 4
         *  name: IsHidden
         *  type: 
         */

        /* offset: 0012 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0011 col: 6
         *  name: FishingRecordType
         *  type: 
         */

        /* offset: 0008 col: 7
         *  name: TerritoryType
         *  type: 
         */

        /* offset: 000e col: 8
         *  name: GatheringSubCategory
         *  type: 
         */

        /* offset: 0012 col: 9
         *  name: IsInLog
         *  type: 
         */

        /* offset: 0012 col: 10
         *  name: TimeRestricted
         *  type: 
         */

        /* offset: 0012 col: 11
         *  name: WeatherRestricted
         *  type: 
         */



        // col: 00 offset: 0000
        public string Text;

        // col: 01 offset: 0004
        public int Item;

        // col: 07 offset: 0008
        public int TerritoryType;

        // col: 02 offset: 000c
        public ushort GatheringItemLevel;

        // col: 08 offset: 000e
        public ushort GatheringSubCategory;

        // col: 03 offset: 0010
        public byte unknown10;

        // col: 06 offset: 0011
        public byte FishingRecordType;

        // col: 04 offset: 0012
        private byte packed12;
        public bool IsHidden => ( packed12 & 0x1 ) == 0x1;
        public bool packed12_2 => ( packed12 & 0x2 ) == 0x2;
        public bool IsInLog => ( packed12 & 0x4 ) == 0x4;
        public bool TimeRestricted => ( packed12 & 0x8 ) == 0x8;
        public bool WeatherRestricted => ( packed12 & 0x10 ) == 0x10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Item = parser.ReadOffset< int >( 0x4 );

            // col: 7 offset: 0008
            TerritoryType = parser.ReadOffset< int >( 0x8 );

            // col: 2 offset: 000c
            GatheringItemLevel = parser.ReadOffset< ushort >( 0xc );

            // col: 8 offset: 000e
            GatheringSubCategory = parser.ReadOffset< ushort >( 0xe );

            // col: 3 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 6 offset: 0011
            FishingRecordType = parser.ReadOffset< byte >( 0x11 );

            // col: 4 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12 );


        }
    }
}