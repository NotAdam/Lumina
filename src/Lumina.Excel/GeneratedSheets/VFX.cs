// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VFX", columnHash: 0xdebb20e3 )]
    public class VFX : ExcelRow
    {
        
        public SeString Location;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Location = parser.ReadColumn< SeString >( 0 );
        }
    }
}