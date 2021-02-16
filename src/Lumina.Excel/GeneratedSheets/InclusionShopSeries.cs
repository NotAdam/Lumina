// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InclusionShopSeries", columnHash: 0xdbf43666 )]
    public class InclusionShopSeries : ExcelRow
    {
        
        public LazyRow< SpecialShop > SpecialShop;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SpecialShop = new LazyRow< SpecialShop >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}