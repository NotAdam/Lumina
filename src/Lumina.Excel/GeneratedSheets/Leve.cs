// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Leve", columnHash: 0xb1795a98 )]
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
        public ushort Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public LazyRow< JournalGenre > JournalGenre { get; set; }
        public int Unknown17 { get; set; }
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
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 15 ), language );
            JournalGenre = new LazyRow< JournalGenre >( gameData, parser.ReadColumn< uint >( 16 ), language );
            Unknown17 = parser.ReadColumn< int >( 17 );
            PlaceNameStartZone = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 18 ), language );
            IconCityState = parser.ReadColumn< int >( 19 );
            DataId = parser.ReadColumn< int >( 20 );
            CanCancel = parser.ReadColumn< bool >( 21 );
            MaxDifficulty = parser.ReadColumn< byte >( 22 );
            ExpFactor = parser.ReadColumn< float >( 23 );
            ExpReward = parser.ReadColumn< uint >( 24 );
            GilReward = parser.ReadColumn< uint >( 25 );
            LeveRewardItem = new LazyRow< LeveRewardItem >( gameData, parser.ReadColumn< ushort >( 26 ), language );
            LeveVfx = new LazyRow< LeveVfx >( gameData, parser.ReadColumn< byte >( 27 ), language );
            LeveVfxFrame = new LazyRow< LeveVfx >( gameData, parser.ReadColumn< byte >( 28 ), language );
            LevelLevemete = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 29 ), language );
            IconIssuer = parser.ReadColumn< int >( 30 );
            LockedLeve = parser.ReadColumn< bool >( 31 );
            LevelStart = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 32 ), language );
            BGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 33 ), language );
        }
    }
}