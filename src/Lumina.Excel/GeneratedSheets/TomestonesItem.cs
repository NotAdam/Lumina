// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TomestonesItem", columnHash: 0xc8901190 )]
    public class TomestonesItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public sbyte Unknown1;
        public LazyRow< Tomestones > Tomestones;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Tomestones = new LazyRow< Tomestones >( lumina, parser.ReadColumn< int >( 2 ), language );
        }
    }
}