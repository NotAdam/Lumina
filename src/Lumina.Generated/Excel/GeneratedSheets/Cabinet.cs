using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Cabinet", columnHash: 0x200261d8 )]
    public class Cabinet : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public ushort Order;
        public LazyRow< CabinetCategory > Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            Order = parser.ReadColumn< ushort >( 1 );
            Category = new LazyRow< CabinetCategory >( lumina, parser.ReadColumn< byte >( 2 ) );
        }
    }
}