// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeddingBGM", columnHash: 0x3d65a9f1 )]
    public partial class WeddingBGM : ExcelRow
    {
        
        public LazyRow< BGM > Song { get; set; }
        public SeString SongName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Song = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            SongName = parser.ReadColumn< SeString >( 1 );
        }
    }
}