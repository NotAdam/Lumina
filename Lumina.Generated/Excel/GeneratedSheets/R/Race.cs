using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Race", columnHash: 0x3cc6df2e )]
    public class Race : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Masculine;

        // col: 01 offset: 0004
        public string Feminine;

        // col: 02 offset: 0008
        public int RSEMBody;

        // col: 06 offset: 000c
        public int RSEFBody;

        // col: 03 offset: 0010
        public int RSEMHands;

        // col: 07 offset: 0014
        public int RSEFHands;

        // col: 04 offset: 0018
        public int RSEMLegs;

        // col: 08 offset: 001c
        public int RSEFLegs;

        // col: 05 offset: 0020
        public int RSEMFeet;

        // col: 09 offset: 0024
        public int RSEFFeet;

        // col: 10 offset: 0028
        public byte unknown28;


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
            RSEMBody = parser.ReadOffset< int >( 0x8 );

            // col: 6 offset: 000c
            RSEFBody = parser.ReadOffset< int >( 0xc );

            // col: 3 offset: 0010
            RSEMHands = parser.ReadOffset< int >( 0x10 );

            // col: 7 offset: 0014
            RSEFHands = parser.ReadOffset< int >( 0x14 );

            // col: 4 offset: 0018
            RSEMLegs = parser.ReadOffset< int >( 0x18 );

            // col: 8 offset: 001c
            RSEFLegs = parser.ReadOffset< int >( 0x1c );

            // col: 5 offset: 0020
            RSEMFeet = parser.ReadOffset< int >( 0x20 );

            // col: 9 offset: 0024
            RSEFFeet = parser.ReadOffset< int >( 0x24 );

            // col: 10 offset: 0028
            unknown28 = parser.ReadOffset< byte >( 0x28 );


        }
    }
}