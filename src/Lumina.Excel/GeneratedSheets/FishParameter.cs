// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishParameter", columnHash: 0x019385c9 )]
    public class FishParameter : ExcelRow
    {
        
        public SeString Text;
        public int Item;
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel;
        public byte Unknown3;
        public bool IsHidden;
        public bool Unknown5;
        public LazyRow< FishingRecordType > FishingRecordType;
        public LazyRow< TerritoryType > TerritoryType;
        public LazyRow< GatheringSubCategory > GatheringSubCategory;
        public bool IsInLog;
        public bool TimeRestricted;
        public bool WeatherRestricted;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Text = parser.ReadColumn< SeString >( 0 );
            Item = parser.ReadColumn< int >( 1 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            IsHidden = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            FishingRecordType = new LazyRow< FishingRecordType >( lumina, parser.ReadColumn< byte >( 6 ), language );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< int >( 7 ), language );
            GatheringSubCategory = new LazyRow< GatheringSubCategory >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            IsInLog = parser.ReadColumn< bool >( 9 );
            TimeRestricted = parser.ReadColumn< bool >( 10 );
            WeatherRestricted = parser.ReadColumn< bool >( 11 );
        }
    }
}