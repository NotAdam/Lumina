namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Transformation", columnHash: 0xa9f5ba48 )]
    public class Transformation : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 002a col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 1
         *  name: Model
         *  type: 
         */

        /* offset: 0014 col: 2
         *  name: BNpcName
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: BNpcCustomize
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: NpcEquip
         *  type: 
         */

        /* offset: 002e col: 5
         *  name: ExHotbarEnableConfig
         *  type: 
         */

        /* offset: 0016 col: 6
         *  name: Action[0]
         *  type: 
         */

        /* offset: 002f col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 8
         *  name: Action[1]
         *  type: 
         */

        /* offset: 0030 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 001a col: 10
         *  name: Action[2]
         *  type: 
         */

        /* offset: 0031 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 12
         *  name: Action[3]
         *  type: 
         */

        /* offset: 0032 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 001e col: 14
         *  name: Action[4]
         *  type: 
         */

        /* offset: 0020 col: 15
         *  name: Action[5]
         *  type: 
         */

        /* offset: 0033 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0033 col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 002b col: 18
         *  name: RPParameter
         *  type: 
         */

        /* offset: 0000 col: 19
         *  name: Speed
         *  type: 
         */

        /* offset: 0004 col: 20
         *  name: Scale
         *  type: 
         */

        /* offset: 0033 col: 21
         *  name: IsPvP
         *  type: 
         */

        /* offset: 0033 col: 22
         *  name: IsEvent
         *  type: 
         */

        /* offset: 0033 col: 23
         *  name: PlayerCamera
         *  type: 
         */

        /* offset: 0033 col: 24
         *  name: StartVFX
         *  type: 
         */

        /* offset: 0033 col: 25
         *  name: EndVFX
         *  type: 
         */

        /* offset: 0022 col: 26
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 27
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 002d col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 30
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 31
         *  no SaintCoinach definition found
         */



        // col: 19 offset: 0000
        public float Speed;

        // col: 20 offset: 0004
        public float Scale;

        // col: 28 offset: 0008
        public uint unknown8;

        // col: 03 offset: 000c
        public int BNpcCustomize;

        // col: 04 offset: 0010
        public int NpcEquip;

        // col: 02 offset: 0014
        public ushort BNpcName;

        // col: 06 offset: 0016
        public ushort Action0;

        // col: 08 offset: 0018
        public ushort Action1;

        // col: 10 offset: 001a
        public ushort Action2;

        // col: 12 offset: 001c
        public ushort Action3;

        // col: 14 offset: 001e
        public ushort Action4;

        // col: 15 offset: 0020
        public ushort Action5;

        // col: 26 offset: 0022
        public ushort unknown22;

        // col: 27 offset: 0024
        public ushort unknown24;

        // col: 30 offset: 0026
        public ushort unknown26;

        // col: 01 offset: 0028
        public short Model;

        // col: 00 offset: 002a
        public byte unknown2a;

        // col: 18 offset: 002b
        public byte RPParameter;

        // col: 31 offset: 002c
        public byte unknown2c;

        // col: 29 offset: 002d
        public sbyte unknown2d;

        // col: 05 offset: 002e
        public bool ExHotbarEnableConfig;

        // col: 07 offset: 002f
        public bool unknown2f;

        // col: 09 offset: 0030
        public bool unknown30;

        // col: 11 offset: 0031
        public bool unknown31;

        // col: 13 offset: 0032
        public bool unknown32;

        // col: 16 offset: 0033
        private byte packed33;
        public bool packed33_1 => ( packed33 & 0x1 ) == 0x1;
        public bool packed33_2 => ( packed33 & 0x2 ) == 0x2;
        public bool IsPvP => ( packed33 & 0x4 ) == 0x4;
        public bool IsEvent => ( packed33 & 0x8 ) == 0x8;
        public bool PlayerCamera => ( packed33 & 0x10 ) == 0x10;
        public bool StartVFX => ( packed33 & 0x20 ) == 0x20;
        public bool EndVFX => ( packed33 & 0x40 ) == 0x40;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 19 offset: 0000
            Speed = parser.ReadOffset< float >( 0x0 );

            // col: 20 offset: 0004
            Scale = parser.ReadOffset< float >( 0x4 );

            // col: 28 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            BNpcCustomize = parser.ReadOffset< int >( 0xc );

            // col: 4 offset: 0010
            NpcEquip = parser.ReadOffset< int >( 0x10 );

            // col: 2 offset: 0014
            BNpcName = parser.ReadOffset< ushort >( 0x14 );

            // col: 6 offset: 0016
            Action0 = parser.ReadOffset< ushort >( 0x16 );

            // col: 8 offset: 0018
            Action1 = parser.ReadOffset< ushort >( 0x18 );

            // col: 10 offset: 001a
            Action2 = parser.ReadOffset< ushort >( 0x1a );

            // col: 12 offset: 001c
            Action3 = parser.ReadOffset< ushort >( 0x1c );

            // col: 14 offset: 001e
            Action4 = parser.ReadOffset< ushort >( 0x1e );

            // col: 15 offset: 0020
            Action5 = parser.ReadOffset< ushort >( 0x20 );

            // col: 26 offset: 0022
            unknown22 = parser.ReadOffset< ushort >( 0x22 );

            // col: 27 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 30 offset: 0026
            unknown26 = parser.ReadOffset< ushort >( 0x26 );

            // col: 1 offset: 0028
            Model = parser.ReadOffset< short >( 0x28 );

            // col: 0 offset: 002a
            unknown2a = parser.ReadOffset< byte >( 0x2a );

            // col: 18 offset: 002b
            RPParameter = parser.ReadOffset< byte >( 0x2b );

            // col: 31 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 29 offset: 002d
            unknown2d = parser.ReadOffset< sbyte >( 0x2d );

            // col: 5 offset: 002e
            ExHotbarEnableConfig = parser.ReadOffset< bool >( 0x2e );

            // col: 7 offset: 002f
            unknown2f = parser.ReadOffset< bool >( 0x2f );

            // col: 9 offset: 0030
            unknown30 = parser.ReadOffset< bool >( 0x30 );

            // col: 11 offset: 0031
            unknown31 = parser.ReadOffset< bool >( 0x31 );

            // col: 13 offset: 0032
            unknown32 = parser.ReadOffset< bool >( 0x32 );

            // col: 16 offset: 0033
            packed33 = parser.ReadOffset< byte >( 0x33 );


        }
    }
}