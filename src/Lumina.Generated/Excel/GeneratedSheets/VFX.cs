using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VFX", columnHash: 0xdebb20e3 )]
    public class VFX : IExcelRow
    {
        
        public string Location;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Location = parser.ReadColumn< string >( 0 );
        }
    }
}