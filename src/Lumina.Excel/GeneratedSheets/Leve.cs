// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Leve", columnHash: 0x745e3c08 )]
    public partial class Leve : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public LazyRow< LeveClient > LeveClient { get; set; }
        public LazyRow< LeveAssignmentType > LeveAssignmentType { get; set; }
        public int Unknown4 { get; set; }
        public LazyRow< Town > Town { get; set; }
        public ushort ClassJobLevel { get; set; }
        public byte TimeLimit { get; set; }
        public byte AllowanceCost { get; set; }
        public int Evaluation { get; set; }
        public LazyRow< PlaceName > PlaceNameStart { get; set; }
        public LazyRow< PlaceName > PlaceNameIssued { get; set; }
        public bool Unknown12 { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public LazyRow< JournalGenre > JournalGenre { get; set; }
        public int Unknown15 { get; set; }
        public LazyRow< PlaceName > PlaceNameStartZone { get; set; }
        public int IconCityState { get; set; }
        public int DataId { get; set; }
        public bool CanCancel { get; set; }
        public byte MaxDifficulty { get; set; }
        public float ExpFactor { get; set; }
        public uint ExpReward { get; set; }
        public uint GilReward { get; set; }
        public LazyRow< LeveRewardItem > LeveRewardItem { get; set; }
        public LazyRow< LeveVfx > LeveVfx { get; set; }
        public LazyRow< LeveVfx > LeveVfxFrame { get; set; }
        public LazyRow< Level > LevelLevemete { get; set; }
        public int IconIssuer { get; set; }
        public bool LockedLeve { get; set; }
        public LazyRow< Level > LevelStart { get; set; }
        public LazyRow< BGM > BGM { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            LeveClient = new LazyRow< LeveClient >( gameData, parser.ReadColumn< int >( 2 ), language );
            LeveAssignmentType = new LazyRow< LeveAssignmentType >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Town = new LazyRow< Town >( gameData, parser.ReadColumn< int >( 5 ), language );
            ClassJobLevel = parser.ReadColumn< ushort >( 6 );
            TimeLimit = parser.ReadColumn< byte >( 7 );
            AllowanceCost = parser.ReadColumn< byte >( 8 );
            Evaluation = parser.ReadColumn< int >( 9 );
            PlaceNameStart = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 10 ), language );
            PlaceNameIssued = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 11 ), language );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 13 ), language );
            JournalGenre = new LazyRow< JournalGenre >( gameData, parser.ReadColumn< int >( 14 ), language );
            Unknown15 = parser.ReadColumn< int >( 15 );
            PlaceNameStartZone = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 16 ), language );
            IconCityState = parser.ReadColumn< int >( 17 );
            DataId = parser.ReadColumn< int >( 18 );
            CanCancel = parser.ReadColumn< bool >( 19 );
            MaxDifficulty = parser.ReadColumn< byte >( 20 );
            ExpFactor = parser.ReadColumn< float >( 21 );
            ExpReward = parser.ReadColumn< uint >( 22 );
            GilReward = parser.ReadColumn< uint >( 23 );
            LeveRewardItem = new LazyRow< LeveRewardItem >( gameData, parser.ReadColumn< ushort >( 24 ), language );
            LeveVfx = new LazyRow< LeveVfx >( gameData, parser.ReadColumn< byte >( 25 ), language );
            LeveVfxFrame = new LazyRow< LeveVfx >( gameData, parser.ReadColumn< byte >( 26 ), language );
            LevelLevemete = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 27 ), language );
            IconIssuer = parser.ReadColumn< int >( 28 );
            LockedLeve = parser.ReadColumn< bool >( 29 );
            LevelStart = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 30 ), language );
            BGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 31 ), language );
        }
    }
}