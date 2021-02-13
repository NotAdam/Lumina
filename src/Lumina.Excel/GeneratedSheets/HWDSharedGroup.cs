// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroup", columnHash: 0x5a516458 )]
    public class HWDSharedGroup : ExcelRow
    {
        
        public uint LGB;
        public LazyRow< HWDSharedGroupControlParam > Param;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            LGB = parser.ReadColumn< uint >( 0 );
            Param = new LazyRow< HWDSharedGroupControlParam >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}