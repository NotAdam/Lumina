// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Companion", columnHash: 0x776048c3 )]
    public class Companion : ExcelRow
    {
        
        public SeString Singular;
        public sbyte Adjective;
        public SeString Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Pronoun;
        public sbyte Article;
        public LazyRow< ModelChara > Model;
        public byte Scale;
        public byte InactiveIdle0;
        public byte InactiveIdle1;
        public byte InactiveBattle;
        public byte InactiveWandering;
        public LazyRow< CompanionMove > Behavior;
        public byte Special;
        public byte WanderingWait;
        public ushort Priority;
        public bool Roulette;
        public bool Unknown19;
        public bool Battle;
        public bool LookAt;
        public bool Poke;
        public ushort Enemy;
        public bool Stroke;
        public bool Clapping;
        public ushort Icon;
        public ushort Order;
        public bool Unknown28;
        public byte Unknown29;
        public byte Cost;
        public ushort HP;
        public byte Unknown32;
        public ushort SkillAngle;
        public byte SkillCost;
        public byte Unknown35;
        public ushort Unknown36;
        public LazyRow< MinionRace > MinionRace;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            Model = new LazyRow< ModelChara >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            Scale = parser.ReadColumn< byte >( 9 );
            InactiveIdle0 = parser.ReadColumn< byte >( 10 );
            InactiveIdle1 = parser.ReadColumn< byte >( 11 );
            InactiveBattle = parser.ReadColumn< byte >( 12 );
            InactiveWandering = parser.ReadColumn< byte >( 13 );
            Behavior = new LazyRow< CompanionMove >( lumina, parser.ReadColumn< byte >( 14 ), language );
            Special = parser.ReadColumn< byte >( 15 );
            WanderingWait = parser.ReadColumn< byte >( 16 );
            Priority = parser.ReadColumn< ushort >( 17 );
            Roulette = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Battle = parser.ReadColumn< bool >( 20 );
            LookAt = parser.ReadColumn< bool >( 21 );
            Poke = parser.ReadColumn< bool >( 22 );
            Enemy = parser.ReadColumn< ushort >( 23 );
            Stroke = parser.ReadColumn< bool >( 24 );
            Clapping = parser.ReadColumn< bool >( 25 );
            Icon = parser.ReadColumn< ushort >( 26 );
            Order = parser.ReadColumn< ushort >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Cost = parser.ReadColumn< byte >( 30 );
            HP = parser.ReadColumn< ushort >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            SkillAngle = parser.ReadColumn< ushort >( 33 );
            SkillCost = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< ushort >( 36 );
            MinionRace = new LazyRow< MinionRace >( lumina, parser.ReadColumn< byte >( 37 ), language );
        }
    }
}