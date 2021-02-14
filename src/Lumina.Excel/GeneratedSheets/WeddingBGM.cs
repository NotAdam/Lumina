// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeddingBGM", columnHash: 0x3d65a9f1 )]
    public class WeddingBGM : ExcelRow
    {
        
        public LazyRow< BGM > Song;
        public SeString SongName;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Song = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            SongName = parser.ReadColumn< SeString >( 1 );
        }
    }
}