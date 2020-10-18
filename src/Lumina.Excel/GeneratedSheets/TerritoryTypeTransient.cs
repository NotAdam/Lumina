// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryTypeTransient", columnHash: 0xd9b2883f )]
    public class TerritoryTypeTransient : IExcelRow
    {
        
        public short OffsetZ;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            OffsetZ = parser.ReadColumn< short >( 0 );
        }
    }
}