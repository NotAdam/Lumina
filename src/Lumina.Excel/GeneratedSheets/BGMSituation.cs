// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSituation", columnHash: 0x64a88f98 )]
    public partial class BGMSituation : ExcelRow
    {
        
        public LazyRow< BGM > DaytimeID { get; set; }
        public LazyRow< BGM > NightID { get; set; }
        public LazyRow< BGM > BattleID { get; set; }
        public LazyRow< BGM > DaybreakID { get; set; }
        public LazyRow< BGM > TwilightID { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            DaytimeID = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            NightID = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            BattleID = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            DaybreakID = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            TwilightID = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}