// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbilityType", columnHash: 0xcd4cb81c )]
    public partial class ChocoboRaceAbilityType : ExcelRow
    {
        
        public bool IsActive { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IsActive = parser.ReadColumn< bool >( 0 );
        }
    }
}