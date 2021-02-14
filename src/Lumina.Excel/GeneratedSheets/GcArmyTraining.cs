// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyTraining", columnHash: 0x274780bb )]
    public class GcArmyTraining : ExcelRow
    {
        
        public sbyte PhysicalBonus;
        public sbyte MentalBonus;
        public sbyte TacticalBonus;
        public uint Experience;
        public SeString Name;
        public SeString Description;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            PhysicalBonus = parser.ReadColumn< sbyte >( 0 );
            MentalBonus = parser.ReadColumn< sbyte >( 1 );
            TacticalBonus = parser.ReadColumn< sbyte >( 2 );
            Experience = parser.ReadColumn< uint >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
            Description = parser.ReadColumn< SeString >( 5 );
        }
    }
}