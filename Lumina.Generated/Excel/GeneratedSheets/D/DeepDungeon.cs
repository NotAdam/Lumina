using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeon", columnHash: 0xea7a6143 )]
    public class DeepDungeon : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public byte[] PomanderSlot;

        // col: 18 offset: 0010
        public byte[] MagiciteSlot;

        // col: 22 offset: 0014
        public string Name;

        // col: 23 offset: 0018
        public ushort ContentFinderConditionStart;

        // col: 00 offset: 001a
        public byte AetherpoolArm;

        // col: 01 offset: 001b
        public byte AetherpoolArmor;

        // col: 24 offset: 001c
        public bool packed1c_1;
        public byte packed1c;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            PomanderSlot = new byte[16];
            PomanderSlot[0] = parser.ReadOffset< byte >( 0x0 );
            PomanderSlot[1] = parser.ReadOffset< byte >( 0x1 );
            PomanderSlot[2] = parser.ReadOffset< byte >( 0x2 );
            PomanderSlot[3] = parser.ReadOffset< byte >( 0x3 );
            PomanderSlot[4] = parser.ReadOffset< byte >( 0x4 );
            PomanderSlot[5] = parser.ReadOffset< byte >( 0x5 );
            PomanderSlot[6] = parser.ReadOffset< byte >( 0x6 );
            PomanderSlot[7] = parser.ReadOffset< byte >( 0x7 );
            PomanderSlot[8] = parser.ReadOffset< byte >( 0x8 );
            PomanderSlot[9] = parser.ReadOffset< byte >( 0x9 );
            PomanderSlot[10] = parser.ReadOffset< byte >( 0xa );
            PomanderSlot[11] = parser.ReadOffset< byte >( 0xb );
            PomanderSlot[12] = parser.ReadOffset< byte >( 0xc );
            PomanderSlot[13] = parser.ReadOffset< byte >( 0xd );
            PomanderSlot[14] = parser.ReadOffset< byte >( 0xe );
            PomanderSlot[15] = parser.ReadOffset< byte >( 0xf );

            // col: 18 offset: 0010
            MagiciteSlot = new byte[4];
            MagiciteSlot[0] = parser.ReadOffset< byte >( 0x10 );
            MagiciteSlot[1] = parser.ReadOffset< byte >( 0x11 );
            MagiciteSlot[2] = parser.ReadOffset< byte >( 0x12 );
            MagiciteSlot[3] = parser.ReadOffset< byte >( 0x13 );

            // col: 22 offset: 0014
            Name = parser.ReadOffset< string >( 0x14 );

            // col: 23 offset: 0018
            ContentFinderConditionStart = parser.ReadOffset< ushort >( 0x18 );

            // col: 0 offset: 001a
            AetherpoolArm = parser.ReadOffset< byte >( 0x1a );

            // col: 1 offset: 001b
            AetherpoolArmor = parser.ReadOffset< byte >( 0x1b );

            // col: 24 offset: 001c
            packed1c = parser.ReadOffset< byte >( 0x1c, ExcelColumnDataType.UInt8 );

            packed1c_1 = ( packed1c & 0x1 ) == 0x1;


        }
    }
}