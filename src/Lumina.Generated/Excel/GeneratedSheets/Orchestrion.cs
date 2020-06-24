using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Orchestrion", columnHash: 0x9db0e48f )]
    public class Orchestrion : IExcelRow
    {
        
        public string Name;
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
        }
    }
}