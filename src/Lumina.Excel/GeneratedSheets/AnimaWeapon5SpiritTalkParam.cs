// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5SpiritTalkParam", columnHash: 0xeb6ca51f )]
    public partial class AnimaWeapon5SpiritTalkParam : ExcelRow
    {
        
        public SeString Prologue { get; set; }
        public SeString Epilogue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Prologue = parser.ReadColumn< SeString >( 0 );
            Epilogue = parser.ReadColumn< SeString >( 1 );
        }
    }
}