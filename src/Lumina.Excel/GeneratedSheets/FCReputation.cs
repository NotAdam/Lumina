// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCReputation", columnHash: 0x3d6be37e )]
    public partial class FCReputation : ExcelRow
    {
        
        public uint PointsToNext { get; set; }
        public uint RequiredPoints { get; set; }
        public byte DiscountRate { get; set; }
        public LazyRow< UIColor > Color { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PointsToNext = parser.ReadColumn< uint >( 0 );
            RequiredPoints = parser.ReadColumn< uint >( 1 );
            DiscountRate = parser.ReadColumn< byte >( 2 );
            Color = new LazyRow< UIColor >( gameData, parser.ReadColumn< uint >( 3 ), language );
            Name = parser.ReadColumn< SeString >( 4 );
        }
    }
}