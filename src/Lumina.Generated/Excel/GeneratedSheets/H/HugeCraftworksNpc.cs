using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksNpc", columnHash: 0x79685419 )]
    public class HugeCraftworksNpc : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint unknown0;

        // col: 38 offset: 0004
        public ushort unknown4;

        // col: 08 offset: 0006
        public byte unknown6;

        // col: 20 offset: 0007
        public byte unknown7;

        // col: 26 offset: 0008
        public byte unknown8;

        // col: 32 offset: 0009
        public byte unknown9;

        // col: 44 offset: 000a
        public byte unknowna;

        // col: 14 offset: 000b
        public bool packedb_1;
        public byte packedb;

        // col: 03 offset: 000c
        public uint[] ItemRequested;

        // col: 39 offset: 0010
        public ushort unknown10;

        // col: 09 offset: 0012
        public byte[] QtyRequested;

        // col: 21 offset: 0013
        public byte unknown13;

        // col: 27 offset: 0014
        public byte unknown14;

        // col: 33 offset: 0015
        public byte unknown15;

        // col: 45 offset: 0016
        public byte unknown16;

        // col: 15 offset: 0017
        public bool packed17_1;
        public byte packed17;

        // col: 40 offset: 001c
        public ushort unknown1c;

        // col: 22 offset: 001f
        public byte unknown1f;

        // col: 28 offset: 0020
        public byte unknown20;

        // col: 34 offset: 0021
        public byte unknown21;

        // col: 46 offset: 0022
        public byte unknown22;

        // col: 16 offset: 0023
        public bool packed23_1;
        public byte packed23;

        // col: 41 offset: 0028
        public ushort unknown28;

        // col: 23 offset: 002b
        public byte unknown2b;

        // col: 29 offset: 002c
        public byte unknown2c;

        // col: 35 offset: 002d
        public byte unknown2d;

        // col: 47 offset: 002e
        public byte unknown2e;

        // col: 17 offset: 002f
        public bool packed2f_1;
        public byte packed2f;

        // col: 42 offset: 0034
        public ushort unknown34;

        // col: 24 offset: 0037
        public byte unknown37;

        // col: 30 offset: 0038
        public byte unknown38;

        // col: 36 offset: 0039
        public byte unknown39;

        // col: 48 offset: 003a
        public byte unknown3a;

        // col: 18 offset: 003b
        public bool packed3b_1;
        public byte packed3b;

        // col: 07 offset: 003c
        public uint unknown3c;

        // col: 43 offset: 0040
        public ushort unknown40;

        // col: 13 offset: 0042
        public byte unknown42;

        // col: 25 offset: 0043
        public byte unknown43;

        // col: 31 offset: 0044
        public byte unknown44;

        // col: 37 offset: 0045
        public byte unknown45;

        // col: 49 offset: 0046
        public byte unknown46;

        // col: 19 offset: 0047
        public bool packed47_1;
        public byte packed47;

        // col: 50 offset: 0048
        public uint unknown48;

        // col: 68 offset: 004c
        public uint unknown4c;

        // col: 62 offset: 0050
        public byte unknown50;

        // col: 80 offset: 0051
        public byte unknown51;

        // col: 56 offset: 0052
        public bool unknown52;

        // col: 74 offset: 0053
        public bool unknown53;

        // col: 51 offset: 0054
        public uint unknown54;

        // col: 69 offset: 0058
        public uint unknown58;

        // col: 63 offset: 005c
        public byte unknown5c;

        // col: 81 offset: 005d
        public byte unknown5d;

        // col: 57 offset: 005e
        public bool unknown5e;

        // col: 75 offset: 005f
        public bool unknown5f;

        // col: 52 offset: 0060
        public uint[] ItemReward;

        // col: 70 offset: 0064
        public uint[] ItemUnkown;

        // col: 64 offset: 0068
        public byte[] QtyItemReward;

        // col: 82 offset: 0069
        public byte[] QtyItemUnkown;

        // col: 58 offset: 006a
        public bool unknown6a;

        // col: 76 offset: 006b
        public bool unknown6b;

        // col: 59 offset: 0076
        public bool unknown76;

        // col: 77 offset: 0077
        public bool unknown77;

        // col: 60 offset: 0082
        public bool unknown82;

        // col: 78 offset: 0083
        public bool unknown83;

        // col: 61 offset: 008e
        public bool unknown8e;

        // col: 79 offset: 008f
        public bool unknown8f;

        // col: 86 offset: 0090
        public string Transient;

        // col: 00 offset: 0094
        public uint ENpcResident;

        // col: 01 offset: 0098
        public ushort ClassJobCategory;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 38 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 8 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );

            // col: 20 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 26 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 32 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 44 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );

            // col: 14 offset: 000b
            packedb = parser.ReadOffset< byte >( 0xb, ExcelColumnDataType.UInt8 );

            packedb_1 = ( packedb & 0x1 ) == 0x1;

            // col: 3 offset: 000c
            ItemRequested = new uint[4];
            ItemRequested[0] = parser.ReadOffset< uint >( 0xc );
            ItemRequested[1] = parser.ReadOffset< uint >( 0x18 );
            ItemRequested[2] = parser.ReadOffset< uint >( 0x24 );
            ItemRequested[3] = parser.ReadOffset< uint >( 0x30 );

            // col: 39 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 9 offset: 0012
            QtyRequested = new byte[4];
            QtyRequested[0] = parser.ReadOffset< byte >( 0x12 );
            QtyRequested[1] = parser.ReadOffset< byte >( 0x1e );
            QtyRequested[2] = parser.ReadOffset< byte >( 0x2a );
            QtyRequested[3] = parser.ReadOffset< byte >( 0x36 );

            // col: 21 offset: 0013
            unknown13 = parser.ReadOffset< byte >( 0x13 );

            // col: 27 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 33 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 45 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 15 offset: 0017
            packed17 = parser.ReadOffset< byte >( 0x17, ExcelColumnDataType.UInt8 );

            packed17_1 = ( packed17 & 0x1 ) == 0x1;

            // col: 40 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 22 offset: 001f
            unknown1f = parser.ReadOffset< byte >( 0x1f );

            // col: 28 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );

            // col: 34 offset: 0021
            unknown21 = parser.ReadOffset< byte >( 0x21 );

            // col: 46 offset: 0022
            unknown22 = parser.ReadOffset< byte >( 0x22 );

            // col: 16 offset: 0023
            packed23 = parser.ReadOffset< byte >( 0x23, ExcelColumnDataType.UInt8 );

            packed23_1 = ( packed23 & 0x1 ) == 0x1;

            // col: 41 offset: 0028
            unknown28 = parser.ReadOffset< ushort >( 0x28 );

            // col: 23 offset: 002b
            unknown2b = parser.ReadOffset< byte >( 0x2b );

            // col: 29 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 35 offset: 002d
            unknown2d = parser.ReadOffset< byte >( 0x2d );

            // col: 47 offset: 002e
            unknown2e = parser.ReadOffset< byte >( 0x2e );

            // col: 17 offset: 002f
            packed2f = parser.ReadOffset< byte >( 0x2f, ExcelColumnDataType.UInt8 );

            packed2f_1 = ( packed2f & 0x1 ) == 0x1;

            // col: 42 offset: 0034
            unknown34 = parser.ReadOffset< ushort >( 0x34 );

            // col: 24 offset: 0037
            unknown37 = parser.ReadOffset< byte >( 0x37 );

            // col: 30 offset: 0038
            unknown38 = parser.ReadOffset< byte >( 0x38 );

            // col: 36 offset: 0039
            unknown39 = parser.ReadOffset< byte >( 0x39 );

            // col: 48 offset: 003a
            unknown3a = parser.ReadOffset< byte >( 0x3a );

            // col: 18 offset: 003b
            packed3b = parser.ReadOffset< byte >( 0x3b, ExcelColumnDataType.UInt8 );

            packed3b_1 = ( packed3b & 0x1 ) == 0x1;

            // col: 7 offset: 003c
            unknown3c = parser.ReadOffset< uint >( 0x3c );

            // col: 43 offset: 0040
            unknown40 = parser.ReadOffset< ushort >( 0x40 );

            // col: 13 offset: 0042
            unknown42 = parser.ReadOffset< byte >( 0x42 );

            // col: 25 offset: 0043
            unknown43 = parser.ReadOffset< byte >( 0x43 );

            // col: 31 offset: 0044
            unknown44 = parser.ReadOffset< byte >( 0x44 );

            // col: 37 offset: 0045
            unknown45 = parser.ReadOffset< byte >( 0x45 );

            // col: 49 offset: 0046
            unknown46 = parser.ReadOffset< byte >( 0x46 );

            // col: 19 offset: 0047
            packed47 = parser.ReadOffset< byte >( 0x47, ExcelColumnDataType.UInt8 );

            packed47_1 = ( packed47 & 0x1 ) == 0x1;

            // col: 50 offset: 0048
            unknown48 = parser.ReadOffset< uint >( 0x48 );

            // col: 68 offset: 004c
            unknown4c = parser.ReadOffset< uint >( 0x4c );

            // col: 62 offset: 0050
            unknown50 = parser.ReadOffset< byte >( 0x50 );

            // col: 80 offset: 0051
            unknown51 = parser.ReadOffset< byte >( 0x51 );

            // col: 56 offset: 0052
            unknown52 = parser.ReadOffset< bool >( 0x52 );

            // col: 74 offset: 0053
            unknown53 = parser.ReadOffset< bool >( 0x53 );

            // col: 51 offset: 0054
            unknown54 = parser.ReadOffset< uint >( 0x54 );

            // col: 69 offset: 0058
            unknown58 = parser.ReadOffset< uint >( 0x58 );

            // col: 63 offset: 005c
            unknown5c = parser.ReadOffset< byte >( 0x5c );

            // col: 81 offset: 005d
            unknown5d = parser.ReadOffset< byte >( 0x5d );

            // col: 57 offset: 005e
            unknown5e = parser.ReadOffset< bool >( 0x5e );

            // col: 75 offset: 005f
            unknown5f = parser.ReadOffset< bool >( 0x5f );

            // col: 52 offset: 0060
            ItemReward = new uint[4];
            ItemReward[0] = parser.ReadOffset< uint >( 0x60 );
            ItemReward[1] = parser.ReadOffset< uint >( 0x6c );
            ItemReward[2] = parser.ReadOffset< uint >( 0x78 );
            ItemReward[3] = parser.ReadOffset< uint >( 0x84 );

            // col: 70 offset: 0064
            ItemUnkown = new uint[4];
            ItemUnkown[0] = parser.ReadOffset< uint >( 0x64 );
            ItemUnkown[1] = parser.ReadOffset< uint >( 0x70 );
            ItemUnkown[2] = parser.ReadOffset< uint >( 0x7c );
            ItemUnkown[3] = parser.ReadOffset< uint >( 0x88 );

            // col: 64 offset: 0068
            QtyItemReward = new byte[4];
            QtyItemReward[0] = parser.ReadOffset< byte >( 0x68 );
            QtyItemReward[1] = parser.ReadOffset< byte >( 0x74 );
            QtyItemReward[2] = parser.ReadOffset< byte >( 0x80 );
            QtyItemReward[3] = parser.ReadOffset< byte >( 0x8c );

            // col: 82 offset: 0069
            QtyItemUnkown = new byte[4];
            QtyItemUnkown[0] = parser.ReadOffset< byte >( 0x69 );
            QtyItemUnkown[1] = parser.ReadOffset< byte >( 0x75 );
            QtyItemUnkown[2] = parser.ReadOffset< byte >( 0x81 );
            QtyItemUnkown[3] = parser.ReadOffset< byte >( 0x8d );

            // col: 58 offset: 006a
            unknown6a = parser.ReadOffset< bool >( 0x6a );

            // col: 76 offset: 006b
            unknown6b = parser.ReadOffset< bool >( 0x6b );

            // col: 59 offset: 0076
            unknown76 = parser.ReadOffset< bool >( 0x76 );

            // col: 77 offset: 0077
            unknown77 = parser.ReadOffset< bool >( 0x77 );

            // col: 60 offset: 0082
            unknown82 = parser.ReadOffset< bool >( 0x82 );

            // col: 78 offset: 0083
            unknown83 = parser.ReadOffset< bool >( 0x83 );

            // col: 61 offset: 008e
            unknown8e = parser.ReadOffset< bool >( 0x8e );

            // col: 79 offset: 008f
            unknown8f = parser.ReadOffset< bool >( 0x8f );

            // col: 86 offset: 0090
            Transient = parser.ReadOffset< string >( 0x90 );

            // col: 0 offset: 0094
            ENpcResident = parser.ReadOffset< uint >( 0x94 );

            // col: 1 offset: 0098
            ClassJobCategory = parser.ReadOffset< ushort >( 0x98 );


        }
    }
}