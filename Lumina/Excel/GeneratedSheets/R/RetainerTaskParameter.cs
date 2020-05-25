using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskParameter", columnHash: 0xcbd32284 )]
    public class RetainerTaskParameter : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public short[] ItemLevelDoW;

        // col: 02 offset: 0004
        public short[] GatheringDoL;

        // col: 04 offset: 0008
        public short[] GatheringFSH;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ItemLevelDoW = new short[2];
            ItemLevelDoW[0] = parser.ReadOffset< short >( 0x0 );
            ItemLevelDoW[1] = parser.ReadOffset< short >( 0x2 );

            // col: 2 offset: 0004
            GatheringDoL = new short[2];
            GatheringDoL[0] = parser.ReadOffset< short >( 0x4 );
            GatheringDoL[1] = parser.ReadOffset< short >( 0x6 );

            // col: 4 offset: 0008
            GatheringFSH = new short[2];
            GatheringFSH[0] = parser.ReadOffset< short >( 0x8 );
            GatheringFSH[1] = parser.ReadOffset< short >( 0xa );


        }
    }
}