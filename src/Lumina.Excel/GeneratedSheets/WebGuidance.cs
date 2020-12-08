// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WebGuidance", columnHash: 0xa6cfe561 )]
    public class WebGuidance : IExcelRow
    {
        
        public int Image;
        public LazyRow< WebURL > Url;
        public SeString Name;
        public SeString Unknown54;
        public SeString Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Image = parser.ReadColumn< int >( 0 );
            Url = new LazyRow< WebURL >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Name = parser.ReadColumn< SeString >( 2 );
            Unknown54 = parser.ReadColumn< SeString >( 3 );
            Description = parser.ReadColumn< SeString >( 4 );
        }
    }
}