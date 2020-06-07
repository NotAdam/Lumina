using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateEvent", columnHash: 0xb047403f )]
    public class FateEvent : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 08 offset: 0000
        public uint[] Gesture;

        // col: 16 offset: 0004
        public int[] LipSync;

        // col: 24 offset: 0008
        public int[] Facial;

        // col: 32 offset: 000c
        public int[] Shape;

        // col: 00 offset: 0010
        public byte[] Turn;

        // col: 48 offset: 0011
        public byte[] WidgetType;

        // col: 40 offset: 0012
        public bool[] IsAutoShake;
        public byte packed12;
        public byte packed26;
        public byte packed3a;
        public byte packed4e;
        public byte packed62;
        public byte packed76;
        public byte packed8a;
        public byte packed9e;

        // col: 56 offset: 00a0
        public string[] Text;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 8 offset: 0000
            Gesture = new uint[8];
            Gesture[0] = parser.ReadOffset< uint >( 0x0 );
            Gesture[1] = parser.ReadOffset< uint >( 0x14 );
            Gesture[2] = parser.ReadOffset< uint >( 0x28 );
            Gesture[3] = parser.ReadOffset< uint >( 0x3c );
            Gesture[4] = parser.ReadOffset< uint >( 0x50 );
            Gesture[5] = parser.ReadOffset< uint >( 0x64 );
            Gesture[6] = parser.ReadOffset< uint >( 0x78 );
            Gesture[7] = parser.ReadOffset< uint >( 0x8c );

            // col: 16 offset: 0004
            LipSync = new int[8];
            LipSync[0] = parser.ReadOffset< int >( 0x4 );
            LipSync[1] = parser.ReadOffset< int >( 0x18 );
            LipSync[2] = parser.ReadOffset< int >( 0x2c );
            LipSync[3] = parser.ReadOffset< int >( 0x40 );
            LipSync[4] = parser.ReadOffset< int >( 0x54 );
            LipSync[5] = parser.ReadOffset< int >( 0x68 );
            LipSync[6] = parser.ReadOffset< int >( 0x7c );
            LipSync[7] = parser.ReadOffset< int >( 0x90 );

            // col: 24 offset: 0008
            Facial = new int[8];
            Facial[0] = parser.ReadOffset< int >( 0x8 );
            Facial[1] = parser.ReadOffset< int >( 0x1c );
            Facial[2] = parser.ReadOffset< int >( 0x30 );
            Facial[3] = parser.ReadOffset< int >( 0x44 );
            Facial[4] = parser.ReadOffset< int >( 0x58 );
            Facial[5] = parser.ReadOffset< int >( 0x6c );
            Facial[6] = parser.ReadOffset< int >( 0x80 );
            Facial[7] = parser.ReadOffset< int >( 0x94 );

            // col: 32 offset: 000c
            Shape = new int[8];
            Shape[0] = parser.ReadOffset< int >( 0xc );
            Shape[1] = parser.ReadOffset< int >( 0x20 );
            Shape[2] = parser.ReadOffset< int >( 0x34 );
            Shape[3] = parser.ReadOffset< int >( 0x48 );
            Shape[4] = parser.ReadOffset< int >( 0x5c );
            Shape[5] = parser.ReadOffset< int >( 0x70 );
            Shape[6] = parser.ReadOffset< int >( 0x84 );
            Shape[7] = parser.ReadOffset< int >( 0x98 );

            // col: 0 offset: 0010
            Turn = new byte[8];
            Turn[0] = parser.ReadOffset< byte >( 0x10 );
            Turn[1] = parser.ReadOffset< byte >( 0x24 );
            Turn[2] = parser.ReadOffset< byte >( 0x38 );
            Turn[3] = parser.ReadOffset< byte >( 0x4c );
            Turn[4] = parser.ReadOffset< byte >( 0x60 );
            Turn[5] = parser.ReadOffset< byte >( 0x74 );
            Turn[6] = parser.ReadOffset< byte >( 0x88 );
            Turn[7] = parser.ReadOffset< byte >( 0x9c );

            // col: 48 offset: 0011
            WidgetType = new byte[8];
            WidgetType[0] = parser.ReadOffset< byte >( 0x11 );
            WidgetType[1] = parser.ReadOffset< byte >( 0x25 );
            WidgetType[2] = parser.ReadOffset< byte >( 0x39 );
            WidgetType[3] = parser.ReadOffset< byte >( 0x4d );
            WidgetType[4] = parser.ReadOffset< byte >( 0x61 );
            WidgetType[5] = parser.ReadOffset< byte >( 0x75 );
            WidgetType[6] = parser.ReadOffset< byte >( 0x89 );
            WidgetType[7] = parser.ReadOffset< byte >( 0x9d );

            // col: 40 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );

            IsAutoShake = new bool[8];
            IsAutoShake[0] = ( packed12 & 0x1 ) == 0x1;
            packed26 = parser.ReadOffset< byte >( 0x26, ExcelColumnDataType.UInt8 );

            IsAutoShake[1] = ( packed26 & 0x1 ) == 0x1;
            packed3a = parser.ReadOffset< byte >( 0x3a, ExcelColumnDataType.UInt8 );

            IsAutoShake[2] = ( packed3a & 0x1 ) == 0x1;
            packed4e = parser.ReadOffset< byte >( 0x4e, ExcelColumnDataType.UInt8 );

            IsAutoShake[3] = ( packed4e & 0x1 ) == 0x1;
            packed62 = parser.ReadOffset< byte >( 0x62, ExcelColumnDataType.UInt8 );

            IsAutoShake[4] = ( packed62 & 0x1 ) == 0x1;
            packed76 = parser.ReadOffset< byte >( 0x76, ExcelColumnDataType.UInt8 );

            IsAutoShake[5] = ( packed76 & 0x1 ) == 0x1;
            packed8a = parser.ReadOffset< byte >( 0x8a, ExcelColumnDataType.UInt8 );

            IsAutoShake[6] = ( packed8a & 0x1 ) == 0x1;
            packed9e = parser.ReadOffset< byte >( 0x9e, ExcelColumnDataType.UInt8 );

            IsAutoShake[7] = ( packed9e & 0x1 ) == 0x1;

            // col: 56 offset: 00a0
            Text = new string[8];
            Text[0] = parser.ReadOffset< string >( 0xa0 );
            Text[1] = parser.ReadOffset< string >( 0xa4 );
            Text[2] = parser.ReadOffset< string >( 0xa8 );
            Text[3] = parser.ReadOffset< string >( 0xac );
            Text[4] = parser.ReadOffset< string >( 0xb0 );
            Text[5] = parser.ReadOffset< string >( 0xb4 );
            Text[6] = parser.ReadOffset< string >( 0xb8 );
            Text[7] = parser.ReadOffset< string >( 0xbc );


        }
    }
}