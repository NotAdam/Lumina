using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimelineReplace", columnHash: 0x2020acf6 )]
    public class ActionTimelineReplace : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public ushort Old;

        // col: 01 offset: 0002
        public ushort New;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Old = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            New = parser.ReadOffset< ushort >( 0x2 );


        }
    }
}