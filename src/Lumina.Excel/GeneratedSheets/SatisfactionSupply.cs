// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionSupply", columnHash: 0x2d608ea2 )]
    public class SatisfactionSupply : ExcelRow
    {
        
        public byte Slot;
        public byte ProbabilityPct;
        public LazyRow< Item > Item;
        public ushort CollectabilityLow;
        public ushort CollectabilityMid;
        public ushort CollectabilityHigh;
        public LazyRow< SatisfactionSupplyReward > Reward;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Slot = parser.ReadColumn< byte >( 0 );
            ProbabilityPct = parser.ReadColumn< byte >( 1 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 2 ), language );
            CollectabilityLow = parser.ReadColumn< ushort >( 3 );
            CollectabilityMid = parser.ReadColumn< ushort >( 4 );
            CollectabilityHigh = parser.ReadColumn< ushort >( 5 );
            Reward = new LazyRow< SatisfactionSupplyReward >( lumina, parser.ReadColumn< ushort >( 6 ), language );
        }
    }
}