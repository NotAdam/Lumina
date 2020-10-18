// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnContent", columnHash: 0x5d58cc84 )]
    public class DawnContent : IExcelRow
    {
        
        public LazyRow< ContentFinderCondition > Content;
        public uint Exp;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Content = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Exp = parser.ReadColumn< uint >( 1 );
        }
    }
}