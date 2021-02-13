// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5Param", columnHash: 0x5eb59ccb )]
    public class AnimaWeapon5Param : ExcelRow
    {
        
        public LazyRow< BaseParam > BaseParam;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            BaseParam = new LazyRow< BaseParam >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}