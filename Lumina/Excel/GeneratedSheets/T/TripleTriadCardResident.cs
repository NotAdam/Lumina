using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardResident", columnHash: 0xcce12103 )]
    public class TripleTriadCardResident : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public ushort unknown0;

        // col: 07 offset: 0002
        public ushort SaleValue;

        // col: 01 offset: 0004
        public byte Top;

        // col: 02 offset: 0005
        public byte Bottom;

        // col: 03 offset: 0006
        public byte Left;

        // col: 04 offset: 0007
        public byte Right;

        // col: 05 offset: 0008
        public byte TripleTriadCardRarity;

        // col: 06 offset: 0009
        public byte TripleTriadCardType;

        // col: 08 offset: 000a
        public byte SortKey;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 7 offset: 0002
            SaleValue = parser.ReadOffset< ushort >( 0x2 );

            // col: 1 offset: 0004
            Top = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            Bottom = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            Left = parser.ReadOffset< byte >( 0x6 );

            // col: 4 offset: 0007
            Right = parser.ReadOffset< byte >( 0x7 );

            // col: 5 offset: 0008
            TripleTriadCardRarity = parser.ReadOffset< byte >( 0x8 );

            // col: 6 offset: 0009
            TripleTriadCardType = parser.ReadOffset< byte >( 0x9 );

            // col: 8 offset: 000a
            SortKey = parser.ReadOffset< byte >( 0xa );


        }
    }
}