// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeddingBGM", columnHash: 0x3d65a9f1 )]
    public class WeddingBGM : IExcelRow
    {
        
        public LazyRow< BGM > Song;
        public SeString SongName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Song = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            SongName = parser.ReadColumn< SeString >( 1 );
        }
    }
}