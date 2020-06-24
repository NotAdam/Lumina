using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureSpot", columnHash: 0x4a63eb8e )]
    public class TreasureSpot : IExcelRow
    {
        
        public LazyRow< Level > Location;
        public float MapOffsetX;
        public float MapOffsetY;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Location = new LazyRow< Level >( lumina, parser.ReadColumn< int >( 0 ), language );
            MapOffsetX = parser.ReadColumn< float >( 1 );
            MapOffsetY = parser.ReadColumn< float >( 2 );
        }
    }
}