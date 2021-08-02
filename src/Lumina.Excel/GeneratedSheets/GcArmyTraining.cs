// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyTraining", columnHash: 0x274780bb )]
    public partial class GcArmyTraining : ExcelRow
    {
        
        public sbyte PhysicalBonus { get; set; }
        public sbyte MentalBonus { get; set; }
        public sbyte TacticalBonus { get; set; }
        public uint Experience { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PhysicalBonus = parser.ReadColumn< sbyte >( 0 );
            MentalBonus = parser.ReadColumn< sbyte >( 1 );
            TacticalBonus = parser.ReadColumn< sbyte >( 2 );
            Experience = parser.ReadColumn< uint >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
            Description = parser.ReadColumn< SeString >( 5 );
        }
    }
}