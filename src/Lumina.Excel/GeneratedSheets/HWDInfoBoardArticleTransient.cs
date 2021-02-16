// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleTransient", columnHash: 0x11a44a12 )]
    public class HWDInfoBoardArticleTransient : ExcelRow
    {
        
        public uint Image;
        public SeString Text;
        public SeString NpcName;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< uint >( 0 );
            Text = parser.ReadColumn< SeString >( 1 );
            NpcName = parser.ReadColumn< SeString >( 2 );
        }
    }
}