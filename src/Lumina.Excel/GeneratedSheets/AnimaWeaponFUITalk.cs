// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponFUITalk", columnHash: 0xda365c51 )]
    public partial class AnimaWeaponFUITalk : ExcelRow
    {
        
        public LazyRow< AnimaWeaponFUITalkParam > Dialogue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Dialogue = new LazyRow< AnimaWeaponFUITalkParam >( gameData, parser.ReadColumn< int >( 0 ), language );
        }
    }
}