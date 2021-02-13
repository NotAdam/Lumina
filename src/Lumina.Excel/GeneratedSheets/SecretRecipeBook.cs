// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SecretRecipeBook", columnHash: 0x0c8db36c )]
    public class SecretRecipeBook : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}