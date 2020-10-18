// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherReportReplace", columnHash: 0x2020acf6 )]
    public class WeatherReportReplace : IExcelRow
    {
        
        public LazyRow< PlaceName > PlaceNameSub;
        public LazyRow< PlaceName > PlaceNameParent;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PlaceNameSub = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            PlaceNameParent = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}