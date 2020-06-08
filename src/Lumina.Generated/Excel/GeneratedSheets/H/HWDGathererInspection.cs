using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspection", columnHash: 0x79936cf0 )]
    public class HWDGathererInspection : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint[] ItemRequired;

        // col: 32 offset: 0004
        public uint[] FishParameter;

        // col: 96 offset: 0008
        public uint[] ItemReceived;

        // col: 128 offset: 000c
        public ushort[] Reward1;

        // col: 160 offset: 000e
        public ushort[] Reward2;

        // col: 64 offset: 0010
        public byte[] AmountRequired;

        // col: 192 offset: 0011
        public byte[] Phase;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ItemRequired = new uint[32];
            ItemRequired[0] = parser.ReadOffset< uint >( 0x0 );
            ItemRequired[1] = parser.ReadOffset< uint >( 0x14 );
            ItemRequired[2] = parser.ReadOffset< uint >( 0x28 );
            ItemRequired[3] = parser.ReadOffset< uint >( 0x3c );
            ItemRequired[4] = parser.ReadOffset< uint >( 0x50 );
            ItemRequired[5] = parser.ReadOffset< uint >( 0x64 );
            ItemRequired[6] = parser.ReadOffset< uint >( 0x78 );
            ItemRequired[7] = parser.ReadOffset< uint >( 0x8c );
            ItemRequired[8] = parser.ReadOffset< uint >( 0xa0 );
            ItemRequired[9] = parser.ReadOffset< uint >( 0xb4 );
            ItemRequired[10] = parser.ReadOffset< uint >( 0xc8 );
            ItemRequired[11] = parser.ReadOffset< uint >( 0xdc );
            ItemRequired[12] = parser.ReadOffset< uint >( 0xf0 );
            ItemRequired[13] = parser.ReadOffset< uint >( 0x104 );
            ItemRequired[14] = parser.ReadOffset< uint >( 0x118 );
            ItemRequired[15] = parser.ReadOffset< uint >( 0x12c );
            ItemRequired[16] = parser.ReadOffset< uint >( 0x140 );
            ItemRequired[17] = parser.ReadOffset< uint >( 0x154 );
            ItemRequired[18] = parser.ReadOffset< uint >( 0x168 );
            ItemRequired[19] = parser.ReadOffset< uint >( 0x17c );
            ItemRequired[20] = parser.ReadOffset< uint >( 0x190 );
            ItemRequired[21] = parser.ReadOffset< uint >( 0x1a4 );
            ItemRequired[22] = parser.ReadOffset< uint >( 0x1b8 );
            ItemRequired[23] = parser.ReadOffset< uint >( 0x1cc );
            ItemRequired[24] = parser.ReadOffset< uint >( 0x1e0 );
            ItemRequired[25] = parser.ReadOffset< uint >( 0x1f4 );
            ItemRequired[26] = parser.ReadOffset< uint >( 0x208 );
            ItemRequired[27] = parser.ReadOffset< uint >( 0x21c );
            ItemRequired[28] = parser.ReadOffset< uint >( 0x230 );
            ItemRequired[29] = parser.ReadOffset< uint >( 0x244 );
            ItemRequired[30] = parser.ReadOffset< uint >( 0x258 );
            ItemRequired[31] = parser.ReadOffset< uint >( 0x26c );

            // col: 32 offset: 0004
            FishParameter = new uint[32];
            FishParameter[0] = parser.ReadOffset< uint >( 0x4 );
            FishParameter[1] = parser.ReadOffset< uint >( 0x18 );
            FishParameter[2] = parser.ReadOffset< uint >( 0x2c );
            FishParameter[3] = parser.ReadOffset< uint >( 0x40 );
            FishParameter[4] = parser.ReadOffset< uint >( 0x54 );
            FishParameter[5] = parser.ReadOffset< uint >( 0x68 );
            FishParameter[6] = parser.ReadOffset< uint >( 0x7c );
            FishParameter[7] = parser.ReadOffset< uint >( 0x90 );
            FishParameter[8] = parser.ReadOffset< uint >( 0xa4 );
            FishParameter[9] = parser.ReadOffset< uint >( 0xb8 );
            FishParameter[10] = parser.ReadOffset< uint >( 0xcc );
            FishParameter[11] = parser.ReadOffset< uint >( 0xe0 );
            FishParameter[12] = parser.ReadOffset< uint >( 0xf4 );
            FishParameter[13] = parser.ReadOffset< uint >( 0x108 );
            FishParameter[14] = parser.ReadOffset< uint >( 0x11c );
            FishParameter[15] = parser.ReadOffset< uint >( 0x130 );
            FishParameter[16] = parser.ReadOffset< uint >( 0x144 );
            FishParameter[17] = parser.ReadOffset< uint >( 0x158 );
            FishParameter[18] = parser.ReadOffset< uint >( 0x16c );
            FishParameter[19] = parser.ReadOffset< uint >( 0x180 );
            FishParameter[20] = parser.ReadOffset< uint >( 0x194 );
            FishParameter[21] = parser.ReadOffset< uint >( 0x1a8 );
            FishParameter[22] = parser.ReadOffset< uint >( 0x1bc );
            FishParameter[23] = parser.ReadOffset< uint >( 0x1d0 );
            FishParameter[24] = parser.ReadOffset< uint >( 0x1e4 );
            FishParameter[25] = parser.ReadOffset< uint >( 0x1f8 );
            FishParameter[26] = parser.ReadOffset< uint >( 0x20c );
            FishParameter[27] = parser.ReadOffset< uint >( 0x220 );
            FishParameter[28] = parser.ReadOffset< uint >( 0x234 );
            FishParameter[29] = parser.ReadOffset< uint >( 0x248 );
            FishParameter[30] = parser.ReadOffset< uint >( 0x25c );
            FishParameter[31] = parser.ReadOffset< uint >( 0x270 );

            // col: 96 offset: 0008
            ItemReceived = new uint[32];
            ItemReceived[0] = parser.ReadOffset< uint >( 0x8 );
            ItemReceived[1] = parser.ReadOffset< uint >( 0x1c );
            ItemReceived[2] = parser.ReadOffset< uint >( 0x30 );
            ItemReceived[3] = parser.ReadOffset< uint >( 0x44 );
            ItemReceived[4] = parser.ReadOffset< uint >( 0x58 );
            ItemReceived[5] = parser.ReadOffset< uint >( 0x6c );
            ItemReceived[6] = parser.ReadOffset< uint >( 0x80 );
            ItemReceived[7] = parser.ReadOffset< uint >( 0x94 );
            ItemReceived[8] = parser.ReadOffset< uint >( 0xa8 );
            ItemReceived[9] = parser.ReadOffset< uint >( 0xbc );
            ItemReceived[10] = parser.ReadOffset< uint >( 0xd0 );
            ItemReceived[11] = parser.ReadOffset< uint >( 0xe4 );
            ItemReceived[12] = parser.ReadOffset< uint >( 0xf8 );
            ItemReceived[13] = parser.ReadOffset< uint >( 0x10c );
            ItemReceived[14] = parser.ReadOffset< uint >( 0x120 );
            ItemReceived[15] = parser.ReadOffset< uint >( 0x134 );
            ItemReceived[16] = parser.ReadOffset< uint >( 0x148 );
            ItemReceived[17] = parser.ReadOffset< uint >( 0x15c );
            ItemReceived[18] = parser.ReadOffset< uint >( 0x170 );
            ItemReceived[19] = parser.ReadOffset< uint >( 0x184 );
            ItemReceived[20] = parser.ReadOffset< uint >( 0x198 );
            ItemReceived[21] = parser.ReadOffset< uint >( 0x1ac );
            ItemReceived[22] = parser.ReadOffset< uint >( 0x1c0 );
            ItemReceived[23] = parser.ReadOffset< uint >( 0x1d4 );
            ItemReceived[24] = parser.ReadOffset< uint >( 0x1e8 );
            ItemReceived[25] = parser.ReadOffset< uint >( 0x1fc );
            ItemReceived[26] = parser.ReadOffset< uint >( 0x210 );
            ItemReceived[27] = parser.ReadOffset< uint >( 0x224 );
            ItemReceived[28] = parser.ReadOffset< uint >( 0x238 );
            ItemReceived[29] = parser.ReadOffset< uint >( 0x24c );
            ItemReceived[30] = parser.ReadOffset< uint >( 0x260 );
            ItemReceived[31] = parser.ReadOffset< uint >( 0x274 );

            // col: 128 offset: 000c
            Reward1 = new ushort[32];
            Reward1[0] = parser.ReadOffset< ushort >( 0xc );
            Reward1[1] = parser.ReadOffset< ushort >( 0x20 );
            Reward1[2] = parser.ReadOffset< ushort >( 0x34 );
            Reward1[3] = parser.ReadOffset< ushort >( 0x48 );
            Reward1[4] = parser.ReadOffset< ushort >( 0x5c );
            Reward1[5] = parser.ReadOffset< ushort >( 0x70 );
            Reward1[6] = parser.ReadOffset< ushort >( 0x84 );
            Reward1[7] = parser.ReadOffset< ushort >( 0x98 );
            Reward1[8] = parser.ReadOffset< ushort >( 0xac );
            Reward1[9] = parser.ReadOffset< ushort >( 0xc0 );
            Reward1[10] = parser.ReadOffset< ushort >( 0xd4 );
            Reward1[11] = parser.ReadOffset< ushort >( 0xe8 );
            Reward1[12] = parser.ReadOffset< ushort >( 0xfc );
            Reward1[13] = parser.ReadOffset< ushort >( 0x110 );
            Reward1[14] = parser.ReadOffset< ushort >( 0x124 );
            Reward1[15] = parser.ReadOffset< ushort >( 0x138 );
            Reward1[16] = parser.ReadOffset< ushort >( 0x14c );
            Reward1[17] = parser.ReadOffset< ushort >( 0x160 );
            Reward1[18] = parser.ReadOffset< ushort >( 0x174 );
            Reward1[19] = parser.ReadOffset< ushort >( 0x188 );
            Reward1[20] = parser.ReadOffset< ushort >( 0x19c );
            Reward1[21] = parser.ReadOffset< ushort >( 0x1b0 );
            Reward1[22] = parser.ReadOffset< ushort >( 0x1c4 );
            Reward1[23] = parser.ReadOffset< ushort >( 0x1d8 );
            Reward1[24] = parser.ReadOffset< ushort >( 0x1ec );
            Reward1[25] = parser.ReadOffset< ushort >( 0x200 );
            Reward1[26] = parser.ReadOffset< ushort >( 0x214 );
            Reward1[27] = parser.ReadOffset< ushort >( 0x228 );
            Reward1[28] = parser.ReadOffset< ushort >( 0x23c );
            Reward1[29] = parser.ReadOffset< ushort >( 0x250 );
            Reward1[30] = parser.ReadOffset< ushort >( 0x264 );
            Reward1[31] = parser.ReadOffset< ushort >( 0x278 );

            // col: 160 offset: 000e
            Reward2 = new ushort[32];
            Reward2[0] = parser.ReadOffset< ushort >( 0xe );
            Reward2[1] = parser.ReadOffset< ushort >( 0x22 );
            Reward2[2] = parser.ReadOffset< ushort >( 0x36 );
            Reward2[3] = parser.ReadOffset< ushort >( 0x4a );
            Reward2[4] = parser.ReadOffset< ushort >( 0x5e );
            Reward2[5] = parser.ReadOffset< ushort >( 0x72 );
            Reward2[6] = parser.ReadOffset< ushort >( 0x86 );
            Reward2[7] = parser.ReadOffset< ushort >( 0x9a );
            Reward2[8] = parser.ReadOffset< ushort >( 0xae );
            Reward2[9] = parser.ReadOffset< ushort >( 0xc2 );
            Reward2[10] = parser.ReadOffset< ushort >( 0xd6 );
            Reward2[11] = parser.ReadOffset< ushort >( 0xea );
            Reward2[12] = parser.ReadOffset< ushort >( 0xfe );
            Reward2[13] = parser.ReadOffset< ushort >( 0x112 );
            Reward2[14] = parser.ReadOffset< ushort >( 0x126 );
            Reward2[15] = parser.ReadOffset< ushort >( 0x13a );
            Reward2[16] = parser.ReadOffset< ushort >( 0x14e );
            Reward2[17] = parser.ReadOffset< ushort >( 0x162 );
            Reward2[18] = parser.ReadOffset< ushort >( 0x176 );
            Reward2[19] = parser.ReadOffset< ushort >( 0x18a );
            Reward2[20] = parser.ReadOffset< ushort >( 0x19e );
            Reward2[21] = parser.ReadOffset< ushort >( 0x1b2 );
            Reward2[22] = parser.ReadOffset< ushort >( 0x1c6 );
            Reward2[23] = parser.ReadOffset< ushort >( 0x1da );
            Reward2[24] = parser.ReadOffset< ushort >( 0x1ee );
            Reward2[25] = parser.ReadOffset< ushort >( 0x202 );
            Reward2[26] = parser.ReadOffset< ushort >( 0x216 );
            Reward2[27] = parser.ReadOffset< ushort >( 0x22a );
            Reward2[28] = parser.ReadOffset< ushort >( 0x23e );
            Reward2[29] = parser.ReadOffset< ushort >( 0x252 );
            Reward2[30] = parser.ReadOffset< ushort >( 0x266 );
            Reward2[31] = parser.ReadOffset< ushort >( 0x27a );

            // col: 64 offset: 0010
            AmountRequired = new byte[32];
            AmountRequired[0] = parser.ReadOffset< byte >( 0x10 );
            AmountRequired[1] = parser.ReadOffset< byte >( 0x24 );
            AmountRequired[2] = parser.ReadOffset< byte >( 0x38 );
            AmountRequired[3] = parser.ReadOffset< byte >( 0x4c );
            AmountRequired[4] = parser.ReadOffset< byte >( 0x60 );
            AmountRequired[5] = parser.ReadOffset< byte >( 0x74 );
            AmountRequired[6] = parser.ReadOffset< byte >( 0x88 );
            AmountRequired[7] = parser.ReadOffset< byte >( 0x9c );
            AmountRequired[8] = parser.ReadOffset< byte >( 0xb0 );
            AmountRequired[9] = parser.ReadOffset< byte >( 0xc4 );
            AmountRequired[10] = parser.ReadOffset< byte >( 0xd8 );
            AmountRequired[11] = parser.ReadOffset< byte >( 0xec );
            AmountRequired[12] = parser.ReadOffset< byte >( 0x100 );
            AmountRequired[13] = parser.ReadOffset< byte >( 0x114 );
            AmountRequired[14] = parser.ReadOffset< byte >( 0x128 );
            AmountRequired[15] = parser.ReadOffset< byte >( 0x13c );
            AmountRequired[16] = parser.ReadOffset< byte >( 0x150 );
            AmountRequired[17] = parser.ReadOffset< byte >( 0x164 );
            AmountRequired[18] = parser.ReadOffset< byte >( 0x178 );
            AmountRequired[19] = parser.ReadOffset< byte >( 0x18c );
            AmountRequired[20] = parser.ReadOffset< byte >( 0x1a0 );
            AmountRequired[21] = parser.ReadOffset< byte >( 0x1b4 );
            AmountRequired[22] = parser.ReadOffset< byte >( 0x1c8 );
            AmountRequired[23] = parser.ReadOffset< byte >( 0x1dc );
            AmountRequired[24] = parser.ReadOffset< byte >( 0x1f0 );
            AmountRequired[25] = parser.ReadOffset< byte >( 0x204 );
            AmountRequired[26] = parser.ReadOffset< byte >( 0x218 );
            AmountRequired[27] = parser.ReadOffset< byte >( 0x22c );
            AmountRequired[28] = parser.ReadOffset< byte >( 0x240 );
            AmountRequired[29] = parser.ReadOffset< byte >( 0x254 );
            AmountRequired[30] = parser.ReadOffset< byte >( 0x268 );
            AmountRequired[31] = parser.ReadOffset< byte >( 0x27c );

            // col: 192 offset: 0011
            Phase = new byte[32];
            Phase[0] = parser.ReadOffset< byte >( 0x11 );
            Phase[1] = parser.ReadOffset< byte >( 0x25 );
            Phase[2] = parser.ReadOffset< byte >( 0x39 );
            Phase[3] = parser.ReadOffset< byte >( 0x4d );
            Phase[4] = parser.ReadOffset< byte >( 0x61 );
            Phase[5] = parser.ReadOffset< byte >( 0x75 );
            Phase[6] = parser.ReadOffset< byte >( 0x89 );
            Phase[7] = parser.ReadOffset< byte >( 0x9d );
            Phase[8] = parser.ReadOffset< byte >( 0xb1 );
            Phase[9] = parser.ReadOffset< byte >( 0xc5 );
            Phase[10] = parser.ReadOffset< byte >( 0xd9 );
            Phase[11] = parser.ReadOffset< byte >( 0xed );
            Phase[12] = parser.ReadOffset< byte >( 0x101 );
            Phase[13] = parser.ReadOffset< byte >( 0x115 );
            Phase[14] = parser.ReadOffset< byte >( 0x129 );
            Phase[15] = parser.ReadOffset< byte >( 0x13d );
            Phase[16] = parser.ReadOffset< byte >( 0x151 );
            Phase[17] = parser.ReadOffset< byte >( 0x165 );
            Phase[18] = parser.ReadOffset< byte >( 0x179 );
            Phase[19] = parser.ReadOffset< byte >( 0x18d );
            Phase[20] = parser.ReadOffset< byte >( 0x1a1 );
            Phase[21] = parser.ReadOffset< byte >( 0x1b5 );
            Phase[22] = parser.ReadOffset< byte >( 0x1c9 );
            Phase[23] = parser.ReadOffset< byte >( 0x1dd );
            Phase[24] = parser.ReadOffset< byte >( 0x1f1 );
            Phase[25] = parser.ReadOffset< byte >( 0x205 );
            Phase[26] = parser.ReadOffset< byte >( 0x219 );
            Phase[27] = parser.ReadOffset< byte >( 0x22d );
            Phase[28] = parser.ReadOffset< byte >( 0x241 );
            Phase[29] = parser.ReadOffset< byte >( 0x255 );
            Phase[30] = parser.ReadOffset< byte >( 0x269 );
            Phase[31] = parser.ReadOffset< byte >( 0x27d );


        }
    }
}