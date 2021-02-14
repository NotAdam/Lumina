// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentTalk", columnHash: 0x5eb59ccb )]
    public class ContentTalk : ExcelRow
    {
        
        public LazyRow< ContentTalkParam > ContentTalkParam;
        public SeString Text;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ContentTalkParam = new LazyRow< ContentTalkParam >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Text = parser.ReadColumn< SeString >( 1 );
        }
    }
}