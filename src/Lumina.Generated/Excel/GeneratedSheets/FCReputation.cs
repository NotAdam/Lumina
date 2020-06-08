using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCReputation", columnHash: 0x3d6be37e )]
    public class FCReputation : IExcelRow
    {
        
        public uint PointsToNext;
        public uint RequiredPoints;
        public byte DiscountRate;
        public uint Color;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PointsToNext = parser.ReadColumn< uint >( 0 );
            RequiredPoints = parser.ReadColumn< uint >( 1 );
            DiscountRate = parser.ReadColumn< byte >( 2 );
            Color = parser.ReadColumn< uint >( 3 );
            Name = parser.ReadColumn< string >( 4 );
        }
    }
}