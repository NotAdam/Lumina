// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Guide", columnHash: 0x2020acf6 )]
    public class Guide : ExcelRow
    {
        
        public LazyRow< GuideTitle > GuideTitle;
        public LazyRow< GuidePage > GuidePage;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            GuideTitle = new LazyRow< GuideTitle >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            GuidePage = new LazyRow< GuidePage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}