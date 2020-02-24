namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Status", columnHash: 0xd8ae9831 )]
    public class Status : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Description
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Icon
         *  type: 
         */

        /* offset: 000e col: 3
         *  name: MaxStacks
         *  type: 
         */

        /* offset: 000f col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 5
         *  name: Category
         *  type: 
         */

        /* offset: 0011 col: 6
         *  name: HitEffect
         *  type: 
         */

        /* offset: 0012 col: 7
         *  name: VFX
         *  type: 
         */

        /* offset: 0017 col: 8
         *  name: LockMovement
         *  type: 
         */

        /* offset: 0017 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0017 col: 10
         *  name: LockActions
         *  type: 
         */

        /* offset: 0017 col: 11
         *  name: LockControl
         *  type: 
         */

        /* offset: 0017 col: 12
         *  name: Transfiguration
         *  type: 
         */

        /* offset: 0017 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0017 col: 14
         *  name: CanDispel
         *  type: 
         */

        /* offset: 0017 col: 15
         *  name: InflictedByActor
         *  type: 
         */

        /* offset: 0018 col: 16
         *  name: IsPermanent
         *  type: 
         */

        /* offset: 0013 col: 17
         *  name: PartyListPriority
         *  type: 
         */

        /* offset: 0018 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 23
         *  name: Log
         *  type: 
         */

        /* offset: 0018 col: 24
         *  name: IsFcBuff
         *  type: 
         */

        /* offset: 0018 col: 25
         *  name: Invisibility
         *  type: 
         */

        /* offset: 0015 col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0016 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 28
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public ushort Icon;

        // col: 23 offset: 000a
        public ushort Log;

        // col: 20 offset: 000c
        public short unknownc;

        // col: 03 offset: 000e
        public byte MaxStacks;

        // col: 04 offset: 000f
        public byte unknownf;

        // col: 05 offset: 0010
        public byte Category;

        // col: 06 offset: 0011
        public byte HitEffect;

        // col: 07 offset: 0012
        public byte VFX;

        // col: 17 offset: 0013
        public byte PartyListPriority;

        // col: 21 offset: 0014
        public byte unknown14;

        // col: 26 offset: 0015
        public byte unknown15;

        // col: 27 offset: 0016
        public byte unknown16;

        // col: 08 offset: 0017
        private byte packed17;
        public bool LockMovement => ( packed17 & 0x1 ) == 0x1;
        public bool packed17_2 => ( packed17 & 0x2 ) == 0x2;
        public bool LockActions => ( packed17 & 0x4 ) == 0x4;
        public bool LockControl => ( packed17 & 0x8 ) == 0x8;
        public bool Transfiguration => ( packed17 & 0x10 ) == 0x10;
        public bool packed17_20 => ( packed17 & 0x20 ) == 0x20;
        public bool CanDispel => ( packed17 & 0x40 ) == 0x40;
        public bool InflictedByActor => ( packed17 & 0x80 ) == 0x80;

        // col: 16 offset: 0018
        private byte packed18;
        public bool IsPermanent => ( packed18 & 0x1 ) == 0x1;
        public bool packed18_2 => ( packed18 & 0x2 ) == 0x2;
        public bool packed18_4 => ( packed18 & 0x4 ) == 0x4;
        public bool packed18_8 => ( packed18 & 0x8 ) == 0x8;
        public bool IsFcBuff => ( packed18 & 0x10 ) == 0x10;
        public bool Invisibility => ( packed18 & 0x20 ) == 0x20;
        public bool packed18_40 => ( packed18 & 0x40 ) == 0x40;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< ushort >( 0x8 );

            // col: 23 offset: 000a
            Log = parser.ReadOffset< ushort >( 0xa );

            // col: 20 offset: 000c
            unknownc = parser.ReadOffset< short >( 0xc );

            // col: 3 offset: 000e
            MaxStacks = parser.ReadOffset< byte >( 0xe );

            // col: 4 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 5 offset: 0010
            Category = parser.ReadOffset< byte >( 0x10 );

            // col: 6 offset: 0011
            HitEffect = parser.ReadOffset< byte >( 0x11 );

            // col: 7 offset: 0012
            VFX = parser.ReadOffset< byte >( 0x12 );

            // col: 17 offset: 0013
            PartyListPriority = parser.ReadOffset< byte >( 0x13 );

            // col: 21 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 26 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 27 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 8 offset: 0017
            packed17 = parser.ReadOffset< byte >( 0x17 );

            // col: 16 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18 );


        }
    }
}