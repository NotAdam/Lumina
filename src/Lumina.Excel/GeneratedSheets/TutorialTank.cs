// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TutorialTank", columnHash: 0xdcfd9eba )]
    public class TutorialTank : ExcelRow
    {
        
        public LazyRow< Tutorial > Objective;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Objective = new LazyRow< Tutorial >( lumina, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}