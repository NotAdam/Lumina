// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspection", columnHash: 0xd65ee518 )]
    public class HWDGathererInspection : IExcelRow
    {
        
        public LazyRow< GatheringItem >[] ItemRequired;
        public LazyRow< FishParameter >[] FishParameter;
        public byte[] AmountRequired;
        public LazyRow< Item >[] ItemReceived;
        public LazyRow< HWDGathererInspectionReward >[] Reward1;
        public LazyRow< HWDGathererInspectionReward >[] Reward2;
        public LazyRow< HWDGathereInspectTerm >[] Phase;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemRequired = new LazyRow< GatheringItem >[ 53 ];
            for( var i = 0; i < 53; i++ )
                ItemRequired[ i ] = new LazyRow< GatheringItem >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
            FishParameter = new LazyRow< FishParameter >[ 53 ];
            for( var i = 0; i < 53; i++ )
                FishParameter[ i ] = new LazyRow< FishParameter >( lumina, parser.ReadColumn< uint >( 53 + i ), language );
            AmountRequired = new byte[ 53 ];
            for( var i = 0; i < 53; i++ )
                AmountRequired[ i ] = parser.ReadColumn< byte >( 106 + i );
            ItemReceived = new LazyRow< Item >[ 53 ];
            for( var i = 0; i < 53; i++ )
                ItemReceived[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 159 + i ), language );
            Reward1 = new LazyRow< HWDGathererInspectionReward >[ 53 ];
            for( var i = 0; i < 53; i++ )
                Reward1[ i ] = new LazyRow< HWDGathererInspectionReward >( lumina, parser.ReadColumn< ushort >( 212 + i ), language );
            Reward2 = new LazyRow< HWDGathererInspectionReward >[ 53 ];
            for( var i = 0; i < 53; i++ )
                Reward2[ i ] = new LazyRow< HWDGathererInspectionReward >( lumina, parser.ReadColumn< ushort >( 265 + i ), language );
            Phase = new LazyRow< HWDGathereInspectTerm >[ 53 ];
            for( var i = 0; i < 53; i++ )
                Phase[ i ] = new LazyRow< HWDGathereInspectTerm >( lumina, parser.ReadColumn< byte >( 318 + i ), language );
        }
    }
}