using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonDanger", columnHash: 0xdc23efe7 )]
    public class DeepDungeonDanger : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort ScreenImage;

        // col: 01 offset: 0002
        public ushort LogMessage;

        // col: 02 offset: 0004
        public ushort Name;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ScreenImage = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            LogMessage = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            Name = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}