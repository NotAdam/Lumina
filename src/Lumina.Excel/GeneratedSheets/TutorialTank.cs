// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TutorialTank", columnHash: 0xdcfd9eba )]
    public partial class TutorialTank : ExcelRow
    {
        
        public LazyRow< Tutorial > Objective { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Objective = new LazyRow< Tutorial >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}