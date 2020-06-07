using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherialWheel", columnHash: 0xfee5acb6 )]
    public class AetherialWheel : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int ItemUnprimed;

        // col: 01 offset: 0004
        public int ItemPrimed;

        // col: 02 offset: 0008
        public byte Grade;

        // col: 03 offset: 0009
        public byte HoursRequired;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ItemUnprimed = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            ItemPrimed = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            Grade = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            HoursRequired = parser.ReadOffset< byte >( 0x9 );


        }
    }
}