// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Action", columnHash: 0xfedb4d9a )]
    public partial class Action : ExcelRow
    {
        
        public SeString Name { get; set; }
        public bool Unknown1 { get; set; }
        public ushort Icon { get; set; }
        public LazyRow< ActionCategory > ActionCategory { get; set; }
        public byte Unknown4 { get; set; }
        public LazyRow< ActionCastTimeline > AnimationStart { get; set; }
        public LazyRow< ActionCastVFX > VFX { get; set; }
        public LazyRow< ActionTimeline > AnimationEnd { get; set; }
        public LazyRow< ActionTimeline > ActionTimelineHit { get; set; }
        public byte Unknown9 { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        public byte BehaviourType { get; set; }
        public byte ClassJobLevel { get; set; }
        public bool IsRoleAction { get; set; }
        public sbyte Range { get; set; }
        public bool CanTargetSelf { get; set; }
        public bool CanTargetParty { get; set; }
        public bool CanTargetFriendly { get; set; }
        public bool CanTargetHostile { get; set; }
        public bool Unknown19 { get; set; }
        public bool Unknown20 { get; set; }
        public bool TargetArea { get; set; }
        public bool Unknown22 { get; set; }
        public bool Unknown23 { get; set; }
        public sbyte Unknown24 { get; set; }
        public bool CanTargetDead { get; set; }
        public bool Unknown26 { get; set; }
        public byte CastType { get; set; }
        public byte EffectRange { get; set; }
        public byte XAxisModifier { get; set; }
        public bool Unknown30 { get; set; }
        public byte PrimaryCostType { get; set; }
        public ushort PrimaryCostValue { get; set; }
        public byte SecondaryCostType { get; set; }
        public ushort SecondaryCostValue { get; set; }
        public LazyRow< Action > ActionCombo { get; set; }
        public bool PreservesCombo { get; set; }
        public ushort Cast100ms { get; set; }
        public byte Unknown38 { get; set; }
        public ushort Recast100ms { get; set; }
        public byte CooldownGroup { get; set; }
        public byte AdditionalCooldownGroup { get; set; }
        public byte MaxCharges { get; set; }
        public LazyRow< AttackType > AttackType { get; set; }
        public byte Aspect { get; set; }
        public LazyRow< ActionProcStatus > ActionProcStatus { get; set; }
        public byte Unknown46 { get; set; }
        public LazyRow< Status > StatusGainSelf { get; set; }
        public uint UnlockLink { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public byte Unknown50 { get; set; }
        public bool Unknown51 { get; set; }
        public bool AffectsPosition { get; set; }
        public LazyRow< Omen > Omen { get; set; }
        public ushort Unknown54 { get; set; }
        public bool IsPvP { get; set; }
        public bool Unknown56 { get; set; }
        public bool Unknown57 { get; set; }
        public bool Unknown58 { get; set; }
        public bool Unknown59 { get; set; }
        public bool Unknown60 { get; set; }
        public bool Unknown61 { get; set; }
        public bool Unknown62 { get; set; }
        public bool Unknown63 { get; set; }
        public byte Unknown64 { get; set; }
        public bool Unknown65 { get; set; }
        public bool Unknown66 { get; set; }
        public bool IsPlayerAction { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            ActionCategory = new LazyRow< ActionCategory >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            AnimationStart = new LazyRow< ActionCastTimeline >( gameData, parser.ReadColumn< byte >( 5 ), language );
            VFX = new LazyRow< ActionCastVFX >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< short >( 7 ), language );
            ActionTimelineHit = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< sbyte >( 10 ), language );
            BehaviourType = parser.ReadColumn< byte >( 11 );
            ClassJobLevel = parser.ReadColumn< byte >( 12 );
            IsRoleAction = parser.ReadColumn< bool >( 13 );
            Range = parser.ReadColumn< sbyte >( 14 );
            CanTargetSelf = parser.ReadColumn< bool >( 15 );
            CanTargetParty = parser.ReadColumn< bool >( 16 );
            CanTargetFriendly = parser.ReadColumn< bool >( 17 );
            CanTargetHostile = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            TargetArea = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< bool >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            Unknown24 = parser.ReadColumn< sbyte >( 24 );
            CanTargetDead = parser.ReadColumn< bool >( 25 );
            Unknown26 = parser.ReadColumn< bool >( 26 );
            CastType = parser.ReadColumn< byte >( 27 );
            EffectRange = parser.ReadColumn< byte >( 28 );
            XAxisModifier = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            PrimaryCostType = parser.ReadColumn< byte >( 31 );
            PrimaryCostValue = parser.ReadColumn< ushort >( 32 );
            SecondaryCostType = parser.ReadColumn< byte >( 33 );
            SecondaryCostValue = parser.ReadColumn< ushort >( 34 );
            ActionCombo = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 35 ), language );
            PreservesCombo = parser.ReadColumn< bool >( 36 );
            Cast100ms = parser.ReadColumn< ushort >( 37 );
            Unknown38 = parser.ReadColumn< byte >( 38 );
            Recast100ms = parser.ReadColumn< ushort >( 39 );
            CooldownGroup = parser.ReadColumn< byte >( 40 );
            AdditionalCooldownGroup = parser.ReadColumn< byte >( 41 );
            MaxCharges = parser.ReadColumn< byte >( 42 );
            AttackType = new LazyRow< AttackType >( gameData, parser.ReadColumn< sbyte >( 43 ), language );
            Aspect = parser.ReadColumn< byte >( 44 );
            ActionProcStatus = new LazyRow< ActionProcStatus >( gameData, parser.ReadColumn< byte >( 45 ), language );
            Unknown46 = parser.ReadColumn< byte >( 46 );
            StatusGainSelf = new LazyRow< Status >( gameData, parser.ReadColumn< ushort >( 47 ), language );
            UnlockLink = parser.ReadColumn< uint >( 48 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 49 ), language );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            Unknown51 = parser.ReadColumn< bool >( 51 );
            AffectsPosition = parser.ReadColumn< bool >( 52 );
            Omen = new LazyRow< Omen >( gameData, parser.ReadColumn< ushort >( 53 ), language );
            Unknown54 = parser.ReadColumn< ushort >( 54 );
            IsPvP = parser.ReadColumn< bool >( 55 );
            Unknown56 = parser.ReadColumn< bool >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< bool >( 62 );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< bool >( 65 );
            Unknown66 = parser.ReadColumn< bool >( 66 );
            IsPlayerAction = parser.ReadColumn< bool >( 67 );
        }
    }
}