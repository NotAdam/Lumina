// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleTransient", columnHash: 0x11a44a12 )]
    public partial class HWDInfoBoardArticleTransient : ExcelRow
    {
        
        public uint Image { get; set; }
        public SeString Text { get; set; }
        public SeString NpcName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< uint >( 0 );
            Text = parser.ReadColumn< SeString >( 1 );
            NpcName = parser.ReadColumn< SeString >( 2 );
        }
    }
}