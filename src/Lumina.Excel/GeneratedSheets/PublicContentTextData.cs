// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentTextData", columnHash: 0xdebb20e3 )]
    public partial class PublicContentTextData : ExcelRow
    {
        
        public SeString TextData { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TextData = parser.ReadColumn< SeString >( 0 );
        }
    }
}