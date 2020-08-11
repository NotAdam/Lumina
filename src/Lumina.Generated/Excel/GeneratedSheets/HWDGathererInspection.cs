// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspection", columnHash: 0xd65ee518 )]
    public class HWDGathererInspection : IExcelRow
    {
        
        public LazyRow< GatheringItem >[] ItemRequired;
        public uint Unknown52;
        public LazyRow< FishParameter >[] FishParameter;
        public uint[] AmountRequired;
        public LazyRow< Item >[] ItemReceived;
        public LazyRow< HWDGathererInspectionReward >[] Reward1;
        public LazyRow< HWDGathererInspectionReward >[] Reward2;
        public LazyRow< HWDGathereInspectTerm >[] Phase;
        public byte Unknown365;
        public byte Unknown366;
        public byte Unknown367;
        public byte Unknown368;
        public byte Unknown369;
        public byte Unknown370;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemRequired = new LazyRow< GatheringItem >[ 52 ];
            for( var i = 0; i < 52; i++ )
                ItemRequired[ i ] = new LazyRow< GatheringItem >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
            Unknown52 = parser.ReadColumn< uint >( 52 );
            FishParameter = new LazyRow< FishParameter >[ 52 ];
            for( var i = 0; i < 52; i++ )
                FishParameter[ i ] = new LazyRow< FishParameter >( lumina, parser.ReadColumn< uint >( 53 + i ), language );
            AmountRequired = new uint[ 52 ];
            for( var i = 0; i < 52; i++ )
                AmountRequired[ i ] = parser.ReadColumn< uint >( 105 + i );
            ItemReceived = new LazyRow< Item >[ 52 ];
            for( var i = 0; i < 52; i++ )
                ItemReceived[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< byte >( 157 + i ), language );
            Reward1 = new LazyRow< HWDGathererInspectionReward >[ 52 ];
            for( var i = 0; i < 52; i++ )
                Reward1[ i ] = new LazyRow< HWDGathererInspectionReward >( lumina, parser.ReadColumn< uint >( 209 + i ), language );
            Reward2 = new LazyRow< HWDGathererInspectionReward >[ 52 ];
            for( var i = 0; i < 52; i++ )
                Reward2[ i ] = new LazyRow< HWDGathererInspectionReward >( lumina, parser.ReadColumn< ushort >( 261 + i ), language );
            Phase = new LazyRow< HWDGathereInspectTerm >[ 52 ];
            for( var i = 0; i < 52; i++ )
                Phase[ i ] = new LazyRow< HWDGathereInspectTerm >( lumina, parser.ReadColumn< ushort >( 313 + i ), language );
            Unknown365 = parser.ReadColumn< byte >( 365 );
            Unknown366 = parser.ReadColumn< byte >( 366 );
            Unknown367 = parser.ReadColumn< byte >( 367 );
            Unknown368 = parser.ReadColumn< byte >( 368 );
            Unknown369 = parser.ReadColumn< byte >( 369 );
            Unknown370 = parser.ReadColumn< byte >( 370 );
        }
    }
}