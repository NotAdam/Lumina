// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardDecoration", columnHash: 0x77521ea8 )]
    public partial class CharaCardDecoration : ExcelRow
    {
        
        public byte Category { get; set; }
        public int Image { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = parser.ReadColumn< byte >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            SortKey = parser.ReadColumn< ushort >( 4 );
            Name = parser.ReadColumn< SeString >( 5 );
        }
    }
}