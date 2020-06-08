using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2RangeType", columnHash: 0xdcfd9eba )]
    public class SkyIsland2RangeType : IExcelRow
    {
        
        public byte Type;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< byte >( 0 );
        }
    }
}