// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDFishParam", columnHash: 0x1b55da98 )]
    public class IKDFishParam : ExcelRow
    {
        
        public LazyRow< FishParameter > Fish;
        public LazyRow< IKDContentBonus > IKDContentBonus;
        public byte Unknown54;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Fish = new LazyRow< FishParameter >( lumina, parser.ReadColumn< uint >( 0 ), language );
            IKDContentBonus = new LazyRow< IKDContentBonus >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Unknown54 = parser.ReadColumn< byte >( 2 );
        }
    }
}