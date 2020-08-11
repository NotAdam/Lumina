// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Action", columnHash: 0xb3773db1 )]
    public class Action : IExcelRow
    {
        
        public string Name;
        public bool Unknown1;
        public ushort Icon;
        public LazyRow< ActionCategory > ActionCategory;
        public byte Unknown4;
        public LazyRow< ActionCastTimeline > AnimationStart;
        public LazyRow< ActionCastVFX > VFX;
        public LazyRow< ActionTimeline > AnimationEnd;
        public LazyRow< ActionTimeline > ActionTimelineHit;
        public byte Unknown9;
        public LazyRow< ClassJob > ClassJob;
        public byte BehaviourType;
        public byte ClassJobLevel;
        public bool IsRoleAction;
        public sbyte Range;
        public bool CanTargetSelf;
        public bool CanTargetParty;
        public bool CanTargetFriendly;
        public bool CanTargetHostile;
        public bool Unknown19;
        public bool Unknown20;
        public bool TargetArea;
        public bool Unknown22;
        public bool Unknown23;
        public sbyte Unknown24;
        public bool CanTargetDead;
        public bool Unknown26;
        public byte CastType;
        public byte EffectRange;
        public byte XAxisModifier;
        public bool Unknown30;
        public byte PrimaryCostType;
        public ushort PrimaryCostValue;
        public byte SecondaryCostType;
        public ushort SecondaryCostValue;
        public LazyRow< Action > ActionCombo;
        public bool PreservesCombo;
        public ushort Cast100ms;
        public ushort Recast100ms;
        public byte CooldownGroup;
        public byte Unknown40;
        public byte MaxCharges;
        public LazyRow< AttackType > AttackType;
        public byte Aspect;
        public LazyRow< ActionProcStatus > ActionProcStatus;
        public byte Unknown45;
        public LazyRow< Status > StatusGainSelf;
        public uint UnlockLink;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public byte Unknown49;
        public bool Unknown50;
        public bool AffectsPosition;
        public LazyRow< Omen > Omen;
        public bool IsPvP;
        public bool Unknown54;
        public bool Unknown55;
        public bool Unknown56;
        public bool Unknown57;
        public bool Unknown58;
        public bool Unknown59;
        public bool Unknown60;
        public bool Unknown61;
        public byte Unknown62;
        public bool Unknown63;
        public bool Unknown64;
        public bool IsPlayerAction;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            ActionCategory = new LazyRow< ActionCategory >( lumina, parser.ReadColumn< byte >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            AnimationStart = new LazyRow< ActionCastTimeline >( lumina, parser.ReadColumn< byte >( 5 ), language );
            VFX = new LazyRow< ActionCastVFX >( lumina, parser.ReadColumn< byte >( 6 ), language );
            AnimationEnd = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< short >( 7 ), language );
            ActionTimelineHit = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< sbyte >( 10 ), language );
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
            ActionCombo = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 35 ), language );
            PreservesCombo = parser.ReadColumn< bool >( 36 );
            Cast100ms = parser.ReadColumn< ushort >( 37 );
            Recast100ms = parser.ReadColumn< ushort >( 38 );
            CooldownGroup = parser.ReadColumn< byte >( 39 );
            Unknown40 = parser.ReadColumn< byte >( 40 );
            MaxCharges = parser.ReadColumn< byte >( 41 );
            AttackType = new LazyRow< AttackType >( lumina, parser.ReadColumn< sbyte >( 42 ), language );
            Aspect = parser.ReadColumn< byte >( 43 );
            ActionProcStatus = new LazyRow< ActionProcStatus >( lumina, parser.ReadColumn< byte >( 44 ), language );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            StatusGainSelf = new LazyRow< Status >( lumina, parser.ReadColumn< ushort >( 46 ), language );
            UnlockLink = parser.ReadColumn< uint >( 47 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 48 ), language );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< bool >( 50 );
            AffectsPosition = parser.ReadColumn< bool >( 51 );
            Omen = new LazyRow< Omen >( lumina, parser.ReadColumn< ushort >( 52 ), language );
            IsPvP = parser.ReadColumn< bool >( 53 );
            Unknown54 = parser.ReadColumn< bool >( 54 );
            Unknown55 = parser.ReadColumn< bool >( 55 );
            Unknown56 = parser.ReadColumn< bool >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< bool >( 64 );
            IsPlayerAction = parser.ReadColumn< bool >( 65 );
        }
    }
}