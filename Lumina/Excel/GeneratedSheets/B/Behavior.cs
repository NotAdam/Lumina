using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Behavior", columnHash: 0x858a7450 )]
    public class Behavior : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 11 offset: 0000
        public uint unknown0;

        // col: 15 offset: 0004
        public uint unknown4;

        // col: 04 offset: 0008
        public int Balloon;

        // col: 06 offset: 000c
        public int unknownc;

        // col: 07 offset: 0010
        public ushort unknown10;

        // col: 08 offset: 0012
        public ushort unknown12;

        // col: 16 offset: 0014
        public ushort unknown14;

        // col: 05 offset: 0016
        public short unknown16;

        // col: 00 offset: 0018
        public byte unknown18;

        // col: 01 offset: 0019
        public byte unknown19;

        // col: 02 offset: 001a
        public byte unknown1a;

        // col: 03 offset: 001b
        public byte unknown1b;

        // col: 09 offset: 001c
        public byte unknown1c;

        // col: 10 offset: 001d
        public byte unknown1d;

        // col: 12 offset: 001e
        public byte unknown1e;

        // col: 13 offset: 001f
        public byte unknown1f;

        // col: 14 offset: 0020
        public byte unknown20;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 11 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 15 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            Balloon = parser.ReadOffset< int >( 0x8 );

            // col: 6 offset: 000c
            unknownc = parser.ReadOffset< int >( 0xc );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 8 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 16 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 5 offset: 0016
            unknown16 = parser.ReadOffset< short >( 0x16 );

            // col: 0 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 1 offset: 0019
            unknown19 = parser.ReadOffset< byte >( 0x19 );

            // col: 2 offset: 001a
            unknown1a = parser.ReadOffset< byte >( 0x1a );

            // col: 3 offset: 001b
            unknown1b = parser.ReadOffset< byte >( 0x1b );

            // col: 9 offset: 001c
            unknown1c = parser.ReadOffset< byte >( 0x1c );

            // col: 10 offset: 001d
            unknown1d = parser.ReadOffset< byte >( 0x1d );

            // col: 12 offset: 001e
            unknown1e = parser.ReadOffset< byte >( 0x1e );

            // col: 13 offset: 001f
            unknown1f = parser.ReadOffset< byte >( 0x1f );

            // col: 14 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );


        }
    }
}