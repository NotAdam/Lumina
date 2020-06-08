using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNoteTarget", columnHash: 0x4157404f )]
    public class MonsterNoteTarget : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int Icon;

        // col: 00 offset: 0004
        public ushort BNpcName;

        // col: 03 offset: 0006
        public ushort[] unknown6;

        // col: 07 offset: 000a
        public ushort unknowna;

        // col: 06 offset: 000e
        public ushort unknowne;

        // col: 08 offset: 0010
        public ushort unknown10;

        // col: 02 offset: 0012
        public byte Town;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Icon = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            BNpcName = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            unknown6 = new ushort[3];
            unknown6[0] = parser.ReadOffset< ushort >( 0x6 );
            unknown6[1] = parser.ReadOffset< ushort >( 0xc );
            unknown6[2] = parser.ReadOffset< ushort >( 0x8 );

            // col: 7 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 2 offset: 0012
            Town = parser.ReadOffset< byte >( 0x12 );


        }
    }
}