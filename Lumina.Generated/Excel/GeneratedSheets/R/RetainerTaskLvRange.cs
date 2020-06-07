using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskLvRange", columnHash: 0xde74b4c4 )]
    public class RetainerTaskLvRange : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public byte Min;

        // col: 01 offset: 0001
        public byte Max;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Min = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            Max = parser.ReadOffset< byte >( 0x1 );


        }
    }
}