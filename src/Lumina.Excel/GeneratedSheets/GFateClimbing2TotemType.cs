// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateClimbing2TotemType", columnHash: 0xdbf43666 )]
    public class GFateClimbing2TotemType : ExcelRow
    {
        
        public LazyRow< PublicContentTextData > PublicContentTextData;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            PublicContentTextData = new LazyRow< PublicContentTextData >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}