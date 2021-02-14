// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExportedSG", columnHash: 0xdebb20e3 )]
    public class ExportedSG : ExcelRow
    {
        
        public SeString SgbPath;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            SgbPath = parser.ReadColumn< SeString >( 0 );
        }
    }
}