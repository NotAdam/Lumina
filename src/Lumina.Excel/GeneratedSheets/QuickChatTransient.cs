// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChatTransient", columnHash: 0xdebb20e3 )]
    public class QuickChatTransient : IExcelRow
    {
        
        public SeString TextOutput;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            TextOutput = parser.ReadColumn< SeString >( 0 );
        }
    }
}