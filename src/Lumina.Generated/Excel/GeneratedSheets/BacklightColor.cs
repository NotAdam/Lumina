using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BacklightColor", columnHash: 0xdbf43666 )]
    public class BacklightColor : IExcelRow
    {
        
        public uint Color;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Color = parser.ReadColumn< uint >( 0 );
        }
    }
}