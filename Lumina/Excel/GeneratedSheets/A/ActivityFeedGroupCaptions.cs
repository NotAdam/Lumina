using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedGroupCaptions", columnHash: 0x776ee24c )]
    public class ActivityFeedGroupCaptions : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string JA;

        // col: 01 offset: 0004
        public string EN;

        // col: 02 offset: 0008
        public string DE;

        // col: 03 offset: 000c
        public string FR;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            JA = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            EN = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            DE = parser.ReadOffset< string >( 0x8 );

            // col: 3 offset: 000c
            FR = parser.ReadOffset< string >( 0xc );


        }
    }
}