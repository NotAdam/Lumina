using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPTrait", columnHash: 0xdc23efe7 )]
    public class PvPTrait : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort Trait1;

        // col: 01 offset: 0002
        public ushort Trait2;

        // col: 02 offset: 0004
        public ushort Trait3;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Trait1 = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            Trait2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            Trait3 = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}