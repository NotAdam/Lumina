// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingItem", columnHash: 0xd9375ed5 )]
    public class SpearfishingItem : ExcelRow
    {
        
        public SeString Description { get; set; }
        public LazyRow< Item > Item { get; set; }
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public LazyRow< FishingRecordType > FishingRecordType { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public ushort Unknown7 { get; set; }
        public bool IsVisible { get; set; }
        public bool Unknown9 { get; set; }
        public bool Unknown10 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Description = parser.ReadColumn< SeString >( 0 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 ), language );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadColumn< byte >( 5 ), language );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            IsVisible = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
        }
    }
}