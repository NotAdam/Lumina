// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointTransient", columnHash: 0x7164626b )]
    public partial class GatheringPointTransient : ExcelRow
    {
        
        public ushort EphemeralStartTime { get; set; }
        public ushort EphemeralEndTime { get; set; }
        public LazyRow< GatheringRarePopTimeTable > GatheringRarePopTimeTable { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EphemeralStartTime = parser.ReadColumn< ushort >( 0 );
            EphemeralEndTime = parser.ReadColumn< ushort >( 1 );
            GatheringRarePopTimeTable = new LazyRow< GatheringRarePopTimeTable >( gameData, parser.ReadColumn< int >( 2 ), language );
        }
    }
}