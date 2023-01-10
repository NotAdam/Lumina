// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Companion", columnHash: 0x776048c3 )]
    public partial class Companion : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public LazyRow< ModelChara > Model { get; set; }
        public byte Scale { get; set; }
        public byte InactiveIdle0 { get; set; }
        public byte InactiveIdle1 { get; set; }
        public byte InactiveBattle { get; set; }
        public byte InactiveWandering { get; set; }
        public LazyRow< CompanionMove > Behavior { get; set; }
        public byte Special { get; set; }
        public byte WanderingWait { get; set; }
        public ushort Priority { get; set; }
        public bool Unknown18 { get; set; }
        public bool Unknown19 { get; set; }
        public bool Unknown20 { get; set; }
        public bool Unknown21 { get; set; }
        public bool Unknown22 { get; set; }
        public ushort Enemy { get; set; }
        public bool Battle { get; set; }
        public bool Roulette { get; set; }
        public ushort Icon { get; set; }
        public ushort Order { get; set; }
        public bool IdleAnimation { get; set; }
        public byte Unknown29 { get; set; }
        public byte Cost { get; set; }
        public ushort HP { get; set; }
        public byte Unknown32 { get; set; }
        public ushort SkillAngle { get; set; }
        public byte SkillCost { get; set; }
        public byte Unknown35 { get; set; }
        public ushort Unknown36 { get; set; }
        public LazyRow< MinionRace > MinionRace { get; set; }
        
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
            Model = new LazyRow< ModelChara >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Scale = parser.ReadColumn< byte >( 9 );
            InactiveIdle0 = parser.ReadColumn< byte >( 10 );
            InactiveIdle1 = parser.ReadColumn< byte >( 11 );
            InactiveBattle = parser.ReadColumn< byte >( 12 );
            InactiveWandering = parser.ReadColumn< byte >( 13 );
            Behavior = new LazyRow< CompanionMove >( gameData, parser.ReadColumn< byte >( 14 ), language );
            Special = parser.ReadColumn< byte >( 15 );
            WanderingWait = parser.ReadColumn< byte >( 16 );
            Priority = parser.ReadColumn< ushort >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< bool >( 22 );
            Enemy = parser.ReadColumn< ushort >( 23 );
            Battle = parser.ReadColumn< bool >( 24 );
            Roulette = parser.ReadColumn< bool >( 25 );
            Icon = parser.ReadColumn< ushort >( 26 );
            Order = parser.ReadColumn< ushort >( 27 );
            IdleAnimation = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Cost = parser.ReadColumn< byte >( 30 );
            HP = parser.ReadColumn< ushort >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            SkillAngle = parser.ReadColumn< ushort >( 33 );
            SkillCost = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< ushort >( 36 );
            MinionRace = new LazyRow< MinionRace >( gameData, parser.ReadColumn< byte >( 37 ), language );
        }
    }
}