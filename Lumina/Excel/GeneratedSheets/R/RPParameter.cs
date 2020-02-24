using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RPParameter", columnHash: 0x251a33cc )]
    public class RPParameter : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public ushort BNpcName;

        // col: 01 offset: 0002
        public byte ClassJob;

        // col: 02 offset: 0003
        public byte unknown3;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            BNpcName = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            ClassJob = parser.ReadOffset< byte >( 0x2 );

            // col: 2 offset: 0003
            unknown3 = parser.ReadOffset< byte >( 0x3 );


        }
    }
}