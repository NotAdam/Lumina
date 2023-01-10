// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerDesignPreset", columnHash: 0xfccd960d )]
    public partial class BannerDesignPreset : ExcelRow
    {
        
        public LazyRow< BannerBg > Background { get; set; }
        public LazyRow< BannerFrame > Frame { get; set; }
        public LazyRow< BannerDecoration > Decoration { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Background = new LazyRow< BannerBg >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Frame = new LazyRow< BannerFrame >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Decoration = new LazyRow< BannerDecoration >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            SortKey = parser.ReadColumn< ushort >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
        }
    }
}