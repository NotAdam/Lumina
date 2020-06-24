using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSituation", columnHash: 0x64a88f98 )]
    public class BGMSituation : IExcelRow
    {
        
        public LazyRow< BGM > DaytimeID;
        public LazyRow< BGM > NightID;
        public LazyRow< BGM > BattleID;
        public LazyRow< BGM > DaybreakID;
        public LazyRow< BGM > TwilightID;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            DaytimeID = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            NightID = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            BattleID = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            DaybreakID = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            TwilightID = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}