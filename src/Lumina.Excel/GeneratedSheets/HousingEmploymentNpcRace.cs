// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingEmploymentNpcRace", columnHash: 0xdebb20e3 )]
    public class HousingEmploymentNpcRace : ExcelRow
    {
        
        public SeString Race;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Race = parser.ReadColumn< SeString >( 0 );
        }
    }
}