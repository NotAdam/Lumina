// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbility", columnHash: 0xc68f9e95 )]
    public partial class ChocoboRaceAbility : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public uint Icon { get; set; }
        public LazyRow< ChocoboRaceAbilityType > ChocoboRaceAbilityType { get; set; }
        public byte Value { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            ChocoboRaceAbilityType = new LazyRow< ChocoboRaceAbilityType >( gameData, parser.ReadColumn< sbyte >( 3 ), language );
            Value = parser.ReadColumn< byte >( 4 );
        }
    }
}