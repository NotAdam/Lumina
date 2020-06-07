using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeNotebookList", columnHash: 0x598ed482 )]
    public class RecipeNotebookList : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int[] Recipe;

        // col: 00 offset: 0280
        public byte unknown280;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Recipe = new int[160];
            Recipe[0] = parser.ReadOffset< int >( 0x0 );
            Recipe[1] = parser.ReadOffset< int >( 0x4 );
            Recipe[2] = parser.ReadOffset< int >( 0x8 );
            Recipe[3] = parser.ReadOffset< int >( 0xc );
            Recipe[4] = parser.ReadOffset< int >( 0x10 );
            Recipe[5] = parser.ReadOffset< int >( 0x14 );
            Recipe[6] = parser.ReadOffset< int >( 0x18 );
            Recipe[7] = parser.ReadOffset< int >( 0x1c );
            Recipe[8] = parser.ReadOffset< int >( 0x20 );
            Recipe[9] = parser.ReadOffset< int >( 0x24 );
            Recipe[10] = parser.ReadOffset< int >( 0x28 );
            Recipe[11] = parser.ReadOffset< int >( 0x2c );
            Recipe[12] = parser.ReadOffset< int >( 0x30 );
            Recipe[13] = parser.ReadOffset< int >( 0x34 );
            Recipe[14] = parser.ReadOffset< int >( 0x38 );
            Recipe[15] = parser.ReadOffset< int >( 0x3c );
            Recipe[16] = parser.ReadOffset< int >( 0x40 );
            Recipe[17] = parser.ReadOffset< int >( 0x44 );
            Recipe[18] = parser.ReadOffset< int >( 0x48 );
            Recipe[19] = parser.ReadOffset< int >( 0x4c );
            Recipe[20] = parser.ReadOffset< int >( 0x50 );
            Recipe[21] = parser.ReadOffset< int >( 0x54 );
            Recipe[22] = parser.ReadOffset< int >( 0x58 );
            Recipe[23] = parser.ReadOffset< int >( 0x5c );
            Recipe[24] = parser.ReadOffset< int >( 0x60 );
            Recipe[25] = parser.ReadOffset< int >( 0x64 );
            Recipe[26] = parser.ReadOffset< int >( 0x68 );
            Recipe[27] = parser.ReadOffset< int >( 0x6c );
            Recipe[28] = parser.ReadOffset< int >( 0x70 );
            Recipe[29] = parser.ReadOffset< int >( 0x74 );
            Recipe[30] = parser.ReadOffset< int >( 0x78 );
            Recipe[31] = parser.ReadOffset< int >( 0x7c );
            Recipe[32] = parser.ReadOffset< int >( 0x80 );
            Recipe[33] = parser.ReadOffset< int >( 0x84 );
            Recipe[34] = parser.ReadOffset< int >( 0x88 );
            Recipe[35] = parser.ReadOffset< int >( 0x8c );
            Recipe[36] = parser.ReadOffset< int >( 0x90 );
            Recipe[37] = parser.ReadOffset< int >( 0x94 );
            Recipe[38] = parser.ReadOffset< int >( 0x98 );
            Recipe[39] = parser.ReadOffset< int >( 0x9c );
            Recipe[40] = parser.ReadOffset< int >( 0xa0 );
            Recipe[41] = parser.ReadOffset< int >( 0xa4 );
            Recipe[42] = parser.ReadOffset< int >( 0xa8 );
            Recipe[43] = parser.ReadOffset< int >( 0xac );
            Recipe[44] = parser.ReadOffset< int >( 0xb0 );
            Recipe[45] = parser.ReadOffset< int >( 0xb4 );
            Recipe[46] = parser.ReadOffset< int >( 0xb8 );
            Recipe[47] = parser.ReadOffset< int >( 0xbc );
            Recipe[48] = parser.ReadOffset< int >( 0xc0 );
            Recipe[49] = parser.ReadOffset< int >( 0xc4 );
            Recipe[50] = parser.ReadOffset< int >( 0xc8 );
            Recipe[51] = parser.ReadOffset< int >( 0xcc );
            Recipe[52] = parser.ReadOffset< int >( 0xd0 );
            Recipe[53] = parser.ReadOffset< int >( 0xd4 );
            Recipe[54] = parser.ReadOffset< int >( 0xd8 );
            Recipe[55] = parser.ReadOffset< int >( 0xdc );
            Recipe[56] = parser.ReadOffset< int >( 0xe0 );
            Recipe[57] = parser.ReadOffset< int >( 0xe4 );
            Recipe[58] = parser.ReadOffset< int >( 0xe8 );
            Recipe[59] = parser.ReadOffset< int >( 0xec );
            Recipe[60] = parser.ReadOffset< int >( 0xf0 );
            Recipe[61] = parser.ReadOffset< int >( 0xf4 );
            Recipe[62] = parser.ReadOffset< int >( 0xf8 );
            Recipe[63] = parser.ReadOffset< int >( 0xfc );
            Recipe[64] = parser.ReadOffset< int >( 0x100 );
            Recipe[65] = parser.ReadOffset< int >( 0x104 );
            Recipe[66] = parser.ReadOffset< int >( 0x108 );
            Recipe[67] = parser.ReadOffset< int >( 0x10c );
            Recipe[68] = parser.ReadOffset< int >( 0x110 );
            Recipe[69] = parser.ReadOffset< int >( 0x114 );
            Recipe[70] = parser.ReadOffset< int >( 0x118 );
            Recipe[71] = parser.ReadOffset< int >( 0x11c );
            Recipe[72] = parser.ReadOffset< int >( 0x120 );
            Recipe[73] = parser.ReadOffset< int >( 0x124 );
            Recipe[74] = parser.ReadOffset< int >( 0x128 );
            Recipe[75] = parser.ReadOffset< int >( 0x12c );
            Recipe[76] = parser.ReadOffset< int >( 0x130 );
            Recipe[77] = parser.ReadOffset< int >( 0x134 );
            Recipe[78] = parser.ReadOffset< int >( 0x138 );
            Recipe[79] = parser.ReadOffset< int >( 0x13c );
            Recipe[80] = parser.ReadOffset< int >( 0x140 );
            Recipe[81] = parser.ReadOffset< int >( 0x144 );
            Recipe[82] = parser.ReadOffset< int >( 0x148 );
            Recipe[83] = parser.ReadOffset< int >( 0x14c );
            Recipe[84] = parser.ReadOffset< int >( 0x150 );
            Recipe[85] = parser.ReadOffset< int >( 0x154 );
            Recipe[86] = parser.ReadOffset< int >( 0x158 );
            Recipe[87] = parser.ReadOffset< int >( 0x15c );
            Recipe[88] = parser.ReadOffset< int >( 0x160 );
            Recipe[89] = parser.ReadOffset< int >( 0x164 );
            Recipe[90] = parser.ReadOffset< int >( 0x168 );
            Recipe[91] = parser.ReadOffset< int >( 0x16c );
            Recipe[92] = parser.ReadOffset< int >( 0x170 );
            Recipe[93] = parser.ReadOffset< int >( 0x174 );
            Recipe[94] = parser.ReadOffset< int >( 0x178 );
            Recipe[95] = parser.ReadOffset< int >( 0x17c );
            Recipe[96] = parser.ReadOffset< int >( 0x180 );
            Recipe[97] = parser.ReadOffset< int >( 0x184 );
            Recipe[98] = parser.ReadOffset< int >( 0x188 );
            Recipe[99] = parser.ReadOffset< int >( 0x18c );
            Recipe[100] = parser.ReadOffset< int >( 0x190 );
            Recipe[101] = parser.ReadOffset< int >( 0x194 );
            Recipe[102] = parser.ReadOffset< int >( 0x198 );
            Recipe[103] = parser.ReadOffset< int >( 0x19c );
            Recipe[104] = parser.ReadOffset< int >( 0x1a0 );
            Recipe[105] = parser.ReadOffset< int >( 0x1a4 );
            Recipe[106] = parser.ReadOffset< int >( 0x1a8 );
            Recipe[107] = parser.ReadOffset< int >( 0x1ac );
            Recipe[108] = parser.ReadOffset< int >( 0x1b0 );
            Recipe[109] = parser.ReadOffset< int >( 0x1b4 );
            Recipe[110] = parser.ReadOffset< int >( 0x1b8 );
            Recipe[111] = parser.ReadOffset< int >( 0x1bc );
            Recipe[112] = parser.ReadOffset< int >( 0x1c0 );
            Recipe[113] = parser.ReadOffset< int >( 0x1c4 );
            Recipe[114] = parser.ReadOffset< int >( 0x1c8 );
            Recipe[115] = parser.ReadOffset< int >( 0x1cc );
            Recipe[116] = parser.ReadOffset< int >( 0x1d0 );
            Recipe[117] = parser.ReadOffset< int >( 0x1d4 );
            Recipe[118] = parser.ReadOffset< int >( 0x1d8 );
            Recipe[119] = parser.ReadOffset< int >( 0x1dc );
            Recipe[120] = parser.ReadOffset< int >( 0x1e0 );
            Recipe[121] = parser.ReadOffset< int >( 0x1e4 );
            Recipe[122] = parser.ReadOffset< int >( 0x1e8 );
            Recipe[123] = parser.ReadOffset< int >( 0x1ec );
            Recipe[124] = parser.ReadOffset< int >( 0x1f0 );
            Recipe[125] = parser.ReadOffset< int >( 0x1f4 );
            Recipe[126] = parser.ReadOffset< int >( 0x1f8 );
            Recipe[127] = parser.ReadOffset< int >( 0x1fc );
            Recipe[128] = parser.ReadOffset< int >( 0x200 );
            Recipe[129] = parser.ReadOffset< int >( 0x204 );
            Recipe[130] = parser.ReadOffset< int >( 0x208 );
            Recipe[131] = parser.ReadOffset< int >( 0x20c );
            Recipe[132] = parser.ReadOffset< int >( 0x210 );
            Recipe[133] = parser.ReadOffset< int >( 0x214 );
            Recipe[134] = parser.ReadOffset< int >( 0x218 );
            Recipe[135] = parser.ReadOffset< int >( 0x21c );
            Recipe[136] = parser.ReadOffset< int >( 0x220 );
            Recipe[137] = parser.ReadOffset< int >( 0x224 );
            Recipe[138] = parser.ReadOffset< int >( 0x228 );
            Recipe[139] = parser.ReadOffset< int >( 0x22c );
            Recipe[140] = parser.ReadOffset< int >( 0x230 );
            Recipe[141] = parser.ReadOffset< int >( 0x234 );
            Recipe[142] = parser.ReadOffset< int >( 0x238 );
            Recipe[143] = parser.ReadOffset< int >( 0x23c );
            Recipe[144] = parser.ReadOffset< int >( 0x240 );
            Recipe[145] = parser.ReadOffset< int >( 0x244 );
            Recipe[146] = parser.ReadOffset< int >( 0x248 );
            Recipe[147] = parser.ReadOffset< int >( 0x24c );
            Recipe[148] = parser.ReadOffset< int >( 0x250 );
            Recipe[149] = parser.ReadOffset< int >( 0x254 );
            Recipe[150] = parser.ReadOffset< int >( 0x258 );
            Recipe[151] = parser.ReadOffset< int >( 0x25c );
            Recipe[152] = parser.ReadOffset< int >( 0x260 );
            Recipe[153] = parser.ReadOffset< int >( 0x264 );
            Recipe[154] = parser.ReadOffset< int >( 0x268 );
            Recipe[155] = parser.ReadOffset< int >( 0x26c );
            Recipe[156] = parser.ReadOffset< int >( 0x270 );
            Recipe[157] = parser.ReadOffset< int >( 0x274 );
            Recipe[158] = parser.ReadOffset< int >( 0x278 );
            Recipe[159] = parser.ReadOffset< int >( 0x27c );

            // col: 0 offset: 0280
            unknown280 = parser.ReadOffset< byte >( 0x280 );


        }
    }
}