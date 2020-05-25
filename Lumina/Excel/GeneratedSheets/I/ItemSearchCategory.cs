using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSearchCategory", columnHash: 0xeffa5b93 )]
    public class ItemSearchCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public int Icon;

        // col: 02 offset: 0008
        public byte Category;

        // col: 03 offset: 0009
        public byte Order;

        // col: 04 offset: 000a
        public sbyte ClassJob;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            Category = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            Order = parser.ReadOffset< byte >( 0x9 );

            // col: 4 offset: 000a
            ClassJob = parser.ReadOffset< sbyte >( 0xa );


        }
    }
}