// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEvent", columnHash: 0x4f7339e4 )]
    public partial class DynamicEvent : ExcelRow
    {
        
        public LazyRow< DynamicEventType > EventType { get; set; }
        public LazyRow< DynamicEventEnemyType > EnemyType { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public uint LGBEventObject { get; set; }
        public uint LGBMapRange { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown7 { get; set; }
        public LazyRow< DynamicEventSingleBattle > SingleBattle { get; set; }
        public LazyRow< LogMessage > Announce { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public short Unknown12 { get; set; }
        public short Unknown13 { get; set; }
        public short Unknown14 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EventType = new LazyRow< DynamicEventType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            EnemyType = new LazyRow< DynamicEventEnemyType >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            LGBEventObject = parser.ReadColumn< uint >( 4 );
            LGBMapRange = parser.ReadColumn< uint >( 5 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 6 ), language );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            SingleBattle = new LazyRow< DynamicEventSingleBattle >( gameData, parser.ReadColumn< byte >( 8 ), language );
            Announce = new LazyRow< LogMessage >( gameData, parser.ReadColumn< uint >( 9 ), language );
            Name = parser.ReadColumn< SeString >( 10 );
            Description = parser.ReadColumn< SeString >( 11 );
            Unknown12 = parser.ReadColumn< short >( 12 );
            Unknown13 = parser.ReadColumn< short >( 13 );
            Unknown14 = parser.ReadColumn< short >( 14 );
        }
    }
}