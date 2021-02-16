// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceWeather", columnHash: 0xfaedad07 )]
    public class ChocoboRaceWeather : ExcelRow
    {
        
        public LazyRow< Weather > WeatherType1;
        public LazyRow< Weather > WeatherType2;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            WeatherType1 = new LazyRow< Weather >( gameData, parser.ReadColumn< int >( 0 ), language );
            WeatherType2 = new LazyRow< Weather >( gameData, parser.ReadColumn< int >( 1 ), language );
        }
    }
}