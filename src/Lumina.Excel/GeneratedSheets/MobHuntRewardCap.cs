// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntRewardCap", columnHash: 0x2202a89f )]
    public partial class MobHuntRewardCap : ExcelRow
    {
        
        public uint ExpCap { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ExpCap = parser.ReadColumn< uint >( 0 );
        }
    }
}