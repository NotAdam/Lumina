using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringNotebookList", columnHash: 0xa6318a14 )]
    public class GatheringNotebookList : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int[] GatheringItem;

        // col: 00 offset: 0190
        public byte unknown190;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            GatheringItem = new int[100];
            GatheringItem[0] = parser.ReadOffset< int >( 0x0 );
            GatheringItem[1] = parser.ReadOffset< int >( 0x4 );
            GatheringItem[2] = parser.ReadOffset< int >( 0x8 );
            GatheringItem[3] = parser.ReadOffset< int >( 0xc );
            GatheringItem[4] = parser.ReadOffset< int >( 0x10 );
            GatheringItem[5] = parser.ReadOffset< int >( 0x14 );
            GatheringItem[6] = parser.ReadOffset< int >( 0x18 );
            GatheringItem[7] = parser.ReadOffset< int >( 0x1c );
            GatheringItem[8] = parser.ReadOffset< int >( 0x20 );
            GatheringItem[9] = parser.ReadOffset< int >( 0x24 );
            GatheringItem[10] = parser.ReadOffset< int >( 0x28 );
            GatheringItem[11] = parser.ReadOffset< int >( 0x2c );
            GatheringItem[12] = parser.ReadOffset< int >( 0x30 );
            GatheringItem[13] = parser.ReadOffset< int >( 0x34 );
            GatheringItem[14] = parser.ReadOffset< int >( 0x38 );
            GatheringItem[15] = parser.ReadOffset< int >( 0x3c );
            GatheringItem[16] = parser.ReadOffset< int >( 0x40 );
            GatheringItem[17] = parser.ReadOffset< int >( 0x44 );
            GatheringItem[18] = parser.ReadOffset< int >( 0x48 );
            GatheringItem[19] = parser.ReadOffset< int >( 0x4c );
            GatheringItem[20] = parser.ReadOffset< int >( 0x50 );
            GatheringItem[21] = parser.ReadOffset< int >( 0x54 );
            GatheringItem[22] = parser.ReadOffset< int >( 0x58 );
            GatheringItem[23] = parser.ReadOffset< int >( 0x5c );
            GatheringItem[24] = parser.ReadOffset< int >( 0x60 );
            GatheringItem[25] = parser.ReadOffset< int >( 0x64 );
            GatheringItem[26] = parser.ReadOffset< int >( 0x68 );
            GatheringItem[27] = parser.ReadOffset< int >( 0x6c );
            GatheringItem[28] = parser.ReadOffset< int >( 0x70 );
            GatheringItem[29] = parser.ReadOffset< int >( 0x74 );
            GatheringItem[30] = parser.ReadOffset< int >( 0x78 );
            GatheringItem[31] = parser.ReadOffset< int >( 0x7c );
            GatheringItem[32] = parser.ReadOffset< int >( 0x80 );
            GatheringItem[33] = parser.ReadOffset< int >( 0x84 );
            GatheringItem[34] = parser.ReadOffset< int >( 0x88 );
            GatheringItem[35] = parser.ReadOffset< int >( 0x8c );
            GatheringItem[36] = parser.ReadOffset< int >( 0x90 );
            GatheringItem[37] = parser.ReadOffset< int >( 0x94 );
            GatheringItem[38] = parser.ReadOffset< int >( 0x98 );
            GatheringItem[39] = parser.ReadOffset< int >( 0x9c );
            GatheringItem[40] = parser.ReadOffset< int >( 0xa0 );
            GatheringItem[41] = parser.ReadOffset< int >( 0xa4 );
            GatheringItem[42] = parser.ReadOffset< int >( 0xa8 );
            GatheringItem[43] = parser.ReadOffset< int >( 0xac );
            GatheringItem[44] = parser.ReadOffset< int >( 0xb0 );
            GatheringItem[45] = parser.ReadOffset< int >( 0xb4 );
            GatheringItem[46] = parser.ReadOffset< int >( 0xb8 );
            GatheringItem[47] = parser.ReadOffset< int >( 0xbc );
            GatheringItem[48] = parser.ReadOffset< int >( 0xc0 );
            GatheringItem[49] = parser.ReadOffset< int >( 0xc4 );
            GatheringItem[50] = parser.ReadOffset< int >( 0xc8 );
            GatheringItem[51] = parser.ReadOffset< int >( 0xcc );
            GatheringItem[52] = parser.ReadOffset< int >( 0xd0 );
            GatheringItem[53] = parser.ReadOffset< int >( 0xd4 );
            GatheringItem[54] = parser.ReadOffset< int >( 0xd8 );
            GatheringItem[55] = parser.ReadOffset< int >( 0xdc );
            GatheringItem[56] = parser.ReadOffset< int >( 0xe0 );
            GatheringItem[57] = parser.ReadOffset< int >( 0xe4 );
            GatheringItem[58] = parser.ReadOffset< int >( 0xe8 );
            GatheringItem[59] = parser.ReadOffset< int >( 0xec );
            GatheringItem[60] = parser.ReadOffset< int >( 0xf0 );
            GatheringItem[61] = parser.ReadOffset< int >( 0xf4 );
            GatheringItem[62] = parser.ReadOffset< int >( 0xf8 );
            GatheringItem[63] = parser.ReadOffset< int >( 0xfc );
            GatheringItem[64] = parser.ReadOffset< int >( 0x100 );
            GatheringItem[65] = parser.ReadOffset< int >( 0x104 );
            GatheringItem[66] = parser.ReadOffset< int >( 0x108 );
            GatheringItem[67] = parser.ReadOffset< int >( 0x10c );
            GatheringItem[68] = parser.ReadOffset< int >( 0x110 );
            GatheringItem[69] = parser.ReadOffset< int >( 0x114 );
            GatheringItem[70] = parser.ReadOffset< int >( 0x118 );
            GatheringItem[71] = parser.ReadOffset< int >( 0x11c );
            GatheringItem[72] = parser.ReadOffset< int >( 0x120 );
            GatheringItem[73] = parser.ReadOffset< int >( 0x124 );
            GatheringItem[74] = parser.ReadOffset< int >( 0x128 );
            GatheringItem[75] = parser.ReadOffset< int >( 0x12c );
            GatheringItem[76] = parser.ReadOffset< int >( 0x130 );
            GatheringItem[77] = parser.ReadOffset< int >( 0x134 );
            GatheringItem[78] = parser.ReadOffset< int >( 0x138 );
            GatheringItem[79] = parser.ReadOffset< int >( 0x13c );
            GatheringItem[80] = parser.ReadOffset< int >( 0x140 );
            GatheringItem[81] = parser.ReadOffset< int >( 0x144 );
            GatheringItem[82] = parser.ReadOffset< int >( 0x148 );
            GatheringItem[83] = parser.ReadOffset< int >( 0x14c );
            GatheringItem[84] = parser.ReadOffset< int >( 0x150 );
            GatheringItem[85] = parser.ReadOffset< int >( 0x154 );
            GatheringItem[86] = parser.ReadOffset< int >( 0x158 );
            GatheringItem[87] = parser.ReadOffset< int >( 0x15c );
            GatheringItem[88] = parser.ReadOffset< int >( 0x160 );
            GatheringItem[89] = parser.ReadOffset< int >( 0x164 );
            GatheringItem[90] = parser.ReadOffset< int >( 0x168 );
            GatheringItem[91] = parser.ReadOffset< int >( 0x16c );
            GatheringItem[92] = parser.ReadOffset< int >( 0x170 );
            GatheringItem[93] = parser.ReadOffset< int >( 0x174 );
            GatheringItem[94] = parser.ReadOffset< int >( 0x178 );
            GatheringItem[95] = parser.ReadOffset< int >( 0x17c );
            GatheringItem[96] = parser.ReadOffset< int >( 0x180 );
            GatheringItem[97] = parser.ReadOffset< int >( 0x184 );
            GatheringItem[98] = parser.ReadOffset< int >( 0x188 );
            GatheringItem[99] = parser.ReadOffset< int >( 0x18c );

            // col: 0 offset: 0190
            unknown190 = parser.ReadOffset< byte >( 0x190 );


        }
    }
}