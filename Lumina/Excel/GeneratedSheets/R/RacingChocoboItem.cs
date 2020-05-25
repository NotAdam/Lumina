using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboItem", columnHash: 0xe79dd9d4 )]
    public class RacingChocoboItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Item;

        // col: 01 offset: 0004
        public byte Category;

        // col: 02 offset: 0005
        public byte[] Param;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            Category = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            Param = new byte[2];
            Param[0] = parser.ReadOffset< byte >( 0x5 );
            Param[1] = parser.ReadOffset< byte >( 0x6 );


        }
    }
}