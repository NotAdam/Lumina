using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Warp", columnHash: 0x1a234b7b )]
    public class Warp : IExcelRow
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
        public string Name;
        public string Question;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PopRange = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 0 ) );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 1 ) );
            ConditionSuccessEvent = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 2 ) );
            ConditionFailEvent = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 3 ) );
            ConfirmEvent = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 4 ) );
            WarpCondition = new LazyRow< WarpCondition >( lumina, parser.ReadColumn< ushort >( 5 ) );
            WarpLogic = new LazyRow< WarpLogic >( lumina, parser.ReadColumn< ushort >( 6 ) );
            StartCutscene = new LazyRow< Cutscene >( lumina, parser.ReadColumn< ushort >( 7 ) );
            EndCutscene = new LazyRow< Cutscene >( lumina, parser.ReadColumn< ushort >( 8 ) );
            CanSkipCutscene = parser.ReadColumn< bool >( 9 );
            Name = parser.ReadColumn< string >( 10 );
            Question = parser.ReadColumn< string >( 11 );
        }
    }
}