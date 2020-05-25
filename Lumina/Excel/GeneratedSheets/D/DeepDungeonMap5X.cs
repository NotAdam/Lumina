using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMap5X", columnHash: 0x64a88f98 )]
    public class DeepDungeonMap5X : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort[] DeepDungeonRoom;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            DeepDungeonRoom = new ushort[5];
            DeepDungeonRoom[0] = parser.ReadOffset< ushort >( 0x0 );
            DeepDungeonRoom[1] = parser.ReadOffset< ushort >( 0x2 );
            DeepDungeonRoom[2] = parser.ReadOffset< ushort >( 0x4 );
            DeepDungeonRoom[3] = parser.ReadOffset< ushort >( 0x6 );
            DeepDungeonRoom[4] = parser.ReadOffset< ushort >( 0x8 );


        }
    }
}