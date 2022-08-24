// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Warp", columnHash: 0x1a234b7b )]
    public partial class Warp : ExcelRow
    {
        
        public LazyRow< Level > PopRange { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public LazyRow< DefaultTalk > ConditionSuccessEvent { get; set; }
        public LazyRow< DefaultTalk > ConditionFailEvent { get; set; }
        public LazyRow< DefaultTalk > ConfirmEvent { get; set; }
        public LazyRow< WarpCondition > WarpCondition { get; set; }
        public LazyRow< WarpLogic > WarpLogic { get; set; }
        public LazyRow< Cutscene > StartCutscene { get; set; }
        public LazyRow< Cutscene > EndCutscene { get; set; }
        public bool CanSkipCutscene { get; set; }
        public SeString Name { get; set; }
        public SeString Question { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PopRange = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 0 ), language );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            ConditionSuccessEvent = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 2 ), language );
            ConditionFailEvent = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 3 ), language );
            ConfirmEvent = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 4 ), language );
            WarpCondition = new LazyRow< WarpCondition >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            WarpLogic = new LazyRow< WarpLogic >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            StartCutscene = new LazyRow< Cutscene >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            EndCutscene = new LazyRow< Cutscene >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            CanSkipCutscene = parser.ReadColumn< bool >( 9 );
            Name = parser.ReadColumn< SeString >( 10 );
            Question = parser.ReadColumn< SeString >( 11 );
        }
    }
}