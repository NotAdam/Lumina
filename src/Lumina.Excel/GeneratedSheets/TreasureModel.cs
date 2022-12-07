// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureModel", columnHash: 0x5a05613d )]
    public partial class TreasureModel : ExcelRow
    {
        
        public SeString Path { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Path = parser.ReadColumn< SeString >( 0 );
        }
    }
}