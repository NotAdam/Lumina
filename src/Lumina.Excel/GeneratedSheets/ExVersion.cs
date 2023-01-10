// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExVersion", columnHash: 0xcc3ad729 )]
    public partial class ExVersion : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< ScreenImage > AcceptJingle { get; set; }
        public LazyRow< ScreenImage > CompleteJingle { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            AcceptJingle = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            CompleteJingle = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}