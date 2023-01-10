// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGathering", columnHash: 0xdcfd9eba )]
    public partial class MJIGathering : ExcelRow
    {
        
        public LazyRow< MJIGatheringObject > GatheringObject { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringObject = new LazyRow< MJIGatheringObject >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}