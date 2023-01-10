// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsTutorialPage", columnHash: 0x0c8db36c )]
    public partial class ContentsTutorialPage : ExcelRow
    {
        
        public int Image { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
        }
    }
}