using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignment", columnHash: 0x55964b3b )]
    public class GuildleveAssignment : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string unknown0;

        // col: 01 offset: 0004
        public uint AssignmentTalk;

        // col: 02 offset: 0008
        public uint[] Quest;

        // col: 09 offset: 0010
        public byte unknown10;

        // col: 04 offset: 0011
        public bool packed11_1;
        public byte packed11;
        public bool packed11_2;
        public bool packed11_4;
        public bool packed11_8;
        public bool packed11_10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            AssignmentTalk = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Quest = new uint[2];
            Quest[0] = parser.ReadOffset< uint >( 0x8 );
            Quest[1] = parser.ReadOffset< uint >( 0xc );

            // col: 9 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 4 offset: 0011
            packed11 = parser.ReadOffset< byte >( 0x11, ExcelColumnDataType.UInt8 );

            packed11_1 = ( packed11 & 0x1 ) == 0x1;
            packed11_2 = ( packed11 & 0x2 ) == 0x2;
            packed11_4 = ( packed11 & 0x4 ) == 0x4;
            packed11_8 = ( packed11 & 0x8 ) == 0x8;
            packed11_10 = ( packed11 & 0x10 ) == 0x10;


        }
    }
}