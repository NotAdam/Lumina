// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDLevelChangeDeception", columnHash: 0xda365c51 )]
    public partial class HWDLevelChangeDeception : ExcelRow
    {
        
        public LazyRow< ScreenImage > Image { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< int >( 0 ), language );
        }
    }
}