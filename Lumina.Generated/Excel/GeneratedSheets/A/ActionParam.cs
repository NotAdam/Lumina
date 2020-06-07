using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionParam", columnHash: 0x8795cd75 )]
    public class ActionParam : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public short Name;

        // col: 01 offset: 0002
        public short unknown2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< short >( 0x0 );

            // col: 1 offset: 0002
            unknown2 = parser.ReadOffset< short >( 0x2 );


        }
    }
}