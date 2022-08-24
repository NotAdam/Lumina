// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJob", columnHash: 0x16808bcd )]
    public partial class ClassJob : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Abbreviation { get; set; }
        public SeString Unknown2 { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public sbyte ExpArrayIndex { get; set; }
        public sbyte BattleClassIndex { get; set; }
        public byte Unknown6 { get; set; }
        public byte JobIndex { get; set; }
        public sbyte DohDolJobIndex { get; set; }
        public ushort ModifierHitPoints { get; set; }
        public ushort ModifierManaPoints { get; set; }
        public ushort ModifierStrength { get; set; }
        public ushort ModifierVitality { get; set; }
        public ushort ModifierDexterity { get; set; }
        public ushort ModifierIntelligence { get; set; }
        public ushort ModifierMind { get; set; }
        public ushort ModifierPiety { get; set; }
        public ushort Unknown17 { get; set; }
        public ushort Unknown18 { get; set; }
        public ushort Unknown19 { get; set; }
        public ushort Unknown20 { get; set; }
        public ushort Unknown21 { get; set; }
        public ushort Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte PvPActionSortRow { get; set; }
        public byte Unknown25 { get; set; }
        public LazyRow< ClassJob > ClassJobParent { get; set; }
        public SeString NameEnglish { get; set; }
        public LazyRow< Item > ItemStartingWeapon { get; set; }
        public int Unknown29 { get; set; }
        public byte Role { get; set; }
        public LazyRow< Town > StartingTown { get; set; }
        public LazyRow< MonsterNote > MonsterNote { get; set; }
        public byte PrimaryStat { get; set; }
        public LazyRow< Action > LimitBreak1 { get; set; }
        public LazyRow< Action > LimitBreak2 { get; set; }
        public LazyRow< Action > LimitBreak3 { get; set; }
        public byte UIPriority { get; set; }
        public LazyRow< Item > ItemSoulCrystal { get; set; }
        public LazyRow< Quest > UnlockQuest { get; set; }
        public LazyRow< Quest > RelicQuest { get; set; }
        public LazyRow< Quest > Prerequisite { get; set; }
        public byte StartingLevel { get; set; }
        public byte PartyBonus { get; set; }
        public byte Unknown44 { get; set; }
        public bool IsLimitedJob { get; set; }
        public bool CanQueueForDuty { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Abbreviation = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 3 ), language );
            ExpArrayIndex = parser.ReadColumn< sbyte >( 4 );
            BattleClassIndex = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            JobIndex = parser.ReadColumn< byte >( 7 );
            DohDolJobIndex = parser.ReadColumn< sbyte >( 8 );
            ModifierHitPoints = parser.ReadColumn< ushort >( 9 );
            ModifierManaPoints = parser.ReadColumn< ushort >( 10 );
            ModifierStrength = parser.ReadColumn< ushort >( 11 );
            ModifierVitality = parser.ReadColumn< ushort >( 12 );
            ModifierDexterity = parser.ReadColumn< ushort >( 13 );
            ModifierIntelligence = parser.ReadColumn< ushort >( 14 );
            ModifierMind = parser.ReadColumn< ushort >( 15 );
            ModifierPiety = parser.ReadColumn< ushort >( 16 );
            Unknown17 = parser.ReadColumn< ushort >( 17 );
            Unknown18 = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            Unknown22 = parser.ReadColumn< ushort >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            PvPActionSortRow = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            ClassJobParent = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 26 ), language );
            NameEnglish = parser.ReadColumn< SeString >( 27 );
            ItemStartingWeapon = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 28 ), language );
            Unknown29 = parser.ReadColumn< int >( 29 );
            Role = parser.ReadColumn< byte >( 30 );
            StartingTown = new LazyRow< Town >( gameData, parser.ReadColumn< byte >( 31 ), language );
            MonsterNote = new LazyRow< MonsterNote >( gameData, parser.ReadColumn< sbyte >( 32 ), language );
            PrimaryStat = parser.ReadColumn< byte >( 33 );
            LimitBreak1 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 34 ), language );
            LimitBreak2 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 35 ), language );
            LimitBreak3 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 36 ), language );
            UIPriority = parser.ReadColumn< byte >( 37 );
            ItemSoulCrystal = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 38 ), language );
            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 39 ), language );
            RelicQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 40 ), language );
            Prerequisite = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 41 ), language );
            StartingLevel = parser.ReadColumn< byte >( 42 );
            PartyBonus = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            IsLimitedJob = parser.ReadColumn< bool >( 45 );
            CanQueueForDuty = parser.ReadColumn< bool >( 46 );
        }
    }
}