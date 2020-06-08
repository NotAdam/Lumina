using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PlantPotFlowerSeed", columnHash: 0x84d0ceef )]
    public class PlantPotFlowerSeed : IExcelRow
    {
        
        public uint[] SeedIcon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 9; i++ )
                SeedIcon[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}