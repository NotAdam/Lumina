// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestEffectDefine", columnHash: 0xd870e208 )]
    public partial class QuestEffectDefine : ExcelRow
    {
        
        public LazyRow< QuestEffect > Effect { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Effect = new LazyRow< QuestEffect >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}