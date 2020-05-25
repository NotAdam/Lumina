using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2Mission", columnHash: 0xf300dfd1 )]
    public class SkyIsland2Mission : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 21 offset: 0000
        public string unknown0;

        // col: 22 offset: 0004
        public string unknown4;

        // col: 23 offset: 0008
        public string unknown8;

        // col: 24 offset: 000c
        public string unknownc;

        // col: 25 offset: 0010
        public string unknown10;

        // col: 00 offset: 0014
        public uint Item1;

        // col: 01 offset: 0018
        public uint Item2;

        // col: 05 offset: 001c
        public uint unknown1c;

        // col: 10 offset: 0020
        public uint unknown20;

        // col: 15 offset: 0024
        public uint unknown24;

        // col: 07 offset: 0028
        public uint unknown28;

        // col: 12 offset: 002c
        public uint unknown2c;

        // col: 17 offset: 0030
        public uint unknown30;

        // col: 19 offset: 0034
        public uint unknown34;

        // col: 20 offset: 0038
        public uint Image;

        // col: 02 offset: 003c
        public ushort unknown3c;

        // col: 03 offset: 003e
        public ushort unknown3e;

        // col: 04 offset: 0040
        public ushort Objective1;

        // col: 09 offset: 0042
        public ushort Objective2;

        // col: 14 offset: 0044
        public ushort Objective3;

        // col: 06 offset: 0046
        public byte RequiredAmount1;

        // col: 11 offset: 0047
        public byte RequiredAmount2;

        // col: 16 offset: 0048
        public byte unknown48;

        // col: 08 offset: 0049
        public byte unknown49;

        // col: 13 offset: 004a
        public byte unknown4a;

        // col: 18 offset: 004b
        public byte unknown4b;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 21 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 22 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 23 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 24 offset: 000c
            unknownc = parser.ReadOffset< string >( 0xc );

            // col: 25 offset: 0010
            unknown10 = parser.ReadOffset< string >( 0x10 );

            // col: 0 offset: 0014
            Item1 = parser.ReadOffset< uint >( 0x14 );

            // col: 1 offset: 0018
            Item2 = parser.ReadOffset< uint >( 0x18 );

            // col: 5 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 10 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 15 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 7 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 12 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 17 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 19 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 20 offset: 0038
            Image = parser.ReadOffset< uint >( 0x38 );

            // col: 2 offset: 003c
            unknown3c = parser.ReadOffset< ushort >( 0x3c );

            // col: 3 offset: 003e
            unknown3e = parser.ReadOffset< ushort >( 0x3e );

            // col: 4 offset: 0040
            Objective1 = parser.ReadOffset< ushort >( 0x40 );

            // col: 9 offset: 0042
            Objective2 = parser.ReadOffset< ushort >( 0x42 );

            // col: 14 offset: 0044
            Objective3 = parser.ReadOffset< ushort >( 0x44 );

            // col: 6 offset: 0046
            RequiredAmount1 = parser.ReadOffset< byte >( 0x46 );

            // col: 11 offset: 0047
            RequiredAmount2 = parser.ReadOffset< byte >( 0x47 );

            // col: 16 offset: 0048
            unknown48 = parser.ReadOffset< byte >( 0x48 );

            // col: 8 offset: 0049
            unknown49 = parser.ReadOffset< byte >( 0x49 );

            // col: 13 offset: 004a
            unknown4a = parser.ReadOffset< byte >( 0x4a );

            // col: 18 offset: 004b
            unknown4b = parser.ReadOffset< byte >( 0x4b );


        }
    }
}