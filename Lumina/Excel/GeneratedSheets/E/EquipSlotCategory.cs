namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EquipSlotCategory", columnHash: 0xf4ab6454 )]
    public class EquipSlotCategory : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: MainHand
         *  type: 
         */

        /* offset: 0001 col: 1
         *  name: OffHand
         *  type: 
         */

        /* offset: 0002 col: 2
         *  name: Head
         *  type: 
         */

        /* offset: 0003 col: 3
         *  name: Body
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: Gloves
         *  type: 
         */

        /* offset: 0005 col: 5
         *  name: Waist
         *  type: 
         */

        /* offset: 0006 col: 6
         *  name: Legs
         *  type: 
         */

        /* offset: 0007 col: 7
         *  name: Feet
         *  type: 
         */

        /* offset: 0008 col: 8
         *  name: Ears
         *  type: 
         */

        /* offset: 0009 col: 9
         *  name: Neck
         *  type: 
         */

        /* offset: 000a col: 10
         *  name: Wrists
         *  type: 
         */

        /* offset: 000b col: 11
         *  name: FingerL
         *  type: 
         */

        /* offset: 000c col: 12
         *  name: FingerR
         *  type: 
         */

        /* offset: 000d col: 13
         *  name: SoulCrystal
         *  type: 
         */



        // col: 00 offset: 0000
        public sbyte MainHand;

        // col: 01 offset: 0001
        public sbyte OffHand;

        // col: 02 offset: 0002
        public sbyte Head;

        // col: 03 offset: 0003
        public sbyte Body;

        // col: 04 offset: 0004
        public sbyte Gloves;

        // col: 05 offset: 0005
        public sbyte Waist;

        // col: 06 offset: 0006
        public sbyte Legs;

        // col: 07 offset: 0007
        public sbyte Feet;

        // col: 08 offset: 0008
        public sbyte Ears;

        // col: 09 offset: 0009
        public sbyte Neck;

        // col: 10 offset: 000a
        public sbyte Wrists;

        // col: 11 offset: 000b
        public sbyte FingerL;

        // col: 12 offset: 000c
        public sbyte FingerR;

        // col: 13 offset: 000d
        public sbyte SoulCrystal;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            MainHand = parser.ReadOffset< sbyte >( 0x0 );

            // col: 1 offset: 0001
            OffHand = parser.ReadOffset< sbyte >( 0x1 );

            // col: 2 offset: 0002
            Head = parser.ReadOffset< sbyte >( 0x2 );

            // col: 3 offset: 0003
            Body = parser.ReadOffset< sbyte >( 0x3 );

            // col: 4 offset: 0004
            Gloves = parser.ReadOffset< sbyte >( 0x4 );

            // col: 5 offset: 0005
            Waist = parser.ReadOffset< sbyte >( 0x5 );

            // col: 6 offset: 0006
            Legs = parser.ReadOffset< sbyte >( 0x6 );

            // col: 7 offset: 0007
            Feet = parser.ReadOffset< sbyte >( 0x7 );

            // col: 8 offset: 0008
            Ears = parser.ReadOffset< sbyte >( 0x8 );

            // col: 9 offset: 0009
            Neck = parser.ReadOffset< sbyte >( 0x9 );

            // col: 10 offset: 000a
            Wrists = parser.ReadOffset< sbyte >( 0xa );

            // col: 11 offset: 000b
            FingerL = parser.ReadOffset< sbyte >( 0xb );

            // col: 12 offset: 000c
            FingerR = parser.ReadOffset< sbyte >( 0xc );

            // col: 13 offset: 000d
            SoulCrystal = parser.ReadOffset< sbyte >( 0xd );


        }
    }
}