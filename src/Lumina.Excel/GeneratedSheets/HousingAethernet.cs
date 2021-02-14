// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAethernet", columnHash: 0x751baa92 )]
    public class HousingAethernet : ExcelRow
    {
        
        public LazyRow< Level > Level;
        public LazyRow< TerritoryType > TerritoryType;
        public LazyRow< PlaceName > PlaceName;
        public byte Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Level = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 0 ), language );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            Order = parser.ReadColumn< byte >( 3 );
        }
    }
}