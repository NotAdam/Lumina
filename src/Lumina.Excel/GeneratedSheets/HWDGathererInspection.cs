// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspection", columnHash: 0xad239733 )]
    public partial class HWDGathererInspection : ExcelRow
    {
        
        public LazyRow< GatheringItem >[] ItemRequired { get; set; }
        public LazyRow< FishParameter >[] FishParameter { get; set; }
        public byte[] AmountRequired { get; set; }
        public LazyRow< Item >[] ItemReceived { get; set; }
        public LazyRow< HWDGathererInspectionReward >[] Reward1 { get; set; }
        public LazyRow< HWDGathererInspectionReward >[] Reward2 { get; set; }
        public LazyRow< HWDGathereInspectTerm >[] Phase { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemRequired = new LazyRow< GatheringItem >[ 79 ];
            for( var i = 0; i < 79; i++ )
                ItemRequired[ i ] = new LazyRow< GatheringItem >( gameData, parser.ReadColumn< uint >( 0 + i ), language );
            FishParameter = new LazyRow< FishParameter >[ 79 ];
            for( var i = 0; i < 79; i++ )
                FishParameter[ i ] = new LazyRow< FishParameter >( gameData, parser.ReadColumn< uint >( 79 + i ), language );
            AmountRequired = new byte[ 79 ];
            for( var i = 0; i < 79; i++ )
                AmountRequired[ i ] = parser.ReadColumn< byte >( 158 + i );
            ItemReceived = new LazyRow< Item >[ 79 ];
            for( var i = 0; i < 79; i++ )
                ItemReceived[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 237 + i ), language );
            Reward1 = new LazyRow< HWDGathererInspectionReward >[ 79 ];
            for( var i = 0; i < 79; i++ )
                Reward1[ i ] = new LazyRow< HWDGathererInspectionReward >( gameData, parser.ReadColumn< ushort >( 316 + i ), language );
            Reward2 = new LazyRow< HWDGathererInspectionReward >[ 79 ];
            for( var i = 0; i < 79; i++ )
                Reward2[ i ] = new LazyRow< HWDGathererInspectionReward >( gameData, parser.ReadColumn< ushort >( 395 + i ), language );
            Phase = new LazyRow< HWDGathereInspectTerm >[ 79 ];
            for( var i = 0; i < 79; i++ )
                Phase[ i ] = new LazyRow< HWDGathereInspectTerm >( gameData, parser.ReadColumn< byte >( 474 + i ), language );
        }
    }
}