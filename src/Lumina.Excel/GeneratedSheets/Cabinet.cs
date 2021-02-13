// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Cabinet", columnHash: 0x200261d8 )]
    public class Cabinet : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public ushort Order;
        public LazyRow< CabinetCategory > Category;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Order = parser.ReadColumn< ushort >( 1 );
            Category = new LazyRow< CabinetCategory >( lumina, parser.ReadColumn< byte >( 2 ), language );
        }
    }
}