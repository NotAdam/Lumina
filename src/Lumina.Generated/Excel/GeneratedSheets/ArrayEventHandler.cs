using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ArrayEventHandler", columnHash: 0xb404681e )]
    public class ArrayEventHandler : IExcelRow
    {
        
        public uint[] Data;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Data = new uint[ 16 ];
            for( var i = 0; i < 16; i++ )
                Data[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}