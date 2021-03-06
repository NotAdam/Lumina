// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEventSingleBattle", columnHash: 0xe760c985 )]
    public class DynamicEventSingleBattle : ExcelRow
    {
        
        public int ActionIcon { get; set; }
        public uint Icon { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ActionIcon = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Text = parser.ReadColumn< SeString >( 2 );
        }
    }
}