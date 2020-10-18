// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
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

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Trait1 = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Trait2 = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Trait3 = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}