// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRefine", columnHash: 0xdc23efe7 )]
    public class CollectablesShopRefine : ExcelRow
    {
        
        public ushort LowCollectability;
        public ushort MidCollectability;
        public ushort HighCollectability;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LowCollectability = parser.ReadColumn< ushort >( 0 );
            MidCollectability = parser.ReadColumn< ushort >( 1 );
            HighCollectability = parser.ReadColumn< ushort >( 2 );
        }
    }
}