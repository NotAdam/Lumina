// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChat", columnHash: 0x66d693c5 )]
    public partial class QuickChat : ExcelRow
    {
        
        public SeString NameAction { get; set; }
        public int Icon { get; set; }
        public LazyRow< Addon > Addon { get; set; }
        public LazyRow< QuickChatTransient > QuickChatTransient { get; set; }
        public ushort Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            NameAction = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Addon = new LazyRow< Addon >( gameData, parser.ReadColumn< int >( 2 ), language );
            QuickChatTransient = new LazyRow< QuickChatTransient >( gameData, parser.ReadColumn< sbyte >( 3 ), language );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
        }
    }
}