using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRoulette", columnHash: 0x8dd999fc )]
    public class ContentRoulette : IExcelRow
    {
        
        public string Name;
        public string Unknown1;
        public string Description;
        public string DutyType;
        public byte Unknown4;
        public uint Unknown5;
        public bool IsInDutyFinder;
        public LazyRow< ContentRouletteOpenRule > OpenRule;
        public byte Unknown8;
        public bool RequiredLevel;
        public byte Unknown10;
        public byte ItemLevelRequired;
        public ushort Unknown12;
        public ushort Icon;
        public LazyRow< ContentRouletteRoleBonus > ContentRouletteRoleBonus;
        public byte RewardTomeA;
        public ushort RewardTomeB;
        public ushort RewardTomeC;
        public ushort Unknown18;
        public uint Unknown19;
        public ushort SortKey;
        public byte Unknown21;
        public LazyRow< ContentMemberType > ContentMemberType;
        public byte Unknown23;
        public byte Unknown24;
        public byte Unknown25;
        public sbyte Unknown26;
        public byte Unknown27;
        public byte Unknown28;
        public byte Unknown29;
        public byte Unknown30;
        public bool Unknown31;
        public bool RequireAllDuties;
        public bool Unknown33;
        public bool ContentRouletteOpenRule;
        public LazyRow< InstanceContent > InstanceContent;
        public ushort Unknown36;
        public bool Unknown37;
        public byte Unknown38;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< string >( 1 );
            Description = parser.ReadColumn< string >( 2 );
            DutyType = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            IsInDutyFinder = parser.ReadColumn< bool >( 6 );
            #warning generator error: the definition for this field (OpenRule) has an invalid type for a LazyRow
            Unknown8 = parser.ReadColumn< byte >( 8 );
            RequiredLevel = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            ItemLevelRequired = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Icon = parser.ReadColumn< ushort >( 13 );
            ContentRouletteRoleBonus = new LazyRow< ContentRouletteRoleBonus >( lumina, parser.ReadColumn< uint >( 14 ) );
            RewardTomeA = parser.ReadColumn< byte >( 15 );
            RewardTomeB = parser.ReadColumn< ushort >( 16 );
            RewardTomeC = parser.ReadColumn< ushort >( 17 );
            Unknown18 = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            SortKey = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            ContentMemberType = new LazyRow< ContentMemberType >( lumina, parser.ReadColumn< byte >( 22 ) );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< sbyte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< bool >( 31 );
            RequireAllDuties = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            ContentRouletteOpenRule = parser.ReadColumn< bool >( 34 );
            InstanceContent = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< byte >( 35 ) );
            Unknown36 = parser.ReadColumn< ushort >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
            Unknown38 = parser.ReadColumn< byte >( 38 );
        }
    }
}