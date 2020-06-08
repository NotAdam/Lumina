using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MinionRules", columnHash: 0x9db0e48f )]
    public class MinionRules : IExcelRow
    {
        
        public string Rule;
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Rule = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
        }
    }
}