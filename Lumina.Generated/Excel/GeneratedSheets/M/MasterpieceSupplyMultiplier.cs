using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MasterpieceSupplyMultiplier", columnHash: 0x1b64fcf8 )]
    public class MasterpieceSupplyMultiplier : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort[] XpMultiplier;

        // col: 02 offset: 0004
        public ushort unknown4;

        // col: 03 offset: 0006
        public ushort unknown6;

        // col: 04 offset: 0008
        public ushort[] CurrencyMultiplier;

        // col: 06 offset: 000c
        public ushort unknownc;

        // col: 07 offset: 000e
        public ushort unknowne;

        // col: 08 offset: 0010
        public ushort unknown10;

        // col: 09 offset: 0012
        public ushort unknown12;

        // col: 10 offset: 0014
        public ushort unknown14;

        // col: 11 offset: 0016
        public ushort unknown16;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            XpMultiplier = new ushort[2];
            XpMultiplier[0] = parser.ReadOffset< ushort >( 0x0 );
            XpMultiplier[1] = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            CurrencyMultiplier = new ushort[2];
            CurrencyMultiplier[0] = parser.ReadOffset< ushort >( 0x8 );
            CurrencyMultiplier[1] = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            unknowne = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 9 offset: 0012
            unknown12 = parser.ReadOffset< ushort >( 0x12 );

            // col: 10 offset: 0014
            unknown14 = parser.ReadOffset< ushort >( 0x14 );

            // col: 11 offset: 0016
            unknown16 = parser.ReadOffset< ushort >( 0x16 );


        }
    }
}