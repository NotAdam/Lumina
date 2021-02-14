// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveString", columnHash: 0xdebb20e3 )]
    public class LeveString : ExcelRow
    {
        
        public SeString Objective;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Objective = parser.ReadColumn< SeString >( 0 );
        }
    }
}