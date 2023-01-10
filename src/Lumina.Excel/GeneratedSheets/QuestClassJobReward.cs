// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobReward", columnHash: 0x3d96093f )]
    public partial class QuestClassJobReward : ExcelRow
    {
        
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public LazyRow< Item >[] RewardItem { get; set; }
        public byte[] RewardAmount { get; set; }
        public LazyRow< Item >[] RequiredItem { get; set; }
        public byte[] RequiredAmount { get; set; }
        public bool Unknown17 { get; set; }
        public bool Unknown18 { get; set; }
        public bool Unknown19 { get; set; }
        public bool Unknown20 { get; set; }
        public bool Unknown21 { get; set; }
        public bool Unknown22 { get; set; }
        public bool Unknown23 { get; set; }
        public bool Unknown24 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            RewardItem = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                RewardItem[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 + i ), language );
            RewardAmount = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                RewardAmount[ i ] = parser.ReadColumn< byte >( 5 + i );
            RequiredItem = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                RequiredItem[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 9 + i ), language );
            RequiredAmount = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                RequiredAmount[ i ] = parser.ReadColumn< byte >( 13 + i );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< bool >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
        }
    }
}