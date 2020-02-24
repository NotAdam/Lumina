using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcYell", columnHash: 0xbd07b3cb )]
    public class NpcYell : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 10 offset: 0000
        public string unknown0;

        // col: 06 offset: 0004
        public float BalloonTime;

        // col: 09 offset: 0008
        public float Text;

        // col: 00 offset: 000c
        public uint unknownc;

        // col: 01 offset: 0010
        public byte unknown10;

        // col: 05 offset: 0011
        public byte OutputType;

        // col: 02 offset: 0012
        private byte packed12;
        public bool packed12_1 => ( packed12 & 0x1 ) == 0x1;
        public bool packed12_2 => ( packed12 & 0x2 ) == 0x2;
        public bool packed12_4 => ( packed12 & 0x4 ) == 0x4;
        public bool IsBalloonSlow => ( packed12 & 0x8 ) == 0x8;
        public bool BattleTalkTime => ( packed12 & 0x10 ) == 0x10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 10 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 6 offset: 0004
            BalloonTime = parser.ReadOffset< float >( 0x4 );

            // col: 9 offset: 0008
            Text = parser.ReadOffset< float >( 0x8 );

            // col: 0 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 1 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 5 offset: 0011
            OutputType = parser.ReadOffset< byte >( 0x11 );

            // col: 2 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );


        }
    }
}