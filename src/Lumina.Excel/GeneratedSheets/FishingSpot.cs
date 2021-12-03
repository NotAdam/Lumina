// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingSpot", columnHash: 0xb014a98d )]
    public partial class FishingSpot : ExcelRow
    {
        
        public byte GatheringLevel { get; set; }
        public SeString BigFishOnReach { get; set; }
        public SeString BigFishOnEnd { get; set; }
        public byte FishingSpotCategory { get; set; }
        public bool Rare { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public LazyRow< PlaceName > PlaceNameMain { get; set; }
        public LazyRow< PlaceName > PlaceNameSub { get; set; }
        public short X { get; set; }
        public short Z { get; set; }
        public ushort Radius { get; set; }
        public byte Unknown11 { get; set; }
        public LazyRow< Item >[] Item { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public ushort Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringLevel = parser.ReadColumn< byte >( 0 );
            BigFishOnReach = parser.ReadColumn< SeString >( 1 );
            BigFishOnEnd = parser.ReadColumn< SeString >( 2 );
            FishingSpotCategory = parser.ReadColumn< byte >( 3 );
            Rare = parser.ReadColumn< bool >( 4 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            PlaceNameMain = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            PlaceNameSub = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            X = parser.ReadColumn< short >( 8 );
            Z = parser.ReadColumn< short >( 9 );
            Radius = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Item = new LazyRow< Item >[ 10 ];
            for( var i = 0; i < 10; i++ )
                Item[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 12 + i ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 22 ), language );
            Order = parser.ReadColumn< ushort >( 23 );
        }
    }
}