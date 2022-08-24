// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExportedSG", columnHash: 0xdebb20e3 )]
    public partial class ExportedSG : ExcelRow
    {
        
        public SeString SgbPath { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SgbPath = parser.ReadColumn< SeString >( 0 );
        }
    }
}