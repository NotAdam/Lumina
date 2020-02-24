using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic", columnHash: 0x8080ef57 )]
    public class Relic : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public uint ItemAtma;

        // col: 01 offset: 0004
        public uint ItemAnimus;

        // col: 02 offset: 0008
        public int Icon;

        // col: 03 offset: 000c
        public ushort Materia0;

        // col: 07 offset: 000e
        public ushort Materia1;

        // col: 11 offset: 0010
        public ushort Materia2;

        // col: 14 offset: 0012
        public ushort Materia3;

        // col: 04 offset: 0014
        public byte NoteMain0;

        // col: 05 offset: 0015
        public byte NoteSub0;

        // col: 06 offset: 0016
        public byte NoteSelection10;

        // col: 08 offset: 0017
        public byte NoteMain1;

        // col: 09 offset: 0018
        public byte NoteSub1;

        // col: 10 offset: 0019
        public byte NoteSelection1;

        // col: 12 offset: 001a
        public byte NoteMain2;

        // col: 13 offset: 001b
        public byte NoteSub2;

        // col: 15 offset: 001c
        public byte NoteSelection3;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ItemAtma = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            ItemAnimus = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< int >( 0x8 );

            // col: 3 offset: 000c
            Materia0 = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            Materia1 = parser.ReadOffset< ushort >( 0xe );

            // col: 11 offset: 0010
            Materia2 = parser.ReadOffset< ushort >( 0x10 );

            // col: 14 offset: 0012
            Materia3 = parser.ReadOffset< ushort >( 0x12 );

            // col: 4 offset: 0014
            NoteMain0 = parser.ReadOffset< byte >( 0x14 );

            // col: 5 offset: 0015
            NoteSub0 = parser.ReadOffset< byte >( 0x15 );

            // col: 6 offset: 0016
            NoteSelection10 = parser.ReadOffset< byte >( 0x16 );

            // col: 8 offset: 0017
            NoteMain1 = parser.ReadOffset< byte >( 0x17 );

            // col: 9 offset: 0018
            NoteSub1 = parser.ReadOffset< byte >( 0x18 );

            // col: 10 offset: 0019
            NoteSelection1 = parser.ReadOffset< byte >( 0x19 );

            // col: 12 offset: 001a
            NoteMain2 = parser.ReadOffset< byte >( 0x1a );

            // col: 13 offset: 001b
            NoteSub2 = parser.ReadOffset< byte >( 0x1b );

            // col: 15 offset: 001c
            NoteSelection3 = parser.ReadOffset< byte >( 0x1c );


        }
    }
}