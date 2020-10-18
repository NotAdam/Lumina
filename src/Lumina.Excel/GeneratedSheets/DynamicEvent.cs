// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEvent", columnHash: 0xb5601716 )]
    public class DynamicEvent : IExcelRow
    {
        
        public LazyRow< DynamicEventType > EventType;
        public LazyRow< DynamicEventEnemyType > EnemyType;
        public byte Unknown2;
        public byte Unknown3;
        public uint LGBEventObject;
        public uint LGBMapRange;
        public LazyRow< Quest > Quest;
        public byte Unknown7;
        public LazyRow< DynamicEventSingleBattle > SingleBattle;
        public LazyRow< LogMessage > Announce;
        public SeString Name;
        public SeString Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EventType = new LazyRow< DynamicEventType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            EnemyType = new LazyRow< DynamicEventEnemyType >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            LGBEventObject = parser.ReadColumn< uint >( 4 );
            LGBMapRange = parser.ReadColumn< uint >( 5 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 6 ), language );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            SingleBattle = new LazyRow< DynamicEventSingleBattle >( lumina, parser.ReadColumn< byte >( 8 ), language );
            Announce = new LazyRow< LogMessage >( lumina, parser.ReadColumn< uint >( 9 ), language );
            Name = parser.ReadColumn< SeString >( 10 );
            Description = parser.ReadColumn< SeString >( 11 );
        }
    }
}