// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaAethernet", columnHash: 0xd870e208 )]
    public class EurekaAethernet : IExcelRow
    {
        
        public LazyRow< PlaceName > Location;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Location = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}