// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeNotebookList", columnHash: 0xa067051f )]
    public class RecipeNotebookList : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< Recipe >[] Recipe;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Recipe = new LazyRow< Recipe >[ 160 ];
            for( var i = 0; i < 160; i++ )
                Recipe[ i ] = new LazyRow< Recipe >( lumina, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}