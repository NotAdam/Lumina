// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponFUITalk", columnHash: 0xda365c51 )]
    public class AnimaWeaponFUITalk : IExcelRow
    {
        
        public LazyRow< AnimaWeaponFUITalkParam > Dialogue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Dialogue = new LazyRow< AnimaWeaponFUITalkParam >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}