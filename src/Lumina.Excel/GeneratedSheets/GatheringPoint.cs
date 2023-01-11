// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPoint", columnHash: 0x09006f05 )]
    public partial class GatheringPoint : ExcelRow
    {
        
        public byte Type { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< GatheringPointBase > GatheringPointBase { get; set; }
        public byte Count { get; set; }
        public LazyRow< GatheringPointBonus >[] GatheringPointBonus { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public LazyRow< GatheringSubCategory > GatheringSubCategory { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            GatheringPointBase = new LazyRow< GatheringPointBase >( gameData, parser.ReadColumn< int >( 2 ), language );
            Count = parser.ReadColumn< byte >( 3 );
            GatheringPointBonus = new LazyRow< GatheringPointBonus >[ 2 ];
            for( var i = 0; i < 2; i++ )
                GatheringPointBonus[ i ] = new LazyRow< GatheringPointBonus >( gameData, parser.ReadColumn< ushort >( 4 + i ), language );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadColumn< ushort >( 8 ), language );
        }
    }
}