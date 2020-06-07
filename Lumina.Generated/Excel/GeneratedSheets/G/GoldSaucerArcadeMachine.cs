using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GoldSaucerArcadeMachine", columnHash: 0xaf0ca150 )]
    public class GoldSaucerArcadeMachine : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 27 offset: 0000
        public uint unknown0;

        // col: 35 offset: 0004
        public uint Poor;

        // col: 15 offset: 0008
        public byte unknown8;

        // col: 19 offset: 0009
        public byte unknown9;

        // col: 23 offset: 000a
        public byte unknowna;

        // col: 31 offset: 000b
        public byte unknownb;

        // col: 28 offset: 000c
        public uint unknownc;

        // col: 36 offset: 0010
        public uint Good;

        // col: 16 offset: 0014
        public byte unknown14;

        // col: 20 offset: 0015
        public byte unknown15;

        // col: 24 offset: 0016
        public byte unknown16;

        // col: 32 offset: 0017
        public byte unknown17;

        // col: 29 offset: 0018
        public uint unknown18;

        // col: 37 offset: 001c
        public uint Great;

        // col: 17 offset: 0020
        public byte unknown20;

        // col: 21 offset: 0021
        public byte unknown21;

        // col: 25 offset: 0022
        public byte unknown22;

        // col: 33 offset: 0023
        public byte unknown23;

        // col: 30 offset: 0024
        public uint unknown24;

        // col: 38 offset: 0028
        public uint Excellent;

        // col: 18 offset: 002c
        public byte unknown2c;

        // col: 22 offset: 002d
        public byte unknown2d;

        // col: 26 offset: 002e
        public byte unknown2e;

        // col: 34 offset: 002f
        public byte unknown2f;

        // col: 39 offset: 0030
        public string unknown30;

        // col: 40 offset: 0034
        public string unknown34;

        // col: 41 offset: 0038
        public string unknown38;

        // col: 42 offset: 003c
        public string unknown3c;

        // col: 06 offset: 0040
        public uint FailImage;

        // col: 10 offset: 0044
        public uint unknown44;

        // col: 04 offset: 0048
        public ushort unknown48;

        // col: 00 offset: 004a
        public byte unknown4a;

        // col: 01 offset: 004b
        public byte unknown4b;

        // col: 02 offset: 004c
        public byte unknown4c;

        // col: 03 offset: 004d
        public byte unknown4d;

        // col: 05 offset: 004e
        public byte unknown4e;

        // col: 11 offset: 004f
        public byte unknown4f;

        // col: 07 offset: 0050
        public sbyte unknown50;

        // col: 08 offset: 0051
        public sbyte unknown51;

        // col: 09 offset: 0052
        public sbyte unknown52;

        // col: 12 offset: 0053
        public sbyte unknown53;

        // col: 13 offset: 0054
        public sbyte unknown54;

        // col: 14 offset: 0055
        public sbyte unknown55;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 27 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 35 offset: 0004
            Poor = parser.ReadOffset< uint >( 0x4 );

            // col: 15 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 19 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 23 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );

            // col: 31 offset: 000b
            unknownb = parser.ReadOffset< byte >( 0xb );

            // col: 28 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 36 offset: 0010
            Good = parser.ReadOffset< uint >( 0x10 );

            // col: 16 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 20 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 24 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 32 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );

            // col: 29 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 37 offset: 001c
            Great = parser.ReadOffset< uint >( 0x1c );

            // col: 17 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );

            // col: 21 offset: 0021
            unknown21 = parser.ReadOffset< byte >( 0x21 );

            // col: 25 offset: 0022
            unknown22 = parser.ReadOffset< byte >( 0x22 );

            // col: 33 offset: 0023
            unknown23 = parser.ReadOffset< byte >( 0x23 );

            // col: 30 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 38 offset: 0028
            Excellent = parser.ReadOffset< uint >( 0x28 );

            // col: 18 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 22 offset: 002d
            unknown2d = parser.ReadOffset< byte >( 0x2d );

            // col: 26 offset: 002e
            unknown2e = parser.ReadOffset< byte >( 0x2e );

            // col: 34 offset: 002f
            unknown2f = parser.ReadOffset< byte >( 0x2f );

            // col: 39 offset: 0030
            unknown30 = parser.ReadOffset< string >( 0x30 );

            // col: 40 offset: 0034
            unknown34 = parser.ReadOffset< string >( 0x34 );

            // col: 41 offset: 0038
            unknown38 = parser.ReadOffset< string >( 0x38 );

            // col: 42 offset: 003c
            unknown3c = parser.ReadOffset< string >( 0x3c );

            // col: 6 offset: 0040
            FailImage = parser.ReadOffset< uint >( 0x40 );

            // col: 10 offset: 0044
            unknown44 = parser.ReadOffset< uint >( 0x44 );

            // col: 4 offset: 0048
            unknown48 = parser.ReadOffset< ushort >( 0x48 );

            // col: 0 offset: 004a
            unknown4a = parser.ReadOffset< byte >( 0x4a );

            // col: 1 offset: 004b
            unknown4b = parser.ReadOffset< byte >( 0x4b );

            // col: 2 offset: 004c
            unknown4c = parser.ReadOffset< byte >( 0x4c );

            // col: 3 offset: 004d
            unknown4d = parser.ReadOffset< byte >( 0x4d );

            // col: 5 offset: 004e
            unknown4e = parser.ReadOffset< byte >( 0x4e );

            // col: 11 offset: 004f
            unknown4f = parser.ReadOffset< byte >( 0x4f );

            // col: 7 offset: 0050
            unknown50 = parser.ReadOffset< sbyte >( 0x50 );

            // col: 8 offset: 0051
            unknown51 = parser.ReadOffset< sbyte >( 0x51 );

            // col: 9 offset: 0052
            unknown52 = parser.ReadOffset< sbyte >( 0x52 );

            // col: 12 offset: 0053
            unknown53 = parser.ReadOffset< sbyte >( 0x53 );

            // col: 13 offset: 0054
            unknown54 = parser.ReadOffset< sbyte >( 0x54 );

            // col: 14 offset: 0055
            unknown55 = parser.ReadOffset< sbyte >( 0x55 );


        }
    }
}