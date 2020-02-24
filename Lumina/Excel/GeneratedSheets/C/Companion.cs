namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Companion", columnHash: 0x776048c3 )]
    public class Companion : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Singular
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Adjective
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Plural
         *  type: 
         */

        /* offset: 0009 col: 3
         *  name: PossessivePronoun
         *  type: 
         */

        /* offset: 000a col: 4
         *  name: StartsWithVowel
         *  type: 
         */

        /* offset: 000b col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 6
         *  name: Pronoun
         *  type: 
         */

        /* offset: 000d col: 7
         *  name: Article
         *  type: 
         */

        /* offset: 0010 col: 8
         *  name: Model
         *  type: 
         */

        /* offset: 0020 col: 9
         *  name: Scale
         *  type: 
         */

        /* offset: 0021 col: 10
         *  name: InactiveIdle[0]
         *  type: 
         */

        /* offset: 0022 col: 11
         *  name: InactiveIdle[1]
         *  type: 
         */

        /* offset: 0023 col: 12
         *  name: InactiveBattle
         *  type: 
         */

        /* offset: 0024 col: 13
         *  name: InactiveWandering
         *  type: 
         */

        /* offset: 0025 col: 14
         *  name: Behavior
         *  type: 
         */

        /* offset: 0026 col: 15
         *  name: Special
         *  type: 
         */

        /* offset: 0027 col: 16
         *  name: WanderingWait
         *  type: 
         */

        /* offset: 0012 col: 17
         *  name: Priority
         *  type: 
         */

        /* offset: 002e col: 18
         *  name: Roulette
         *  type: 
         */

        /* offset: 002e col: 19
         *  no SaintCoinach definition found
         */

        /* offset: 002e col: 20
         *  name: Battle
         *  type: 
         */

        /* offset: 002e col: 21
         *  name: LookAt
         *  type: 
         */

        /* offset: 002e col: 22
         *  name: Poke
         *  type: 
         */

        /* offset: 0014 col: 23
         *  name: Enemy
         *  type: 
         */

        /* offset: 002e col: 24
         *  name: Stroke
         *  type: 
         */

        /* offset: 002e col: 25
         *  name: Clapping
         *  type: 
         */

        /* offset: 0016 col: 26
         *  name: Icon
         *  type: 
         */

        /* offset: 0018 col: 27
         *  name: Order
         *  type: 
         */

        /* offset: 002e col: 28
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0029 col: 30
         *  name: Cost
         *  type: 
         */

        /* offset: 001a col: 31
         *  name: HP
         *  type: 
         */

        /* offset: 002a col: 32
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 33
         *  name: Skill{Angle}
         *  type: 
         */

        /* offset: 002b col: 34
         *  name: Skill{Cost}
         *  type: 
         */

        /* offset: 002c col: 35
         *  no SaintCoinach definition found
         */

        /* offset: 001e col: 36
         *  no SaintCoinach definition found
         */

        /* offset: 002d col: 37
         *  name: MinionRace
         *  type: 
         */



        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 01 offset: 0008
        public sbyte Adjective;

        // col: 03 offset: 0009
        public sbyte PossessivePronoun;

        // col: 04 offset: 000a
        public sbyte StartsWithVowel;

        // col: 05 offset: 000b
        public sbyte unknownb;

        // col: 06 offset: 000c
        public sbyte Pronoun;

        // col: 07 offset: 000d
        public sbyte Article;

        // col: 08 offset: 0010
        public ushort Model;

        // col: 17 offset: 0012
        public ushort Priority;

        // col: 23 offset: 0014
        public ushort Enemy;

        // col: 26 offset: 0016
        public ushort Icon;

        // col: 27 offset: 0018
        public ushort Order;

        // col: 31 offset: 001a
        public ushort HP;

        // col: 33 offset: 001c
        public ushort SkillAngle;

        // col: 36 offset: 001e
        public ushort unknown1e;

        // col: 09 offset: 0020
        public byte Scale;

        // col: 10 offset: 0021
        public byte InactiveIdle0;

        // col: 11 offset: 0022
        public byte InactiveIdle1;

        // col: 12 offset: 0023
        public byte InactiveBattle;

        // col: 13 offset: 0024
        public byte InactiveWandering;

        // col: 14 offset: 0025
        public byte Behavior;

        // col: 15 offset: 0026
        public byte Special;

        // col: 16 offset: 0027
        public byte WanderingWait;

        // col: 29 offset: 0028
        public byte unknown28;

        // col: 30 offset: 0029
        public byte Cost;

        // col: 32 offset: 002a
        public byte unknown2a;

        // col: 34 offset: 002b
        public byte SkillCost;

        // col: 35 offset: 002c
        public byte unknown2c;

        // col: 37 offset: 002d
        public byte MinionRace;

        // col: 18 offset: 002e
        private byte packed2e;
        public bool Roulette => ( packed2e & 0x1 ) == 0x1;
        public bool packed2e_2 => ( packed2e & 0x2 ) == 0x2;
        public bool Battle => ( packed2e & 0x4 ) == 0x4;
        public bool LookAt => ( packed2e & 0x8 ) == 0x8;
        public bool Poke => ( packed2e & 0x10 ) == 0x10;
        public bool Stroke => ( packed2e & 0x20 ) == 0x20;
        public bool Clapping => ( packed2e & 0x40 ) == 0x40;
        public bool packed2e_80 => ( packed2e & 0x80 ) == 0x80;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Singular = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Plural = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            Adjective = parser.ReadOffset< sbyte >( 0x8 );

            // col: 3 offset: 0009
            PossessivePronoun = parser.ReadOffset< sbyte >( 0x9 );

            // col: 4 offset: 000a
            StartsWithVowel = parser.ReadOffset< sbyte >( 0xa );

            // col: 5 offset: 000b
            unknownb = parser.ReadOffset< sbyte >( 0xb );

            // col: 6 offset: 000c
            Pronoun = parser.ReadOffset< sbyte >( 0xc );

            // col: 7 offset: 000d
            Article = parser.ReadOffset< sbyte >( 0xd );

            // col: 8 offset: 0010
            Model = parser.ReadOffset< ushort >( 0x10 );

            // col: 17 offset: 0012
            Priority = parser.ReadOffset< ushort >( 0x12 );

            // col: 23 offset: 0014
            Enemy = parser.ReadOffset< ushort >( 0x14 );

            // col: 26 offset: 0016
            Icon = parser.ReadOffset< ushort >( 0x16 );

            // col: 27 offset: 0018
            Order = parser.ReadOffset< ushort >( 0x18 );

            // col: 31 offset: 001a
            HP = parser.ReadOffset< ushort >( 0x1a );

            // col: 33 offset: 001c
            SkillAngle = parser.ReadOffset< ushort >( 0x1c );

            // col: 36 offset: 001e
            unknown1e = parser.ReadOffset< ushort >( 0x1e );

            // col: 9 offset: 0020
            Scale = parser.ReadOffset< byte >( 0x20 );

            // col: 10 offset: 0021
            InactiveIdle0 = parser.ReadOffset< byte >( 0x21 );

            // col: 11 offset: 0022
            InactiveIdle1 = parser.ReadOffset< byte >( 0x22 );

            // col: 12 offset: 0023
            InactiveBattle = parser.ReadOffset< byte >( 0x23 );

            // col: 13 offset: 0024
            InactiveWandering = parser.ReadOffset< byte >( 0x24 );

            // col: 14 offset: 0025
            Behavior = parser.ReadOffset< byte >( 0x25 );

            // col: 15 offset: 0026
            Special = parser.ReadOffset< byte >( 0x26 );

            // col: 16 offset: 0027
            WanderingWait = parser.ReadOffset< byte >( 0x27 );

            // col: 29 offset: 0028
            unknown28 = parser.ReadOffset< byte >( 0x28 );

            // col: 30 offset: 0029
            Cost = parser.ReadOffset< byte >( 0x29 );

            // col: 32 offset: 002a
            unknown2a = parser.ReadOffset< byte >( 0x2a );

            // col: 34 offset: 002b
            SkillCost = parser.ReadOffset< byte >( 0x2b );

            // col: 35 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 37 offset: 002d
            MinionRace = parser.ReadOffset< byte >( 0x2d );

            // col: 18 offset: 002e
            packed2e = parser.ReadOffset< byte >( 0x2e );


        }
    }
}