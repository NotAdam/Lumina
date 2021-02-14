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
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            WeatherType1 = new LazyRow< Weather >( lumina, parser.ReadColumn< int >( 0 ), language );
            WeatherType2 = new LazyRow< Weather >( lumina, parser.ReadColumn< int >( 1 ), language );
        }
    }
}