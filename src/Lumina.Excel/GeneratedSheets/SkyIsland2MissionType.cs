// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionType", columnHash: 0x3e6ec9fd )]
    public partial class SkyIsland2MissionType : ExcelRow
    {
        
        public bool Type { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< bool >( 0 );
        }
    }
}