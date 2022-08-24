// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerTimeline", columnHash: 0xdb953b5e )]
    public partial class BannerTimeline : ExcelRow
    {
        
        public byte Type { get; set; }
        public uint AdditionalData { get; set; }
        public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; set; }
        public byte Category { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public ushort SortKey { get; set; }
        public int Icon { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            AdditionalData = parser.ReadColumn< uint >( 1 );
            AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Category = parser.ReadColumn< byte >( 3 );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            SortKey = parser.ReadColumn< ushort >( 5 );
            Icon = parser.ReadColumn< int >( 6 );
            Name = parser.ReadColumn< SeString >( 7 );
        }
    }
}