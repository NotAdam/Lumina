// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbilityType", columnHash: 0xcd4cb81c )]
    public class ChocoboRaceAbilityType : ExcelRow
    {
        
        public bool IsActive;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            IsActive = parser.ReadColumn< bool >( 0 );
        }
    }
}