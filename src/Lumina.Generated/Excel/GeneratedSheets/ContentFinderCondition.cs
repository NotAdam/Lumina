// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderCondition", columnHash: 0x2b65936c )]
    public class ContentFinderCondition : IExcelRow
    {
        
        public string ShortCode;
        public LazyRow< TerritoryType > TerritoryType;
        public byte ContentLinkType;
        public ushort Content;
        public bool PvP;
        public byte Unknown5;
        public uint Unknown6;
        public uint Unknown7;
        public LazyRow< ClassJobCategory > AcceptClassJobCategory;
        public LazyRow< ContentMemberType > ContentMemberType;
        public byte Unknown10;
        public byte Unknown11;
        public byte Unknown12;
        public LazyRow< Quest > UnlockQuest;
        public ushort Unknown14;
        public byte ClassJobLevelRequired;
        public byte ClassJobLevelSync;
        public ushort ItemLevelRequired;
        public ushort ItemLevelSync;
        public bool AddedIn53;
        public bool AllowUndersized;
        public bool AllowReplacement;
        public bool Unknown22;
        public bool Unknown23;
        public bool Unknown24;
        public byte Unknown25;
        public bool Unknown26;
        public bool HighEndDuty;
        public bool Unknown28;
        public bool Unknown29;
        public bool Unknown30;
        public bool DutyRecorderAllowed;
        public bool Unknown32;
        public bool Unknown33;
        public bool Unknown34;
        public bool Unknown35;
        public string Name;
        public LazyRow< ContentType > ContentType;
        public byte TransientKey;
        public uint Transient;
        public ushort SortKey;
        public uint Image;
        public uint Icon;
        public sbyte Unknown43;
        public bool LevelingRoulette;
        public bool Level5060Roulette;
        public bool MSQRoulette;
        public bool GuildHestRoulette;
        public bool ExpertRoulette;
        public bool TrialRoulette;
        public bool DailyFrontlineChallenge;
        public bool Level70Roulette;
        public bool MentorRoulette;
        public bool Unknown53;
        public bool Unknown54;
        public bool Unknown55;
        public bool Unknown56;
        public bool Unknown57;
        public bool AllianceRoulette;
        public bool Unknown59;
        public bool NormalRaidRoulette;
        public bool Unknown61;
        public bool Unknown62;
        public bool Unknown63;
        public bool Unknown64;
        public bool Unknown65;
        public bool Unknown66;
        public bool Unknown67;
        public bool Unknown68;
        public bool Unknown69;
        public bool Unknown70;
        public bool Unknown71;
        public bool Unknown72;
        public bool Unknown73;
        public bool Unknown74;
        public bool Unknown75;
        public bool Unknown76;
        public bool Unknown77;
        public bool Unknown78;
        public bool Unknown79;
        public bool Unknown80;
        public bool Unknown81;
        public bool Unknown82;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ShortCode = parser.ReadColumn< string >( 0 );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            ContentLinkType = parser.ReadColumn< byte >( 2 );
            Content = parser.ReadColumn< ushort >( 3 );
            PvP = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            AcceptClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 8 ), language );
            ContentMemberType = new LazyRow< ContentMemberType >( lumina, parser.ReadColumn< byte >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            UnlockQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 13 ), language );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            ClassJobLevelRequired = parser.ReadColumn< byte >( 15 );
            ClassJobLevelSync = parser.ReadColumn< byte >( 16 );
            ItemLevelRequired = parser.ReadColumn< ushort >( 17 );
            ItemLevelSync = parser.ReadColumn< ushort >( 18 );
            AddedIn53 = parser.ReadColumn< bool >( 19 );
            AllowUndersized = parser.ReadColumn< bool >( 20 );
            AllowReplacement = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< bool >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< bool >( 26 );
            HighEndDuty = parser.ReadColumn< bool >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            DutyRecorderAllowed = parser.ReadColumn< bool >( 31 );
            Unknown32 = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Name = parser.ReadColumn< string >( 36 );
            ContentType = new LazyRow< ContentType >( lumina, parser.ReadColumn< byte >( 37 ), language );
            TransientKey = parser.ReadColumn< byte >( 38 );
            Transient = parser.ReadColumn< uint >( 39 );
            SortKey = parser.ReadColumn< ushort >( 40 );
            Image = parser.ReadColumn< uint >( 41 );
            Icon = parser.ReadColumn< uint >( 42 );
            Unknown43 = parser.ReadColumn< sbyte >( 43 );
            LevelingRoulette = parser.ReadColumn< bool >( 44 );
            Level5060Roulette = parser.ReadColumn< bool >( 45 );
            MSQRoulette = parser.ReadColumn< bool >( 46 );
            GuildHestRoulette = parser.ReadColumn< bool >( 47 );
            ExpertRoulette = parser.ReadColumn< bool >( 48 );
            TrialRoulette = parser.ReadColumn< bool >( 49 );
            DailyFrontlineChallenge = parser.ReadColumn< bool >( 50 );
            Level70Roulette = parser.ReadColumn< bool >( 51 );
            MentorRoulette = parser.ReadColumn< bool >( 52 );
            Unknown53 = parser.ReadColumn< bool >( 53 );
            Unknown54 = parser.ReadColumn< bool >( 54 );
            Unknown55 = parser.ReadColumn< bool >( 55 );
            Unknown56 = parser.ReadColumn< bool >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            AllianceRoulette = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            NormalRaidRoulette = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< bool >( 62 );
            Unknown63 = parser.ReadColumn< bool >( 63 );
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
        }
    }
}