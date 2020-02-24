using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyLeveRule", columnHash: 0xcc3ad729 )]
    public class CompanyLeveRule : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Type;

        // col: 01 offset: 0004
        public ushort Objective;

        // col: 02 offset: 0006
        public ushort Help;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Type = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Objective = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            Help = parser.ReadOffset< ushort >( 0x6 );


        }
    }
}