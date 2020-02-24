using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRouteTable", columnHash: 0xdbf43666 )]
    public class IKDRouteTable : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT


        // col: 00 offset: 0000
        public uint Route;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Route = parser.ReadOffset< uint >( 0x0 );


        }
    }
}