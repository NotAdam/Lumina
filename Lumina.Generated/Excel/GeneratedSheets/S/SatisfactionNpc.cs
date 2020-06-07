using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionNpc", columnHash: 0x7a8036fa )]
    public class SatisfactionNpc : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public int[] SupplyIndex;

        // col: 16 offset: 0004
        public int[] unknown4;

        // col: 34 offset: 0008
        public int unknown8;

        // col: 52 offset: 000c
        public int unknownc;

        // col: 10 offset: 0010
        public ushort[] SatisfactionRequired;

        // col: 22 offset: 0012
        public byte unknown12;

        // col: 40 offset: 0013
        public byte unknown13;

        // col: 58 offset: 0014
        public byte unknown14;

        // col: 28 offset: 0015
        public bool unknown15;

        // col: 46 offset: 0016
        public bool unknown16;

        // col: 64 offset: 0017
        public bool unknown17;

        // col: 35 offset: 0020
        public int unknown20;

        // col: 53 offset: 0024
        public int unknown24;

        // col: 23 offset: 002a
        public byte unknown2a;

        // col: 41 offset: 002b
        public byte unknown2b;

        // col: 59 offset: 002c
        public byte unknown2c;

        // col: 29 offset: 002d
        public bool unknown2d;

        // col: 47 offset: 002e
        public bool unknown2e;

        // col: 65 offset: 002f
        public bool unknown2f;

        // col: 36 offset: 0038
        public int unknown38;

        // col: 54 offset: 003c
        public int unknown3c;

        // col: 24 offset: 0042
        public byte unknown42;

        // col: 42 offset: 0043
        public byte unknown43;

        // col: 60 offset: 0044
        public byte unknown44;

        // col: 30 offset: 0045
        public bool unknown45;

        // col: 48 offset: 0046
        public bool unknown46;

        // col: 66 offset: 0047
        public bool unknown47;

        // col: 19 offset: 004c
        public int unknown4c;

        // col: 37 offset: 0050
        public int unknown50;

        // col: 55 offset: 0054
        public int unknown54;

        // col: 25 offset: 005a
        public byte unknown5a;

        // col: 43 offset: 005b
        public byte unknown5b;

        // col: 61 offset: 005c
        public byte unknown5c;

        // col: 31 offset: 005d
        public bool unknown5d;

        // col: 49 offset: 005e
        public bool unknown5e;

        // col: 67 offset: 005f
        public bool unknown5f;

        // col: 20 offset: 0064
        public int unknown64;

        // col: 38 offset: 0068
        public int unknown68;

        // col: 56 offset: 006c
        public int unknown6c;

        // col: 26 offset: 0072
        public byte unknown72;

        // col: 44 offset: 0073
        public byte unknown73;

        // col: 62 offset: 0074
        public byte unknown74;

        // col: 32 offset: 0075
        public bool unknown75;

        // col: 50 offset: 0076
        public bool unknown76;

        // col: 68 offset: 0077
        public bool unknown77;

        // col: 21 offset: 007c
        public int unknown7c;

        // col: 39 offset: 0080
        public int unknown80;

        // col: 57 offset: 0084
        public int unknown84;

        // col: 27 offset: 008a
        public byte unknown8a;

        // col: 45 offset: 008b
        public byte unknown8b;

        // col: 63 offset: 008c
        public byte unknown8c;

        // col: 33 offset: 008d
        public bool unknown8d;

        // col: 51 offset: 008e
        public bool unknown8e;

        // col: 69 offset: 008f
        public bool unknown8f;

        // col: 00 offset: 0090
        public int Npc;

        // col: 01 offset: 0094
        public int QuestRequired;

        // col: 70 offset: 0098
        public int Icon;

        // col: 02 offset: 009c
        public byte LevelUnlock;

        // col: 03 offset: 009d
        public byte DeliveriesPerWeek;

        // col: 71 offset: 009e
        public byte unknown9e;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            SupplyIndex = new int[6];
            SupplyIndex[0] = parser.ReadOffset< int >( 0x0 );
            SupplyIndex[1] = parser.ReadOffset< int >( 0x18 );
            SupplyIndex[2] = parser.ReadOffset< int >( 0x30 );
            SupplyIndex[3] = parser.ReadOffset< int >( 0x48 );
            SupplyIndex[4] = parser.ReadOffset< int >( 0x60 );
            SupplyIndex[5] = parser.ReadOffset< int >( 0x78 );

            // col: 16 offset: 0004
            unknown4 = new int[3];
            unknown4[0] = parser.ReadOffset< int >( 0x4 );
            unknown4[1] = parser.ReadOffset< int >( 0x1c );
            unknown4[2] = parser.ReadOffset< int >( 0x34 );

            // col: 34 offset: 0008
            unknown8 = parser.ReadOffset< int >( 0x8 );

            // col: 52 offset: 000c
            unknownc = parser.ReadOffset< int >( 0xc );

            // col: 10 offset: 0010
            SatisfactionRequired = new ushort[6];
            SatisfactionRequired[0] = parser.ReadOffset< ushort >( 0x10 );
            SatisfactionRequired[1] = parser.ReadOffset< ushort >( 0x28 );
            SatisfactionRequired[2] = parser.ReadOffset< ushort >( 0x40 );
            SatisfactionRequired[3] = parser.ReadOffset< ushort >( 0x58 );
            SatisfactionRequired[4] = parser.ReadOffset< ushort >( 0x70 );
            SatisfactionRequired[5] = parser.ReadOffset< ushort >( 0x88 );

            // col: 22 offset: 0012
            unknown12 = parser.ReadOffset< byte >( 0x12 );

            // col: 40 offset: 0013
            unknown13 = parser.ReadOffset< byte >( 0x13 );

            // col: 58 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 28 offset: 0015
            unknown15 = parser.ReadOffset< bool >( 0x15 );

            // col: 46 offset: 0016
            unknown16 = parser.ReadOffset< bool >( 0x16 );

            // col: 64 offset: 0017
            unknown17 = parser.ReadOffset< bool >( 0x17 );

            // col: 35 offset: 0020
            unknown20 = parser.ReadOffset< int >( 0x20 );

            // col: 53 offset: 0024
            unknown24 = parser.ReadOffset< int >( 0x24 );

            // col: 23 offset: 002a
            unknown2a = parser.ReadOffset< byte >( 0x2a );

            // col: 41 offset: 002b
            unknown2b = parser.ReadOffset< byte >( 0x2b );

            // col: 59 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 29 offset: 002d
            unknown2d = parser.ReadOffset< bool >( 0x2d );

            // col: 47 offset: 002e
            unknown2e = parser.ReadOffset< bool >( 0x2e );

            // col: 65 offset: 002f
            unknown2f = parser.ReadOffset< bool >( 0x2f );

            // col: 36 offset: 0038
            unknown38 = parser.ReadOffset< int >( 0x38 );

            // col: 54 offset: 003c
            unknown3c = parser.ReadOffset< int >( 0x3c );

            // col: 24 offset: 0042
            unknown42 = parser.ReadOffset< byte >( 0x42 );

            // col: 42 offset: 0043
            unknown43 = parser.ReadOffset< byte >( 0x43 );

            // col: 60 offset: 0044
            unknown44 = parser.ReadOffset< byte >( 0x44 );

            // col: 30 offset: 0045
            unknown45 = parser.ReadOffset< bool >( 0x45 );

            // col: 48 offset: 0046
            unknown46 = parser.ReadOffset< bool >( 0x46 );

            // col: 66 offset: 0047
            unknown47 = parser.ReadOffset< bool >( 0x47 );

            // col: 19 offset: 004c
            unknown4c = parser.ReadOffset< int >( 0x4c );

            // col: 37 offset: 0050
            unknown50 = parser.ReadOffset< int >( 0x50 );

            // col: 55 offset: 0054
            unknown54 = parser.ReadOffset< int >( 0x54 );

            // col: 25 offset: 005a
            unknown5a = parser.ReadOffset< byte >( 0x5a );

            // col: 43 offset: 005b
            unknown5b = parser.ReadOffset< byte >( 0x5b );

            // col: 61 offset: 005c
            unknown5c = parser.ReadOffset< byte >( 0x5c );

            // col: 31 offset: 005d
            unknown5d = parser.ReadOffset< bool >( 0x5d );

            // col: 49 offset: 005e
            unknown5e = parser.ReadOffset< bool >( 0x5e );

            // col: 67 offset: 005f
            unknown5f = parser.ReadOffset< bool >( 0x5f );

            // col: 20 offset: 0064
            unknown64 = parser.ReadOffset< int >( 0x64 );

            // col: 38 offset: 0068
            unknown68 = parser.ReadOffset< int >( 0x68 );

            // col: 56 offset: 006c
            unknown6c = parser.ReadOffset< int >( 0x6c );

            // col: 26 offset: 0072
            unknown72 = parser.ReadOffset< byte >( 0x72 );

            // col: 44 offset: 0073
            unknown73 = parser.ReadOffset< byte >( 0x73 );

            // col: 62 offset: 0074
            unknown74 = parser.ReadOffset< byte >( 0x74 );

            // col: 32 offset: 0075
            unknown75 = parser.ReadOffset< bool >( 0x75 );

            // col: 50 offset: 0076
            unknown76 = parser.ReadOffset< bool >( 0x76 );

            // col: 68 offset: 0077
            unknown77 = parser.ReadOffset< bool >( 0x77 );

            // col: 21 offset: 007c
            unknown7c = parser.ReadOffset< int >( 0x7c );

            // col: 39 offset: 0080
            unknown80 = parser.ReadOffset< int >( 0x80 );

            // col: 57 offset: 0084
            unknown84 = parser.ReadOffset< int >( 0x84 );

            // col: 27 offset: 008a
            unknown8a = parser.ReadOffset< byte >( 0x8a );

            // col: 45 offset: 008b
            unknown8b = parser.ReadOffset< byte >( 0x8b );

            // col: 63 offset: 008c
            unknown8c = parser.ReadOffset< byte >( 0x8c );

            // col: 33 offset: 008d
            unknown8d = parser.ReadOffset< bool >( 0x8d );

            // col: 51 offset: 008e
            unknown8e = parser.ReadOffset< bool >( 0x8e );

            // col: 69 offset: 008f
            unknown8f = parser.ReadOffset< bool >( 0x8f );

            // col: 0 offset: 0090
            Npc = parser.ReadOffset< int >( 0x90 );

            // col: 1 offset: 0094
            QuestRequired = parser.ReadOffset< int >( 0x94 );

            // col: 70 offset: 0098
            Icon = parser.ReadOffset< int >( 0x98 );

            // col: 2 offset: 009c
            LevelUnlock = parser.ReadOffset< byte >( 0x9c );

            // col: 3 offset: 009d
            DeliveriesPerWeek = parser.ReadOffset< byte >( 0x9d );

            // col: 71 offset: 009e
            unknown9e = parser.ReadOffset< byte >( 0x9e );


        }
    }
}