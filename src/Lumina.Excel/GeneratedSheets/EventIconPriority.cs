// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriority", columnHash: 0xf16871d0 )]
    public class EventIconPriority : IExcelRow
    {
        
        public uint[] Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = new uint[ 19 ];
            for( var i = 0; i < 19; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}