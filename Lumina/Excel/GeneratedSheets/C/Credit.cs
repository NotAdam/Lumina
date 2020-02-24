using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Credit", columnHash: 0x1fe6ec22 )]
    public class Credit : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public ushort Roles1;

        // col: 02 offset: 0002
        public ushort JapaneseCast1;

        // col: 03 offset: 0004
        public ushort EnglishCast1;

        // col: 04 offset: 0006
        public ushort FrenchCast1;

        // col: 05 offset: 0008
        public ushort GermanCast1;

        // col: 06 offset: 000a
        public ushort Roles2;

        // col: 07 offset: 000c
        public ushort JapaneseCast2;

        // col: 08 offset: 000e
        public ushort EnglishCast2;

        // col: 09 offset: 0010
        public ushort FrenchCast2;

        // col: 10 offset: 0012
        public ushort GermanCast2;

        // col: 00 offset: 0014
        public byte unknown14;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Roles1 = parser.ReadOffset< ushort >( 0x0 );

            // col: 2 offset: 0002
            JapaneseCast1 = parser.ReadOffset< ushort >( 0x2 );

            // col: 3 offset: 0004
            EnglishCast1 = parser.ReadOffset< ushort >( 0x4 );

            // col: 4 offset: 0006
            FrenchCast1 = parser.ReadOffset< ushort >( 0x6 );

            // col: 5 offset: 0008
            GermanCast1 = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            Roles2 = parser.ReadOffset< ushort >( 0xa );

            // col: 7 offset: 000c
            JapaneseCast2 = parser.ReadOffset< ushort >( 0xc );

            // col: 8 offset: 000e
            EnglishCast2 = parser.ReadOffset< ushort >( 0xe );

            // col: 9 offset: 0010
            FrenchCast2 = parser.ReadOffset< ushort >( 0x10 );

            // col: 10 offset: 0012
            GermanCast2 = parser.ReadOffset< ushort >( 0x12 );

            // col: 0 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );


        }
    }
}