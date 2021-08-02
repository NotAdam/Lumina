// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeNotebookList", columnHash: 0xa067051f )]
    public partial class RecipeNotebookList : ExcelRow
    {
        
        public byte Count { get; set; }
        public LazyRow< Recipe >[] Recipe { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Count = parser.ReadColumn< byte >( 0 );
            Recipe = new LazyRow< Recipe >[ 160 ];
            for( var i = 0; i < 160; i++ )
                Recipe[ i ] = new LazyRow< Recipe >( gameData, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}