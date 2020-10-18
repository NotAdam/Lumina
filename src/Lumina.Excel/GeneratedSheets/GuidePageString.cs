// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePageString", columnHash: 0xdebb20e3 )]
    public class GuidePageString : IExcelRow
    {
        
        public SeString String;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            String = parser.ReadColumn< SeString >( 0 );
        }
    }
}