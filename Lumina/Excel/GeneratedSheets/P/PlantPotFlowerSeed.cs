using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PlantPotFlowerSeed", columnHash: 0x84d0ceef )]
    public class PlantPotFlowerSeed : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint[] SeedIcon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SeedIcon = new uint[9];
            SeedIcon[0] = parser.ReadOffset< uint >( 0x0 );
            SeedIcon[1] = parser.ReadOffset< uint >( 0x4 );
            SeedIcon[2] = parser.ReadOffset< uint >( 0x8 );
            SeedIcon[3] = parser.ReadOffset< uint >( 0xc );
            SeedIcon[4] = parser.ReadOffset< uint >( 0x10 );
            SeedIcon[5] = parser.ReadOffset< uint >( 0x14 );
            SeedIcon[6] = parser.ReadOffset< uint >( 0x18 );
            SeedIcon[7] = parser.ReadOffset< uint >( 0x1c );
            SeedIcon[8] = parser.ReadOffset< uint >( 0x20 );


        }
    }
}