// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticle", columnHash: 0x76cb5660 )]
    public partial class HWDInfoBoardArticle : ExcelRow
    {
        
        public LazyRow< HWDInfoBoardArticleType > Type { get; set; }
        public byte Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = new LazyRow< HWDInfoBoardArticleType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Text = parser.ReadColumn< SeString >( 4 );
        }
    }
}