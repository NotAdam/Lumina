// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WebGuidance", columnHash: 0xa6cfe561 )]
    public partial class WebGuidance : ExcelRow
    {
        
        public int Image { get; set; }
        public LazyRow< WebURL > Url { get; set; }
        public SeString Name { get; set; }
        public SeString Unknown3 { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
            Url = new LazyRow< WebURL >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Name = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
            Description = parser.ReadColumn< SeString >( 4 );
        }
    }
}