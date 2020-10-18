// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExVersion", columnHash: 0xcc3ad729 )]
    public class ExVersion : IExcelRow
    {
        
        public SeString Name;
        public LazyRow< ScreenImage > AcceptJingle;
        public LazyRow< ScreenImage > CompleteJingle;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            AcceptJingle = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            CompleteJingle = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}