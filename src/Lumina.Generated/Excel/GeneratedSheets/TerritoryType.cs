using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryType", columnHash: 0x7dff1ae4 )]
    public class TerritoryType : IExcelRow
    {
        
        public string Name;
        public string Bg;
        public byte BattalionMode;
        public LazyRow< PlaceName > PlaceNameRegion;
        public LazyRow< PlaceName > PlaceNameZone;
        public LazyRow< PlaceName > PlaceName;
        public LazyRow< Map > Map;
        public byte LoadingImage;
        public byte ExclusiveType;
        public byte TerritoryIntendedUse;
        public ushort Unknown10;
        public bool Unknown11;
        public byte WeatherRate;
        public bool Unknown13;
        public byte Unknown14;
        public bool PCSearch;
        public bool Stealth;
        public bool Mount;
        public bool Unknown18;
        public LazyRow< BGM > BGM;
        public int PlaceNameRegionIcon;
        public int PlaceNameIcon;
        public LazyRow< ArrayEventHandler > ArrayEventHandler;
        public LazyRow< QuestBattle > QuestBattle;
        public LazyRow< Aetheryte > Aetheryte;
        public int FixedTime;
        public ushort Resident;
        public sbyte AchievementIndex;
        public bool IsPvpZone;
        public byte Unknown29;
        public byte Unknown30;
        public byte Unknown31;
        public byte Unknown32;
        public bool Unknown33;
        public bool Unknown34;
        public byte Unknown35;
        public bool Unknown36;
        public bool Unknown37;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Bg = parser.ReadColumn< string >( 1 );
            BattalionMode = parser.ReadColumn< byte >( 2 );
            PlaceNameRegion = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            PlaceNameZone = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            Map = new LazyRow< Map >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            LoadingImage = parser.ReadColumn< byte >( 7 );
            ExclusiveType = parser.ReadColumn< byte >( 8 );
            TerritoryIntendedUse = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            WeatherRate = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            PCSearch = parser.ReadColumn< bool >( 15 );
            Stealth = parser.ReadColumn< bool >( 16 );
            Mount = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 19 ), language );
            PlaceNameRegionIcon = parser.ReadColumn< int >( 20 );
            PlaceNameIcon = parser.ReadColumn< int >( 21 );
            ArrayEventHandler = new LazyRow< ArrayEventHandler >( lumina, parser.ReadColumn< uint >( 22 ), language );
            QuestBattle = new LazyRow< QuestBattle >( lumina, parser.ReadColumn< ushort >( 23 ), language );
            Aetheryte = new LazyRow< Aetheryte >( lumina, parser.ReadColumn< int >( 24 ), language );
            FixedTime = parser.ReadColumn< int >( 25 );
            Resident = parser.ReadColumn< ushort >( 26 );
            AchievementIndex = parser.ReadColumn< sbyte >( 27 );
            IsPvpZone = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< bool >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
        }
    }
}