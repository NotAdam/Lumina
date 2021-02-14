// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Leve", columnHash: 0x745e3c08 )]
    public class Leve : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public LazyRow< LeveClient > LeveClient;
        public LazyRow< LeveAssignmentType > LeveAssignmentType;
        public LazyRow< Town > Town;
        public int Unknown5;
        public ushort ClassJobLevel;
        public byte TimeLimit;
        public byte AllowanceCost;
        public int Evaluation;
        public LazyRow< PlaceName > PlaceNameStart;
        public LazyRow< PlaceName > PlaceNameIssued;
        public bool Unknown12;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public LazyRow< JournalGenre > JournalGenre;
        public int Unknown15;
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
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            LeveClient = new LazyRow< LeveClient >( lumina, parser.ReadColumn< int >( 2 ), language );
            LeveAssignmentType = new LazyRow< LeveAssignmentType >( lumina, parser.ReadColumn< byte >( 3 ), language );
            Town = new LazyRow< Town >( lumina, parser.ReadColumn< int >( 4 ), language );
            Unknown5 = parser.ReadColumn< int >( 5 );
            ClassJobLevel = parser.ReadColumn< ushort >( 6 );
            TimeLimit = parser.ReadColumn< byte >( 7 );
            AllowanceCost = parser.ReadColumn< byte >( 8 );
            Evaluation = parser.ReadColumn< int >( 9 );
            PlaceNameStart = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 10 ), language );
            PlaceNameIssued = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 11 ), language );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 13 ), language );
            JournalGenre = new LazyRow< JournalGenre >( lumina, parser.ReadColumn< int >( 14 ), language );
            Unknown15 = parser.ReadColumn< int >( 15 );
            PlaceNameStartZone = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 16 ), language );
            IconCityState = parser.ReadColumn< int >( 17 );
            DataId = parser.ReadColumn< int >( 18 );
            CanCancel = parser.ReadColumn< bool >( 19 );
            MaxDifficulty = parser.ReadColumn< byte >( 20 );
            ExpFactor = parser.ReadColumn< float >( 21 );
            ExpReward = parser.ReadColumn< uint >( 22 );
            GilReward = parser.ReadColumn< uint >( 23 );
            LeveRewardItem = new LazyRow< LeveRewardItem >( lumina, parser.ReadColumn< ushort >( 24 ), language );
            LeveVfx = new LazyRow< LeveVfx >( lumina, parser.ReadColumn< byte >( 25 ), language );
            LeveVfxFrame = new LazyRow< LeveVfx >( lumina, parser.ReadColumn< byte >( 26 ), language );
            LevelLevemete = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 27 ), language );
            IconIssuer = parser.ReadColumn< int >( 28 );
            LockedLeve = parser.ReadColumn< bool >( 29 );
            LevelStart = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 30 ), language );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 31 ), language );
        }
    }
}