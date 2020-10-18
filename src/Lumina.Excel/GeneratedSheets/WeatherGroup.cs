// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherGroup", columnHash: 0xfaedad07 )]
    public class WeatherGroup : IExcelRow
    {
        
        public int Unknown0;
        public LazyRow< WeatherRate > WeatherRate;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< int >( 0 );
            WeatherRate = new LazyRow< WeatherRate >( lumina, parser.ReadColumn< int >( 1 ), language );
        }
    }
}