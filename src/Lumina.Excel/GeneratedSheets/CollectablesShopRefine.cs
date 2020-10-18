// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRefine", columnHash: 0xdc23efe7 )]
    public class CollectablesShopRefine : IExcelRow
    {
        
        public ushort LowCollectability;
        public ushort MidCollectability;
        public ushort HighCollectability;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            LowCollectability = parser.ReadColumn< ushort >( 0 );
            MidCollectability = parser.ReadColumn< ushort >( 1 );
            HighCollectability = parser.ReadColumn< ushort >( 2 );
        }
    }
}