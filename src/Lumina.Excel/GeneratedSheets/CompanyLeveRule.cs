// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyLeveRule", columnHash: 0xcc3ad729 )]
    public class CompanyLeveRule : ExcelRow
    {
        
        public SeString Type;
        public LazyRow< LeveString > Objective;
        public LazyRow< LeveString > Help;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< SeString >( 0 );
            Objective = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Help = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}