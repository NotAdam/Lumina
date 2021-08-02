// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionSupplyReward", columnHash: 0xc81395f9 )]
    public partial class SatisfactionSupplyReward : ExcelRow
    {
        public class SatisfactionSupplyRewardUnkData1Obj
        {
            public ushort RewardCurrency { get; set; }
            public ushort QuantityLow { get; set; }
            public ushort QuantityMid { get; set; }
            public ushort QuantityHigh { get; set; }
        }
        
        public byte Unknown0 { get; set; }
        public SatisfactionSupplyRewardUnkData1Obj[] UnkData1 { get; set; }
        public byte Unknown9 { get; set; }
        public ushort SatisfactionLow { get; set; }
        public ushort SatisfactionMid { get; set; }
        public ushort SatisfactionHigh { get; set; }
        public ushort GilLow { get; set; }
        public ushort GilMid { get; set; }
        public ushort GilHigh { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            UnkData1 = new SatisfactionSupplyRewardUnkData1Obj[ 2 ];
            for( var i = 0; i < 2; i++ )
            {
                UnkData1[ i ] = new SatisfactionSupplyRewardUnkData1Obj();
                UnkData1[ i ].RewardCurrency = parser.ReadColumn< ushort >( 1 + ( i * 4 + 0 ) );
                UnkData1[ i ].QuantityLow = parser.ReadColumn< ushort >( 1 + ( i * 4 + 1 ) );
                UnkData1[ i ].QuantityMid = parser.ReadColumn< ushort >( 1 + ( i * 4 + 2 ) );
                UnkData1[ i ].QuantityHigh = parser.ReadColumn< ushort >( 1 + ( i * 4 + 3 ) );
            }
            Unknown9 = parser.ReadColumn< byte >( 9 );
            SatisfactionLow = parser.ReadColumn< ushort >( 10 );
            SatisfactionMid = parser.ReadColumn< ushort >( 11 );
            SatisfactionHigh = parser.ReadColumn< ushort >( 12 );
            GilLow = parser.ReadColumn< ushort >( 13 );
            GilMid = parser.ReadColumn< ushort >( 14 );
            GilHigh = parser.ReadColumn< ushort >( 15 );
        }
    }
}