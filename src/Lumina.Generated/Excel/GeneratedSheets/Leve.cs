using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Leve", columnHash: 0x7e5dafa0 )]
    public class Leve : IExcelRow
    {
        
        public string Name;
        public string Description;
        public LazyRow< LeveClient > LeveClient;
        public LazyRow< LeveAssignmentType > LeveAssignmentType;
        public LazyRow< Town > Town;
        public ushort ClassJobLevel;
        public byte TimeLimit;
        public byte AllowanceCost;
        public int Evaluation;
        public LazyRow< PlaceName > PlaceNameStart;
        public LazyRow< PlaceName > PlaceNameIssued;
        public bool Unknown11;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public LazyRow< JournalGenre > JournalGenre;
        public int Unknown14;
        public LazyRow< PlaceName > PlaceNameStartZone;
        public int IconCityState;
        public int DataId;
        public bool CanCancel;
        public byte MaxDifficulty;
        public float ExpFactor;
        public uint ExpReward;
        public uint GilReward;
        public LazyRow< LeveRewardItem > LeveRewardItem;
        public LazyRow< LeveVfx > LeveVfx;
        public LazyRow< LeveVfx > LeveVfxFrame;
        public LazyRow< Level > LevelLevemete;
        public int IconIssuer;
        public bool LockedLeve;
        public LazyRow< Level > LevelStart;
        public LazyRow< BGM > BGM;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            LeveClient = new LazyRow< LeveClient >( lumina, parser.ReadColumn< int >( 2 ), language );
            LeveAssignmentType = new LazyRow< LeveAssignmentType >( lumina, parser.ReadColumn< int >( 3 ), language );
            Town = new LazyRow< Town >( lumina, parser.ReadColumn< int >( 4 ), language );
            ClassJobLevel = parser.ReadColumn< ushort >( 5 );
            TimeLimit = parser.ReadColumn< byte >( 6 );
            AllowanceCost = parser.ReadColumn< byte >( 7 );
            Evaluation = parser.ReadColumn< int >( 8 );
            PlaceNameStart = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 9 ), language );
            PlaceNameIssued = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 10 ), language );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 12 ), language );
            JournalGenre = new LazyRow< JournalGenre >( lumina, parser.ReadColumn< int >( 13 ), language );
            Unknown14 = parser.ReadColumn< int >( 14 );
            PlaceNameStartZone = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 15 ), language );
            IconCityState = parser.ReadColumn< int >( 16 );
            DataId = parser.ReadColumn< int >( 17 );
            CanCancel = parser.ReadColumn< bool >( 18 );
            MaxDifficulty = parser.ReadColumn< byte >( 19 );
            ExpFactor = parser.ReadColumn< float >( 20 );
            ExpReward = parser.ReadColumn< uint >( 21 );
            GilReward = parser.ReadColumn< uint >( 22 );
            LeveRewardItem = new LazyRow< LeveRewardItem >( lumina, parser.ReadColumn< ushort >( 23 ), language );
            LeveVfx = new LazyRow< LeveVfx >( lumina, parser.ReadColumn< byte >( 24 ), language );
            LeveVfxFrame = new LazyRow< LeveVfx >( lumina, parser.ReadColumn< byte >( 25 ), language );
            LevelLevemete = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 26 ), language );
            IconIssuer = parser.ReadColumn< int >( 27 );
            LockedLeve = parser.ReadColumn< bool >( 28 );
            LevelStart = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 29 ), language );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 30 ), language );
        }
    }
}