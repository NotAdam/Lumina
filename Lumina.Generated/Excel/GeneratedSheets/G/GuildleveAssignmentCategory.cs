using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignmentCategory", columnHash: 0xeb15b554 )]
    public class GuildleveAssignmentCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int[] Category;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Category = new int[8];
            Category[0] = parser.ReadOffset< int >( 0x0 );
            Category[1] = parser.ReadOffset< int >( 0x4 );
            Category[2] = parser.ReadOffset< int >( 0x8 );
            Category[3] = parser.ReadOffset< int >( 0xc );
            Category[4] = parser.ReadOffset< int >( 0x10 );
            Category[5] = parser.ReadOffset< int >( 0x14 );
            Category[6] = parser.ReadOffset< int >( 0x18 );
            Category[7] = parser.ReadOffset< int >( 0x1c );


        }
    }
}