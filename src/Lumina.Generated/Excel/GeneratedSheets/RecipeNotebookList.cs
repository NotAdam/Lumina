using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeNotebookList", columnHash: 0x598ed482 )]
    public class RecipeNotebookList : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< Recipe >[] Recipe;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Recipe = new LazyRow< Recipe >[ 160 ];
            for( var i = 0; i < 160; i++ )
                Recipe[ i ] = new LazyRow< Recipe >( lumina, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}