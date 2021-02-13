// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateTokenType", columnHash: 0xdbf43666 )]
    public class FateTokenType : ExcelRow
    {
        
        public LazyRow< Item > Currency;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Currency = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}