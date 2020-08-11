// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5SpiritTalk", columnHash: 0xda365c51 )]
    public class AnimaWeapon5SpiritTalk : IExcelRow
    {
        
        public LazyRow< AnimaWeapon5SpiritTalkParam > Dialogue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Dialogue = new LazyRow< AnimaWeapon5SpiritTalkParam >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}