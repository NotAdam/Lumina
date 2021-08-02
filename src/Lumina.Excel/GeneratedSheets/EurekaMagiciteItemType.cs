// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiciteItemType", columnHash: 0xdebb20e3 )]
    public partial class EurekaMagiciteItemType : ExcelRow
    {
        
        public SeString Type { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< SeString >( 0 );
        }
    }
}