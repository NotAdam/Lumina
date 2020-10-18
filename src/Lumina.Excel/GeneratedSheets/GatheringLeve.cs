// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeve", columnHash: 0xfa74e4d0 )]
    public class GatheringLeve : IExcelRow
    {
        
        public LazyRow< GatheringLeveRoute >[] Route;
        public LazyRow< EventItem > RequiredItem0;
        public byte RequiredItemQty0;
        public LazyRow< EventItem > RequiredItem1;
        public byte RequiredItemQty1;
        public LazyRow< EventItem > RequiredItem2;
        public byte RequiredItemQty2;
        public LazyRow< EventItem > RequiredItem3;
        public byte RequiredItemQty3;
        public byte ItemNumber;
        public LazyRow< GatheringLeveRule > Rule;
        public byte Varient;
        public ushort Objective0;
        public ushort Objective1;
        public int BNpcEntry;
        public bool UseSecondaryTool;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Route = new LazyRow< GatheringLeveRoute >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Route[ i ] = new LazyRow< GatheringLeveRoute >( lumina, parser.ReadColumn< int >( 0 + i ), language );
            RequiredItem0 = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 4 ), language );
            RequiredItemQty0 = parser.ReadColumn< byte >( 5 );
            RequiredItem1 = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 6 ), language );
            RequiredItemQty1 = parser.ReadColumn< byte >( 7 );
            RequiredItem2 = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 8 ), language );
            RequiredItemQty2 = parser.ReadColumn< byte >( 9 );
            RequiredItem3 = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 10 ), language );
            RequiredItemQty3 = parser.ReadColumn< byte >( 11 );
            ItemNumber = parser.ReadColumn< byte >( 12 );
            Rule = new LazyRow< GatheringLeveRule >( lumina, parser.ReadColumn< int >( 13 ), language );
            Varient = parser.ReadColumn< byte >( 14 );
            Objective0 = parser.ReadColumn< ushort >( 15 );
            Objective1 = parser.ReadColumn< ushort >( 16 );
            BNpcEntry = parser.ReadColumn< int >( 17 );
            UseSecondaryTool = parser.ReadColumn< bool >( 18 );
        }
    }
}