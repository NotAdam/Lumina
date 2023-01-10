// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRoulette", columnHash: 0xa675766e )]
    public partial class ContentRoulette : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Category { get; set; }
        public SeString Unknown2 { get; set; }
        public SeString Description { get; set; }
        public SeString DutyType { get; set; }
        public byte Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public bool IsGoldSaucer { get; set; }
        public bool IsInDutyFinder { get; set; }
        public LazyRow< ContentRouletteOpenRule > OpenRule { get; set; }
        public bool IsPvP { get; set; }
        public byte RequiredLevel { get; set; }
        public byte Unknown12 { get; set; }
        public ushort ItemLevelRequired { get; set; }
        public ushort Unknown14 { get; set; }
        public uint Icon { get; set; }
        public LazyRow< ContentRouletteRoleBonus > ContentRouletteRoleBonus { get; set; }
        public ushort RewardTomeA { get; set; }
        public ushort RewardTomeB { get; set; }
        public ushort RewardTomeC { get; set; }
        public uint Unknown20 { get; set; }
        public ushort Unknown21 { get; set; }
        public byte SortKey { get; set; }
        public byte Unknown23 { get; set; }
        public LazyRow< ContentMemberType > ContentMemberType { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public sbyte Unknown27 { get; set; }
        public bool Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public bool Unknown33 { get; set; }
        public bool Unknown34 { get; set; }
        public bool RequireAllDuties { get; set; }
        public bool Unknown36 { get; set; }
        public byte ContentRouletteOpenRule { get; set; }
        public LazyRow< InstanceContent > InstanceContent { get; set; }
        public bool Unknown39 { get; set; }
        public byte Unknown40 { get; set; }
        public bool Unknown41 { get; set; }
        public bool Unknown42 { get; set; }
        public byte Unknown43 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Category = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Description = parser.ReadColumn< SeString >( 3 );
            DutyType = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            IsGoldSaucer = parser.ReadColumn< bool >( 7 );
            IsInDutyFinder = parser.ReadColumn< bool >( 8 );
            OpenRule = new LazyRow< ContentRouletteOpenRule >( gameData, parser.ReadColumn< byte >( 9 ), language );
            IsPvP = parser.ReadColumn< bool >( 10 );
            RequiredLevel = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            ItemLevelRequired = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            Icon = parser.ReadColumn< uint >( 15 );
            ContentRouletteRoleBonus = new LazyRow< ContentRouletteRoleBonus >( gameData, parser.ReadColumn< byte >( 16 ), language );
            RewardTomeA = parser.ReadColumn< ushort >( 17 );
            RewardTomeB = parser.ReadColumn< ushort >( 18 );
            RewardTomeC = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            SortKey = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadColumn< byte >( 24 ), language );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< sbyte >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            Unknown34 = parser.ReadColumn< bool >( 34 );
            RequireAllDuties = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< bool >( 36 );
            ContentRouletteOpenRule = parser.ReadColumn< byte >( 37 );
            InstanceContent = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< ushort >( 38 ), language );
            Unknown39 = parser.ReadColumn< bool >( 39 );
            Unknown40 = parser.ReadColumn< byte >( 40 );
            Unknown41 = parser.ReadColumn< bool >( 41 );
            Unknown42 = parser.ReadColumn< bool >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
        }
    }
}