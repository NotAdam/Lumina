// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic3", columnHash: 0xeb3c566a )]
    public class Relic3 : ExcelRow
    {
        
        public LazyRow< Item > ItemAnimus;
        public LazyRow< Item > ItemScroll;
        public byte MateriaLimit;
        public LazyRow< Item > ItemNovus;
        public int Icon;
        public sbyte Unknown5;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ItemAnimus = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
            ItemScroll = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ), language );
            MateriaLimit = parser.ReadColumn< byte >( 2 );
            ItemNovus = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 3 ), language );
            Icon = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
        }
    }
}