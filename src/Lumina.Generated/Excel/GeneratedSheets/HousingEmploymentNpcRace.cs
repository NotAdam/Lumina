using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingEmploymentNpcRace", columnHash: 0xdebb20e3 )]
    public class HousingEmploymentNpcRace : IExcelRow
    {
        
        public string Race;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Race = parser.ReadColumn< string >( 0 );
        }
    }
}