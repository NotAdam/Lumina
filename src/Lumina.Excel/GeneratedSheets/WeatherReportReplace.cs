// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherReportReplace", columnHash: 0x2020acf6 )]
    public partial class WeatherReportReplace : ExcelRow
    {
        
        public LazyRow< PlaceName > PlaceNameSub { get; set; }
        public LazyRow< PlaceName > PlaceNameParent { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            PlaceNameParent = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}