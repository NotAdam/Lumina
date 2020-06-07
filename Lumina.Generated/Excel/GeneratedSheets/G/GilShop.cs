using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShop", columnHash: 0xa0969241 )]
    public class GilShop : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public uint Quest;

        // col: 03 offset: 000c
        public int AcceptTalk;

        // col: 04 offset: 0010
        public int FailTalk;

        // col: 05 offset: 0014
        public bool packed14_1;
        public byte packed14;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Quest = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            AcceptTalk = parser.ReadOffset< int >( 0xc );

            // col: 4 offset: 0010
            FailTalk = parser.ReadOffset< int >( 0x10 );

            // col: 5 offset: 0014
            packed14 = parser.ReadOffset< byte >( 0x14, ExcelColumnDataType.UInt8 );

            packed14_1 = ( packed14 & 0x1 ) == 0x1;


        }
    }
}