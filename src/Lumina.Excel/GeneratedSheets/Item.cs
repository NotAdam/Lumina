// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Item", columnHash: 0x800968c9 )]
    public partial class Item : ExcelRow
    {
        public class ItemUnkData59Obj
        {
            public byte BaseParam { get; set; }
            public short BaseParamValue { get; set; }
        }
        public class ItemUnkData73Obj
        {
            public byte BaseParamSpecial { get; set; }
            public short BaseParamValueSpecial { get; set; }
        }
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public SeString Description { get; set; }
        public SeString Name { get; set; }
        public ushort Icon { get; set; }
        public LazyRow< ItemLevel > LevelItem { get; set; }
        public byte Rarity { get; set; }
        public byte FilterGroup { get; set; }
        public uint AdditionalData { get; set; }
        public LazyRow< ItemUICategory > ItemUICategory { get; set; }
        public LazyRow< ItemSearchCategory > ItemSearchCategory { get; set; }
        public LazyRow< EquipSlotCategory > EquipSlotCategory { get; set; }
        public LazyRow< ItemSortCategory > ItemSortCategory { get; set; }
        public ushort Unknown19 { get; set; }
        public uint StackSize { get; set; }
        public bool IsUnique { get; set; }
        public bool IsUntradable { get; set; }
        public bool IsIndisposable { get; set; }
        public bool Lot { get; set; }
        public uint PriceMid { get; set; }
        public uint PriceLow { get; set; }
        public bool CanBeHq { get; set; }
        public bool IsDyeable { get; set; }
        public bool IsCrestWorthy { get; set; }
        public LazyRow< ItemAction > ItemAction { get; set; }
        public byte CastTimes { get; set; }
        public ushort Cooldowns { get; set; }
        public LazyRow< ClassJob > ClassJobRepair { get; set; }
        public LazyRow< ItemRepairResource > ItemRepair { get; set; }
        public LazyRow< Item > ItemGlamour { get; set; }
        public ushort Desynth { get; set; }
        public bool IsCollectable { get; set; }
        public bool AlwaysCollectable { get; set; }
        public ushort AetherialReduce { get; set; }
        public byte LevelEquip { get; set; }
        public byte Unknown41 { get; set; }
        public byte EquipRestriction { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public LazyRow< GrandCompany > GrandCompany { get; set; }
        public LazyRow< ItemSeries > ItemSeries { get; set; }
        public byte BaseParamModifier { get; set; }
        public ulong ModelMain { get; set; }
        public ulong ModelSub { get; set; }
        public LazyRow< ClassJob > ClassJobUse { get; set; }
        public byte Unknown50 { get; set; }
        public ushort DamagePhys { get; set; }
        public ushort DamageMag { get; set; }
        public ushort Delayms { get; set; }
        public byte Unknown54 { get; set; }
        public ushort BlockRate { get; set; }
        public ushort Block { get; set; }
        public ushort DefensePhys { get; set; }
        public ushort DefenseMag { get; set; }
        public ItemUnkData59Obj[] UnkData59 { get; set; }
        public LazyRow< ItemSpecialBonus > ItemSpecialBonus { get; set; }
        public byte ItemSpecialBonusParam { get; set; }
        public ItemUnkData73Obj[] UnkData73 { get; set; }
        public byte MaterializeType { get; set; }
        public byte MateriaSlotCount { get; set; }
        public bool IsAdvancedMeldingPermitted { get; set; }
        public bool IsPvP { get; set; }
        public byte SubStatCategory { get; set; }
        public bool IsGlamourous { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            Description = parser.ReadColumn< SeString >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
            Icon = parser.ReadColumn< ushort >( 10 );
            LevelItem = new LazyRow< ItemLevel >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            Rarity = parser.ReadColumn< byte >( 12 );
            FilterGroup = parser.ReadColumn< byte >( 13 );
            AdditionalData = parser.ReadColumn< uint >( 14 );
            ItemUICategory = new LazyRow< ItemUICategory >( gameData, parser.ReadColumn< byte >( 15 ), language );
            ItemSearchCategory = new LazyRow< ItemSearchCategory >( gameData, parser.ReadColumn< byte >( 16 ), language );
            EquipSlotCategory = new LazyRow< EquipSlotCategory >( gameData, parser.ReadColumn< byte >( 17 ), language );
            ItemSortCategory = new LazyRow< ItemSortCategory >( gameData, parser.ReadColumn< byte >( 18 ), language );
            Unknown19 = parser.ReadColumn< ushort >( 19 );
            StackSize = parser.ReadColumn< uint >( 20 );
            IsUnique = parser.ReadColumn< bool >( 21 );
            IsUntradable = parser.ReadColumn< bool >( 22 );
            IsIndisposable = parser.ReadColumn< bool >( 23 );
            Lot = parser.ReadColumn< bool >( 24 );
            PriceMid = parser.ReadColumn< uint >( 25 );
            PriceLow = parser.ReadColumn< uint >( 26 );
            CanBeHq = parser.ReadColumn< bool >( 27 );
            IsDyeable = parser.ReadColumn< bool >( 28 );
            IsCrestWorthy = parser.ReadColumn< bool >( 29 );
            ItemAction = new LazyRow< ItemAction >( gameData, parser.ReadColumn< ushort >( 30 ), language );
            CastTimes = parser.ReadColumn< byte >( 31 );
            Cooldowns = parser.ReadColumn< ushort >( 32 );
            ClassJobRepair = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 33 ), language );
            ItemRepair = new LazyRow< ItemRepairResource >( gameData, parser.ReadColumn< int >( 34 ), language );
            ItemGlamour = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 35 ), language );
            Desynth = parser.ReadColumn< ushort >( 36 );
            IsCollectable = parser.ReadColumn< bool >( 37 );
            AlwaysCollectable = parser.ReadColumn< bool >( 38 );
            AetherialReduce = parser.ReadColumn< ushort >( 39 );
            LevelEquip = parser.ReadColumn< byte >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            EquipRestriction = parser.ReadColumn< byte >( 42 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 43 ), language );
            GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadColumn< byte >( 44 ), language );
            ItemSeries = new LazyRow< ItemSeries >( gameData, parser.ReadColumn< byte >( 45 ), language );
            BaseParamModifier = parser.ReadColumn< byte >( 46 );
            ModelMain = parser.ReadColumn< ulong >( 47 );
            ModelSub = parser.ReadColumn< ulong >( 48 );
            ClassJobUse = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 49 ), language );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            DamagePhys = parser.ReadColumn< ushort >( 51 );
            DamageMag = parser.ReadColumn< ushort >( 52 );
            Delayms = parser.ReadColumn< ushort >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            BlockRate = parser.ReadColumn< ushort >( 55 );
            Block = parser.ReadColumn< ushort >( 56 );
            DefensePhys = parser.ReadColumn< ushort >( 57 );
            DefenseMag = parser.ReadColumn< ushort >( 58 );
            UnkData59 = new ItemUnkData59Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData59[ i ] = new ItemUnkData59Obj();
                UnkData59[ i ].BaseParam = parser.ReadColumn< byte >( 59 + ( i * 2 + 0 ) );
                UnkData59[ i ].BaseParamValue = parser.ReadColumn< short >( 59 + ( i * 2 + 1 ) );
            }
            ItemSpecialBonus = new LazyRow< ItemSpecialBonus >( gameData, parser.ReadColumn< byte >( 71 ), language );
            ItemSpecialBonusParam = parser.ReadColumn< byte >( 72 );
            UnkData73 = new ItemUnkData73Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData73[ i ] = new ItemUnkData73Obj();
                UnkData73[ i ].BaseParamSpecial = parser.ReadColumn< byte >( 73 + ( i * 2 + 0 ) );
                UnkData73[ i ].BaseParamValueSpecial = parser.ReadColumn< short >( 73 + ( i * 2 + 1 ) );
            }
            MaterializeType = parser.ReadColumn< byte >( 85 );
            MateriaSlotCount = parser.ReadColumn< byte >( 86 );
            IsAdvancedMeldingPermitted = parser.ReadColumn< bool >( 87 );
            IsPvP = parser.ReadColumn< bool >( 88 );
            SubStatCategory = parser.ReadColumn< byte >( 89 );
            IsGlamourous = parser.ReadColumn< bool >( 90 );
        }
    }
}