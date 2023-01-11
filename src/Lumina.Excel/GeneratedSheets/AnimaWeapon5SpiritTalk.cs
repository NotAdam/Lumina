// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5SpiritTalk", columnHash: 0xda365c51 )]
    public partial class AnimaWeapon5SpiritTalk : ExcelRow
    {
        
        public LazyRow< AnimaWeapon5SpiritTalkParam > Dialogue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Dialogue = new LazyRow< AnimaWeapon5SpiritTalkParam >( gameData, parser.ReadColumn< int >( 0 ), language );
        }
    }
}