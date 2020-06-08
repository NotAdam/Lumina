using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContent", columnHash: 0x54e6a214 )]
    public class PartyContent : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 05 offset: 0000
        public uint unknown0;

        // col: 06 offset: 0004
        public uint unknown4;

        // col: 07 offset: 0008
        public uint unknown8;

        // col: 08 offset: 000c
        public uint unknownc;

        // col: 09 offset: 0010
        public uint unknown10;

        // col: 10 offset: 0014
        public uint unknown14;

        // col: 11 offset: 0018
        public uint unknown18;

        // col: 12 offset: 001c
        public uint unknown1c;

        // col: 13 offset: 0020
        public uint unknown20;

        // col: 14 offset: 0024
        public uint unknown24;

        // col: 15 offset: 0028
        public uint unknown28;

        // col: 16 offset: 002c
        public uint unknown2c;

        // col: 17 offset: 0030
        public uint unknown30;

        // col: 18 offset: 0034
        public uint unknown34;

        // col: 19 offset: 0038
        public uint unknown38;

        // col: 20 offset: 003c
        public uint unknown3c;

        // col: 21 offset: 0040
        public uint unknown40;

        // col: 22 offset: 0044
        public uint unknown44;

        // col: 23 offset: 0048
        public uint unknown48;

        // col: 24 offset: 004c
        public uint unknown4c;

        // col: 25 offset: 0050
        public uint unknown50;

        // col: 26 offset: 0054
        public uint unknown54;

        // col: 27 offset: 0058
        public uint unknown58;

        // col: 28 offset: 005c
        public uint unknown5c;

        // col: 29 offset: 0060
        public uint unknown60;

        // col: 30 offset: 0064
        public uint unknown64;

        // col: 31 offset: 0068
        public uint unknown68;

        // col: 03 offset: 006c
        public uint TextDataStart;

        // col: 04 offset: 0070
        public uint TextDataEnd;

        // col: 34 offset: 0074
        public uint Image;

        // col: 01 offset: 0078
        public ushort TimeLimit;

        // col: 32 offset: 007a
        public ushort unknown7a;

        // col: 33 offset: 007c
        public ushort ContentFinderCondition;

        // col: 00 offset: 007e
        public byte Key;

        // col: 35 offset: 007f
        public byte unknown7f;

        // col: 02 offset: 0080
        public bool Name;
        public byte packed80;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 6 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 7 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 8 offset: 000c
            unknownc = parser.ReadOffset< uint >( 0xc );

            // col: 9 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 10 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 11 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 12 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 13 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 14 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 15 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 16 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 17 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 18 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 19 offset: 0038
            unknown38 = parser.ReadOffset< uint >( 0x38 );

            // col: 20 offset: 003c
            unknown3c = parser.ReadOffset< uint >( 0x3c );

            // col: 21 offset: 0040
            unknown40 = parser.ReadOffset< uint >( 0x40 );

            // col: 22 offset: 0044
            unknown44 = parser.ReadOffset< uint >( 0x44 );

            // col: 23 offset: 0048
            unknown48 = parser.ReadOffset< uint >( 0x48 );

            // col: 24 offset: 004c
            unknown4c = parser.ReadOffset< uint >( 0x4c );

            // col: 25 offset: 0050
            unknown50 = parser.ReadOffset< uint >( 0x50 );

            // col: 26 offset: 0054
            unknown54 = parser.ReadOffset< uint >( 0x54 );

            // col: 27 offset: 0058
            unknown58 = parser.ReadOffset< uint >( 0x58 );

            // col: 28 offset: 005c
            unknown5c = parser.ReadOffset< uint >( 0x5c );

            // col: 29 offset: 0060
            unknown60 = parser.ReadOffset< uint >( 0x60 );

            // col: 30 offset: 0064
            unknown64 = parser.ReadOffset< uint >( 0x64 );

            // col: 31 offset: 0068
            unknown68 = parser.ReadOffset< uint >( 0x68 );

            // col: 3 offset: 006c
            TextDataStart = parser.ReadOffset< uint >( 0x6c );

            // col: 4 offset: 0070
            TextDataEnd = parser.ReadOffset< uint >( 0x70 );

            // col: 34 offset: 0074
            Image = parser.ReadOffset< uint >( 0x74 );

            // col: 1 offset: 0078
            TimeLimit = parser.ReadOffset< ushort >( 0x78 );

            // col: 32 offset: 007a
            unknown7a = parser.ReadOffset< ushort >( 0x7a );

            // col: 33 offset: 007c
            ContentFinderCondition = parser.ReadOffset< ushort >( 0x7c );

            // col: 0 offset: 007e
            Key = parser.ReadOffset< byte >( 0x7e );

            // col: 35 offset: 007f
            unknown7f = parser.ReadOffset< byte >( 0x7f );

            // col: 2 offset: 0080
            packed80 = parser.ReadOffset< byte >( 0x80, ExcelColumnDataType.UInt8 );

            Name = ( packed80 & 0x1 ) == 0x1;


        }
    }
}