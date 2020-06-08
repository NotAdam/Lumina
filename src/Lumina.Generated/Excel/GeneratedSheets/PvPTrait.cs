using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPTrait", columnHash: 0xdc23efe7 )]
    public class PvPTrait : IExcelRow
    {
        
        public LazyRow< Trait > Trait1;
        public LazyRow< Trait > Trait2;
        public LazyRow< Trait > Trait3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Trait1 = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 0 ) );
            Trait2 = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 1 ) );
            Trait3 = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 2 ) );
        }
    }
}