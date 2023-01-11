// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAethernet", columnHash: 0x751baa92 )]
    public partial class HousingAethernet : ExcelRow
    {
        
        public LazyRow< Level > Level { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Level = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 0 ), language );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Order = parser.ReadColumn< byte >( 3 );
        }
    }
}