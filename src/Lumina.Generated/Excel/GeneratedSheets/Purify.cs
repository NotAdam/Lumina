using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Purify", columnHash: 0xde74b4c4 )]
    public class Purify : IExcelRow
    {
        
        public LazyRow< ClassJob > Class;
        public byte Level;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Class = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 0 ) );
            Level = parser.ReadColumn< byte >( 1 );
        }
    }
}