using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicNote", columnHash: 0xb557320e )]
    public class RelicNote : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint EventItem;

        // col: 01 offset: 0004
        public ushort[] unknown4;

        // col: 11 offset: 000e
        public ushort unknowne;

        // col: 13 offset: 0010
        public ushort unknown10;

        // col: 15 offset: 0012
        public ushort unknown12;

        // col: 17 offset: 0014
        public ushort unknown14;

        // col: 19 offset: 0016
        public ushort unknown16;

        // col: 21 offset: 0018
        public ushort[] MonsterNoteTargetNM;

        // col: 24 offset: 001e
        public ushort unknown1e;

        // col: 25 offset: 0020
        public ushort[] unknown20;

        // col: 29 offset: 0024
        public ushort unknown24;

        // col: 28 offset: 0028
        public ushort unknown28;

        // col: 30 offset: 002a
        public ushort unknown2a;

        // col: 31 offset: 002c
        public ushort[] Leve;

        // col: 12 offset: 0037
        public byte unknown37;

        // col: 14 offset: 0038
        public byte unknown38;

        // col: 16 offset: 0039
        public byte unknown39;

        // col: 18 offset: 003a
        public byte unknown3a;

        // col: 20 offset: 003b
        public byte unknown3b;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            EventItem = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = new ushort[10];
            unknown4[0] = parser.ReadOffset< ushort >( 0x4 );
            unknown4[1] = parser.ReadOffset< ushort >( 0x32 );
            unknown4[2] = parser.ReadOffset< ushort >( 0x6 );
            unknown4[3] = parser.ReadOffset< ushort >( 0x33 );
            unknown4[4] = parser.ReadOffset< ushort >( 0x8 );
            unknown4[5] = parser.ReadOffset< ushort >( 0x34 );
            unknown4[6] = parser.ReadOffset< ushort >( 0xa );
            unknown4[7] = parser.ReadOffset< ushort >( 0x35 );
            unknown4[8] = parser.ReadOffset< ushort >( 0xc );
            unknown4[9] = parser.ReadOffset< ushort >( 0x36 );

            // col: 11 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 13 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 15 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 17 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 19 offset: 0016
            unknown16 = parser.ReadOffset< ushort >( 0x16 );

            // col: 21 offset: 0018
            MonsterNoteTargetNM = new ushort[3];
            MonsterNoteTargetNM[0] = parser.ReadOffset< ushort >( 0x18 );
            MonsterNoteTargetNM[1] = parser.ReadOffset< ushort >( 0x1a );
            MonsterNoteTargetNM[2] = parser.ReadOffset< ushort >( 0x1c );

            // col: 24 offset: 001e
            unknown1e = parser.ReadOffset< ushort >( 0x1e );

            // col: 25 offset: 0020
            unknown20 = new ushort[3];
            unknown20[0] = parser.ReadOffset< ushort >( 0x20 );
            unknown20[1] = parser.ReadOffset< ushort >( 0x26 );
            unknown20[2] = parser.ReadOffset< ushort >( 0x22 );

            // col: 29 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 28 offset: 0028
            unknown28 = parser.ReadOffset< ushort >( 0x28 );

            // col: 30 offset: 002a
            unknown2a = parser.ReadOffset< ushort >( 0x2a );

            // col: 31 offset: 002c
            Leve = new ushort[3];
            Leve[0] = parser.ReadOffset< ushort >( 0x2c );
            Leve[1] = parser.ReadOffset< ushort >( 0x2e );
            Leve[2] = parser.ReadOffset< ushort >( 0x30 );

            // col: 12 offset: 0037
            unknown37 = parser.ReadOffset< byte >( 0x37 );

            // col: 14 offset: 0038
            unknown38 = parser.ReadOffset< byte >( 0x38 );

            // col: 16 offset: 0039
            unknown39 = parser.ReadOffset< byte >( 0x39 );

            // col: 18 offset: 003a
            unknown3a = parser.ReadOffset< byte >( 0x3a );

            // col: 20 offset: 003b
            unknown3b = parser.ReadOffset< byte >( 0x3b );


        }
    }
}