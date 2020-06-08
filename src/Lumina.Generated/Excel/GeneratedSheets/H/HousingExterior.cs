using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingExterior", columnHash: 0xb56595e0 )]
    public class HousingExterior : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public string Model;

        // col: 02 offset: 0004
        public ushort PlaceName;

        // col: 00 offset: 0006
        public byte unknown6;

        // col: 01 offset: 0007
        public byte unknown7;

        // col: 03 offset: 0008
        public byte HousingSize;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Model = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            PlaceName = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 3 offset: 0008
            HousingSize = parser.ReadOffset< byte >( 0x8 );


        }
    }
}