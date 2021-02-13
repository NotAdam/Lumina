// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaAethernet", columnHash: 0xd870e208 )]
    public class EurekaAethernet : ExcelRow
    {
        
        public LazyRow< PlaceName > Location;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Location = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}