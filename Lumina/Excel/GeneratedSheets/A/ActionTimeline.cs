namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimeline", columnHash: 0x7402d920 )]
    public class ActionTimeline : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0006 col: 0
         *  name: Type
         *  type: 
         */

        /* offset: 0007 col: 1
         *  name: Priority
         *  type: 
         */

        /* offset: 0011 col: 2
         *  name: Pause
         *  type: 
         */

        /* offset: 0008 col: 3
         *  name: Stance
         *  type: 
         */

        /* offset: 0009 col: 4
         *  name: Slot
         *  type: 
         */

        /* offset: 000a col: 5
         *  name: LookAtMode
         *  type: 
         */

        /* offset: 0000 col: 6
         *  name: Key
         *  type: 
         */

        /* offset: 000b col: 7
         *  name: ActionTimelineIDMode
         *  type: 
         */

        /* offset: 000c col: 8
         *  name: WeaponTimeline
         *  type: 
         */

        /* offset: 000d col: 9
         *  name: LoadType
         *  type: 
         */

        /* offset: 000e col: 10
         *  name: StartAttach
         *  type: 
         */

        /* offset: 000f col: 11
         *  name: ResidentPap
         *  type: 
         */

        /* offset: 0011 col: 12
         *  name: Resident
         *  type: 
         */

        /* offset: 0004 col: 13
         *  name: KillUpper
         *  type: 
         */

        /* offset: 0011 col: 14
         *  name: IsMotionCanceledByMoving
         *  type: 
         */

        /* offset: 0011 col: 15
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 16
         *  name: IsLoop
         *  type: 
         */

        /* offset: 0011 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 0011 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0011 col: 19
         *  no SaintCoinach definition found
         */



        // col: 06 offset: 0000
        public string Key;

        // col: 13 offset: 0004
        public ushort KillUpper;

        // col: 00 offset: 0006
        public byte Type;

        // col: 01 offset: 0007
        public byte Priority;

        // col: 03 offset: 0008
        public byte Stance;

        // col: 04 offset: 0009
        public byte Slot;

        // col: 05 offset: 000a
        public byte LookAtMode;

        // col: 07 offset: 000b
        public byte ActionTimelineIDMode;

        // col: 08 offset: 000c
        public byte WeaponTimeline;

        // col: 09 offset: 000d
        public byte LoadType;

        // col: 10 offset: 000e
        public byte StartAttach;

        // col: 11 offset: 000f
        public byte ResidentPap;

        // col: 16 offset: 0010
        public byte IsLoop;

        // col: 02 offset: 0011
        private byte packed11;
        public bool Pause => ( packed11 & 0x1 ) == 0x1;
        public bool Resident => ( packed11 & 0x2 ) == 0x2;
        public bool IsMotionCanceledByMoving => ( packed11 & 0x4 ) == 0x4;
        public bool packed11_8 => ( packed11 & 0x8 ) == 0x8;
        public bool packed11_10 => ( packed11 & 0x10 ) == 0x10;
        public bool packed11_20 => ( packed11 & 0x20 ) == 0x20;
        public bool packed11_40 => ( packed11 & 0x40 ) == 0x40;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0000
            Key = parser.ReadOffset< string >( 0x0 );

            // col: 13 offset: 0004
            KillUpper = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            Type = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            Priority = parser.ReadOffset< byte >( 0x7 );

            // col: 3 offset: 0008
            Stance = parser.ReadOffset< byte >( 0x8 );

            // col: 4 offset: 0009
            Slot = parser.ReadOffset< byte >( 0x9 );

            // col: 5 offset: 000a
            LookAtMode = parser.ReadOffset< byte >( 0xa );

            // col: 7 offset: 000b
            ActionTimelineIDMode = parser.ReadOffset< byte >( 0xb );

            // col: 8 offset: 000c
            WeaponTimeline = parser.ReadOffset< byte >( 0xc );

            // col: 9 offset: 000d
            LoadType = parser.ReadOffset< byte >( 0xd );

            // col: 10 offset: 000e
            StartAttach = parser.ReadOffset< byte >( 0xe );

            // col: 11 offset: 000f
            ResidentPap = parser.ReadOffset< byte >( 0xf );

            // col: 16 offset: 0010
            IsLoop = parser.ReadOffset< byte >( 0x10 );

            // col: 2 offset: 0011
            packed11 = parser.ReadOffset< byte >( 0x11 );


        }
    }
}