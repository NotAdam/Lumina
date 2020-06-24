using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionPath", columnHash: 0xdebb20e3 )]
    public class OrchestrionPath : IExcelRow
    {
        
        public string File;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            File = parser.ReadColumn< string >( 0 );
        }
    }
}