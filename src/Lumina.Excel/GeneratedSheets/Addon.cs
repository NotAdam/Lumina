// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Addon", columnHash: 0xdebb20e3 )]
    public class Addon : ExcelRow
    {
        
        public SeString Text;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Text = parser.ReadColumn< SeString >( 0 );
        }
    }
}