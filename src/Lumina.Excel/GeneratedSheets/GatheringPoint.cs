// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPoint", columnHash: 0x4f531171 )]
    public class GatheringPoint : ExcelRow
    {
        
        public byte Type;
        public LazyRow< GatheringPointBase > GatheringPointBase;
        public byte Count;
        public LazyRow< GatheringPointBonus >[] GatheringPointBonus;
        public LazyRow< TerritoryType > TerritoryType;
        public LazyRow< PlaceName > PlaceName;
        public LazyRow< GatheringSubCategory > GatheringSubCategory;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< byte >( 0 );
            GatheringPointBase = new LazyRow< GatheringPointBase >( lumina, parser.ReadColumn< int >( 1 ), language );
            Count = parser.ReadColumn< byte >( 2 );
            GatheringPointBonus = new LazyRow< GatheringPointBonus >[ 2 ];
            for( var i = 0; i < 2; i++ )
                GatheringPointBonus[ i ] = new LazyRow< GatheringPointBonus >( lumina, parser.ReadColumn< ushort >( 3 + i ), language );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            GatheringSubCategory = new LazyRow< GatheringSubCategory >( lumina, parser.ReadColumn< ushort >( 7 ), language );
        }
    }
}