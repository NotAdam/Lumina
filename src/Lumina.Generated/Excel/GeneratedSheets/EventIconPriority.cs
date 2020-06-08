using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriority", columnHash: 0x0bc77e1c )]
    public class EventIconPriority : IExcelRow
    {
        
        public uint[] Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 19; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}