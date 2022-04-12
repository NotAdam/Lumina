// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionSupply", columnHash: 0x2d608ea2 )]
    public class SatisfactionSupply : ExcelRow
    {
        
        public byte Slot { get; set; }
        public byte ProbabilityPct { get; set; }
        public LazyRow< Item > Item { get; set; }
        public ushort CollectabilityLow { get; set; }
        public ushort CollectabilityMid { get; set; }
        public ushort CollectabilityHigh { get; set; }
        public LazyRow< SatisfactionSupplyReward > Reward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Slot = parser.ReadColumn< byte >( 0 );
            ProbabilityPct = parser.ReadColumn< byte >( 1 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 2 ), language );
            CollectabilityLow = parser.ReadColumn< ushort >( 3 );
            CollectabilityMid = parser.ReadColumn< ushort >( 4 );
            CollectabilityHigh = parser.ReadColumn< ushort >( 5 );
            Reward = new LazyRow< SatisfactionSupplyReward >( gameData, parser.ReadColumn< ushort >( 6 ), language );
        }
    }
}