using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemLevel", columnHash: 0xc71c2c61 )]
    public class ItemLevel : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort Strength;

        // col: 01 offset: 0002
        public ushort Dexterity;

        // col: 02 offset: 0004
        public ushort Vitality;

        // col: 03 offset: 0006
        public ushort Intelligence;

        // col: 04 offset: 0008
        public ushort Mind;

        // col: 05 offset: 000a
        public ushort Piety;

        // col: 06 offset: 000c
        public ushort HP;

        // col: 07 offset: 000e
        public ushort MP;

        // col: 08 offset: 0010
        public ushort TP;

        // col: 09 offset: 0012
        public ushort GP;

        // col: 10 offset: 0014
        public ushort CP;

        // col: 11 offset: 0016
        public ushort PhysicalDamage;

        // col: 12 offset: 0018
        public ushort MagicalDamage;

        // col: 13 offset: 001a
        public ushort Delay;

        // col: 14 offset: 001c
        public ushort AdditionalEffect;

        // col: 15 offset: 001e
        public ushort AttackSpeed;

        // col: 16 offset: 0020
        public ushort BlockRate;

        // col: 17 offset: 0022
        public ushort BlockStrength;

        // col: 18 offset: 0024
        public ushort Tenacity;

        // col: 19 offset: 0026
        public ushort AttackPower;

        // col: 20 offset: 0028
        public ushort Defense;

        // col: 21 offset: 002a
        public ushort DirectHitRate;

        // col: 22 offset: 002c
        public ushort Evasion;

        // col: 23 offset: 002e
        public ushort MagicDefense;

        // col: 24 offset: 0030
        public ushort CriticalHitPower;

        // col: 25 offset: 0032
        public ushort CriticalHitResilience;

        // col: 26 offset: 0034
        public ushort CriticalHit;

        // col: 27 offset: 0036
        public ushort CriticalHitEvasion;

        // col: 28 offset: 0038
        public ushort SlashingResistance;

        // col: 29 offset: 003a
        public ushort PiercingResistance;

        // col: 30 offset: 003c
        public ushort BluntResistance;

        // col: 31 offset: 003e
        public ushort ProjectileResistance;

        // col: 32 offset: 0040
        public ushort AttackMagicPotency;

        // col: 33 offset: 0042
        public ushort HealingMagicPotency;

        // col: 34 offset: 0044
        public ushort EnhancementMagicPotency;

        // col: 35 offset: 0046
        public ushort EnfeeblingMagicPotency;

        // col: 36 offset: 0048
        public ushort FireResistance;

        // col: 37 offset: 004a
        public ushort IceResistance;

        // col: 38 offset: 004c
        public ushort WindResistance;

        // col: 39 offset: 004e
        public ushort EarthResistance;

        // col: 40 offset: 0050
        public ushort LightningResistance;

        // col: 41 offset: 0052
        public ushort WaterResistance;

        // col: 42 offset: 0054
        public ushort MagicResistance;

        // col: 43 offset: 0056
        public ushort Determination;

        // col: 44 offset: 0058
        public ushort SkillSpeed;

        // col: 45 offset: 005a
        public ushort SpellSpeed;

        // col: 46 offset: 005c
        public ushort Haste;

        // col: 47 offset: 005e
        public ushort Morale;

        // col: 48 offset: 0060
        public ushort Enmity;

        // col: 49 offset: 0062
        public ushort EnmityReduction;

        // col: 50 offset: 0064
        public ushort CarefulDesynthesis;

        // col: 51 offset: 0066
        public ushort EXPBonus;

        // col: 52 offset: 0068
        public ushort Regen;

        // col: 53 offset: 006a
        public ushort Refresh;

        // col: 54 offset: 006c
        public ushort MovementSpeed;

        // col: 55 offset: 006e
        public ushort Spikes;

        // col: 56 offset: 0070
        public ushort SlowResistance;

        // col: 57 offset: 0072
        public ushort PetrificationResistance;

        // col: 58 offset: 0074
        public ushort ParalysisResistance;

        // col: 59 offset: 0076
        public ushort SilenceResistance;

        // col: 60 offset: 0078
        public ushort BlindResistance;

        // col: 61 offset: 007a
        public ushort PoisonResistance;

        // col: 62 offset: 007c
        public ushort StunResistance;

        // col: 63 offset: 007e
        public ushort SleepResistance;

        // col: 64 offset: 0080
        public ushort BindResistance;

        // col: 65 offset: 0082
        public ushort HeavyResistance;

        // col: 66 offset: 0084
        public ushort DoomResistance;

        // col: 67 offset: 0086
        public ushort ReducedDurabilityLoss;

        // col: 68 offset: 0088
        public ushort IncreasedSpiritbondGain;

        // col: 69 offset: 008a
        public ushort Craftsmanship;

        // col: 70 offset: 008c
        public ushort Control;

        // col: 71 offset: 008e
        public ushort Gathering;

        // col: 72 offset: 0090
        public ushort Perception;

        // col: 73 offset: 0092
        public ushort unknown92;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Strength = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            Dexterity = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            Vitality = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            Intelligence = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            Mind = parser.ReadOffset< ushort >( 0x8 );

            // col: 5 offset: 000a
            Piety = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000c
            HP = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            MP = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            TP = parser.ReadOffset< ushort >( 0x10 );

            // col: 9 offset: 0012
            GP = parser.ReadOffset< ushort >( 0x12 );

            // col: 10 offset: 0014
            CP = parser.ReadOffset< ushort >( 0x14 );

            // col: 11 offset: 0016
            PhysicalDamage = parser.ReadOffset< ushort >( 0x16 );

            // col: 12 offset: 0018
            MagicalDamage = parser.ReadOffset< ushort >( 0x18 );

            // col: 13 offset: 001a
            Delay = parser.ReadOffset< ushort >( 0x1a );

            // col: 14 offset: 001c
            AdditionalEffect = parser.ReadOffset< ushort >( 0x1c );

            // col: 15 offset: 001e
            AttackSpeed = parser.ReadOffset< ushort >( 0x1e );

            // col: 16 offset: 0020
            BlockRate = parser.ReadOffset< ushort >( 0x20 );

            // col: 17 offset: 0022
            BlockStrength = parser.ReadOffset< ushort >( 0x22 );

            // col: 18 offset: 0024
            Tenacity = parser.ReadOffset< ushort >( 0x24 );

            // col: 19 offset: 0026
            AttackPower = parser.ReadOffset< ushort >( 0x26 );

            // col: 20 offset: 0028
            Defense = parser.ReadOffset< ushort >( 0x28 );

            // col: 21 offset: 002a
            DirectHitRate = parser.ReadOffset< ushort >( 0x2a );

            // col: 22 offset: 002c
            Evasion = parser.ReadOffset< ushort >( 0x2c );

            // col: 23 offset: 002e
            MagicDefense = parser.ReadOffset< ushort >( 0x2e );

            // col: 24 offset: 0030
            CriticalHitPower = parser.ReadOffset< ushort >( 0x30 );

            // col: 25 offset: 0032
            CriticalHitResilience = parser.ReadOffset< ushort >( 0x32 );

            // col: 26 offset: 0034
            CriticalHit = parser.ReadOffset< ushort >( 0x34 );

            // col: 27 offset: 0036
            CriticalHitEvasion = parser.ReadOffset< ushort >( 0x36 );

            // col: 28 offset: 0038
            SlashingResistance = parser.ReadOffset< ushort >( 0x38 );

            // col: 29 offset: 003a
            PiercingResistance = parser.ReadOffset< ushort >( 0x3a );

            // col: 30 offset: 003c
            BluntResistance = parser.ReadOffset< ushort >( 0x3c );

            // col: 31 offset: 003e
            ProjectileResistance = parser.ReadOffset< ushort >( 0x3e );

            // col: 32 offset: 0040
            AttackMagicPotency = parser.ReadOffset< ushort >( 0x40 );

            // col: 33 offset: 0042
            HealingMagicPotency = parser.ReadOffset< ushort >( 0x42 );

            // col: 34 offset: 0044
            EnhancementMagicPotency = parser.ReadOffset< ushort >( 0x44 );

            // col: 35 offset: 0046
            EnfeeblingMagicPotency = parser.ReadOffset< ushort >( 0x46 );

            // col: 36 offset: 0048
            FireResistance = parser.ReadOffset< ushort >( 0x48 );

            // col: 37 offset: 004a
            IceResistance = parser.ReadOffset< ushort >( 0x4a );

            // col: 38 offset: 004c
            WindResistance = parser.ReadOffset< ushort >( 0x4c );

            // col: 39 offset: 004e
            EarthResistance = parser.ReadOffset< ushort >( 0x4e );

            // col: 40 offset: 0050
            LightningResistance = parser.ReadOffset< ushort >( 0x50 );

            // col: 41 offset: 0052
            WaterResistance = parser.ReadOffset< ushort >( 0x52 );

            // col: 42 offset: 0054
            MagicResistance = parser.ReadOffset< ushort >( 0x54 );

            // col: 43 offset: 0056
            Determination = parser.ReadOffset< ushort >( 0x56 );

            // col: 44 offset: 0058
            SkillSpeed = parser.ReadOffset< ushort >( 0x58 );

            // col: 45 offset: 005a
            SpellSpeed = parser.ReadOffset< ushort >( 0x5a );

            // col: 46 offset: 005c
            Haste = parser.ReadOffset< ushort >( 0x5c );

            // col: 47 offset: 005e
            Morale = parser.ReadOffset< ushort >( 0x5e );

            // col: 48 offset: 0060
            Enmity = parser.ReadOffset< ushort >( 0x60 );

            // col: 49 offset: 0062
            EnmityReduction = parser.ReadOffset< ushort >( 0x62 );

            // col: 50 offset: 0064
            CarefulDesynthesis = parser.ReadOffset< ushort >( 0x64 );

            // col: 51 offset: 0066
            EXPBonus = parser.ReadOffset< ushort >( 0x66 );

            // col: 52 offset: 0068
            Regen = parser.ReadOffset< ushort >( 0x68 );

            // col: 53 offset: 006a
            Refresh = parser.ReadOffset< ushort >( 0x6a );

            // col: 54 offset: 006c
            MovementSpeed = parser.ReadOffset< ushort >( 0x6c );

            // col: 55 offset: 006e
            Spikes = parser.ReadOffset< ushort >( 0x6e );

            // col: 56 offset: 0070
            SlowResistance = parser.ReadOffset< ushort >( 0x70 );

            // col: 57 offset: 0072
            PetrificationResistance = parser.ReadOffset< ushort >( 0x72 );

            // col: 58 offset: 0074
            ParalysisResistance = parser.ReadOffset< ushort >( 0x74 );

            // col: 59 offset: 0076
            SilenceResistance = parser.ReadOffset< ushort >( 0x76 );

            // col: 60 offset: 0078
            BlindResistance = parser.ReadOffset< ushort >( 0x78 );

            // col: 61 offset: 007a
            PoisonResistance = parser.ReadOffset< ushort >( 0x7a );

            // col: 62 offset: 007c
            StunResistance = parser.ReadOffset< ushort >( 0x7c );

            // col: 63 offset: 007e
            SleepResistance = parser.ReadOffset< ushort >( 0x7e );

            // col: 64 offset: 0080
            BindResistance = parser.ReadOffset< ushort >( 0x80 );

            // col: 65 offset: 0082
            HeavyResistance = parser.ReadOffset< ushort >( 0x82 );

            // col: 66 offset: 0084
            DoomResistance = parser.ReadOffset< ushort >( 0x84 );

            // col: 67 offset: 0086
            ReducedDurabilityLoss = parser.ReadOffset< ushort >( 0x86 );

            // col: 68 offset: 0088
            IncreasedSpiritbondGain = parser.ReadOffset< ushort >( 0x88 );

            // col: 69 offset: 008a
            Craftsmanship = parser.ReadOffset< ushort >( 0x8a );

            // col: 70 offset: 008c
            Control = parser.ReadOffset< ushort >( 0x8c );

            // col: 71 offset: 008e
            Gathering = parser.ReadOffset< ushort >( 0x8e );

            // col: 72 offset: 0090
            Perception = parser.ReadOffset< ushort >( 0x90 );

            // col: 73 offset: 0092
            unknown92 = parser.ReadOffset< ushort >( 0x92 );


        }
    }
}