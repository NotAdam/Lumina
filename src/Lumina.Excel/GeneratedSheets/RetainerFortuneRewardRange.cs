// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerFortuneRewardRange", columnHash: 0xd870e208 )]
    public partial class RetainerFortuneRewardRange : ExcelRow
    {
        
        public ushort PercentOfLevel { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PercentOfLevel = parser.ReadColumn< ushort >( 0 );
        }
    }
}