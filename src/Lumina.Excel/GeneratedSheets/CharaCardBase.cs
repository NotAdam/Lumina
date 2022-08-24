// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardBase", columnHash: 0x2e632858 )]
    public partial class CharaCardBase : ExcelRow
    {
        
        public int Image { get; set; }
        public byte FontColor { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
            FontColor = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            SortKey = parser.ReadColumn< ushort >( 6 );
            Name = parser.ReadColumn< SeString >( 7 );
        }
    }
}