namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Achievement", columnHash: 0x24bfffd6 )]
    public class Achievement : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0036 col: 0
         *  name: AchievementCategory
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Description
         *  type: 
         */

        /* offset: 0037 col: 3
         *  name: Points
         *  type: 
         */

        /* offset: 0030 col: 4
         *  name: Title
         *  type: 
         */

        /* offset: 0008 col: 5
         *  name: Item
         *  type: 
         */

        /* offset: 0032 col: 6
         *  name: Icon
         *  type: 
         */

        /* offset: 0038 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0039 col: 8
         *  name: Type
         *  type: 
         */

        /* offset: 000c col: 9
         *  name: Key
         *  type: 
         */

        /* offset: 0010 col: 10
         *  name: Data
         *  repeat count: 8
         */

        /* offset: 0014 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 18
         *  name: Order
         *  type: 
         */

        /* offset: 003a col: 19
         *  name: Padding
         *  type: 
         */

        /* offset: 003b col: 20
         *  name: AchievementHideCondition
         *  type: 
         */



        // col: 01 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public string Description;

        // col: 05 offset: 0008
        public uint Item;

        // col: 09 offset: 000c
        public int Key;

        // col: 10 offset: 0010
        public int[] Data;

        // col: 04 offset: 0030
        public ushort Title;

        // col: 06 offset: 0032
        public ushort Icon;

        // col: 18 offset: 0034
        public ushort Order;

        // col: 00 offset: 0036
        public byte AchievementCategory;

        // col: 03 offset: 0037
        public byte Points;

        // col: 07 offset: 0038
        public byte unknown38;

        // col: 08 offset: 0039
        public byte Type;

        // col: 19 offset: 003a
        public byte Padding;

        // col: 20 offset: 003b
        public byte AchievementHideCondition;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            Item = parser.ReadOffset< uint >( 0x8 );

            // col: 9 offset: 000c
            Key = parser.ReadOffset< int >( 0xc );

            // col: 10 offset: 0010
            Data = new int[8];
            Data[0] = parser.ReadOffset< int >( 0x10 );
            Data[1] = parser.ReadOffset< int >( 0x14 );
            Data[2] = parser.ReadOffset< int >( 0x18 );
            Data[3] = parser.ReadOffset< int >( 0x1c );
            Data[4] = parser.ReadOffset< int >( 0x20 );
            Data[5] = parser.ReadOffset< int >( 0x24 );
            Data[6] = parser.ReadOffset< int >( 0x28 );
            Data[7] = parser.ReadOffset< int >( 0x2c );

            // col: 4 offset: 0030
            Title = parser.ReadOffset< ushort >( 0x30 );

            // col: 6 offset: 0032
            Icon = parser.ReadOffset< ushort >( 0x32 );

            // col: 18 offset: 0034
            Order = parser.ReadOffset< ushort >( 0x34 );

            // col: 0 offset: 0036
            AchievementCategory = parser.ReadOffset< byte >( 0x36 );

            // col: 3 offset: 0037
            Points = parser.ReadOffset< byte >( 0x37 );

            // col: 7 offset: 0038
            unknown38 = parser.ReadOffset< byte >( 0x38 );

            // col: 8 offset: 0039
            Type = parser.ReadOffset< byte >( 0x39 );

            // col: 19 offset: 003a
            Padding = parser.ReadOffset< byte >( 0x3a );

            // col: 20 offset: 003b
            AchievementHideCondition = parser.ReadOffset< byte >( 0x3b );


        }
    }
}