using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContentTextData", columnHash: 0xdebb20e3 )]
    public class PartyContentTextData : IExcelRow
    {
        
        public string Data;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Data = parser.ReadColumn< string >( 0 );
        }
    }
}