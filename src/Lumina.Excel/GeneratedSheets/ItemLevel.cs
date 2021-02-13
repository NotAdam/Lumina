// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemLevel", columnHash: 0xe216399f )]
    public class ItemLevel : ExcelRow
    {
        
        public ushort Strength;
        public ushort Dexterity;
        public ushort Vitality;
        public ushort Intelligence;
        public ushort Mind;
        public ushort Piety;
        public ushort HP;
        public ushort MP;
        public ushort TP;
        public ushort GP;
        public ushort CP;
        public ushort PhysicalDamage;
        public ushort MagicalDamage;
        public ushort Delay;
        public ushort AdditionalEffect;
        public ushort AttackSpeed;
        public ushort BlockRate;
        public ushort BlockStrength;
        public ushort Tenacity;
        public ushort AttackPower;
        public ushort Defense;
        public ushort DirectHitRate;
        public ushort Evasion;
        public ushort MagicDefense;
        public ushort CriticalHitPower;
        public ushort CriticalHitResilience;
        public ushort CriticalHit;
        public ushort CriticalHitEvasion;
        public ushort SlashingResistance;
        public ushort PiercingResistance;
        public ushort BluntResistance;
        public ushort ProjectileResistance;
        public ushort AttackMagicPotency;
        public ushort HealingMagicPotency;
        public ushort EnhancementMagicPotency;
        public ushort EnfeeblingMagicPotency;
        public ushort FireResistance;
        public ushort IceResistance;
        public ushort WindResistance;
        public ushort EarthResistance;
        public ushort LightningResistance;
        public ushort WaterResistance;
        public ushort MagicResistance;
        public ushort Determination;
        public ushort SkillSpeed;
        public ushort SpellSpeed;
        public ushort Haste;
        public ushort Morale;
        public ushort Enmity;
        public ushort EnmityReduction;
        public ushort CarefulDesynthesis;
        public ushort EXPBonus;
        public ushort Regen;
        public ushort Refresh;
        public ushort MovementSpeed;
        public ushort Spikes;
        public ushort SlowResistance;
        public ushort PetrificationResistance;
        public ushort ParalysisResistance;
        public ushort SilenceResistance;
        public ushort BlindResistance;
        public ushort PoisonResistance;
        public ushort StunResistance;
        public ushort SleepResistance;
        public ushort BindResistance;
        public ushort HeavyResistance;
        public ushort DoomResistance;
        public ushort ReducedDurabilityLoss;
        public ushort IncreasedSpiritbondGain;
        public ushort Craftsmanship;
        public ushort Control;
        public ushort Gathering;
        public ushort Perception;
        public ushort Unknown73;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

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