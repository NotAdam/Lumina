using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateEvent", columnHash: 0xb047403f )]
    public class FateEvent : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


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
        private byte packed12;
        public bool IsAutoShake => ( packed12 & 0x1 ) == 0x1;
        public bool packed12_2 => ( packed12 & 0x2 ) == 0x2;
        public bool packed12_4 => ( packed12 & 0x4 ) == 0x4;
        public bool packed12_8 => ( packed12 & 0x8 ) == 0x8;
        public bool packed12_10 => ( packed12 & 0x10 ) == 0x10;
        public bool packed12_20 => ( packed12 & 0x20 ) == 0x20;
        public bool packed12_40 => ( packed12 & 0x40 ) == 0x40;
        public bool packed12_80 => ( packed12 & 0x80 ) == 0x80;

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