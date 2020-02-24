namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsNote", columnHash: 0x748963d8 )]
    public class ContentsNote : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0024 col: 0
         *  name: ContentType
         *  type: 
         */

        /* offset: 000c col: 1
         *  name: Icon
         *  type: 
         */

        /* offset: 0025 col: 2
         *  name: MenuOrder
         *  type: 
         */

        /* offset: 0010 col: 3
         *  name: RequiredAmount
         *  type: 
         */

        /* offset: 0026 col: 4
         *  name: Reward[0]
         *  type: 
         */

        /* offset: 0014 col: 5
         *  name: ExpMultiplier
         *  type: 
         */

        /* offset: 0027 col: 6
         *  name: Reward[1]
         *  type: 
         */

        /* offset: 0018 col: 7
         *  name: GilRward
         *  type: 
         */

        /* offset: 0020 col: 8
         *  name: LevelUnlock
         *  type: 
         */

        /* offset: 0022 col: 9
         *  name: HowTo
         *  type: 
         */

        /* offset: 0008 col: 10
         *  name: ReqUnlock
         *  type: 
         */

        /* offset: 0000 col: 11
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 12
         *  name: Description
         *  type: 
         */

        /* offset: 001c col: 13
         *  name: ExpCap
         *  type: 
         */



        // col: 11 offset: 0000
        public string Name;

        // col: 12 offset: 0004
        public string Description;

        // col: 10 offset: 0008
        public uint ReqUnlock;

        // col: 01 offset: 000c
        public int Icon;

        // col: 03 offset: 0010
        public int RequiredAmount;

        // col: 05 offset: 0014
        public int ExpMultiplier;

        // col: 07 offset: 0018
        public int GilRward;

        // col: 13 offset: 001c
        public int ExpCap;

        // col: 08 offset: 0020
        public ushort LevelUnlock;

        // col: 09 offset: 0022
        public ushort HowTo;

        // col: 00 offset: 0024
        public byte ContentType;

        // col: 02 offset: 0025
        public byte MenuOrder;

        // col: 04 offset: 0026
        public byte Reward0;

        // col: 06 offset: 0027
        public byte Reward1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 11 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 12 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 10 offset: 0008
            ReqUnlock = parser.ReadOffset< uint >( 0x8 );

            // col: 1 offset: 000c
            Icon = parser.ReadOffset< int >( 0xc );

            // col: 3 offset: 0010
            RequiredAmount = parser.ReadOffset< int >( 0x10 );

            // col: 5 offset: 0014
            ExpMultiplier = parser.ReadOffset< int >( 0x14 );

            // col: 7 offset: 0018
            GilRward = parser.ReadOffset< int >( 0x18 );

            // col: 13 offset: 001c
            ExpCap = parser.ReadOffset< int >( 0x1c );

            // col: 8 offset: 0020
            LevelUnlock = parser.ReadOffset< ushort >( 0x20 );

            // col: 9 offset: 0022
            HowTo = parser.ReadOffset< ushort >( 0x22 );

            // col: 0 offset: 0024
            ContentType = parser.ReadOffset< byte >( 0x24 );

            // col: 2 offset: 0025
            MenuOrder = parser.ReadOffset< byte >( 0x25 );

            // col: 4 offset: 0026
            Reward0 = parser.ReadOffset< byte >( 0x26 );

            // col: 6 offset: 0027
            Reward1 = parser.ReadOffset< byte >( 0x27 );


        }
    }
}