// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveString", columnHash: 0xdebb20e3 )]
    public partial class LeveString : ExcelRow
    {
        
        public SeString Objective { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Objective = parser.ReadColumn< SeString >( 0 );
        }
    }
}