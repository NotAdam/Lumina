// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherGroup", columnHash: 0xfaedad07 )]
    public class WeatherGroup : ExcelRow
    {
        
        public int Unknown0;
        public LazyRow< WeatherRate > WeatherRate;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            WeatherRate = new LazyRow< WeatherRate >( lumina, parser.ReadColumn< int >( 1 ), language );
        }
    }
}