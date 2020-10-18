// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbility", columnHash: 0xc68f9e95 )]
    public class ChocoboRaceAbility : IExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public uint Icon;
        public LazyRow< ChocoboRaceAbilityType > ChocoboRaceAbilityType;
        public byte Value;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            ChocoboRaceAbilityType = new LazyRow< ChocoboRaceAbilityType >( lumina, parser.ReadColumn< sbyte >( 3 ), language );
            Value = parser.ReadColumn< byte >( 4 );
        }
    }
}