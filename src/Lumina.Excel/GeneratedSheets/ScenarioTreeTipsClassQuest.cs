// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTipsClassQuest", columnHash: 0xae1d30a7 )]
    public partial class ScenarioTreeTipsClassQuest : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        public ushort RequiredLevel { get; set; }
        public LazyRow< ExVersion > RequiredExpansion { get; set; }
        public LazyRow< Quest > RequiredQuest { get; set; }
        public bool Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            RequiredLevel = parser.ReadColumn< ushort >( 1 );
            RequiredExpansion = new LazyRow< ExVersion >( gameData, parser.ReadColumn< byte >( 2 ), language );
            RequiredQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 3 ), language );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}