using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MasterpieceSupplyDuty", columnHash: 0x63eafd84 )]
    public class MasterpieceSupplyDuty : IExcelRow
    {
        public struct UnkStruct3Struct
        {
            public uint RequiredItem;
            public byte Quantity;
            public bool RequestHq;
            public ushort CollectabilityHighBonus;
            public ushort CollectabilityBonus;
            public ushort CollectabilityBase;
            public ushort ExpModifier;
            public ushort RewardScrips;
            public byte BonusMultiplier;
            public ushort ClassJobLevelMax;
            public byte Stars;
        }
        
        public LazyRow< ClassJob > ClassJob;
        public byte ClassJobLevel;
        public LazyRow< Currency > RewardCurrency;
        public UnkStruct3Struct[] UnkStruct3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 0 ) );
            ClassJobLevel = parser.ReadColumn< byte >( 1 );
            RewardCurrency = new LazyRow< Currency >( lumina, parser.ReadColumn< ushort >( 2 ) );
            for( var i = 0; i < 8; i++ )
            {
                UnkStruct3[ i ] = new UnkStruct3Struct();
                UnkStruct3[ i ].RequiredItem = parser.ReadColumn< uint >( 3 + ( i * 8 + 0 ) );
                UnkStruct3[ i ].Quantity = parser.ReadColumn< byte >( 3 + ( i * 8 + 1 ) );
                UnkStruct3[ i ].RequestHq = parser.ReadColumn< bool >( 3 + ( i * 8 + 2 ) );
                UnkStruct3[ i ].CollectabilityHighBonus = parser.ReadColumn< ushort >( 3 + ( i * 8 + 3 ) );
                UnkStruct3[ i ].CollectabilityBonus = parser.ReadColumn< ushort >( 3 + ( i * 8 + 4 ) );
                UnkStruct3[ i ].CollectabilityBase = parser.ReadColumn< ushort >( 3 + ( i * 8 + 5 ) );
                UnkStruct3[ i ].ExpModifier = parser.ReadColumn< ushort >( 3 + ( i * 8 + 6 ) );
                UnkStruct3[ i ].RewardScrips = parser.ReadColumn< ushort >( 3 + ( i * 8 + 7 ) );
                UnkStruct3[ i ].BonusMultiplier = parser.ReadColumn< byte >( 3 + ( i * 8 + 8 ) );
                UnkStruct3[ i ].ClassJobLevelMax = parser.ReadColumn< ushort >( 3 + ( i * 8 + 9 ) );
                UnkStruct3[ i ].Stars = parser.ReadColumn< byte >( 3 + ( i * 8 + 10 ) );
            }
        }
    }
}