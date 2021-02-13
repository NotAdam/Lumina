// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSearchCategory", columnHash: 0xeffa5b93 )]
    public class ItemSearchCategory : ExcelRow
    {
        
        public SeString Name;
        public int Icon;
        public byte Category;
        public byte Order;
        public LazyRow< ClassJob > ClassJob;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Category = parser.ReadColumn< byte >( 2 );
            Order = parser.ReadColumn< byte >( 3 );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< sbyte >( 4 ), language );
        }
    }
}