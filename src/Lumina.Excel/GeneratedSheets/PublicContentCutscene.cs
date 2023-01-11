// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentCutscene", columnHash: 0x5d58cc84 )]
    public partial class PublicContentCutscene : ExcelRow
    {
        
        public LazyRow< Cutscene > Cutscene { get; set; }
        public LazyRow< Cutscene > Cutscene2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Cutscene = new LazyRow< Cutscene >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Cutscene2 = new LazyRow< Cutscene >( gameData, parser.ReadColumn< uint >( 1 ), language );
        }
    }
}