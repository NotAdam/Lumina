// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCReputation", columnHash: 0x3d6be37e )]
    public class FCReputation : IExcelRow
    {
        
        public uint PointsToNext;
        public uint RequiredPoints;
        public byte DiscountRate;
        public LazyRow< UIColor > Color;
        public SeString Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PointsToNext = parser.ReadColumn< uint >( 0 );
            RequiredPoints = parser.ReadColumn< uint >( 1 );
            DiscountRate = parser.ReadColumn< byte >( 2 );
            Color = new LazyRow< UIColor >( lumina, parser.ReadColumn< uint >( 3 ), language );
            Name = parser.ReadColumn< SeString >( 4 );
        }
    }
}