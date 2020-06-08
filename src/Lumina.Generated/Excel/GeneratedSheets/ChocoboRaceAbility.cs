using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbility", columnHash: 0xc68f9e95 )]
    public class ChocoboRaceAbility : IExcelRow
    {
        
        public string Name;
        public string Description;
        public uint Icon;
        public LazyRow< ChocoboRaceAbilityType > ChocoboRaceAbilityType;
        public byte Value;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            ChocoboRaceAbilityType = new LazyRow< ChocoboRaceAbilityType >( lumina, parser.ReadColumn< sbyte >( 3 ) );
            Value = parser.ReadColumn< byte >( 4 );
        }
    }
}