// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishParameter", columnHash: 0xa308cac0 )]
    public partial class FishParameter : ExcelRow
    {
        
        public SeString Text { get; set; }
        public int Item { get; set; }
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; set; }
        public byte Unknown3 { get; set; }
        public bool IsHidden { get; set; }
        public bool Unknown5 { get; set; }
        public LazyRow< FishingRecordType > FishingRecordType { get; set; }
        public int Unknown7 { get; set; }
        public LazyRow< FishingSpot > FishingSpot { get; set; }
        public LazyRow< GatheringSubCategory > GatheringSubCategory { get; set; }
        public bool IsInLog { get; set; }
        public bool TimeRestricted { get; set; }
        public bool WeatherRestricted { get; set; }
        public uint Unknown13 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            Item = parser.ReadColumn< int >( 1 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            IsHidden = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            FishingRecordType = new LazyRow< FishingRecordType >( gameData, parser.ReadColumn< byte >( 6 ), language );
            Unknown7 = parser.ReadColumn< int >( 7 );
            FishingSpot = new LazyRow< FishingSpot >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            GatheringSubCategory = new LazyRow< GatheringSubCategory >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            IsInLog = parser.ReadColumn< bool >( 10 );
            TimeRestricted = parser.ReadColumn< bool >( 11 );
            WeatherRestricted = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
        }
    }
}