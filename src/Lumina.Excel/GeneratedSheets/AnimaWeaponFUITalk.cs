// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponFUITalk", columnHash: 0xda365c51 )]
    public class AnimaWeaponFUITalk : ExcelRow
    {
        
        public LazyRow< AnimaWeaponFUITalkParam > Dialogue;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Dialogue = new LazyRow< AnimaWeaponFUITalkParam >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}