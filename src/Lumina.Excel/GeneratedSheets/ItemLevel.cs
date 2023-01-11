// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemLevel", columnHash: 0xe216399f )]
    public partial class ItemLevel : ExcelRow
    {
        
        public ushort Strength { get; set; }
        public ushort Dexterity { get; set; }
        public ushort Vitality { get; set; }
        public ushort Intelligence { get; set; }
        public ushort Mind { get; set; }
        public ushort Piety { get; set; }
        public ushort HP { get; set; }
        public ushort MP { get; set; }
        public ushort TP { get; set; }
        public ushort GP { get; set; }
        public ushort CP { get; set; }
        public ushort PhysicalDamage { get; set; }
        public ushort MagicalDamage { get; set; }
        public ushort Delay { get; set; }
        public ushort AdditionalEffect { get; set; }
        public ushort AttackSpeed { get; set; }
        public ushort BlockRate { get; set; }
        public ushort BlockStrength { get; set; }
        public ushort Tenacity { get; set; }
        public ushort AttackPower { get; set; }
        public ushort Defense { get; set; }
        public ushort DirectHitRate { get; set; }
        public ushort Evasion { get; set; }
        public ushort MagicDefense { get; set; }
        public ushort CriticalHitPower { get; set; }
        public ushort CriticalHitResilience { get; set; }
        public ushort CriticalHit { get; set; }
        public ushort CriticalHitEvasion { get; set; }
        public ushort SlashingResistance { get; set; }
        public ushort PiercingResistance { get; set; }
        public ushort BluntResistance { get; set; }
        public ushort ProjectileResistance { get; set; }
        public ushort AttackMagicPotency { get; set; }
        public ushort HealingMagicPotency { get; set; }
        public ushort EnhancementMagicPotency { get; set; }
        public ushort EnfeeblingMagicPotency { get; set; }
        public ushort FireResistance { get; set; }
        public ushort IceResistance { get; set; }
        public ushort WindResistance { get; set; }
        public ushort EarthResistance { get; set; }
        public ushort LightningResistance { get; set; }
        public ushort WaterResistance { get; set; }
        public ushort MagicResistance { get; set; }
        public ushort Determination { get; set; }
        public ushort SkillSpeed { get; set; }
        public ushort SpellSpeed { get; set; }
        public ushort Haste { get; set; }
        public ushort Morale { get; set; }
        public ushort Enmity { get; set; }
        public ushort EnmityReduction { get; set; }
        public ushort CarefulDesynthesis { get; set; }
        public ushort EXPBonus { get; set; }
        public ushort Regen { get; set; }
        public ushort Refresh { get; set; }
        public ushort MovementSpeed { get; set; }
        public ushort Spikes { get; set; }
        public ushort SlowResistance { get; set; }
        public ushort PetrificationResistance { get; set; }
        public ushort ParalysisResistance { get; set; }
        public ushort SilenceResistance { get; set; }
        public ushort BlindResistance { get; set; }
        public ushort PoisonResistance { get; set; }
        public ushort StunResistance { get; set; }
        public ushort SleepResistance { get; set; }
        public ushort BindResistance { get; set; }
        public ushort HeavyResistance { get; set; }
        public ushort DoomResistance { get; set; }
        public ushort ReducedDurabilityLoss { get; set; }
        public ushort IncreasedSpiritbondGain { get; set; }
        public ushort Craftsmanship { get; set; }
        public ushort Control { get; set; }
        public ushort Gathering { get; set; }
        public ushort Perception { get; set; }
        public ushort Unknown73 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Strength = parser.ReadColumn< ushort >( 0 );
            Dexterity = parser.ReadColumn< ushort >( 1 );
            Vitality = parser.ReadColumn< ushort >( 2 );
            Intelligence = parser.ReadColumn< ushort >( 3 );
            Mind = parser.ReadColumn< ushort >( 4 );
            Piety = parser.ReadColumn< ushort >( 5 );
            HP = parser.ReadColumn< ushort >( 6 );
            MP = parser.ReadColumn< ushort >( 7 );
            TP = parser.ReadColumn< ushort >( 8 );
            GP = parser.ReadColumn< ushort >( 9 );
            CP = parser.ReadColumn< ushort >( 10 );
            PhysicalDamage = parser.ReadColumn< ushort >( 11 );
            MagicalDamage = parser.ReadColumn< ushort >( 12 );
            Delay = parser.ReadColumn< ushort >( 13 );
            AdditionalEffect = parser.ReadColumn< ushort >( 14 );
            AttackSpeed = parser.ReadColumn< ushort >( 15 );
            BlockRate = parser.ReadColumn< ushort >( 16 );
            BlockStrength = parser.ReadColumn< ushort >( 17 );
            Tenacity = parser.ReadColumn< ushort >( 18 );
            AttackPower = parser.ReadColumn< ushort >( 19 );
            Defense = parser.ReadColumn< ushort >( 20 );
            DirectHitRate = parser.ReadColumn< ushort >( 21 );
            Evasion = parser.ReadColumn< ushort >( 22 );
            MagicDefense = parser.ReadColumn< ushort >( 23 );
            CriticalHitPower = parser.ReadColumn< ushort >( 24 );
            CriticalHitResilience = parser.ReadColumn< ushort >( 25 );
            CriticalHit = parser.ReadColumn< ushort >( 26 );
            CriticalHitEvasion = parser.ReadColumn< ushort >( 27 );
            SlashingResistance = parser.ReadColumn< ushort >( 28 );
            PiercingResistance = parser.ReadColumn< ushort >( 29 );
            BluntResistance = parser.ReadColumn< ushort >( 30 );
            ProjectileResistance = parser.ReadColumn< ushort >( 31 );
            AttackMagicPotency = parser.ReadColumn< ushort >( 32 );
            HealingMagicPotency = parser.ReadColumn< ushort >( 33 );
            EnhancementMagicPotency = parser.ReadColumn< ushort >( 34 );
            EnfeeblingMagicPotency = parser.ReadColumn< ushort >( 35 );
            FireResistance = parser.ReadColumn< ushort >( 36 );
            IceResistance = parser.ReadColumn< ushort >( 37 );
            WindResistance = parser.ReadColumn< ushort >( 38 );
            EarthResistance = parser.ReadColumn< ushort >( 39 );
            LightningResistance = parser.ReadColumn< ushort >( 40 );
            WaterResistance = parser.ReadColumn< ushort >( 41 );
            MagicResistance = parser.ReadColumn< ushort >( 42 );
            Determination = parser.ReadColumn< ushort >( 43 );
            SkillSpeed = parser.ReadColumn< ushort >( 44 );
            SpellSpeed = parser.ReadColumn< ushort >( 45 );
            Haste = parser.ReadColumn< ushort >( 46 );
            Morale = parser.ReadColumn< ushort >( 47 );
            Enmity = parser.ReadColumn< ushort >( 48 );
            EnmityReduction = parser.ReadColumn< ushort >( 49 );
            CarefulDesynthesis = parser.ReadColumn< ushort >( 50 );
            EXPBonus = parser.ReadColumn< ushort >( 51 );
            Regen = parser.ReadColumn< ushort >( 52 );
            Refresh = parser.ReadColumn< ushort >( 53 );
            MovementSpeed = parser.ReadColumn< ushort >( 54 );
            Spikes = parser.ReadColumn< ushort >( 55 );
            SlowResistance = parser.ReadColumn< ushort >( 56 );
            PetrificationResistance = parser.ReadColumn< ushort >( 57 );
            ParalysisResistance = parser.ReadColumn< ushort >( 58 );
            SilenceResistance = parser.ReadColumn< ushort >( 59 );
            BlindResistance = parser.ReadColumn< ushort >( 60 );
            PoisonResistance = parser.ReadColumn< ushort >( 61 );
            StunResistance = parser.ReadColumn< ushort >( 62 );
            SleepResistance = parser.ReadColumn< ushort >( 63 );
            BindResistance = parser.ReadColumn< ushort >( 64 );
            HeavyResistance = parser.ReadColumn< ushort >( 65 );
            DoomResistance = parser.ReadColumn< ushort >( 66 );
            ReducedDurabilityLoss = parser.ReadColumn< ushort >( 67 );
            IncreasedSpiritbondGain = parser.ReadColumn< ushort >( 68 );
            Craftsmanship = parser.ReadColumn< ushort >( 69 );
            Control = parser.ReadColumn< ushort >( 70 );
            Gathering = parser.ReadColumn< ushort >( 71 );
            Perception = parser.ReadColumn< ushort >( 72 );
            Unknown73 = parser.ReadColumn< ushort >( 73 );
        }
    }
}