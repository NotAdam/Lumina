namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringSubCategory", columnHash: 0x6dac8145 )]
    public class GatheringSubCategory : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 000e col: 0
         *  name: GatheringType
         *  type: 
         */

        /* offset: 000f col: 1
         *  name: ClassJob
         *  type: 
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  name: Division
         *  type: 
         */

        /* offset: 0008 col: 4
         *  name: Item
         *  type: 
         */

        /* offset: 0000 col: 5
         *  name: FolkloreBook
         *  type: 
         */

        /* offset: 0010 col: 6
         *  no SaintCoinach definition found
         */



        // col: 05 offset: 0000
        public string FolkloreBook;

        // col: 02 offset: 0004
        public uint unknown4;

        // col: 04 offset: 0008
        public int Item;

        // col: 03 offset: 000c
        public ushort Division;

        // col: 00 offset: 000e
        public byte GatheringType;

        // col: 01 offset: 000f
        public byte ClassJob;

        // col: 06 offset: 0010
        public byte unknown10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            FolkloreBook = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            Item = parser.ReadOffset< int >( 0x8 );

            // col: 3 offset: 000c
            Division = parser.ReadOffset< ushort >( 0xc );

            // col: 0 offset: 000e
            GatheringType = parser.ReadOffset< byte >( 0xe );

            // col: 1 offset: 000f
            ClassJob = parser.ReadOffset< byte >( 0xf );

            // col: 6 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );


        }
    }
}