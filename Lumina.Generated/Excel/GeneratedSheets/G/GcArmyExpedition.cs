using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpedition", columnHash: 0x4695a239 )]
    public class GcArmyExpedition : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 08 offset: 0000
        public string Name;

        // col: 09 offset: 0004
        public string Description;

        // col: 10 offset: 0008
        public int[] unknown8;

        // col: 22 offset: 000c
        public ushort[] unknownc;

        // col: 34 offset: 000e
        public ushort[] unknowne;

        // col: 46 offset: 0010
        public ushort[] unknown10;

        // col: 16 offset: 0012
        public byte[] unknown12;

        // col: 28 offset: 0013
        public byte[] unknown13;

        // col: 40 offset: 0014
        public byte[] unknown14;

        // col: 52 offset: 0015
        public byte[] unknown15;

        // col: 58 offset: 0016
        public byte[] unknown16;

        // col: 04 offset: 0068
        public uint RewardExperience;

        // col: 03 offset: 006c
        public ushort RequiredSeals;

        // col: 00 offset: 006e
        public byte RequiredFlag;

        // col: 01 offset: 006f
        public byte UnlockFlag;

        // col: 02 offset: 0070
        public byte RequiredLevel;

        // col: 05 offset: 0071
        public byte PercentBase;

        // col: 06 offset: 0072
        public byte unknown72;

        // col: 07 offset: 0073
        public byte GcArmyExpeditionType;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 8 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 9 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 10 offset: 0008
            unknown8 = new int[6];
            unknown8[0] = parser.ReadOffset< int >( 0x8 );
            unknown8[1] = parser.ReadOffset< int >( 0x18 );
            unknown8[2] = parser.ReadOffset< int >( 0x28 );
            unknown8[3] = parser.ReadOffset< int >( 0x38 );
            unknown8[4] = parser.ReadOffset< int >( 0x48 );
            unknown8[5] = parser.ReadOffset< int >( 0x58 );

            // col: 22 offset: 000c
            unknownc = new ushort[6];
            unknownc[0] = parser.ReadOffset< ushort >( 0xc );
            unknownc[1] = parser.ReadOffset< ushort >( 0x1c );
            unknownc[2] = parser.ReadOffset< ushort >( 0x2c );
            unknownc[3] = parser.ReadOffset< ushort >( 0x3c );
            unknownc[4] = parser.ReadOffset< ushort >( 0x4c );
            unknownc[5] = parser.ReadOffset< ushort >( 0x5c );

            // col: 34 offset: 000e
            unknowne = new ushort[6];
            unknowne[0] = parser.ReadOffset< ushort >( 0xe );
            unknowne[1] = parser.ReadOffset< ushort >( 0x1e );
            unknowne[2] = parser.ReadOffset< ushort >( 0x2e );
            unknowne[3] = parser.ReadOffset< ushort >( 0x3e );
            unknowne[4] = parser.ReadOffset< ushort >( 0x4e );
            unknowne[5] = parser.ReadOffset< ushort >( 0x5e );

            // col: 46 offset: 0010
            unknown10 = new ushort[6];
            unknown10[0] = parser.ReadOffset< ushort >( 0x10 );
            unknown10[1] = parser.ReadOffset< ushort >( 0x20 );
            unknown10[2] = parser.ReadOffset< ushort >( 0x30 );
            unknown10[3] = parser.ReadOffset< ushort >( 0x40 );
            unknown10[4] = parser.ReadOffset< ushort >( 0x50 );
            unknown10[5] = parser.ReadOffset< ushort >( 0x60 );

            // col: 16 offset: 0012
            unknown12 = new byte[6];
            unknown12[0] = parser.ReadOffset< byte >( 0x12 );
            unknown12[1] = parser.ReadOffset< byte >( 0x22 );
            unknown12[2] = parser.ReadOffset< byte >( 0x32 );
            unknown12[3] = parser.ReadOffset< byte >( 0x42 );
            unknown12[4] = parser.ReadOffset< byte >( 0x52 );
            unknown12[5] = parser.ReadOffset< byte >( 0x62 );

            // col: 28 offset: 0013
            unknown13 = new byte[6];
            unknown13[0] = parser.ReadOffset< byte >( 0x13 );
            unknown13[1] = parser.ReadOffset< byte >( 0x23 );
            unknown13[2] = parser.ReadOffset< byte >( 0x33 );
            unknown13[3] = parser.ReadOffset< byte >( 0x43 );
            unknown13[4] = parser.ReadOffset< byte >( 0x53 );
            unknown13[5] = parser.ReadOffset< byte >( 0x63 );

            // col: 40 offset: 0014
            unknown14 = new byte[6];
            unknown14[0] = parser.ReadOffset< byte >( 0x14 );
            unknown14[1] = parser.ReadOffset< byte >( 0x24 );
            unknown14[2] = parser.ReadOffset< byte >( 0x34 );
            unknown14[3] = parser.ReadOffset< byte >( 0x44 );
            unknown14[4] = parser.ReadOffset< byte >( 0x54 );
            unknown14[5] = parser.ReadOffset< byte >( 0x64 );

            // col: 52 offset: 0015
            unknown15 = new byte[6];
            unknown15[0] = parser.ReadOffset< byte >( 0x15 );
            unknown15[1] = parser.ReadOffset< byte >( 0x25 );
            unknown15[2] = parser.ReadOffset< byte >( 0x35 );
            unknown15[3] = parser.ReadOffset< byte >( 0x45 );
            unknown15[4] = parser.ReadOffset< byte >( 0x55 );
            unknown15[5] = parser.ReadOffset< byte >( 0x65 );

            // col: 58 offset: 0016
            unknown16 = new byte[6];
            unknown16[0] = parser.ReadOffset< byte >( 0x16 );
            unknown16[1] = parser.ReadOffset< byte >( 0x26 );
            unknown16[2] = parser.ReadOffset< byte >( 0x36 );
            unknown16[3] = parser.ReadOffset< byte >( 0x46 );
            unknown16[4] = parser.ReadOffset< byte >( 0x56 );
            unknown16[5] = parser.ReadOffset< byte >( 0x66 );

            // col: 4 offset: 0068
            RewardExperience = parser.ReadOffset< uint >( 0x68 );

            // col: 3 offset: 006c
            RequiredSeals = parser.ReadOffset< ushort >( 0x6c );

            // col: 0 offset: 006e
            RequiredFlag = parser.ReadOffset< byte >( 0x6e );

            // col: 1 offset: 006f
            UnlockFlag = parser.ReadOffset< byte >( 0x6f );

            // col: 2 offset: 0070
            RequiredLevel = parser.ReadOffset< byte >( 0x70 );

            // col: 5 offset: 0071
            PercentBase = parser.ReadOffset< byte >( 0x71 );

            // col: 6 offset: 0072
            unknown72 = parser.ReadOffset< byte >( 0x72 );

            // col: 7 offset: 0073
            GcArmyExpeditionType = parser.ReadOffset< byte >( 0x73 );


        }
    }
}