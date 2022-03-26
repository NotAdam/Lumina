// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderCondition", columnHash: 0xf911a41e )]
    public class ContentFinderCondition : ExcelRow
    {
        
        public SeString ShortCode { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public byte ContentLinkType { get; set; }
        public ushort Content { get; set; }
        public bool PvP { get; set; }
        public byte Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; set; }
        public LazyRow< ContentMemberType > ContentMemberType { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public LazyRow< Quest > UnlockQuest { get; set; }
        public ushort Unknown14 { get; set; }
        public byte ClassJobLevelRequired { get; set; }
        public byte ClassJobLevelSync { get; set; }
        public ushort ItemLevelRequired { get; set; }
        public ushort ItemLevelSync { get; set; }
        public bool Unknown19 { get; set; }
        public bool AllowUndersized { get; set; }
        public bool AllowReplacement { get; set; }
        public bool Unknown22 { get; set; }
        public bool AllowExplorerMode { get; set; }
        public bool Unknown24 { get; set; }
        public bool Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public bool Unknown27 { get; set; }
        public bool HighEndDuty { get; set; }
        public bool Unknown29 { get; set; }
        public bool Unknown30 { get; set; }
        public bool Unknown31 { get; set; }
        public bool DutyRecorderAllowed { get; set; }
        public bool Unknown33 { get; set; }
        public bool Unknown34 { get; set; }
        public bool Unknown35 { get; set; }
        public bool Unknown36 { get; set; }
        public SeString Name { get; set; }
        public SeString NameShort { get; set; }
        public LazyRow< ContentType > ContentType { get; set; }
        public byte TransientKey { get; set; }
        public uint Transient { get; set; }
        public ushort SortKey { get; set; }
        public uint Image { get; set; }
        public uint Icon { get; set; }
        public sbyte Unknown45 { get; set; }
        public bool LevelingRoulette { get; set; }
        public bool Unknown47 { get; set; }
        public bool Level506070Roulette { get; set; }
        public bool MSQRoulette { get; set; }
        public bool GuildHestRoulette { get; set; }
        public bool ExpertRoulette { get; set; }
        public bool TrialRoulette { get; set; }
        public bool DailyFrontlineChallenge { get; set; }
        public bool Level80Roulette { get; set; }
        public bool MentorRoulette { get; set; }
        public bool Unknown56 { get; set; }
        public bool Unknown57 { get; set; }
        public bool Unknown58 { get; set; }
        public bool Unknown59 { get; set; }
        public bool Unknown60 { get; set; }
        public bool AllianceRoulette { get; set; }
        public bool Unknown62 { get; set; }
        public bool NormalRaidRoulette { get; set; }
        public bool Unknown64 { get; set; }
        public bool Unknown65 { get; set; }
        public bool Unknown66 { get; set; }
        public bool Unknown67 { get; set; }
        public bool Unknown68 { get; set; }
        public bool Unknown69 { get; set; }
        public bool Unknown70 { get; set; }
        public bool Unknown71 { get; set; }
        public bool Unknown72 { get; set; }
        public bool Unknown73 { get; set; }
        public bool Unknown74 { get; set; }
        public bool Unknown75 { get; set; }
        public bool Unknown76 { get; set; }
        public bool Unknown77 { get; set; }
        public bool Unknown78 { get; set; }
        public bool Unknown79 { get; set; }
        public bool Unknown80 { get; set; }
        public bool Unknown81 { get; set; }
        public bool Unknown82 { get; set; }
        public bool Unknown83 { get; set; }
        public bool Unknown84 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ShortCode = parser.ReadColumn< SeString >( 0 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            ContentLinkType = parser.ReadColumn< byte >( 2 );
            Content = parser.ReadColumn< ushort >( 3 );
            PvP = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 8 ), language );
            ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadColumn< byte >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 13 ), language );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            ClassJobLevelRequired = parser.ReadColumn< byte >( 15 );
            ClassJobLevelSync = parser.ReadColumn< byte >( 16 );
            ItemLevelRequired = parser.ReadColumn< ushort >( 17 );
            ItemLevelSync = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            AllowUndersized = parser.ReadColumn< bool >( 20 );
            AllowReplacement = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< bool >( 22 );
            AllowExplorerMode = parser.ReadColumn< bool >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< bool >( 27 );
            HighEndDuty = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            Unknown31 = parser.ReadColumn< bool >( 31 );
            DutyRecorderAllowed = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< bool >( 36 );
            Name = parser.ReadColumn< SeString >( 37 );
            NameShort = parser.ReadColumn< SeString >( 38 );
            ContentType = new LazyRow< ContentType >( gameData, parser.ReadColumn< byte >( 39 ), language );
            TransientKey = parser.ReadColumn< byte >( 40 );
            Transient = parser.ReadColumn< uint >( 41 );
            SortKey = parser.ReadColumn< ushort >( 42 );
            Image = parser.ReadColumn< uint >( 43 );
            Icon = parser.ReadColumn< uint >( 44 );
            Unknown45 = parser.ReadColumn< sbyte >( 45 );
            LevelingRoulette = parser.ReadColumn< bool >( 46 );
            Unknown47 = parser.ReadColumn< bool >( 47 );
            Level506070Roulette = parser.ReadColumn< bool >( 48 );
            MSQRoulette = parser.ReadColumn< bool >( 49 );
            GuildHestRoulette = parser.ReadColumn< bool >( 50 );
            ExpertRoulette = parser.ReadColumn< bool >( 51 );
            TrialRoulette = parser.ReadColumn< bool >( 52 );
            DailyFrontlineChallenge = parser.ReadColumn< bool >( 53 );
            Level80Roulette = parser.ReadColumn< bool >( 54 );
            MentorRoulette = parser.ReadColumn< bool >( 55 );
            Unknown56 = parser.ReadColumn< bool >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            AllianceRoulette = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< bool >( 62 );
            NormalRaidRoulette = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< bool >( 64 );
            Unknown65 = parser.ReadColumn< bool >( 65 );
            Unknown66 = parser.ReadColumn< bool >( 66 );
            Unknown67 = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
            Unknown70 = parser.ReadColumn< bool >( 70 );
            Unknown71 = parser.ReadColumn< bool >( 71 );
            Unknown72 = parser.ReadColumn< bool >( 72 );
            Unknown73 = parser.ReadColumn< bool >( 73 );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            Unknown75 = parser.ReadColumn< bool >( 75 );
            Unknown76 = parser.ReadColumn< bool >( 76 );
            Unknown77 = parser.ReadColumn< bool >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
            Unknown79 = parser.ReadColumn< bool >( 79 );
            Unknown80 = parser.ReadColumn< bool >( 80 );
            Unknown81 = parser.ReadColumn< bool >( 81 );
            Unknown82 = parser.ReadColumn< bool >( 82 );
            Unknown83 = parser.ReadColumn< bool >( 83 );
            Unknown84 = parser.ReadColumn< bool >( 84 );
        }
    }
}