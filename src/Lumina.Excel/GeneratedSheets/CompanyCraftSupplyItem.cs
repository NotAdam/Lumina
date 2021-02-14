// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftSupplyItem", columnHash: 0xdbf43666 )]
    public class CompanyCraftSupplyItem : ExcelRow
    {
        
        public LazyRow< Item > Item;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}