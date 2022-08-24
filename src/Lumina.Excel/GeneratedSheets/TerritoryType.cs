// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryType", columnHash: 0x5baa595e )]
    public partial class TerritoryType : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Bg { get; set; }
        public byte BattalionMode { get; set; }
        public LazyRow< PlaceName > PlaceNameRegion { get; set; }
        public LazyRow< PlaceName > PlaceNameZone { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public LazyRow< Map > Map { get; set; }
        public byte LoadingImage { get; set; }
        public byte ExclusiveType { get; set; }
        public byte TerritoryIntendedUse { get; set; }
        public LazyRow< ContentFinderCondition > ContentFinderCondition { get; set; }
        public bool Unknown11 { get; set; }
        public byte WeatherRate { get; set; }
        public bool Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public bool PCSearch { get; set; }
        public bool Stealth { get; set; }
        public bool Mount { get; set; }
        public bool Unknown18 { get; set; }
        public ushort BGM { get; set; }
        public int PlaceNameRegionIcon { get; set; }
        public int PlaceNameIcon { get; set; }
        public LazyRow< ArrayEventHandler > ArrayEventHandler { get; set; }
        public LazyRow< QuestBattle > QuestBattle { get; set; }
        public LazyRow< Aetheryte > Aetheryte { get; set; }
        public int FixedTime { get; set; }
        public ushort Resident { get; set; }
        public sbyte AchievementIndex { get; set; }
        public bool IsPvpZone { get; set; }
        public LazyRow< ExVersion > ExVersion { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public LazyRow< MountSpeed > MountSpeed { get; set; }
        public bool Unknown34 { get; set; }
        public bool Unknown35 { get; set; }
        public byte Unknown36 { get; set; }
        public bool Unknown37 { get; set; }
        public bool Unknown38 { get; set; }
        public bool Unknown39 { get; set; }
        public bool Unknown40 { get; set; }
        public bool Unknown41 { get; set; }
        public ushort Unknown42 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Bg = parser.ReadColumn< SeString >( 1 );
            BattalionMode = parser.ReadColumn< byte >( 2 );
            PlaceNameRegion = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            PlaceNameZone = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Map = new LazyRow< Map >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            LoadingImage = parser.ReadColumn< byte >( 7 );
            ExclusiveType = parser.ReadColumn< byte >( 8 );
            TerritoryIntendedUse = parser.ReadColumn< byte >( 9 );
            ContentFinderCondition = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            WeatherRate = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            PCSearch = parser.ReadColumn< bool >( 15 );
            Stealth = parser.ReadColumn< bool >( 16 );
            Mount = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            BGM = parser.ReadColumn< ushort >( 19 );
            PlaceNameRegionIcon = parser.ReadColumn< int >( 20 );
            PlaceNameIcon = parser.ReadColumn< int >( 21 );
            ArrayEventHandler = new LazyRow< ArrayEventHandler >( gameData, parser.ReadColumn< uint >( 22 ), language );
            QuestBattle = new LazyRow< QuestBattle >( gameData, parser.ReadColumn< ushort >( 23 ), language );
            Aetheryte = new LazyRow< Aetheryte >( gameData, parser.ReadColumn< int >( 24 ), language );
            FixedTime = parser.ReadColumn< int >( 25 );
            Resident = parser.ReadColumn< ushort >( 26 );
            AchievementIndex = parser.ReadColumn< sbyte >( 27 );
            IsPvpZone = parser.ReadColumn< bool >( 28 );
            ExVersion = new LazyRow< ExVersion >( gameData, parser.ReadColumn< byte >( 29 ), language );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            MountSpeed = new LazyRow< MountSpeed >( gameData, parser.ReadColumn< byte >( 33 ), language );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            Unknown39 = parser.ReadColumn< bool >( 39 );
            Unknown40 = parser.ReadColumn< bool >( 40 );
            Unknown41 = parser.ReadColumn< bool >( 41 );
            Unknown42 = parser.ReadColumn< ushort >( 42 );
        }
    }
}