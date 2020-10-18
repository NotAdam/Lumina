// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShop", columnHash: 0x6a066e9a )]
    public class CollectablesShop : IExcelRow
    {
        
        public SeString Name;
        public LazyRow< Quest > Quest;
        public byte Unknown2;
        public LazyRow< CollectablesShopItem >[] ShopItems;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            ShopItems = new LazyRow< CollectablesShopItem >[ 11 ];
            for( var i = 0; i < 11; i++ )
                ShopItems[ i ] = new LazyRow< CollectablesShopItem >( lumina, parser.ReadColumn< ushort >( 3 + i ), language );
        }
    }
}