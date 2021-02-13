// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDLevelChangeDeception", columnHash: 0xda365c51 )]
    public class HWDLevelChangeDeception : ExcelRow
    {
        
        public LazyRow< ScreenImage > Image;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Image = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}