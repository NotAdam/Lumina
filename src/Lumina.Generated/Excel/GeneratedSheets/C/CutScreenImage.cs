using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutScreenImage", columnHash: 0xe4a523cd )]
    public class CutScreenImage : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int Image;

        // col: 00 offset: 0004
        public short Type;

        // col: 02 offset: 0006
        public short unknown6;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Image = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            Type = parser.ReadOffset< short >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< short >( 0x6 );


        }
    }
}