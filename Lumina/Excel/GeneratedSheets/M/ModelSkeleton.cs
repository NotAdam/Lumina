using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelSkeleton", columnHash: 0x94cc54f1 )]
    public class ModelSkeleton : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public float Radius;

        // col: 01 offset: 0004
        public float Height;

        // col: 02 offset: 0008
        public float VFXScale;

        // col: 11 offset: 000c
        public float FloatHeight;

        // col: 12 offset: 0010
        public float FloatDown;

        // col: 03 offset: 0014
        public ushort unknown14;

        // col: 04 offset: 0016
        public ushort unknown16;

        // col: 05 offset: 0018
        public ushort unknown18;

        // col: 06 offset: 001a
        public ushort unknown1a;

        // col: 07 offset: 001c
        public ushort unknown1c;

        // col: 08 offset: 001e
        public ushort unknown1e;

        // col: 09 offset: 0020
        public ushort unknown20;

        // col: 10 offset: 0022
        public ushort unknown22;

        // col: 13 offset: 0024
        public ushort FloatUp;

        // col: 14 offset: 0026
        public byte unknown26;

        // col: 16 offset: 0027
        public byte LoopFlySE;

        // col: 15 offset: 0028
        private byte packed28;
        public bool MotionBlendType => ( packed28 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Radius = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            Height = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            VFXScale = parser.ReadOffset< float >( 0x8 );

            // col: 11 offset: 000c
            FloatHeight = parser.ReadOffset< float >( 0xc );

            // col: 12 offset: 0010
            FloatDown = parser.ReadOffset< float >( 0x10 );

            // col: 3 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 4 offset: 0016
            unknown16 = parser.ReadOffset< ushort >( 0x16 );

            // col: 5 offset: 0018
            unknown18 = parser.ReadOffset< ushort >( 0x18 );

            // col: 6 offset: 001a
            unknown1a = parser.ReadOffset< ushort >( 0x1a );

            // col: 7 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 8 offset: 001e
            unknown1e = parser.ReadOffset< ushort >( 0x1e );

            // col: 9 offset: 0020
            unknown20 = parser.ReadOffset< ushort >( 0x20 );

            // col: 10 offset: 0022
            unknown22 = parser.ReadOffset< ushort >( 0x22 );

            // col: 13 offset: 0024
            FloatUp = parser.ReadOffset< ushort >( 0x24 );

            // col: 14 offset: 0026
            unknown26 = parser.ReadOffset< byte >( 0x26 );

            // col: 16 offset: 0027
            LoopFlySE = parser.ReadOffset< byte >( 0x27 );

            // col: 15 offset: 0028
            packed28 = parser.ReadOffset< byte >( 0x28, ExcelColumnDataType.UInt8 );


        }
    }
}