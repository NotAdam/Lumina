// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TraitRecast", columnHash: 0xdc23efe7 )]
    public class TraitRecast : IExcelRow
    {
        
        public LazyRow< Trait > Trait;
        public LazyRow< Action > Action;
        public ushort Timeds;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Trait = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Timeds = parser.ReadColumn< ushort >( 2 );
        }
    }
}