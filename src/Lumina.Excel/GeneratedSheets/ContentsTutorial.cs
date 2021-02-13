// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsTutorial", columnHash: 0x85313f44 )]
    public class ContentsTutorial : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public LazyRow< ContentsTutorialPage >[] Page;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Page = new LazyRow< ContentsTutorialPage >[ 8 ];
            for( var i = 0; i < 8; i++ )
                Page[ i ] = new LazyRow< ContentsTutorialPage >( lumina, parser.ReadColumn< int >( 2 + i ), language );
        }
    }
}