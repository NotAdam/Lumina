using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBase", columnHash: 0x73fa0924 )]
    public class GatheringPointBase : IExcelRow
    {
        
        public LazyRow< GatheringType > GatheringType;
        public byte GatheringLevel;
        public int[] Item;
        public bool IsLimited;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GatheringType = new LazyRow< GatheringType >( lumina, parser.ReadColumn< int >( 0 ) );
            GatheringLevel = parser.ReadColumn< byte >( 1 );
            for( var i = 0; i < 8; i++ )
                Item[ i ] = parser.ReadColumn< int >( 2 + i );
            IsLimited = parser.ReadColumn< bool >( 10 );
        }
    }
}