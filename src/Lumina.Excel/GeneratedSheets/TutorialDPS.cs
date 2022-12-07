// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TutorialDPS", columnHash: 0xd060a8d1 )]
    public partial class TutorialDPS : ExcelRow
    {
        
        public LazyRow< Tutorial > Objective { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Objective = new LazyRow< Tutorial >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}