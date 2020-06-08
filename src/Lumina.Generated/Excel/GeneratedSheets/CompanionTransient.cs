using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanionTransient", columnHash: 0xea0b06cf )]
    public class CompanionTransient : IExcelRow
    {
        
        public string Description;
        public string DescriptionEnhanced;
        public string Tooltip;
        public string SpecialActionName;
        public string SpecialActionDescription;
        public byte Attack;
        public byte Defense;
        public byte Speed;
        public bool HasAreaAttack;
        public bool StrengthGate;
        public bool StrengthEye;
        public bool StrengthShield;
        public bool StrengthArcana;
        public LazyRow< MinionSkillType > MinionSkillType;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< string >( 0 );
            DescriptionEnhanced = parser.ReadColumn< string >( 1 );
            Tooltip = parser.ReadColumn< string >( 2 );
            SpecialActionName = parser.ReadColumn< string >( 3 );
            SpecialActionDescription = parser.ReadColumn< string >( 4 );
            Attack = parser.ReadColumn< byte >( 5 );
            Defense = parser.ReadColumn< byte >( 6 );
            Speed = parser.ReadColumn< byte >( 7 );
            HasAreaAttack = parser.ReadColumn< bool >( 8 );
            StrengthGate = parser.ReadColumn< bool >( 9 );
            StrengthEye = parser.ReadColumn< bool >( 10 );
            StrengthShield = parser.ReadColumn< bool >( 11 );
            StrengthArcana = parser.ReadColumn< bool >( 12 );
            MinionSkillType = new LazyRow< MinionSkillType >( lumina, parser.ReadColumn< byte >( 13 ) );
        }
    }
}