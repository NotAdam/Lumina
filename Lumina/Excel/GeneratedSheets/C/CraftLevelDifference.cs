using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLevelDifference", columnHash: 0xba1851a4 )]
    public class CraftLevelDifference : IExcelRow
    {
        // column defs from Wed, 24 Jul 2019 22:56:39 GMT


        // col: 00 offset: 0000
        public short Difference;

        // col: 01 offset: 0002
        public short ProgressFactor;

        // col: 02 offset: 0004
        public short QualityFactor;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Difference = parser.ReadOffset< short >( 0x0 );

            // col: 1 offset: 0002
            ProgressFactor = parser.ReadOffset< short >( 0x2 );

            // col: 2 offset: 0004
            QualityFactor = parser.ReadOffset< short >( 0x4 );


        }
    }
}