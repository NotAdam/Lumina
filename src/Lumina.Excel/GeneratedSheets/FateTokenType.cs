// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateTokenType", columnHash: 0xdbf43666 )]
    public class FateTokenType : IExcelRow
    {
        
        public LazyRow< Item > Currency;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Currency = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}