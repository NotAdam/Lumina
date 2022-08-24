// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDCrafterSupply", columnHash: 0xa04b4cc9 )]
    public partial class HWDCrafterSupply : ExcelRow
    {
        
        public LazyRow< Item >[] ItemTradeIn { get; set; }
        public byte[] Level { get; set; }
        public byte[] LevelMax { get; set; }
        public byte Unknown69 { get; set; }
        public byte Unknown70 { get; set; }
        public byte Unknown71 { get; set; }
        public byte Unknown72 { get; set; }
        public byte Unknown73 { get; set; }
        public byte Unknown74 { get; set; }
        public byte Unknown75 { get; set; }
        public byte Unknown76 { get; set; }
        public byte Unknown77 { get; set; }
        public byte Unknown78 { get; set; }
        public byte Unknown79 { get; set; }
        public byte Unknown80 { get; set; }
        public byte Unknown81 { get; set; }
        public byte Unknown82 { get; set; }
        public byte Unknown83 { get; set; }
        public byte Unknown84 { get; set; }
        public byte Unknown85 { get; set; }
        public byte Unknown86 { get; set; }
        public byte Unknown87 { get; set; }
        public byte Unknown88 { get; set; }
        public byte Unknown89 { get; set; }
        public byte Unknown90 { get; set; }
        public byte Unknown91 { get; set; }
        public ushort[] BaseCollectableRating { get; set; }
        public ushort[] MidCollectableRating { get; set; }
        public ushort[] HighCollectableRating { get; set; }
        public LazyRow< HWDCrafterSupplyReward >[] BaseCollectableReward { get; set; }
        public LazyRow< HWDCrafterSupplyReward >[] MidCollectableReward { get; set; }
        public LazyRow< HWDCrafterSupplyReward >[] HighCollectableReward { get; set; }
        public LazyRow< HWDCrafterSupplyReward >[] BaseCollectableRewardPostPhase { get; set; }
        public LazyRow< HWDCrafterSupplyReward >[] MidCollectableRewardPostPhase { get; set; }
        public LazyRow< HWDCrafterSupplyReward >[] HighCollectableRewardPostPhase { get; set; }
        public LazyRow< HWDCrafterSupplyTerm >[] TermName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemTradeIn = new LazyRow< Item >[ 23 ];
            for( var i = 0; i < 23; i++ )
                ItemTradeIn[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 + i ), language );
            Level = new byte[ 23 ];
            for( var i = 0; i < 23; i++ )
                Level[ i ] = parser.ReadColumn< byte >( 23 + i );
            LevelMax = new byte[ 23 ];
            for( var i = 0; i < 23; i++ )
                LevelMax[ i ] = parser.ReadColumn< byte >( 46 + i );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< byte >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
            Unknown72 = parser.ReadColumn< byte >( 72 );
            Unknown73 = parser.ReadColumn< byte >( 73 );
            Unknown74 = parser.ReadColumn< byte >( 74 );
            Unknown75 = parser.ReadColumn< byte >( 75 );
            Unknown76 = parser.ReadColumn< byte >( 76 );
            Unknown77 = parser.ReadColumn< byte >( 77 );
            Unknown78 = parser.ReadColumn< byte >( 78 );
            Unknown79 = parser.ReadColumn< byte >( 79 );
            Unknown80 = parser.ReadColumn< byte >( 80 );
            Unknown81 = parser.ReadColumn< byte >( 81 );
            Unknown82 = parser.ReadColumn< byte >( 82 );
            Unknown83 = parser.ReadColumn< byte >( 83 );
            Unknown84 = parser.ReadColumn< byte >( 84 );
            Unknown85 = parser.ReadColumn< byte >( 85 );
            Unknown86 = parser.ReadColumn< byte >( 86 );
            Unknown87 = parser.ReadColumn< byte >( 87 );
            Unknown88 = parser.ReadColumn< byte >( 88 );
            Unknown89 = parser.ReadColumn< byte >( 89 );
            Unknown90 = parser.ReadColumn< byte >( 90 );
            Unknown91 = parser.ReadColumn< byte >( 91 );
            BaseCollectableRating = new ushort[ 23 ];
            for( var i = 0; i < 23; i++ )
                BaseCollectableRating[ i ] = parser.ReadColumn< ushort >( 92 + i );
            MidCollectableRating = new ushort[ 23 ];
            for( var i = 0; i < 23; i++ )
                MidCollectableRating[ i ] = parser.ReadColumn< ushort >( 115 + i );
            HighCollectableRating = new ushort[ 23 ];
            for( var i = 0; i < 23; i++ )
                HighCollectableRating[ i ] = parser.ReadColumn< ushort >( 138 + i );
            BaseCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                BaseCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadColumn< ushort >( 161 + i ), language );
            MidCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                MidCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadColumn< ushort >( 184 + i ), language );
            HighCollectableReward = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                HighCollectableReward[ i ] = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadColumn< ushort >( 207 + i ), language );
            BaseCollectableRewardPostPhase = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                BaseCollectableRewardPostPhase[ i ] = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadColumn< ushort >( 230 + i ), language );
            MidCollectableRewardPostPhase = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                MidCollectableRewardPostPhase[ i ] = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadColumn< ushort >( 253 + i ), language );
            HighCollectableRewardPostPhase = new LazyRow< HWDCrafterSupplyReward >[ 23 ];
            for( var i = 0; i < 23; i++ )
                HighCollectableRewardPostPhase[ i ] = new LazyRow< HWDCrafterSupplyReward >( gameData, parser.ReadColumn< ushort >( 276 + i ), language );
            TermName = new LazyRow< HWDCrafterSupplyTerm >[ 23 ];
            for( var i = 0; i < 23; i++ )
                TermName[ i ] = new LazyRow< HWDCrafterSupplyTerm >( gameData, parser.ReadColumn< byte >( 299 + i ), language );
        }
    }
}