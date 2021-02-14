// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExVersion", columnHash: 0xcc3ad729 )]
    public class ExVersion : ExcelRow
    {
        
        public SeString Name;
        public LazyRow< ScreenImage > AcceptJingle;
        public LazyRow< ScreenImage > CompleteJingle;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            AcceptJingle = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            CompleteJingle = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}