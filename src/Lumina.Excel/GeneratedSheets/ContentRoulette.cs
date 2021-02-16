// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRoulette", columnHash: 0xd8e2fea2 )]
    public class ContentRoulette : ExcelRow
    {
        
        public SeString Name;
        public SeString Category;
        public SeString Unknown2;
        public SeString Description;
        public SeString DutyType;
        public byte Unknown5;
        public uint Unknown6;
        public bool Unknown7;
        public bool IsInDutyFinder;
        public LazyRow< ContentRouletteOpenRule > OpenRule;
        public bool Unknown10;
        public byte RequiredLevel;
        public byte Unknown12;
        public ushort ItemLevelRequired;
        public ushort Unknown14;
        public uint Icon;
        public LazyRow< ContentRouletteRoleBonus > ContentRouletteRoleBonus;
        public ushort RewardTomeA;
        public ushort RewardTomeB;
        public ushort RewardTomeC;
        public uint Unknown20;
        public ushort Unknown21;
        public byte SortKey;
        public byte Unknown23;
        public LazyRow< ContentMemberType > ContentMemberType;
        public byte Unknown25;
        public byte Unknown26;
        public sbyte Unknown27;
        public byte Unknown28;
        public byte Unknown29;
        public byte Unknown30;
        public byte Unknown31;
        public bool Unknown32;
        public bool Unknown33;
        public bool RequireAllDuties;
        public bool Unknown35;
        public byte ContentRouletteOpenRule;
        public LazyRow< InstanceContent > InstanceContent;
        public bool Unknown38;
        public byte Unknown39;
        

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
            Unknown7 = parser.ReadColumn< bool >( 7 );
            IsInDutyFinder = parser.ReadColumn< bool >( 8 );
            OpenRule = new LazyRow< ContentRouletteOpenRule >( gameData, parser.ReadColumn< byte >( 9 ), language );
            Unknown10 = parser.ReadColumn< bool >( 10 );
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
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            RequireAllDuties = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            ContentRouletteOpenRule = parser.ReadColumn< byte >( 36 );
            InstanceContent = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< ushort >( 37 ), language );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            Unknown39 = parser.ReadColumn< byte >( 39 );
        }
    }
}