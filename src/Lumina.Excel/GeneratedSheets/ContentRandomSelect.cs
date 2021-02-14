// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRandomSelect", columnHash: 0xd870e208 )]
    public class ContentRandomSelect : ExcelRow
    {
        
        public LazyRow< ContentFinderCondition > Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}