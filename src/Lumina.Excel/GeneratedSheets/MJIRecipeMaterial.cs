// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIRecipeMaterial", columnHash: 0xfaedad07 )]
    public partial class MJIRecipeMaterial : ExcelRow
    {
        
        public LazyRow< MJIItemPouch > ItemPouch { get; set; }
        public int Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemPouch = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< int >( 1 );
        }
    }
}