// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeve", columnHash: 0xfa74e4d0 )]
    public partial class GatheringLeve : ExcelRow
    {
        
        public LazyRow< GatheringLeveRoute >[] Route { get; set; }
        public LazyRow< EventItem > RequiredItem0 { get; set; }
        public byte RequiredItemQty0 { get; set; }
        public LazyRow< EventItem > RequiredItem1 { get; set; }
        public byte RequiredItemQty1 { get; set; }
        public LazyRow< EventItem > RequiredItem2 { get; set; }
        public byte RequiredItemQty2 { get; set; }
        public LazyRow< EventItem > RequiredItem3 { get; set; }
        public byte RequiredItemQty3 { get; set; }
        public byte ItemNumber { get; set; }
        public LazyRow< GatheringLeveRule > Rule { get; set; }
        public byte Varient { get; set; }
        public ushort Objective0 { get; set; }
        public ushort Objective1 { get; set; }
        public int BNpcEntry { get; set; }
        public bool UseSecondaryTool { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Route = new LazyRow< GatheringLeveRoute >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Route[ i ] = new LazyRow< GatheringLeveRoute >( gameData, parser.ReadColumn< int >( 0 + i ), language );
            RequiredItem0 = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 4 ), language );
            RequiredItemQty0 = parser.ReadColumn< byte >( 5 );
            RequiredItem1 = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 6 ), language );
            RequiredItemQty1 = parser.ReadColumn< byte >( 7 );
            RequiredItem2 = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 8 ), language );
            RequiredItemQty2 = parser.ReadColumn< byte >( 9 );
            RequiredItem3 = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 10 ), language );
            RequiredItemQty3 = parser.ReadColumn< byte >( 11 );
            ItemNumber = parser.ReadColumn< byte >( 12 );
            Rule = new LazyRow< GatheringLeveRule >( gameData, parser.ReadColumn< int >( 13 ), language );
            Varient = parser.ReadColumn< byte >( 14 );
            Objective0 = parser.ReadColumn< ushort >( 15 );
            Objective1 = parser.ReadColumn< ushort >( 16 );
            BNpcEntry = parser.ReadColumn< int >( 17 );
            UseSecondaryTool = parser.ReadColumn< bool >( 18 );
        }
    }
}