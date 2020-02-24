using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcState", columnHash: 0x439de63e )]
    public class BNpcState : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 11 offset: 0000
        public float Scale;

        // col: 13 offset: 0004
        public int LoopTimeline;

        // col: 04 offset: 0008
        public ushort Idle;

        // col: 00 offset: 000a
        public byte Slot;

        // col: 03 offset: 000b
        public byte unknownb;

        // col: 05 offset: 000c
        public byte Attribute0;

        // col: 07 offset: 000d
        public byte Attribute1;

        // col: 09 offset: 000e
        public byte Attribute2;

        // col: 12 offset: 000f
        public byte unknownf;

        // col: 01 offset: 0010
        public sbyte OverRay;

        // col: 02 offset: 0011
        public sbyte unknown11;

        // col: 06 offset: 0012
        public bool AttributeFlag0;

        // col: 08 offset: 0013
        public bool AttributeFlag1;

        // col: 10 offset: 0014
        public bool AttributeFlag2;

        // col: 14 offset: 0015
        private byte packed15;
        public bool packed15_1 => ( packed15 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 11 offset: 0000
            Scale = parser.ReadOffset< float >( 0x0 );

            // col: 13 offset: 0004
            LoopTimeline = parser.ReadOffset< int >( 0x4 );

            // col: 4 offset: 0008
            Idle = parser.ReadOffset< ushort >( 0x8 );

            // col: 0 offset: 000a
            Slot = parser.ReadOffset< byte >( 0xa );

            // col: 3 offset: 000b
            unknownb = parser.ReadOffset< byte >( 0xb );

            // col: 5 offset: 000c
            Attribute0 = parser.ReadOffset< byte >( 0xc );

            // col: 7 offset: 000d
            Attribute1 = parser.ReadOffset< byte >( 0xd );

            // col: 9 offset: 000e
            Attribute2 = parser.ReadOffset< byte >( 0xe );

            // col: 12 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 1 offset: 0010
            OverRay = parser.ReadOffset< sbyte >( 0x10 );

            // col: 2 offset: 0011
            unknown11 = parser.ReadOffset< sbyte >( 0x11 );

            // col: 6 offset: 0012
            AttributeFlag0 = parser.ReadOffset< bool >( 0x12 );

            // col: 8 offset: 0013
            AttributeFlag1 = parser.ReadOffset< bool >( 0x13 );

            // col: 10 offset: 0014
            AttributeFlag2 = parser.ReadOffset< bool >( 0x14 );

            // col: 14 offset: 0015
            packed15 = parser.ReadOffset< byte >( 0x15, ExcelColumnDataType.UInt8 );


        }
    }
}