using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingRecordPage", columnHash: 0x4f78acda )]
    public class SpearfishingRecordPage : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public int PlaceName;

        // col: 04 offset: 0004
        public int Image;

        // col: 00 offset: 0008
        public byte unknown8;

        // col: 01 offset: 0009
        public byte unknown9;

        // col: 02 offset: 000a
        public byte unknowna;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            PlaceName = parser.ReadOffset< int >( 0x0 );

            // col: 4 offset: 0004
            Image = parser.ReadOffset< int >( 0x4 );

            // col: 0 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 1 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 2 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );


        }
    }
}