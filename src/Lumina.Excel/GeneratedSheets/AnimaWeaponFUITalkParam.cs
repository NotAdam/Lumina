// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponFUITalkParam", columnHash: 0x9db0e48f )]
    public class AnimaWeaponFUITalkParam : ExcelRow
    {
        
        public SeString Prologue;
        public SeString Epilogue;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Prologue = parser.ReadColumn< SeString >( 0 );
            Epilogue = parser.ReadColumn< SeString >( 1 );
        }
    }
}