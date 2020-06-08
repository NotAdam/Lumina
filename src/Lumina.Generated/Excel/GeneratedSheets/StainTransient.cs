using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StainTransient", columnHash: 0x5d58cc84 )]
    public class StainTransient : IExcelRow
    {
        
        public LazyRow< Item > Item1;
        public LazyRow< Item > Item2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item1 = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ) );
            Item2 = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ) );
        }
    }
}