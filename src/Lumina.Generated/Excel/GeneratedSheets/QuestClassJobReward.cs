using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobReward", columnHash: 0x1eed8c67 )]
    public class QuestClassJobReward : IExcelRow
    {
        
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public LazyRow< Item >[] RewardItem;
        public byte[] RewardAmount;
        public LazyRow< Item >[] RequiredItem;
        public byte[] RequiredAmount;
        public bool Unknown17;
        public bool Unknown18;
        public bool Unknown19;
        public bool Unknown20;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 0 ) );
            for( var i = 0; i < 4; i++ )
                RewardItem[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 + i ) );
            for( var i = 0; i < 4; i++ )
                RewardAmount[ i ] = parser.ReadColumn< byte >( 5 + i );
            for( var i = 0; i < 4; i++ )
                RequiredItem[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 9 + i ) );
            for( var i = 0; i < 4; i++ )
                RequiredAmount[ i ] = parser.ReadColumn< byte >( 13 + i );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
        }
    }
}