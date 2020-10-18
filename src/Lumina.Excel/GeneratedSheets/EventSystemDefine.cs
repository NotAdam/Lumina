// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventSystemDefine", columnHash: 0x98fff20a )]
    public class EventSystemDefine : IExcelRow
    {
        
        public SeString Text;
        public uint DefineValue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Text = parser.ReadColumn< SeString >( 0 );
            DefineValue = parser.ReadColumn< uint >( 1 );
        }
    }
}