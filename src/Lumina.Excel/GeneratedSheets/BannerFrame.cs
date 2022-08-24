// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerFrame", columnHash: 0x1c6c81a1 )]
    public partial class BannerFrame : ExcelRow
    {
        
        public int Image { get; set; }
        public int Icon { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            SortKey = parser.ReadColumn< ushort >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
        }
    }
}