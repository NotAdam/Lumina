using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyAction", columnHash: 0xde0dd9cf )]
    public class CompanyAction : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 04 offset: 0008
        public uint Cost;

        // col: 02 offset: 000c
        public int Icon;

        // col: 03 offset: 0010
        public byte FCRank;

        // col: 05 offset: 0011
        public byte Order;

        // col: 06 offset: 0012
        public bool Purchasable;
        public byte packed12;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 4 offset: 0008
            Cost = parser.ReadOffset< uint >( 0x8 );

            // col: 2 offset: 000c
            Icon = parser.ReadOffset< int >( 0xc );

            // col: 3 offset: 0010
            FCRank = parser.ReadOffset< byte >( 0x10 );

            // col: 5 offset: 0011
            Order = parser.ReadOffset< byte >( 0x11 );

            // col: 6 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );

            Purchasable = ( packed12 & 0x1 ) == 0x1;


        }
    }
}