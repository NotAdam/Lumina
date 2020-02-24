namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Perform", columnHash: 0x48a99e9c )]
    public class Perform : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0010 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0023 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  name: ModelKey
         *  type: 
         */

        /* offset: 001c col: 3
         *  name: Animation{Start}
         *  type: 
         */

        /* offset: 001e col: 4
         *  name: Animation{End}
         *  type: 
         */

        /* offset: 0020 col: 5
         *  name: Animation{Idle}
         *  type: 
         */

        /* offset: 0000 col: 6
         *  name: Animation{Play01}
         *  type: 
         */

        /* offset: 0002 col: 7
         *  name: Animation{Play02}
         *  type: 
         */

        /* offset: 0014 col: 8
         *  name: StopAnimation
         *  type: 
         */

        /* offset: 0004 col: 9
         *  name: Instrument
         *  type: 
         */

        /* offset: 0018 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0022 col: 11
         *  name: Transient
         *  type: 
         */



        // col: 06 offset: 0000
        public ushort AnimationPlay01;

        // col: 07 offset: 0002
        public ushort AnimationPlay02;

        // col: 09 offset: 0004
        public string Instrument;

        // col: 02 offset: 0008
        public ulong ModelKey;

        // col: 00 offset: 0010
        public string Name;

        // col: 08 offset: 0014
        public int StopAnimation;

        // col: 10 offset: 0018
        public int unknown18;

        // col: 03 offset: 001c
        public ushort AnimationStart;

        // col: 04 offset: 001e
        public ushort AnimationEnd;

        // col: 05 offset: 0020
        public ushort AnimationIdle;

        // col: 11 offset: 0022
        public byte Transient;

        // col: 01 offset: 0023
        private byte packed23;
        public bool packed23_1 => ( packed23 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0000
            AnimationPlay01 = parser.ReadOffset< ushort >( 0x0 );

            // col: 7 offset: 0002
            AnimationPlay02 = parser.ReadOffset< ushort >( 0x2 );

            // col: 9 offset: 0004
            Instrument = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            ModelKey = parser.ReadOffset< ulong >( 0x8 );

            // col: 0 offset: 0010
            Name = parser.ReadOffset< string >( 0x10 );

            // col: 8 offset: 0014
            StopAnimation = parser.ReadOffset< int >( 0x14 );

            // col: 10 offset: 0018
            unknown18 = parser.ReadOffset< int >( 0x18 );

            // col: 3 offset: 001c
            AnimationStart = parser.ReadOffset< ushort >( 0x1c );

            // col: 4 offset: 001e
            AnimationEnd = parser.ReadOffset< ushort >( 0x1e );

            // col: 5 offset: 0020
            AnimationIdle = parser.ReadOffset< ushort >( 0x20 );

            // col: 11 offset: 0022
            Transient = parser.ReadOffset< byte >( 0x22 );

            // col: 1 offset: 0023
            packed23 = parser.ReadOffset< byte >( 0x23 );


        }
    }
}