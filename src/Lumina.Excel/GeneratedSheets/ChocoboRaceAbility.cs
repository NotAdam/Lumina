// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbility", columnHash: 0xc68f9e95 )]
    public class ChocoboRaceAbility : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public uint Icon;
        public LazyRow< ChocoboRaceAbilityType > ChocoboRaceAbilityType;
        public byte Value;
        

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