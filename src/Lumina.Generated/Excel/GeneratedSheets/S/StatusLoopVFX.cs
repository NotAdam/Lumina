using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusLoopVFX", columnHash: 0xe9330973 )]
    public class StatusLoopVFX : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort VFX;

        // col: 02 offset: 0002
        public ushort VFX2;

        // col: 04 offset: 0004
        public ushort VFX3;

        // col: 01 offset: 0006
        public byte unknown6;

        // col: 03 offset: 0007
        public byte unknown7;

        // col: 05 offset: 0008
        public byte unknown8;

        // col: 06 offset: 0009
        public byte unknown9;

        // col: 07 offset: 000a
        public bool packeda_1;
        public byte packeda;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            VFX = parser.ReadOffset< ushort >( 0x0 );

            // col: 2 offset: 0002
            VFX2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 4 offset: 0004
            VFX3 = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );

            // col: 3 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 6 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 7 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa, ExcelColumnDataType.UInt8 );

            packeda_1 = ( packeda & 0x1 ) == 0x1;


        }
    }
}