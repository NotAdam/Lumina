using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickJump", columnHash: 0x4858f2f1 )]
    public class GimmickJump : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 02 offset: 0000
        public uint LoopMotion;

        // col: 03 offset: 0004
        public uint EndMotion;

        // col: 00 offset: 0008
        public ushort FallDamage;

        // col: 01 offset: 000a
        public sbyte Height;

        // col: 04 offset: 000b
        private byte packedb;
        public bool StartClient => ( packedb & 0x1 ) == 0x1;
        public bool packedb_2 => ( packedb & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            LoopMotion = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            EndMotion = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            FallDamage = parser.ReadOffset< ushort >( 0x8 );

            // col: 1 offset: 000a
            Height = parser.ReadOffset< sbyte >( 0xa );

            // col: 4 offset: 000b
            packedb = parser.ReadOffset< byte >( 0xb, ExcelColumnDataType.UInt8 );


        }
    }
}