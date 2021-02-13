// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CabinetCategory", columnHash: 0xc6207018 )]
    public class CabinetCategory : ExcelRow
    {
        
        public byte MenuOrder;
        public int Icon;
        public LazyRow< Addon > Category;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            MenuOrder = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< Addon >( lumina, parser.ReadColumn< int >( 2 ), language );
        }
    }
}