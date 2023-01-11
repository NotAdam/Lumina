// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherGroup", columnHash: 0xfaedad07 )]
    public partial class WeatherGroup : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public LazyRow< WeatherRate > WeatherRate { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            WeatherRate = new LazyRow< WeatherRate >( gameData, parser.ReadColumn< int >( 1 ), language );
        }
    }
}