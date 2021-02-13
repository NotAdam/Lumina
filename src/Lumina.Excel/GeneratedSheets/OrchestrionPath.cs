// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionPath", columnHash: 0xdebb20e3 )]
    public class OrchestrionPath : ExcelRow
    {
        
        public SeString File;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            File = parser.ReadColumn< SeString >( 0 );
        }
    }
}