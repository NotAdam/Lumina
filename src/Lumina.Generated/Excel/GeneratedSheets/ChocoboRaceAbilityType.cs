using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbilityType", columnHash: 0xcd4cb81c )]
    public class ChocoboRaceAbilityType : IExcelRow
    {
        
        public bool IsActive;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            IsActive = parser.ReadColumn< bool >( 0 );
        }
    }
}