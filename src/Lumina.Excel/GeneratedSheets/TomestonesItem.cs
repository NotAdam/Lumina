// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TomestonesItem", columnHash: 0xc8901190 )]
    public class TomestonesItem : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public sbyte Unknown1;
        public LazyRow< Tomestones > Tomestones;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Tomestones = new LazyRow< Tomestones >( lumina, parser.ReadColumn< int >( 2 ), language );
        }
    }
}