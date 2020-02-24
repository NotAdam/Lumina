using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FieldMarker", columnHash: 0x23003392 )]
    public class FieldMarker : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 03 offset: 0000
        public string unknown0;

        // col: 00 offset: 0004
        public int VFX;

        // col: 01 offset: 0008
        public ushort Icon;

        // col: 02 offset: 000a
        public ushort unknowna;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            VFX = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            Icon = parser.ReadOffset< ushort >( 0x8 );

            // col: 2 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );


        }
    }
}