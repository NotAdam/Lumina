// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntOrderType", columnHash: 0x795a75a0 )]
    public class MobHuntOrderType : ExcelRow
    {
        
        public byte Type;
        public LazyRow< Quest > Quest;
        public LazyRow< EventItem > EventItem;
        public LazyRow< MobHuntOrder > OrderStart;
        public byte OrderAmount;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            EventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 2 ), language );
            OrderStart = new LazyRow< MobHuntOrder >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            OrderAmount = parser.ReadColumn< byte >( 4 );
        }
    }
}