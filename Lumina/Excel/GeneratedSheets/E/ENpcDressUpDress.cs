using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUpDress", columnHash: 0xc427517b )]
    public class ENpcDressUpDress : IExcelRow
    {
        // column defs from Fri, 28 Jun 2019 17:13:11 GMT


        // col: 35 offset: 0000
        public ulong ModelMainHand;

        // col: 37 offset: 0008
        public ulong ModelOffHand;

        // col: 00 offset: 0010
        public uint unknown10;

        // col: 06 offset: 0014
        public uint ENpc;

        // col: 39 offset: 0018
        public uint ModelHead;

        // col: 41 offset: 001c
        public uint ModelBody;

        // col: 43 offset: 0020
        public uint ModelHands;

        // col: 45 offset: 0024
        public uint ModelLegs;

        // col: 47 offset: 0028
        public uint ModelFeet;

        // col: 49 offset: 002c
        public uint unknown2c;

        // col: 51 offset: 0030
        public uint unknown30;

        // col: 53 offset: 0034
        public uint unknown34;

        // col: 55 offset: 0038
        public uint unknown38;

        // col: 57 offset: 003c
        public uint unknown3c;

        // col: 07 offset: 0040
        public ushort unknown40;

        // col: 08 offset: 0042
        public ushort Behavior;

        // col: 05 offset: 0044
        public byte unknown44;

        // col: 09 offset: 0045
        public byte unknown45;

        // col: 10 offset: 0046
        public byte unknown46;

        // col: 11 offset: 0047
        public byte unknown47;

        // col: 12 offset: 0048
        public byte unknown48;

        // col: 13 offset: 0049
        public byte unknown49;

        // col: 14 offset: 004a
        public byte unknown4a;

        // col: 15 offset: 004b
        public byte unknown4b;

        // col: 16 offset: 004c
        public byte unknown4c;

        // col: 17 offset: 004d
        public byte unknown4d;

        // col: 18 offset: 004e
        public byte unknown4e;

        // col: 19 offset: 004f
        public byte unknown4f;

        // col: 20 offset: 0050
        public byte unknown50;

        // col: 21 offset: 0051
        public byte unknown51;

        // col: 22 offset: 0052
        public byte unknown52;

        // col: 23 offset: 0053
        public byte unknown53;

        // col: 24 offset: 0054
        public byte unknown54;

        // col: 25 offset: 0055
        public byte unknown55;

        // col: 26 offset: 0056
        public byte unknown56;

        // col: 27 offset: 0057
        public byte unknown57;

        // col: 28 offset: 0058
        public byte unknown58;

        // col: 29 offset: 0059
        public byte unknown59;

        // col: 30 offset: 005a
        public byte unknown5a;

        // col: 31 offset: 005b
        public byte unknown5b;

        // col: 32 offset: 005c
        public byte unknown5c;

        // col: 33 offset: 005d
        public byte unknown5d;

        // col: 34 offset: 005e
        public byte unknown5e;

        // col: 36 offset: 005f
        public byte DyeMainHand;

        // col: 38 offset: 0060
        public byte DyeOffHand;

        // col: 40 offset: 0061
        public byte DyeHead;

        // col: 42 offset: 0062
        public byte DyeBody;

        // col: 44 offset: 0063
        public byte DyeHands;

        // col: 46 offset: 0064
        public byte DyeLegs;

        // col: 48 offset: 0065
        public byte DyeFeet;

        // col: 50 offset: 0066
        public byte unknown66;

        // col: 52 offset: 0067
        public byte unknown67;

        // col: 54 offset: 0068
        public byte unknown68;

        // col: 56 offset: 0069
        public byte unknown69;

        // col: 58 offset: 006a
        public byte unknown6a;

        // col: 01 offset: 006b
        private byte packed6b;
        public bool packed6b_1 => ( packed6b & 0x1 ) == 0x1;
        public bool packed6b_2 => ( packed6b & 0x2 ) == 0x2;
        public bool packed6b_4 => ( packed6b & 0x4 ) == 0x4;
        public bool packed6b_8 => ( packed6b & 0x8 ) == 0x8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 35 offset: 0000
            ModelMainHand = parser.ReadOffset< ulong >( 0x0 );

            // col: 37 offset: 0008
            ModelOffHand = parser.ReadOffset< ulong >( 0x8 );

            // col: 0 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 6 offset: 0014
            ENpc = parser.ReadOffset< uint >( 0x14 );

            // col: 39 offset: 0018
            ModelHead = parser.ReadOffset< uint >( 0x18 );

            // col: 41 offset: 001c
            ModelBody = parser.ReadOffset< uint >( 0x1c );

            // col: 43 offset: 0020
            ModelHands = parser.ReadOffset< uint >( 0x20 );

            // col: 45 offset: 0024
            ModelLegs = parser.ReadOffset< uint >( 0x24 );

            // col: 47 offset: 0028
            ModelFeet = parser.ReadOffset< uint >( 0x28 );

            // col: 49 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 51 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 53 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 55 offset: 0038
            unknown38 = parser.ReadOffset< uint >( 0x38 );

            // col: 57 offset: 003c
            unknown3c = parser.ReadOffset< uint >( 0x3c );

            // col: 7 offset: 0040
            unknown40 = parser.ReadOffset< ushort >( 0x40 );

            // col: 8 offset: 0042
            Behavior = parser.ReadOffset< ushort >( 0x42 );

            // col: 5 offset: 0044
            unknown44 = parser.ReadOffset< byte >( 0x44 );

            // col: 9 offset: 0045
            unknown45 = parser.ReadOffset< byte >( 0x45 );

            // col: 10 offset: 0046
            unknown46 = parser.ReadOffset< byte >( 0x46 );

            // col: 11 offset: 0047
            unknown47 = parser.ReadOffset< byte >( 0x47 );

            // col: 12 offset: 0048
            unknown48 = parser.ReadOffset< byte >( 0x48 );

            // col: 13 offset: 0049
            unknown49 = parser.ReadOffset< byte >( 0x49 );

            // col: 14 offset: 004a
            unknown4a = parser.ReadOffset< byte >( 0x4a );

            // col: 15 offset: 004b
            unknown4b = parser.ReadOffset< byte >( 0x4b );

            // col: 16 offset: 004c
            unknown4c = parser.ReadOffset< byte >( 0x4c );

            // col: 17 offset: 004d
            unknown4d = parser.ReadOffset< byte >( 0x4d );

            // col: 18 offset: 004e
            unknown4e = parser.ReadOffset< byte >( 0x4e );

            // col: 19 offset: 004f
            unknown4f = parser.ReadOffset< byte >( 0x4f );

            // col: 20 offset: 0050
            unknown50 = parser.ReadOffset< byte >( 0x50 );

            // col: 21 offset: 0051
            unknown51 = parser.ReadOffset< byte >( 0x51 );

            // col: 22 offset: 0052
            unknown52 = parser.ReadOffset< byte >( 0x52 );

            // col: 23 offset: 0053
            unknown53 = parser.ReadOffset< byte >( 0x53 );

            // col: 24 offset: 0054
            unknown54 = parser.ReadOffset< byte >( 0x54 );

            // col: 25 offset: 0055
            unknown55 = parser.ReadOffset< byte >( 0x55 );

            // col: 26 offset: 0056
            unknown56 = parser.ReadOffset< byte >( 0x56 );

            // col: 27 offset: 0057
            unknown57 = parser.ReadOffset< byte >( 0x57 );

            // col: 28 offset: 0058
            unknown58 = parser.ReadOffset< byte >( 0x58 );

            // col: 29 offset: 0059
            unknown59 = parser.ReadOffset< byte >( 0x59 );

            // col: 30 offset: 005a
            unknown5a = parser.ReadOffset< byte >( 0x5a );

            // col: 31 offset: 005b
            unknown5b = parser.ReadOffset< byte >( 0x5b );

            // col: 32 offset: 005c
            unknown5c = parser.ReadOffset< byte >( 0x5c );

            // col: 33 offset: 005d
            unknown5d = parser.ReadOffset< byte >( 0x5d );

            // col: 34 offset: 005e
            unknown5e = parser.ReadOffset< byte >( 0x5e );

            // col: 36 offset: 005f
            DyeMainHand = parser.ReadOffset< byte >( 0x5f );

            // col: 38 offset: 0060
            DyeOffHand = parser.ReadOffset< byte >( 0x60 );

            // col: 40 offset: 0061
            DyeHead = parser.ReadOffset< byte >( 0x61 );

            // col: 42 offset: 0062
            DyeBody = parser.ReadOffset< byte >( 0x62 );

            // col: 44 offset: 0063
            DyeHands = parser.ReadOffset< byte >( 0x63 );

            // col: 46 offset: 0064
            DyeLegs = parser.ReadOffset< byte >( 0x64 );

            // col: 48 offset: 0065
            DyeFeet = parser.ReadOffset< byte >( 0x65 );

            // col: 50 offset: 0066
            unknown66 = parser.ReadOffset< byte >( 0x66 );

            // col: 52 offset: 0067
            unknown67 = parser.ReadOffset< byte >( 0x67 );

            // col: 54 offset: 0068
            unknown68 = parser.ReadOffset< byte >( 0x68 );

            // col: 56 offset: 0069
            unknown69 = parser.ReadOffset< byte >( 0x69 );

            // col: 58 offset: 006a
            unknown6a = parser.ReadOffset< byte >( 0x6a );

            // col: 1 offset: 006b
            packed6b = parser.ReadOffset< byte >( 0x6b, ExcelColumnDataType.UInt8 );


        }
    }
}