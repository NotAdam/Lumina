// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryType", columnHash: 0x5cbd7b58 )]
    public class TerritoryType : IExcelRow
    {
        
        public SeString Name;
        public SeString Bg;
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
        public LazyRow< ExVersion > ExVersion;
        public byte Unknown30;
        public byte Unknown31;
        public byte AddedIn53;
        public LazyRow< MountSpeed > MountSpeed;
        public bool Unknown34;
        public bool Unknown35;
        public byte Unknown36;
        public bool Unknown37;
        public bool Unknown38;
        public bool Unknown39;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Bg = parser.ReadColumn< SeString >( 1 );
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
            ExVersion = new LazyRow< ExVersion >( lumina, parser.ReadColumn< byte >( 29 ), language );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            AddedIn53 = parser.ReadColumn< byte >( 32 );
            MountSpeed = new LazyRow< MountSpeed >( lumina, parser.ReadColumn< byte >( 33 ), language );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            Unknown39 = parser.ReadColumn< bool >( 39 );
        }
    }
}