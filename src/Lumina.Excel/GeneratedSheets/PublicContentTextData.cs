// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentTextData", columnHash: 0xdebb20e3 )]
    public class PublicContentTextData : IExcelRow
    {
        
        public SeString TextData;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            TextData = parser.ReadColumn< SeString >( 0 );
        }
    }
}