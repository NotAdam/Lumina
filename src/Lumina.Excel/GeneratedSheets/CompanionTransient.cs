// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanionTransient", columnHash: 0xea0b06cf )]
    public partial class CompanionTransient : ExcelRow
    {
        
        public SeString Description { get; set; }
        public SeString DescriptionEnhanced { get; set; }
        public SeString Tooltip { get; set; }
        public SeString SpecialActionName { get; set; }
        public SeString SpecialActionDescription { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte Speed { get; set; }
        public bool HasAreaAttack { get; set; }
        public bool StrengthGate { get; set; }
        public bool StrengthEye { get; set; }
        public bool StrengthShield { get; set; }
        public bool StrengthArcana { get; set; }
        public LazyRow< MinionSkillType > MinionSkillType { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Description = parser.ReadColumn< SeString >( 0 );
            DescriptionEnhanced = parser.ReadColumn< SeString >( 1 );
            Tooltip = parser.ReadColumn< SeString >( 2 );
            SpecialActionName = parser.ReadColumn< SeString >( 3 );
            SpecialActionDescription = parser.ReadColumn< SeString >( 4 );
            Attack = parser.ReadColumn< byte >( 5 );
            Defense = parser.ReadColumn< byte >( 6 );
            Speed = parser.ReadColumn< byte >( 7 );
            HasAreaAttack = parser.ReadColumn< bool >( 8 );
            StrengthGate = parser.ReadColumn< bool >( 9 );
            StrengthEye = parser.ReadColumn< bool >( 10 );
            StrengthShield = parser.ReadColumn< bool >( 11 );
            StrengthArcana = parser.ReadColumn< bool >( 12 );
            MinionSkillType = new LazyRow< MinionSkillType >( gameData, parser.ReadColumn< byte >( 13 ), language );
        }
    }
}