// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemPoint", columnHash: 0xdbf43666 )]
    public partial class GatheringItemPoint : ExcelRow
    {
        
        public LazyRow< GatheringPoint > GatheringPoint { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringPoint = new LazyRow< GatheringPoint >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}