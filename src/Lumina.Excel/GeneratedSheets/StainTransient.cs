// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StainTransient", columnHash: 0x5d58cc84 )]
    public class StainTransient : ExcelRow
    {
        
        public LazyRow< Item > Item1;
        public LazyRow< Item > Item2;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item1 = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Item2 = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ), language );
        }
    }
}