// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Warp", columnHash: 0x1a234b7b )]
    public class Warp : ExcelRow
    {
        
        public LazyRow< Level > PopRange;
        public LazyRow< TerritoryType > TerritoryType;
        public LazyRow< DefaultTalk > ConditionSuccessEvent;
        public LazyRow< DefaultTalk > ConditionFailEvent;
        public LazyRow< DefaultTalk > ConfirmEvent;
        public LazyRow< WarpCondition > WarpCondition;
        public LazyRow< WarpLogic > WarpLogic;
        public LazyRow< Cutscene > StartCutscene;
        public LazyRow< Cutscene > EndCutscene;
        public bool CanSkipCutscene;
        public SeString Name;
        public SeString Question;
        

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