// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryTypeTransient", columnHash: 0xd9b2883f )]
    public partial class TerritoryTypeTransient : ExcelRow
    {
        
        public short OffsetZ { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            OffsetZ = parser.ReadColumn< short >( 0 );
        }
    }
}