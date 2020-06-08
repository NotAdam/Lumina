using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionSupplyReward", columnHash: 0xc81395f9 )]
    public class SatisfactionSupplyReward : IExcelRow
    {
        public struct UnkStruct1Struct
        {
            public ushort RewardCurrency;
            public ushort QuantityLow;
            public ushort QuantityMid;
            public ushort QuantityHigh;
        }
        
        public byte Unknown0;
        public UnkStruct1Struct[] UnkStruct1;
        public byte Unknown9;
        public ushort SatisfactionLow;
        public ushort SatisfactionMid;
        public ushort SatisfactionHigh;
        public ushort GilLow;
        public ushort GilMid;
        public ushort GilHigh;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            for( var i = 0; i < 2; i++ )
            {
                UnkStruct1[ i ] = new UnkStruct1Struct();
                UnkStruct1[ i ].RewardCurrency = parser.ReadColumn< ushort >( 1 + ( i * 2 + 0 ) );
                UnkStruct1[ i ].QuantityLow = parser.ReadColumn< ushort >( 1 + ( i * 2 + 1 ) );
                UnkStruct1[ i ].QuantityMid = parser.ReadColumn< ushort >( 1 + ( i * 2 + 2 ) );
                UnkStruct1[ i ].QuantityHigh = parser.ReadColumn< ushort >( 1 + ( i * 2 + 3 ) );
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