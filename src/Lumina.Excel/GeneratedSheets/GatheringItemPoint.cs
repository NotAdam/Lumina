// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemPoint", columnHash: 0xdbf43666 )]
    public class GatheringItemPoint : ExcelRow
    {
        
        public LazyRow< GatheringPoint > GatheringPoint;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            GatheringPoint = new LazyRow< GatheringPoint >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}