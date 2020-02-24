namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJob", columnHash: 0xc6d83eda )]
    public class ClassJob : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Abbreviation
         *  type: 
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 004e col: 3
         *  name: ClassJobCategory
         *  type: 
         */

        /* offset: 005b col: 4
         *  name: ExpArrayIndex
         *  type: 
         */

        /* offset: 005c col: 5
         *  name: BattleClassIndex
         *  type: 
         */

        /* offset: 004f col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0050 col: 7
         *  name: JobIndex
         *  type: 
         */

        /* offset: 005d col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 9
         *  name: Modifier{HitPoints}
         *  type: 
         */

        /* offset: 002e col: 10
         *  name: Modifier{ManaPoints}
         *  type: 
         */

        /* offset: 0030 col: 11
         *  name: Modifier{Strength}
         *  type: 
         */

        /* offset: 0032 col: 12
         *  name: Modifier{Vitality}
         *  type: 
         */

        /* offset: 0034 col: 13
         *  name: Modifier{Dexterity}
         *  type: 
         */

        /* offset: 0036 col: 14
         *  name: Modifier{Intelligence}
         *  type: 
         */

        /* offset: 0038 col: 15
         *  name: Modifier{Mind}
         *  type: 
         */

        /* offset: 003a col: 16
         *  name: Modifier{Piety}
         *  type: 
         */

        /* offset: 003c col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 003e col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 0042 col: 20
         *  no SaintCoinach definition found
         */

        /* offset: 0044 col: 21
         *  no SaintCoinach definition found
         */

        /* offset: 0046 col: 22
         *  no SaintCoinach definition found
         */

        /* offset: 0051 col: 23
         *  no SaintCoinach definition found
         */

        /* offset: 0052 col: 24
         *  no SaintCoinach definition found
         */

        /* offset: 0053 col: 25
         *  no SaintCoinach definition found
         */

        /* offset: 0054 col: 26
         *  name: ClassJob{Parent}
         *  type: 
         */

        /* offset: 0010 col: 27
         *  name: Name{English}
         *  type: 
         */

        /* offset: 0024 col: 28
         *  name: Item{StartingWeapon}
         *  type: 
         */

        /* offset: 0028 col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0055 col: 30
         *  name: Role
         *  type: 
         */

        /* offset: 0056 col: 31
         *  name: StartingTown
         *  type: 
         */

        /* offset: 005e col: 32
         *  name: MonsterNote
         *  type: 
         */

        /* offset: 0057 col: 33
         *  name: PrimaryStat
         *  type: 
         */

        /* offset: 0048 col: 34
         *  name: LimitBreak1
         *  type: 
         */

        /* offset: 004a col: 35
         *  name: LimitBreak2
         *  type: 
         */

        /* offset: 004c col: 36
         *  name: LimitBreak3
         *  type: 
         */

        /* offset: 0058 col: 37
         *  name: UIPriority
         *  type: 
         */

        /* offset: 0014 col: 38
         *  name: Item{SoulCrystal}
         *  type: 
         */

        /* offset: 0018 col: 39
         *  name: UnlockQuest
         *  type: 
         */

        /* offset: 001c col: 40
         *  name: RelicQuest
         *  type: 
         */

        /* offset: 0020 col: 41
         *  name: Prerequisite
         *  type: 
         */

        /* offset: 0059 col: 42
         *  name: StartingLevel
         *  type: 
         */

        /* offset: 005a col: 43
         *  name: PartyBonus
         *  type: 
         */

        /* offset: 005f col: 44
         *  name: IsLimitedJob
         *  type: 
         */

        /* offset: 000c col: 45
         *  name: CanQueueForDuty
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Abbreviation;

        // col: 02 offset: 0008
        public string unknown8;

        // col: 45 offset: 000c
        private byte packedc;
        public bool CanQueueForDuty => ( packedc & 0x1 ) == 0x1;

        // col: 27 offset: 0010
        public string NameEnglish;

        // col: 38 offset: 0014
        public uint ItemSoulCrystal;

        // col: 39 offset: 0018
        public uint UnlockQuest;

        // col: 40 offset: 001c
        public uint RelicQuest;

        // col: 41 offset: 0020
        public uint Prerequisite;

        // col: 28 offset: 0024
        public int ItemStartingWeapon;

        // col: 29 offset: 0028
        public int unknown28;

        // col: 09 offset: 002c
        public ushort ModifierHitPoints;

        // col: 10 offset: 002e
        public ushort ModifierManaPoints;

        // col: 11 offset: 0030
        public ushort ModifierStrength;

        // col: 12 offset: 0032
        public ushort ModifierVitality;

        // col: 13 offset: 0034
        public ushort ModifierDexterity;

        // col: 14 offset: 0036
        public ushort ModifierIntelligence;

        // col: 15 offset: 0038
        public ushort ModifierMind;

        // col: 16 offset: 003a
        public ushort ModifierPiety;

        // col: 17 offset: 003c
        public ushort unknown3c;

        // col: 18 offset: 003e
        public ushort unknown3e;

        // col: 19 offset: 0040
        public ushort unknown40;

        // col: 20 offset: 0042
        public ushort unknown42;

        // col: 21 offset: 0044
        public ushort unknown44;

        // col: 22 offset: 0046
        public ushort unknown46;

        // col: 34 offset: 0048
        public ushort LimitBreak1;

        // col: 35 offset: 004a
        public ushort LimitBreak2;

        // col: 36 offset: 004c
        public ushort LimitBreak3;

        // col: 03 offset: 004e
        public byte ClassJobCategory;

        // col: 06 offset: 004f
        public byte unknown4f;

        // col: 07 offset: 0050
        public byte JobIndex;

        // col: 23 offset: 0051
        public byte unknown51;

        // col: 24 offset: 0052
        public byte unknown52;

        // col: 25 offset: 0053
        public byte unknown53;

        // col: 26 offset: 0054
        public byte ClassJobParent;

        // col: 30 offset: 0055
        public byte Role;

        // col: 31 offset: 0056
        public byte StartingTown;

        // col: 33 offset: 0057
        public byte PrimaryStat;

        // col: 37 offset: 0058
        public byte UIPriority;

        // col: 42 offset: 0059
        public byte StartingLevel;

        // col: 43 offset: 005a
        public byte PartyBonus;

        // col: 04 offset: 005b
        public sbyte ExpArrayIndex;

        // col: 05 offset: 005c
        public sbyte BattleClassIndex;

        // col: 08 offset: 005d
        public sbyte unknown5d;

        // col: 32 offset: 005e
        public sbyte MonsterNote;

        // col: 44 offset: 005f
        private byte packed5f;
        public bool IsLimitedJob => ( packed5f & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Abbreviation = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 45 offset: 000c
            packedc = parser.ReadOffset< byte >( 0xc );

            // col: 27 offset: 0010
            NameEnglish = parser.ReadOffset< string >( 0x10 );

            // col: 38 offset: 0014
            ItemSoulCrystal = parser.ReadOffset< uint >( 0x14 );

            // col: 39 offset: 0018
            UnlockQuest = parser.ReadOffset< uint >( 0x18 );

            // col: 40 offset: 001c
            RelicQuest = parser.ReadOffset< uint >( 0x1c );

            // col: 41 offset: 0020
            Prerequisite = parser.ReadOffset< uint >( 0x20 );

            // col: 28 offset: 0024
            ItemStartingWeapon = parser.ReadOffset< int >( 0x24 );

            // col: 29 offset: 0028
            unknown28 = parser.ReadOffset< int >( 0x28 );

            // col: 9 offset: 002c
            ModifierHitPoints = parser.ReadOffset< ushort >( 0x2c );

            // col: 10 offset: 002e
            ModifierManaPoints = parser.ReadOffset< ushort >( 0x2e );

            // col: 11 offset: 0030
            ModifierStrength = parser.ReadOffset< ushort >( 0x30 );

            // col: 12 offset: 0032
            ModifierVitality = parser.ReadOffset< ushort >( 0x32 );

            // col: 13 offset: 0034
            ModifierDexterity = parser.ReadOffset< ushort >( 0x34 );

            // col: 14 offset: 0036
            ModifierIntelligence = parser.ReadOffset< ushort >( 0x36 );

            // col: 15 offset: 0038
            ModifierMind = parser.ReadOffset< ushort >( 0x38 );

            // col: 16 offset: 003a
            ModifierPiety = parser.ReadOffset< ushort >( 0x3a );

            // col: 17 offset: 003c
            unknown3c = parser.ReadOffset< ushort >( 0x3c );

            // col: 18 offset: 003e
            unknown3e = parser.ReadOffset< ushort >( 0x3e );

            // col: 19 offset: 0040
            unknown40 = parser.ReadOffset< ushort >( 0x40 );

            // col: 20 offset: 0042
            unknown42 = parser.ReadOffset< ushort >( 0x42 );

            // col: 21 offset: 0044
            unknown44 = parser.ReadOffset< ushort >( 0x44 );

            // col: 22 offset: 0046
            unknown46 = parser.ReadOffset< ushort >( 0x46 );

            // col: 34 offset: 0048
            LimitBreak1 = parser.ReadOffset< ushort >( 0x48 );

            // col: 35 offset: 004a
            LimitBreak2 = parser.ReadOffset< ushort >( 0x4a );

            // col: 36 offset: 004c
            LimitBreak3 = parser.ReadOffset< ushort >( 0x4c );

            // col: 3 offset: 004e
            ClassJobCategory = parser.ReadOffset< byte >( 0x4e );

            // col: 6 offset: 004f
            unknown4f = parser.ReadOffset< byte >( 0x4f );

            // col: 7 offset: 0050
            JobIndex = parser.ReadOffset< byte >( 0x50 );

            // col: 23 offset: 0051
            unknown51 = parser.ReadOffset< byte >( 0x51 );

            // col: 24 offset: 0052
            unknown52 = parser.ReadOffset< byte >( 0x52 );

            // col: 25 offset: 0053
            unknown53 = parser.ReadOffset< byte >( 0x53 );

            // col: 26 offset: 0054
            ClassJobParent = parser.ReadOffset< byte >( 0x54 );

            // col: 30 offset: 0055
            Role = parser.ReadOffset< byte >( 0x55 );

            // col: 31 offset: 0056
            StartingTown = parser.ReadOffset< byte >( 0x56 );

            // col: 33 offset: 0057
            PrimaryStat = parser.ReadOffset< byte >( 0x57 );

            // col: 37 offset: 0058
            UIPriority = parser.ReadOffset< byte >( 0x58 );

            // col: 42 offset: 0059
            StartingLevel = parser.ReadOffset< byte >( 0x59 );

            // col: 43 offset: 005a
            PartyBonus = parser.ReadOffset< byte >( 0x5a );

            // col: 4 offset: 005b
            ExpArrayIndex = parser.ReadOffset< sbyte >( 0x5b );

            // col: 5 offset: 005c
            BattleClassIndex = parser.ReadOffset< sbyte >( 0x5c );

            // col: 8 offset: 005d
            unknown5d = parser.ReadOffset< sbyte >( 0x5d );

            // col: 32 offset: 005e
            MonsterNote = parser.ReadOffset< sbyte >( 0x5e );

            // col: 44 offset: 005f
            packed5f = parser.ReadOffset< byte >( 0x5f );


        }
    }
}