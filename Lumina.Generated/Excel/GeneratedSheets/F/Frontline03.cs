using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Frontline03", columnHash: 0x605090e3 )]
    public class Frontline03 : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 09 offset: 0000
        public uint[] EmptyIcon;

        // col: 12 offset: 0004
        public uint[] MaelstromIcon;

        // col: 15 offset: 0008
        public uint[] TwinAdderIcon;

        // col: 18 offset: 000c
        public uint[] ImmortalFlamesIcon;

        // col: 00 offset: 0010
        public byte unknown10;

        // col: 03 offset: 0011
        public byte unknown11;

        // col: 06 offset: 0012
        public byte unknown12;

        // col: 01 offset: 0024
        public byte unknown24;

        // col: 04 offset: 0025
        public byte unknown25;

        // col: 07 offset: 0026
        public byte unknown26;

        // col: 02 offset: 0038
        public byte unknown38;

        // col: 05 offset: 0039
        public byte unknown39;

        // col: 08 offset: 003a
        public byte unknown3a;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 9 offset: 0000
            EmptyIcon = new uint[3];
            EmptyIcon[0] = parser.ReadOffset< uint >( 0x0 );
            EmptyIcon[1] = parser.ReadOffset< uint >( 0x14 );
            EmptyIcon[2] = parser.ReadOffset< uint >( 0x28 );

            // col: 12 offset: 0004
            MaelstromIcon = new uint[3];
            MaelstromIcon[0] = parser.ReadOffset< uint >( 0x4 );
            MaelstromIcon[1] = parser.ReadOffset< uint >( 0x18 );
            MaelstromIcon[2] = parser.ReadOffset< uint >( 0x2c );

            // col: 15 offset: 0008
            TwinAdderIcon = new uint[3];
            TwinAdderIcon[0] = parser.ReadOffset< uint >( 0x8 );
            TwinAdderIcon[1] = parser.ReadOffset< uint >( 0x1c );
            TwinAdderIcon[2] = parser.ReadOffset< uint >( 0x30 );

            // col: 18 offset: 000c
            ImmortalFlamesIcon = new uint[3];
            ImmortalFlamesIcon[0] = parser.ReadOffset< uint >( 0xc );
            ImmortalFlamesIcon[1] = parser.ReadOffset< uint >( 0x20 );
            ImmortalFlamesIcon[2] = parser.ReadOffset< uint >( 0x34 );

            // col: 0 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 3 offset: 0011
            unknown11 = parser.ReadOffset< byte >( 0x11 );

            // col: 6 offset: 0012
            unknown12 = parser.ReadOffset< byte >( 0x12 );

            // col: 1 offset: 0024
            unknown24 = parser.ReadOffset< byte >( 0x24 );

            // col: 4 offset: 0025
            unknown25 = parser.ReadOffset< byte >( 0x25 );

            // col: 7 offset: 0026
            unknown26 = parser.ReadOffset< byte >( 0x26 );

            // col: 2 offset: 0038
            unknown38 = parser.ReadOffset< byte >( 0x38 );

            // col: 5 offset: 0039
            unknown39 = parser.ReadOffset< byte >( 0x39 );

            // col: 8 offset: 003a
            unknown3a = parser.ReadOffset< byte >( 0x3a );


        }
    }
}