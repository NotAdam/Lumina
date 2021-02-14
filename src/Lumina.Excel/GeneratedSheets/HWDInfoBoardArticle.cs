// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticle", columnHash: 0x76cb5660 )]
    public class HWDInfoBoardArticle : ExcelRow
    {
        
        public LazyRow< HWDInfoBoardArticleType > Type;
        public byte Unknown1;
        public ushort Unknown2;
        public bool Unknown3;
        public SeString Text;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = new LazyRow< HWDInfoBoardArticleType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Text = parser.ReadColumn< SeString >( 4 );
        }
    }
}