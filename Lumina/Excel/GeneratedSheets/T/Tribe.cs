using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tribe", columnHash: 0xe74759fb )]
    public class Tribe : IExcelRow
    {
        // column defs from Sun, 09 Feb 2020 20:51:08 GMT


        // col: 00 offset: 0000
        public string Masculine;

        // col: 01 offset: 0004
        public string Feminine;

        // col: 02 offset: 0008
        public sbyte Hp;

        // col: 03 offset: 0009
        public sbyte Mp;

        // col: 04 offset: 000a
        public sbyte STR;

        // col: 05 offset: 000b
        public sbyte VIT;

        // col: 06 offset: 000c
        public sbyte DEX;

        // col: 07 offset: 000d
        public sbyte INT;

        // col: 08 offset: 000e
        public sbyte MND;

        // col: 09 offset: 000f
        public sbyte PIE;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Masculine = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Feminine = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Hp = parser.ReadOffset< sbyte >( 0x8 );

            // col: 3 offset: 0009
            Mp = parser.ReadOffset< sbyte >( 0x9 );

            // col: 4 offset: 000a
            STR = parser.ReadOffset< sbyte >( 0xa );

            // col: 5 offset: 000b
            VIT = parser.ReadOffset< sbyte >( 0xb );

            // col: 6 offset: 000c
            DEX = parser.ReadOffset< sbyte >( 0xc );

            // col: 7 offset: 000d
            INT = parser.ReadOffset< sbyte >( 0xd );

            // col: 8 offset: 000e
            MND = parser.ReadOffset< sbyte >( 0xe );

            // col: 9 offset: 000f
            PIE = parser.ReadOffset< sbyte >( 0xf );


        }
    }
}