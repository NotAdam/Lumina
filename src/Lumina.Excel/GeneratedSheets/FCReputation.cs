// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCReputation", columnHash: 0x3d6be37e )]
    public class FCReputation : ExcelRow
    {
        
        public uint PointsToNext;
        public uint RequiredPoints;
        public byte DiscountRate;
        public LazyRow< UIColor > Color;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            PointsToNext = parser.ReadColumn< uint >( 0 );
            RequiredPoints = parser.ReadColumn< uint >( 1 );
            DiscountRate = parser.ReadColumn< byte >( 2 );
            Color = new LazyRow< UIColor >( lumina, parser.ReadColumn< uint >( 3 ), language );
            Name = parser.ReadColumn< SeString >( 4 );
        }
    }
}