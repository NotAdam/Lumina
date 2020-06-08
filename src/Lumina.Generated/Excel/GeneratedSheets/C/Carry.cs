using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Carry", columnHash: 0x31e1f9e6 )]
    public class Carry : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ulong Model;

        // col: 01 offset: 0008
        public byte Timeline;

        // col: 02 offset: 0009
        public byte unknown9;

        // col: 03 offset: 000a
        public byte unknowna;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Model = parser.ReadOffset< ulong >( 0x0 );

            // col: 1 offset: 0008
            Timeline = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 3 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );


        }
    }
}