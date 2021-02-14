// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TraitRecast", columnHash: 0xdc23efe7 )]
    public class TraitRecast : ExcelRow
    {
        
        public LazyRow< Trait > Trait;
        public LazyRow< Action > Action;
        public ushort Timeds;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Trait = new LazyRow< Trait >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Timeds = parser.ReadColumn< ushort >( 2 );
        }
    }
}