// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemBarterCheck", columnHash: 0x8920dbd8 )]
    public class ItemBarterCheck : ExcelRow
    {
        
        public ushort Category;
        public uint Question;
        public LazyRow< Addon > Confirm;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< ushort >( 0 );
            Question = parser.ReadColumn< uint >( 1 );
            Confirm = new LazyRow< Addon >( gameData, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}